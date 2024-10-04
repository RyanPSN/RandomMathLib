using System;
using RandomMathDLL;

namespace RandomAddition
{
    class Program
    {
        public static RandomNum projectName = new RandomNum();
        public static RandomNum Number = new RandomNum();

        static void Main(string[] _)
        {

            string proName = "Random Math Libary";
            projectName.ProjectName("Project Name:", proName);

            int number_1 = 10;
            int number_2 = 1;

            Console.WriteLine();

            int num1 = Number.getRandomNum(number_1, number_2);
            int num2 = Number.getRandomNum(number_1, number_2);
                        
            string op = Number.getOperator();

            Number.notGetAnswer(op, num1, num2);


            string result = $"{num1} {op} {num2}";
            projectName.ProjectName("Problem:", result);

            int answer = int.Parse(Console.ReadLine());

            if (op.Equals("+") && answer == Number.Add(num1, num2)) {

                Console.WriteLine("Correct");
                Console.ReadLine();
            }

            else if (op.Equals("-") && answer == Number.Sub(num1, num2))
            {
                Console.WriteLine("Correct");
                Console.ReadLine();
            }


            else if (op.Equals("*") && answer == Number.Mul(num1, num2))
            {
                Console.WriteLine("Correct");
                Console.ReadLine();
            }

            else if (op.Equals("-") && answer == Number.Div(num1, num2))
            {
                Console.WriteLine("Correct");
                Console.ReadLine();
            }

            Console.Write("Op: {0}", op);
            Console.ReadLine();
                    


        }
    }
}
