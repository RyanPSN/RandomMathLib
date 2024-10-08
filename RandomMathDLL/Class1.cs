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
        public static List<string> wordName = new List<string>();


        public static Random r = new Random();
        public static bool isNotCorrect = false;

        public int Add(int a, int b)
        {
            return Math.Abs(a + b);
        }

        public int Sub(int a, int b)
        {
            return Math.Abs(a - b);
        }

        public int Mul(int a, int b)
        {
            return Math.Abs(a * b);
        } 

        public int Div(int a, int b)
        {
            return Math.Abs(a / b);
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

            int n = 0;

            opAdd.Add("+");
            opAdd.Add("-");
            opAdd.Add("*");
            opAdd.Add("/");

            n = r.Next(opAdd.Count);

            foreach (var ops in opAdd)
            {
                n = r.Next(opAdd.Count);


                return opAdd[n];

            }
            
            return opAdd[n];
        }

        public int getRandomNum(int a, int b)
        {
            return r.Next(a, b);
        }
        
            
        public static int SetNumber(int num)
        {
            return num;
        }

        public int Answer()
        {
            return int.Parse(Console.ReadLine());
        }


        public void notGetAnswer(string op, int b, int c)
        {

            while(!isNotCorrect)
            {
                Console.WriteLine("Did You Get The Problem: ");
                string answer = Console.ReadLine();


                if (answer.Equals("No"))
                {
                    if (op.Equals("+"))
                    {
                        var answeredVar = Math.Abs(b + c);
                        foreach(var a in answeredVar.ToString())
                        {
                            Console.WriteLine("The Correct Answer: {0} + {2} = {3}", b, op, c);
                            Console.ReadLine();

                        }

                    }




                    if (op.Equals("-")) 
                    {

                        var answeredVar = Math.Abs(b - c);

                        foreach (var a in answeredVar.ToString())
                        {
                            Console.WriteLine("The Correct Answer: {0} - {2} = {3}", b, op, c, answeredVar);
                            Console.ReadLine();

                        }


                    }

                    if (op.Equals("*"))
                    {
                        var answeredVar = b * c;

                        foreach (var a in answeredVar.ToString())
                        {


                            Console.WriteLine("The Correct Answer: {0} * {2} = {3}", b, op, c, answeredVar);
                            Console.ReadLine();

                        }


                    }

                

                    if (op.Equals("/"))
                    {
                        var answeredVar = b / c;


                        foreach(var a in answeredVar.ToString())
                        {

                            Console.WriteLine("The Correct Answer: {0} * {2} = {3}", b, op, c, answeredVar);
                            Console.ReadLine();
                        }

                    }

                }

                else if (answer.Equals("Yes") )
                {

                    Console.WriteLine("What is: {0} {1} {2}: ", b, op, c);

                    int num = Answer();

                    if (op.Equals("+") && num == Add(b, c))
                    {
                        Console.WriteLine("Correct");

                        Console.ReadLine();
                    }
                    
                    if (op.Equals("-") && num == Sub(b, c))
                    {
                        Console.WriteLine("Correct");

                        Console.ReadLine();
                    }                             
                    if (op.Equals("*") && num == Mul(b, c))
                    {
                        Console.WriteLine("Correct");

                        Console.ReadLine();
                    }
                    
                    if (op.Equals("/") && num == Div(b, c))
                    {
                        Console.WriteLine("Correct");

                        Console.ReadLine();
                    }

                    Console.ReadLine();
                }




                isNotCorrect = true;
            }

        }

        public static string SetName(string name)
        {
            
            return name;
        
        }

        public static string WordName(string wordName)
        {
            return wordName;

        }

        public static void getWordName()
        {
            Console.WriteLine("Enter Fruit Name 1:");
            foreach(string a in wordName)
            {
                Console.WriteLine("Enter Fruit Name {0}:", a);
                string wordNames = WordName(a);

                Console.WriteLine(wordNames);
                Console.ReadLine();
           
            }



        }
    
    }

}
