using System;
using System.Collections.Generic;
using System.Text;
using BorderControl.Contracts;

namespace BorderControl.Models
{
    class Robot : IIdeable
    {
        public string Model { get; private set; }
        public string Id { get; set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
