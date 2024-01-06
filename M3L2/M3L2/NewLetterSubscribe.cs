using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M3L2
{
    public class Subscribe : IDisposable
    {
        private PostalService postalService;
        public Subscriber Subscriber { get; set; }
        public Subscribe(PostalService postalService, Subscriber subscriber)
        {
            this.postalService = postalService;
            this.Subscriber = subscriber;
            postalService.NewLetter += NewLetter;
        }
        private void NewLetter(object sender, EventArgs e)
        {
            Console.WriteLine($"\n{Subscriber.FirstName} {Subscriber.LastName}, a new letter has arrived!");
        }
        public void Dispose()
        {
            postalService.NewLetter -= NewLetter;
        }
    }
}
