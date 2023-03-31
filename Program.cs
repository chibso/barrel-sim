using System;
using System.Runtime.InteropServices;

namespace BOX
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        private static void onBroken(object sender, EventArgs e)
        { Console.WriteLine("your car has been blown up"); }

            static void Main(string[] args)
        {   
               
            string a;
            int i=1, b=1;
            Console.WriteLine(++i);
            Console.WriteLine(b++);

                


            Console.WriteLine (Riyazi.Square(10));
           
            paykan paykanjavanan = new paykan();
            pride pride111 = new pride();
            pride111.AirBag();
            paykanjavanan.LicenseNumber = "11S198|46";
            paykanjavanan.broken += onBroken;
            paykanjavanan.ignition();
            


            Console.WriteLine(paykanjavanan.LicenseNumber);
;            Box theBox = new Box();
            Box theBox2 = new Box(SizeType.Small); 
            Console.WriteLine(theBox2.Size.ToString()+"2");
            Console.WriteLine(theBox2.Material.ToString()+"2");


            
            theBox.SetTheMaterial();
            theBox.SetTheSizeOfTheBox();
            Console.WriteLine(theBox.Size);
            Console.WriteLine(theBox.Material);
            a = Console.ReadLine().ToLower();
            

            switch (a)
            {
                case "WoodBox":
                    theBox.SetTheMaterial(MaterialType.Wood);
                    break;
                case "IronBox":
                    theBox.SetTheMaterial(MaterialType.Iron);
                    break;
                default:
                    MessageBox(IntPtr.Zero, "Error Found {you can only use iron or wood in this program} (ERORR ID:781)Input Error , ErrorOnReadLine ".ToString(), "ERROR", 0);
                    return;
                    
            }
            MessageBox(IntPtr.Zero, theBox.Material.ToString(), "The Box Material Has Been Change ", 0);


            
        }

    }
}