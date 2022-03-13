using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        private List<IBirthable> Ibirthables;

        public Engine()
        {
            this.Ibirthables = new List<IBirthable>();
        }
        public void Run()
        {
            CreateBirthables();
            CheckForBirtdate();

        }



        private void CheckForBirtdate()
        {
            string birthdateChecker = Console.ReadLine();
            string[] birthdates = this.Ibirthables.Where(x => x.BirthDate.EndsWith(birthdateChecker))
                .Select(x => x.BirthDate).ToArray();
            foreach (var date in birthdates)
            {
                Console.WriteLine(date);
            }

        }

        private void CreateBirthables()
        {

            string input = Console.ReadLine();
            while (input != "End")
            {
                IBirthable birthable = null;
                string[] currInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (currInput[0] == "Citizen")
                {
                    string name = currInput[1];
                    int age = int.Parse(currInput[2]);
                    string id = currInput[3];
                    string birthdate = currInput[4];
                    birthable = new Citizen(name, age, id, birthdate);
                }
                else if (currInput[0] == "Pet")
                {
                    string name = currInput[1];
                    string birthdate = currInput[2];
                    birthable = new Pet(name, birthdate);
                }

                if (birthable != null)
                {
                    this.Ibirthables.Add(birthable);
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
