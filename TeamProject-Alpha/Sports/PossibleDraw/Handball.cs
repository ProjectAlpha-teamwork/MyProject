namespace TeamProject_Alpha.Sports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Handball : PossibleDraw
    {
        public Handball(DateTime eventDate, string sportName, int matchDuration, double[] coefficients)
            : base(eventDate, sportName, matchDuration, coefficients)
        {

        }
    }
}