using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class ContactManagerException : Exception

    {

        public ContactManagerException() { }


        public ContactManagerException(string message) : base(message) { }


        public ContactManagerException(string message, Exception inner) : base(message, inner) { }

    }
}
