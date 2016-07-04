using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamProject_Alpha.Sports;
using TeamProject_Alpha.Users;
using Users;
using System.IO;
using static System.Net.WebRequestMethods;

namespace TeamProject_Alpha
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport test = new Volleyball("ime");
            test.UserBetInteraction();


            //    List<string> lines = new List<string>(System.IO.File.ReadAllLines("../../OpponentList.txt"));
            //    foreach (var item in lines)
            //    {
            //        //System.Console.WriteLine(item);
            //        //Console.WriteLine("Extracting id from text file");
            //        //System.Console.WriteLine(ParseId(item));
            //        //Console.WriteLine("Extracting match from text file");
            //        //System.Console.WriteLine(ParseMatch(item));
            //        //Console.WriteLine("Extracting coef of _1_ result");
            //        //Console.WriteLine(ParseBetCoef(item, "1"));

            //        //Console.WriteLine(ParseBetCoef(item));

            //        Console.WriteLine(PrintF(ParseId(item),ParseMatch(item),ParseBetCoef(item)));
            //    }
            //    Console.WriteLine("Select match id to bet on:");
            //    int selector = int.Parse(Console.ReadLine());
            //    Console.WriteLine(PrintF(ParseId(lines[selector-1]), ParseMatch(lines[selector - 1]), ParseBetCoef(lines[selector - 1])));
            //    Console.WriteLine("Select a bet and deposit");
            //    var betselector = Console.ReadLine().Split(' ');
            //    var coef = ParseBetCoef(lines[selector - 1], betselector[0]);
            //    var possibleresult = CalculateBet(coef, double.Parse(betselector[1]));
            //    Console.WriteLine("Potential win:");
            //    Console.WriteLine(possibleresult);

            //    using (StreamWriter writer =
            //    new StreamWriter("../../BetHistory.txt"))
            //    {
            //        //insert Method
            //        // todo: save print match info + possible result
            //        writer.Write(PrintF(ParseId(lines[selector - 1]), ParseMatch(lines[selector - 1]), ParseBetCoef(lines[selector - 1])) + " " +possibleresult);

            //    }


            //    //var reg = new Registration("gosho", "goshov", "goshov", "99999999999", 1000,
            //    //    Gender.Male, "123456", "123456", "slientam", new DateTime(1995, 1, 18));
            //    //
            //    //var gosho = Login.SignIn("gosho", "123456");
            //    //
            //    //Console.WriteLine(gosho.UserName);

            //}
            //public static string ParseId(string text) //parse method to read path from string
            //{
            //    int id = 0;
            //    int endid = text.IndexOf('.');
            //    id = text.Length - (text.Length - endid) - 1;
            //    return text[id].ToString() + '.';
            //}
            //public static string ParseMatch(string text)
            //{
            //    string match = null;
            //    string[] arr = text.Split('|');
            //    match = arr[1];
            //    return match.ToString();
            //}
            //public static double ParseBetCoef(string text, string bet)
            //{
            //    double result;
            //    string[] arr = text.Split('|');
            //    string[] possibleCoef = new string[3];
            //    possibleCoef[0] = arr[2];
            //    possibleCoef[1] = arr[3];
            //    possibleCoef[2] = arr[4];
            //    if (bet == "1")
            //    {
            //        return result = Convert.ToDouble(possibleCoef[0].Substring(5, 4));
            //    }
            //    if (bet == "x")
            //    {
            //        return result = Convert.ToDouble(possibleCoef[1].Substring(5, 4));

            //    }
            //    if (bet == "2")
            //    {
            //        return result = Convert.ToDouble(possibleCoef[2].Substring(5, 4));
            //    }
            //    else
            //    {
            //        throw new ArgumentException("No such bet exists");
            //    }

            //}
            //public static double CalculateBet(double bet, double deposit)
            //{

            //    double finalBet = deposit * bet;
            //    return finalBet;
            //}
            //public static string ParseBetCoef(string text)
            //{
            //    string threeCoeff;
            //    string[] arr = text.Split('|');
            //    string[] possibleCoef = new string[3];
            //    possibleCoef[0] = arr[2];
            //    possibleCoef[1] = arr[3];
            //    possibleCoef[2] = arr[4];
            //    threeCoeff = possibleCoef[0] + possibleCoef[1] + possibleCoef[2];
            //    return threeCoeff;

            //}
            //public static string PrintF(string id, string match, string possibleResults)
            //{
            //    string result = string.Format("Match id: " + id + " " + match + " " + possibleResults);
            //    return result;
            //}
        }
    }
}
