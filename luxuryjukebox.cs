using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using RestSharp;
using System;

    public class LuxuryJukebox : Jukebox
    {
       
     
        public void Luxury()
        {
            var songlist = new List<string>(); 

            while(replay == true)
            {
                Console.WriteLine("This is the luxury jukebox where you can choose not just 3 but as many songs that you want.");
                Console.WriteLine(" So here have your picks, and when you sre satisfied with your choices type the word, done");

               while(trues == false) 
               {
                    songlist1 = Console.ReadLine();
                    songlist.Add(songlist1); 
                             
                    if( songlist1 == "done")
                    {
                        Console.WriteLine("Alright we have your songs, playing them now:");
                       
                        System.Console.WriteLine("here are the songs you picked: ");
                        songlist.ForEach(Console.WriteLine);
                        trues = true;                
                    }
               }
             
                System.Console.WriteLine("that was your playlist, want to play again?");
                songlist1 = Console.ReadLine();

                if(yesarray.Contains(songlist1))
                {
                    System.Console.WriteLine("alright booting up the luxury jukebox again.");
                    replay = true;
                    trues = false;
                }
                
                if(noarray.Contains(songlist1))
                {
                    System.Console.WriteLine("Ok moving on to the next booth.");
                    replay = false;
                }

            }
            
                Console.ReadLine();
        }
    }
