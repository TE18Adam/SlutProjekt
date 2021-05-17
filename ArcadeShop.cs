using System;


    abstract class ArcadeShop
    {
        string HeBought;
        public abstract int shoop
        {
           get;   
        }
        public abstract string Name();
    
    }

  

    class Pear : ArcadeShop
    {

        public string Namee {get; set; }
        public override int shoop
        {
            get
            {
                return 10;
            }
        }

        public Pear( string name)
        {
            Namee = name;
        }

        public override string Name() 
        {
            return Namee + "pear";
        }
    }

    class Apple : ArcadeShop
    {

        public string Namee {get; set; }
        public override int shoop
        {
            get
            {
                return 20;
            }
        }

        public Apple( string name)
        {
            Namee = name;
        }

        public override string Name() 
        {
            return Namee + "apple";
        }
    }
  

