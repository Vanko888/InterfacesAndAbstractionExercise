using System;
using System.Collections.Generic;
using BorderControl.Core;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //List<string> ids = new List<string>();
            //string input = Console.ReadLine();
            //while (input != "End")
            //{
            //    string[] currInput = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    if (currInput.Length == 2)
            //    {
            //        string model = currInput[0];
            //        string id = currInput[1];
            //        ids.Add(id);
            //    }
            //    else
            //    {
            //        string name = currInput[0];
            //        int age = int.Parse(currInput[1]);
            //        string id = currInput[2];
            //        ids.Add(id);
            //    }
            //    input = Console.ReadLine();
            //}

            //string checker = Console.ReadLine();
            //int stepen = checker.Length;
            //double delitel = Math.Pow(10, stepen);
            //foreach (var id in ids)
            //{
            //    double number = double.Parse(id);
            //    if (number % delitel == double.Parse(checker))
            //    {
            //        Console.WriteLine(id);
            //    }
            //}
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
