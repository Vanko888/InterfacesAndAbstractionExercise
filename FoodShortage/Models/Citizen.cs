using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.Contracts;
using FoodShortage.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Citizen : IIdeable, IBirthable, IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.BirthDate = birthdate;
        }
        public string Id { get; set; }

        public string Name { get; private set; }
        public int Food { get; private set; }
        public void BuyFood()
        {
            this.Food += 10;
        }

        public void ResetFood()
        {
            this.Food = 0;
        }

        public int Age { get; private set; }
        
        public string BirthDate { get; set; }
    }
}
