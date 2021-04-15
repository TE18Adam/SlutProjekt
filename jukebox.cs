using System.Collections.Generic;
using System.Linq;
using System;
using Newtonsoft.Json;
using RestSharp;

namespace Program
{
    public class jukebox : Booth_basklass
    {
        private string songchoice;  private string songchoice2; private string songchoice3;
        protected string songlist1; protected string songlist2; protected string songlist3;
        private string confirm;
        private bool lista = true;
      
        public void juke()
        {
        
            while(trues == false)
            {
               
                // Här förklaras jukebox reglerna tydligt. Sedan registreras också vad spelarens försa låtval är i songchoice
                Console.WriteLine("Hello and welcome to the jukebox. Here you write in which song you want to play and we will play chronologically");
                Console.WriteLine("In other words, the first song you put in we play first, the second song you put in we play after the first etc.");
                Console.Write("So please write in your choices: ");
                songchoice = Console.ReadLine();
            
                // Här registreras andra låtvalet
                Console.Write("And the second choice: ");
                songchoice2 = Console.ReadLine();
            
                // Här registreras tredje låtvalet
                Console.Write("And the third choice: ");
                songchoice3 = Console.ReadLine();

                // Här skapas en queue med namnet songorder
                Queue<string> songorder = new Queue<string>();

                // Här Läggs spelarens låtval som sparats i variationer av songchoice variabeln i kö.
                songorder.Enqueue(songchoice);
                songorder.Enqueue(songchoice2);
                songorder.Enqueue(songchoice3);

                // här spelas spelarens låtval upp och medans den spelas så tas den bort ur queuen
                Console.WriteLine("Those are some fine tunes. We will play the first one named: " + songorder.Dequeue() );
                Console.WriteLine("Now the second song named: " + songorder.Dequeue() );
                Console.WriteLine("Now the third song named: " + songorder.Dequeue() );
                Console.WriteLine("Looks like all your songs have been played.");


            
                Console.WriteLine("Emergency broadcast, many customers have put in complaints about not being able to change their song choice");
                while(lista == true)
                {
                
                // en list som innehåller spelarens låtval
                var songlist = new List<string>(); 
                
                Console.WriteLine("You may now choose your song choices and you will be asked to confirm the song choice in the end ");
               
                // låter spelaren skriva in sitt låtval som sparas i songlist1
                Console.Write("Choice 1: "); songlist1 = Console.ReadLine();
                Console.Write("Choice 2: "); songlist2 = Console.ReadLine();
                Console.Write("Choice 3: "); songlist3 = Console.ReadLine();

                Console.WriteLine("Confirm, " + songlist1 + ", " + songlist2 + ", " + songlist3 +  " as your choices?");
                confirm = Console.ReadLine();

                // kollar om spelaren är nöjd med sina låtval och om personen är det spelas låtvalen upp
                if (yesarray.Contains(confirm))
                {
                    Console.WriteLine("Ok then playing your selection now:");
                    
                    songlist.Add(songlist1);
                    songlist.Add(songlist2);
                    songlist.Add(songlist3);
               
                    songlist.ForEach(Console.WriteLine);
                    lista = false;
                
                }

                // kollar om spelaren inte är nöjd med sina låtval. om spelaren inte är nöjd startas loopen om igen så spelaren får välja om
                if (noarray.Contains(confirm))
                {
                    Console.WriteLine("Ok then we deleted your selection.");
                    lista = true;
                }

                }
               
               Console.ReadLine();

            }
        }
    }
}
