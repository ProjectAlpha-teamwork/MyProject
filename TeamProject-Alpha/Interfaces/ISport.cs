using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_Alpha.Interfaces
{
    public interface ISport
    {
        string ParseId(string text);
        string ParseMatch(string text);
        double ParseBetCoef(string text, string bet);
        double CalculateBet(double bet, double deposit);
        string ParseBetCoef(string text);
        void UserBetInteraction();



    }
}
