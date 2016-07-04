using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_Alpha.Sports
{
    public class Volleyball : Sport, IVolleyball
    {
        public Volleyball(string sportName) : base(sportName)
        {
        }
        public override void UserBetInteraction()
        {
            List<string> lines = new List<string>(System.IO.File.ReadAllLines("../../VolleyballOpponentList.txt"));
            foreach (var item in lines)
            {

                Console.WriteLine(PrintF(ParseId(item), ParseMatch(item), ParseBetCoef(item)));
            }
            Console.WriteLine("Select match id to bet on:");
            int selector = int.Parse(Console.ReadLine());
            Console.WriteLine(PrintF(ParseId(lines[selector - 1]), ParseMatch(lines[selector - 1]), ParseBetCoef(lines[selector - 1])));
            Console.WriteLine("Select a bet and deposit");
            var betselector = Console.ReadLine().Split(' ');
            var coef = ParseBetCoef(lines[selector - 1], betselector[0]);
            var possibleresult = CalculateBet(coef, double.Parse(betselector[1]));
            Console.WriteLine("Potential win:");
            Console.WriteLine(possibleresult);

            using (StreamWriter writer =
            new StreamWriter("../../VolleyballBetHistory.txt"))
            {
                //insert Method
                // todo: save print match info + possible result
                writer.Write(PrintF(ParseId(lines[selector - 1]), ParseMatch(lines[selector - 1]), ParseBetCoef(lines[selector - 1])) + " " + possibleresult);

            }
        }
    }
}
