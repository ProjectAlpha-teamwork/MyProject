namespace TeamProject_Alpha.Sports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    abstract class NotPossibleDraw : Sport
    {
        private double[] coefficients;
        public NotPossibleDraw(DateTime eventDate, string sportName, int matchDuration, double[] coefficients)
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
    }
}

