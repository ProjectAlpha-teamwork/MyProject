﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TeamProject_Alpha.Sports
{
    class Football : PossibleDraw
    {
        public Football(DateTime eventDate, string sportName, int matchDuration, double[] coefficients)
            : base(eventDate, sportName, matchDuration, coefficients)
        {

        }
    }
}