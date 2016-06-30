
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users;

namespace TeamProject_Alpha.Users
{
    class Registration
    {

        public Registration(string userName, string firstName, string lastName,
            string ssn, decimal balance, Gender gender, string passWord,
            string backUpCode, string address, DateTime birthDay)
        {
            var randomUser = new User(userName, firstName, lastName, ssn, balance, gender, passWord, backUpCode, address, birthDay);

            DoesItExist(userName);

            var writer = new StreamWriter("Users.txt");

            writer.WriteLine(userName + " " + firstName + " " + lastName + " " + ssn + " " + balance + " " + gender + " " + passWord
                + " " + backUpCode + " " + address + " " + birthDay);

            writer.Close();



        }


        private static void DoesItExist(string userName)
        {
            var reader = new StreamReader("Users.txt");
           
            var line = reader.ReadLine();          

            while (line == null)
            {
                if (line.Contains(userName))
                {
                    reader.Close();
                    throw new ArgumentException("This username is already taken");
                }

                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
