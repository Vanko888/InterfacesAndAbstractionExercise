using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Contracts;

namespace BorderControl.Models
{
    public class Citizen : IIdeable
    {
        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            
        }
        public string Id { get; set; }

        public string Name { get; private set; }
        public int Age { get; private set; }

        

        public string BirthDate { get; set; }
    }
}
