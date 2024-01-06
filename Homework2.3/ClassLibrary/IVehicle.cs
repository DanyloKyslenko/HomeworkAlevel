namespace ClassLibrary
{
    interface IVehicle
    {
        string Model { get; set; }
        int Speed { get; set; }
        double Weight { get; set; }
        string Area { get; set; }
        void PrintStats();
    }
}