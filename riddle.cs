using System;
using System.Collections.Generic;

    public class riddle : NumberGuessBooth
    {

      int riddlesvar = 4;
      public void riddleme()
      {

        trues = false;
        Console.WriteLine("arya bertil conny dalia bor i ett fyravåningsus. vilken våning bor arya på?");
        Console.WriteLine("bertil och conny bor under dalia och arya bor över dalia.");
        
          try
          {
       ;
            while(trues == false)
            {

              Stack<int> housestack = new Stack<int>();
              housestack.Push(2);
              housestack.Push(3);
              housestack.Push(4);

              hisguess = Convert.ToInt32(Console.ReadLine());

    
              if(hisguess == riddlesvar)
              {
                Console.WriteLine("you were right arya lives on the " + housestack.Pop() + "th floor");
                Console.WriteLine("and dalia lives on the " + housestack.Pop() + "rd floor");
                trues = true;
              }

              else if( hisguess != riddlesvar)
              {
                Console.WriteLine("wrong answer try again");
                trues = false;
             }
           
           }

          } catch
            {
              Console.WriteLine("write in the number of your guessed floor not in letters");
            }

      }
    }

