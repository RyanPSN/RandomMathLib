using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMathDLL
{
    public class RandomNum
    {
        public static List<string> opAdd = new List<string>();
        public static Random r = new Random();
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

    }
}
