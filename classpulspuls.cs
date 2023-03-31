using System;
namespace BOX
{
    public abstract class vehicle
    {
        public string LicenseNumber { get; set; }

        public abstract void ignition();

        
        

        
        
        





    }
    public class paykan : vehicle
    {
        public event EventHandler broken;

        public override void ignition()
        {
            

            Random random = new Random();
            int a = random.Next(0, 10);
            if (a > 5)
                broken.Invoke(this,EventArgs.Empty);
            else
                Console.WriteLine("your lagan is started");

        }






    }
    public class pride:vehicle
    {
        public void AirBag()
        {
            Console.WriteLine("Air Bag is open but driver is dead");
        }
        public override void ignition()
        {
            Console.WriteLine("killing car is started");
        }


    }
}   