using System;
using System.Runtime.InteropServices;

namespace Barrel
{
    class Program
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        static void Main(string[] args)
        {
            string a;

            Box theBox = new Box();
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