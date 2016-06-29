using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_Alpha.Sports
{
    public abstract class Sport
    {
        string SportName { get; }

        int MatchDuration { get; }

        DateTime EventDate { get; }

        double[] Coefficients { get; }

    }
}
