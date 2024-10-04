﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMathDLL
{
    public class RandomNum
    {
        public static List<string> opAdd = new List<string>();
        public static List<string> names = new List<string>();        
        
        public static Random r = new Random();
        public static bool isNotCorrect = false;

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        } 

        public int Div(int a, int b)
        {
            return a / b;
        }
                     
        public string GetHelloMessage(string message)
        {

            return message.ToUpper();
        }

        public void ProjectName(string name, string x1)
        {
            Console.WriteLine(name.ToUpper() + " " + x1);

        }

        public string getOperator()
        {

            opAdd.Add("+");
            opAdd.Add("-");
            opAdd.Add("*");
            opAdd.Add("/");

            int n = r.Next(opAdd.Count);

            return opAdd[n];

        }

        public int getRandomNum(int a, int b)
        {
            return r.Next(b, a);
        }
        
            

        public void notGetAnswer(string op, int b, int c)
        {

            var num1 = getRandomNum(b, c);

            while(!isNotCorrect)
            {
                Console.WriteLine("Did You Get The Problem: ");
                string answer = Console.ReadLine();


                if (answer.Equals("No"))
                {
                    if (op.Equals("+"))
                    {
                        var answeredVar = b + c;
                        Console.WriteLine("The Correct Answer: {0} + {2} = {3}", b, op, c, answeredVar);
                        Console.ReadLine();

                    }
                    
                    if (op.Equals("-"))
                    {
                        var answeredVar = b - c;
                        Console.WriteLine("The Correct Answer: {0} - {2} = {3}", b, op, c, answeredVar);
                        Console.ReadLine();
                    }

                    if (op.Equals("*"))
                    {
                        var answeredVar = b * c;
                        Console.WriteLine("The Correct Answer: {0} * {2} = {3}", b, op, c, answeredVar);
                        Console.ReadLine();
                    }

                    if (op.Equals("/"))
                    {
                        var answeredVar = b / c;
                        Console.WriteLine("The Correct Answer: {0} / {2} = {3}", b, op, c, answeredVar);
                        Console.ReadLine();
                    }

                }

                else if (answer.Equals("Yes"))
                {

                    Console.WriteLine("What is: {0} {1} {2}: ", b, op, c);
                  
                    Console.ReadLine();
                }




                isNotCorrect = true;
            }

        }

        public static string SetName(string name)
        {
            
            return name;
        
        }


        public static void getWordProblemName()
        {
            Console.WriteLine("Ener Name 1: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ener Name 2: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Ener Name 3: ");
            string name3 = Console.ReadLine();


            foreach (string name in names)
            {
                var listName = SetName(name);
                Console.WriteLine("Name: {0}", listName);
                Console.ReadLine();
            }


        }
    }
}
