namespace Application.PlayersOrTeams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// ne znam dali shte vi trqbwat ,no gi napravih 
    /// ako sluchaino iskate da pravite listove ot tqh ,za da si vzimame dannite s igrachite ot failovete 
    /// ako ne vi trqbvat gi mahnete
    class Players
    {
        private string name;
        private int age;
        private string nationality;
        public Players(string name, int age, string nationality)
        {
            this.Name = name;
            this.Age = age;
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
                    throw new ArgumentException("The name of the player can not be null!");
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The age of the player can not be null!");
                }
                else
                {
                    this.age = value;
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
                    throw new ArgumentException("The nationality of the player can not be null!");
                }
                else
                {
                    this.nationality = value;
                }
            }
        }
    }
}
