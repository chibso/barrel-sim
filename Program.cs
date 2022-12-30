namespace Barrel
{
    class Program
    {
        static void Main(string[] args)
        {   string a;

            Box theBox=new Box();
            a=Console.ReadLine().ToLower();
            switch (a)
            {
                case "wood":
                theBox.SetTheMaterial(MaterialType.Wood);
                break;
                case "iron":
                theBox.SetTheMaterial(MaterialType.Iron);
                break;
                default:
                Console.WriteLine("you can only use Wood or Iron (ERROR)");
                return;
            }      
            Console.WriteLine(theBox.Material);
        }

    }
}