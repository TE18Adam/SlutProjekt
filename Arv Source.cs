using System;

namespace Program
{
    public class ArvSource
    {
        // En random generator som kan instansieras
        public Random randomnumber = new Random(); 

        int[] hisguessinkapsling = new int[10];   
      
       
        // Alla bools som används av andra klasser
        
        // Används av API
        public bool morefacts = true;
        //Används av API och NumberGuess
        public bool trues = false;  
        //Används av API och NumberGuess
        public bool replay = true;
        
        
        //Alla ints som instansieras av andra klasser
        public int hisguess = 0;
        public int attempts = 3;

     /*   public int inkapsling
        {
            get { return hisguess; }
            set 
            { 
                if (value == 1|| value ==2 || value ==3 | value ==4 || value == 5 || value == 6 || value ==7 || value == 8 || value == 9 || value == 10)
                {
                    hisguess = value;
                }
                else
                {
                    hisguess = 0;
                }
            }
            */
        }
       
      
    }

