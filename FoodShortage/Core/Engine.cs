using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BirthdayCelebrations.Contracts;
using BirthdayCelebrations.Models;
using FoodShortage.Contracts;
using FoodShortage.Models;

namespace BirthdayCelebrations.Core
{
    public class Engine
    {
        private List<IBuyer> Ibirthables;

        private List<string> names = new List<string>();
        private int Food { get; set; }
        public Engine()
        {
            this.Ibirthables = new List<IBuyer>();
        }
        public void Run()
        {
            FillList();
            CreateBirthables();
            CheckForBirtdate();

        }

        private void FillList()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] buyersInfo = Console.ReadLine().Split();
                string name = buyersInfo[0];
                int age = int.Parse(buyersInfo[1]);
                IBuyer buyer = null;
                if (buyersInfo.Length == 3)
                {
                    string group = buyersInfo[2];
                    buyer = new Rebel(name, age, group);
                }
                else
                {
                    string id = buyersInfo[2];
                    string birthDate = buyersInfo[3];
                    buyer = new Citizen(name, age, id, birthDate);
                }

                if (buyer != null)
                {
                    this.Ibirthables.Add(buyer);
                    names.Add(name);
                }

            }
        }


        private void CheckForBirtdate()
        {
            Console.WriteLine(this.Food);
        }

        private void CreateBirthables()
        {
           
            string input = Console.ReadLine();
            while (input != "End")
            {
                if (names.Contains(input))
                {
                    IBuyer currBuyer = Ibirthables.FirstOrDefault(x => x.Name == input);
                    currBuyer.BuyFood();
                    this.Food += currBuyer.Food;
                    currBuyer.ResetFood();
                }


                input = Console.ReadLine();
            }
            

            
        }
    }
}
