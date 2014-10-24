using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    public class suznumbers
    {
        public static Tuple<int, string>[] combinations = new Tuple<int, string>[] 
        { 
            new Tuple<int, string> (3, "Fizz"), 
            new Tuple<int, string> (5, "Buzz"), 
        };

        public static string check_mult(int i)
        {
            string ret = "";
            foreach (var comb in combinations)
            {
                if (i % comb.Item1 == 0)
                    ret += comb.Item2;
            }
            return ret;
        }

        public static string fizzbuzz(int i)
        {
            string ret = check_mult(i);
            if (ret.Length == 0)
                ret = i.ToString();
            return ret;
        }

    }
}
