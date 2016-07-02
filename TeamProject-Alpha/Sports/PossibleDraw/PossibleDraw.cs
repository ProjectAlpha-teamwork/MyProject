namespace TeamProject_Alpha.Sports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Opponents;

 abstract class PossibleDraw : Sport
    {
        //private Teams firstTeam;
        //private Teams secondTeam;        
        private double[] coefficients;

        public PossibleDraw(DateTime eventDate, string sportName, int matchDuration, double[] coefficients)
            : base(eventDate, sportName, matchDuration)
        {
            this.Coefficients = coefficients;

        }
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
