/// ne znam dali shte vi trqbwat ,no gi napravih 
/// ako sluchaino iskate da pravite listove ot tqh ,za da si vzimame dannite s igrachite ot failovete 
/// ako ne vi trqbvat gi mahnete
namespace TeamProject_Alpha.Opponents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Teams
    {
        private string name;
        private string nationality;
      
        public Teams(string name, string nationality)
        {
            this.Name = name;
            this.Nationality = nationality;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The name of the opponent can not be null!");
                }
                else
                {
                    this.name = value;
                }     
            }
        }
        public string Nationality
        {

            get
            {
                return this.nationality;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The nationality of the opponent can not be null!");
                }
                else
                {
                    this.nationality = value;
                }     
            }
        }
    }
}
