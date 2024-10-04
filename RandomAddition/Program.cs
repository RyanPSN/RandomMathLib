using System;
using RandomMathDLL;

namespace RandomAddition
{
    class Program
    {

        public static RandomNum projectName = new RandomNum();
        
        static void Main(string[] _)
        {

            string proName = "Random Math Libary";
            projectName.ProjectName("Project Name:", proName);

            int number_1 = 10;
            int number_2 = 1;

            Console.WriteLine();
            RandomNum Number = new RandomNum();

            int num1 = Number.getRandomNum(number_1, number_2);
            int num2 = Number.getRandomNum(number_1, number_2);
                        
            string op = Number.getOperator();


            string result = $"{num1} {op} {num2}";
            projectName.ProjectName("Problem:", result);

            Console.Write("Op: {0}", op);
            Console.ReadLine();
                    


        }
    }
}
