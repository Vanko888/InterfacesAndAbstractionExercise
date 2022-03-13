using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Contracts;
using Telephony.Exceptions;

namespace Telephony.Models
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Call(string number)
        {
            if (!number.All(c => char.IsDigit(c)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumber);
            }

            return number.Length > 7 ? $"Calling... {number}" : $"Dialing... {number}";
        }

        public string Browse(string url)
        {
            if (url.Any(c => char.IsDigit(c)))
            {
                throw new ArgumentException(ExceptionMessages.InvalidUrl);
            }

            return $"Browsing: {url}!";
        }
    }
}
