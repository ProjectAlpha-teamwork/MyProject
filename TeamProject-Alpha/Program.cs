using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject_Alpha.Sports;

namespace TeamProject_Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>(System.IO.File.ReadAllLines("../../OpponentList.txt"));
            foreach (var item in lines)
            {
                System.Console.WriteLine(item);
                Console.WriteLine("Extracting id from text file");
                System.Console.WriteLine(ParseId(item));
                Console.WriteLine("Extracting match from text file");
                System.Console.WriteLine(ParseMatch(item));
                Console.WriteLine("Extracting coef of _1_ result");
                Console.WriteLine(ParseBetCoef(item, "1"));
                Console.WriteLine(CalculateBet(ParseBetCoef(item, "1"),5,10));
            }
        }
        public static string ParseId(string text) //parse method to read path from string
        {
            int id = 0;
            int endid = text.IndexOf('.');
            id = text.Length - (text.Length - endid) - 1;
            return text[id].ToString() + '.';
        }
        public static string ParseMatch(string text)
        {
            string match = null;
            string[] arr = text.Split('|');
            match = arr[1];
            return match.ToString();
        }
        public static double ParseBetCoef(string text, string bet)
        {
            double result;
            string[] arr = text.Split('|');
            string[] possibleCoef = new string[3];
            possibleCoef[0] = arr[2];
            possibleCoef[1] = arr[3];
            possibleCoef[2] = arr[4];
            if (bet == "1")
            {
                return result = Convert.ToDouble(possibleCoef[0].Substring(5, 4));
            }
            if (bet == "x")
            {
                return result = Convert.ToDouble(possibleCoef[1].Substring(5, 4));

            }
            if (bet == "2")
            {
                return result = Convert.ToDouble(possibleCoef[2].Substring(5, 4));
            }
            else
            {
                throw new ArgumentException("No such bet exists");
            }

        }
        public static Tuple<double,double> CalculateBet(double bet, double deposit, double balance)
        {
            double newBalance = balance - deposit;
            double finalBet = deposit * bet;
            return new Tuple<double,double>(finalBet, newBalance);
        }
    }
}
