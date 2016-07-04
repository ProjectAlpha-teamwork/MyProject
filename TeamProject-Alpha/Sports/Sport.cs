namespace TeamProject_Alpha.Sports
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Sport : ISport
    {

        private string sportName;
        
        public Sport(string sportName)
        {
            
            this.SportName = sportName;
        }
        
       public string SportName
        {
            get
            {
                return this.sportName;
            }
            private set
            {
                
                    this.sportName = value;
                
            }
        }

        //Methods
        public abstract void UserBetInteraction();

        public virtual string ParseId(string text) //parse method to read path from string
        {
            int id = 0;
            int endid = text.IndexOf('.');
            id = text.Length - (text.Length - endid);
            return text.Substring(0,id) + '.';
        }
        public virtual string ParseMatch(string text)
        {
            string match = null;
            string[] arr = text.Split('|');
            match = arr[1];
            return match.ToString();
        }
        public virtual double ParseBetCoef(string text, string bet)
        {
            double result;
            string[] arr = text.Split('|');
            string[] possibleCoef = new string[3];
            possibleCoef[0] = arr[2];
            possibleCoef[1] = arr[3];
            possibleCoef[2] = arr[4];
            if (bet == "1")
            {
                return result = Convert.ToDouble(possibleCoef[0].Substring(5, 4));
            }
            if (bet == "x")
            {
                return result = Convert.ToDouble(possibleCoef[1].Substring(5, 4));

            }
            if (bet == "2")
            {
                return result = Convert.ToDouble(possibleCoef[2].Substring(5, 4));
            }
            else
            {
                throw new ArgumentException("No such bet exists");
            }

        }
        public virtual double CalculateBet(double bet, double deposit)
        {

            double finalBet = deposit * bet;
            return finalBet;
        }
        public virtual string ParseBetCoef(string text)
        {
            string threeCoeff;
            string[] arr = text.Split('|');
            string[] possibleCoef = new string[3];
            possibleCoef[0] = arr[2];
            possibleCoef[1] = arr[3];
            possibleCoef[2] = arr[4];
            threeCoeff = possibleCoef[0] + possibleCoef[1] + possibleCoef[2];
            return threeCoeff;

        }
        public virtual string PrintF(string id, string match, string possibleResults)
        {
            string result = string.Format("Match id: " + id + " " + match + " " + possibleResults);
            return result;
        }

        
    }
}