using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamProject_Alpha.Sports
{
    public abstract class PossibleDraw : Sport
    {
        public double[] Coefficients
        {
            get
            {
                return this.Coefficients;
            }

            private set
            {
                bool isInvalid = false;

                foreach (var coeff in value)
                {
                    if (coeff < 0)
                    {
                        isInvalid = true;
                        throw new ArgumentException("Coefficient can not be lesser than zero!");
                    }
                }

                if (!isInvalid)
                {
                    this.Coefficients = value;
                }

            }
        }

        public DateTime EventDate
        {
            get
            {
                return this.EventDate;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The date of the match can not be null!");
                }
                else
                {
                    this.EventDate = value;
                }
            }
        }

        public int MatchDuration
        {
            get
            {
                return this.MatchDuration;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Match duration can not be lesser than zero!");
                }
            }
        }

        public string SportName
        {
            get
            {
                return this.SportName;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Sport name can not be null!");
                }
                else
                {
                    this.SportName = value;
                }
            }
        }

        public virtual bool CheckIfDraw(byte firstTeamScore, byte secondTeamScore) //Checks if the match ends with a draw
        {
            bool isDraw = false;

            if (firstTeamScore == secondTeamScore)
            {
                isDraw = true;
            }

            return isDraw;
        }

    }
}
