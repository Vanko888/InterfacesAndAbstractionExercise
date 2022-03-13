using System;
using System.Collections.Generic;
using System.Text;
using BirthdayCelebrations.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.BirthDate = birthdate;
        }
        public string BirthDate { get; set; }

        public string Name { get; private set; }
    }
}
