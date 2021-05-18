using System;

    // denna abstrakta basklassen har framework som klasser måste ärva av om dom vill vara en instans av arcadeshop
    abstract class ArcadeShop
    {
        string HeBought;
        public abstract int shoop
        {
           get;   
        }
        public abstract string Name();
    
    }

  
    // en instans av ArcadeShop som måste använda sig av arcadeshops framework
    class Pear : ArcadeShop
    {
        // ger ett värde till Namee med set och returnerar värdet med get.
        public string Namee {get; set; }

        // overridar Arcadeshops abstrakta int namngett "shoop" och returnerar ett nytt värde
        public override int shoop
        {
            get
            {
                return 10;
            }
        }
        
        // name innehåller värdet som står i parantesen cart.Add(new Pear()); i program.cs
        public Pear( string name)
        {
            // här sparas stringen från parantesen cart.Add(new Pear()); i en lokal variabel kallad Namee
            Namee = name;
        }
        
        // här overridas name variabeln och returnar den lokala variabeln Namee som plussats ihop med texten "pear"
        public override string Name() 
        {
            return Namee + "pear";
        }
    }
    
    // den här klassen är identisk med pear klassen bara att variabler har olika namn så kommentarerna i pear klassen gäller här också
    
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
  

