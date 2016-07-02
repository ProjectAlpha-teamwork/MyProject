namespace TeamProject_Alpha.Sports
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Sport
    {

        private string sportName;
        //private int matchDuration;
        private DateTime eventDate;

        public Sport(DateTime eventDate, string sportName, int matchDuration)
        {
            this.EventDate = eventDate;
            this.SportName = sportName;
            this.MatchDuration = matchDuration;


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
    }
}