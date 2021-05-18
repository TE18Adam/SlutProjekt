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
             /* en loop som visar hur stack kan användas. här kollar man på värdet högst upp i högen genom .Peek() och när man gör 
                det så tas den komponenten man kollade på genom .Peek() bort med .Pop(). Jag skrev till -1 eftersom att stack körs
                sålänge den inte är på värde 1 så den stannar på värdet 2 men jag vill att hela byggnaden kollapsar så jag får det
                sista värdet att visas som 1 istället för 2 så alla våningar kollapsar */
               
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

