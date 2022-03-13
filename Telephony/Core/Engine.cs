using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models;

namespace Telephony.Core
{
    public class Engine
    {
        private Smartphone smartphone;
        private IList<string> phoneNumbers;
        private IList<string> urls;

        public Engine()
        {
            this.smartphone = new Smartphone();
            this.phoneNumbers = new List<string>();
            this.urls = new List<string>();
        }

        public void Run()
        {
            phoneNumbers = Console.ReadLine().Split().ToList();
            urls = Console.ReadLine().Split().ToList();

            callPhoneNumber();
            browseUrl();
        }

        private void browseUrl()
        {
            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Browse(url));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void callPhoneNumber()
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                try
                {
                    Console.WriteLine(this.smartphone.Call(phoneNumber));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
