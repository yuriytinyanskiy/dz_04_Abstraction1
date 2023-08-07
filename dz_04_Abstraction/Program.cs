namespace dz_04_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar();

            sportCar.Go();

            sportCar.IAcceleration();

            Truck truck = new Truck();

            truck.Go();

            truck.IDownload();

            truck.IUnload();


        }
    }
}