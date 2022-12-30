namespace Barrel
{   
    public enum MaterialType {
    Wood,
    Iron
    }

    public class Box
    {
      public MaterialType Material {get;set;}
      
      public void SetTheMaterial (MaterialType newMaterial)
      {
        Material=newMaterial;

      }   




    }
}