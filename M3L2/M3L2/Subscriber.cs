using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3L2
{
    public class Subscriber
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subscriber(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
