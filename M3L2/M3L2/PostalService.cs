using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3L2
{
    public class PostalService

    {
        public delegate void NewLetterEventHandler(object sender, EventArgs e);
        public event NewLetterEventHandler NewLetter;
        public void AddNewLetter()

        {
            NewLetter?.Invoke(this, EventArgs.Empty);
        }

    }
}
