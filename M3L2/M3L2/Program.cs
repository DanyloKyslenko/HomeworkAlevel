using M3L2;
class Program
{
    static void Main(string[] args)
    {
        PostalService postalService = new PostalService();
        Subscriber danil = new Subscriber("Danil" , "Akakienko");
        Subscriber vadim = new Subscriber("Vadim", "Lampenko");
        Subscriber oleg = new Subscriber("Oleg", "Shevchenko");
        Subscriber maksim = new Subscriber("Maksim", "Tarasenko");
        Subscribe subscriber1 = new Subscribe(postalService, danil);
        Subscribe subscriber2 = new Subscribe(postalService, vadim);
        Subscribe subscriber3 = new Subscribe(postalService, oleg);
        Subscribe subscriber4 = new Subscribe(postalService, maksim);
        postalService.AddNewLetter();
        subscriber3.Dispose();
        postalService.AddNewLetter();
    }

}