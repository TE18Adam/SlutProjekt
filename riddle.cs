using System;
using System.Collections.Generic;

    public class riddle : NumberGuessBooth
    {

    //  int riddlesvar = 4;
    string booom;
      
      public void riddleme()
      {

        trues = false;
     //   Console.WriteLine("arya bertil conny dalia bor i ett fyravåningsus. vilken våning bor arya på?");
     //   Console.WriteLine("bertil och conny bor under dalia och arya bor över dalia.");

     Console.WriteLine("Want to destroy a tall building? if so enter 1");
        
          try
          {
       
            while(trues == false)
            {

              Stack<int> housestack = new Stack<int>();
              housestack.Push(1);
              housestack.Push(2);
              housestack.Push(3);
              housestack.Push(4);
              housestack.Push(5);
              housestack.Push(6);
              housestack.Push(7);

              booom = Console.ReadLine();

              if(booom == "boom")
              {
                
                while(housestack.Peek() != 1)
                {
                  Console.Write("Destroyed story ");
                  Console.WriteLine(housestack.Pop() - 1);
                }    

                Console.WriteLine("All stories are destroyed, the building is decimated");       
                 
              }
              
              /*
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
            */


           }

          

          } catch
            {
              
            }

      }
    }

