using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BorderControl.Contracts;
using BorderControl.Models;

namespace BorderControl.Core
{
    public class Engine
    {
        private List<IIdeable> ideables;

        public Engine()
        {
            this.ideables = new List<IIdeable>();
        }
        public void Run()
        {
            CreateIdentifiable();
            CheckForFakeId();
            
        }

        

        private void CheckForFakeId()
        {
            string fakeIdChecker = Console.ReadLine();
            string[] fakeIds = this.ideables.Where(x => x.Id.EndsWith(fakeIdChecker)).Select(x => x.Id).ToArray();
            foreach (var id in fakeIds)
            {
                Console.WriteLine(id);
            }
        }

        private void CreateIdentifiable()
        {
            string input = Console.ReadLine();
            while (input != "End")
            {
                IIdeable iideBirthables;
                string[] currInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (currInput.Length == 2)
                {
                    string model = currInput[0];
                    string id = currInput[1];
                    iideBirthables = new Robot(model, id);
                }
                else
                {
                    string name = currInput[0];
                    int age = int.Parse(currInput[1]);
                    string id = currInput[2];
                    iideBirthables = new Citizen(name, age, id);
                }
                this.ideables.Add(iideBirthables);
                input = Console.ReadLine();
            }
        }
    }
}
