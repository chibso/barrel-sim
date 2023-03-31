using Microsoft.VisualBasic;
using System.ComponentModel;


namespace BOX
{
    public enum MaterialType
    {
        Wood,
        Iron
    }
    public enum SizeType
    {
        Small,
        Big
    }

    public struct Box
        
    { 
        public MaterialType Material { get; set; }
        public SizeType Size { get; set; }

        public Box()
    
        {
            Size = SizeType.Big;
            Material = MaterialType.Iron;

        }
        public Box(SizeType DEFALTsize)
        {
            Size = DEFALTsize; 
      
        }


        public void SetTheMaterial( MaterialType newMaterial)
            
        {
            Material = newMaterial;

        }

        public void SetTheMaterial()
        {
            if (GetRandomStuff())
                Material = MaterialType.Wood;

            else
                Material = MaterialType.Iron;

        }

        public void SetTheSizeOfTheBox()
        {

            if (GetRandomStuff())
                Size = SizeType.Big;

            else
                Size = SizeType.Small;
        }
        private bool GetRandomStuff()
        {
            

            Random random = new Random();
            int a = random.Next(0, 10);
            if (a > 5)
                return true;
            else
                return false;
         
            
            
            



        }
        

    }
}