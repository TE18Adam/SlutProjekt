using System;
using Newtonsoft.Json;
using RestSharp;
using System.Linq;

namespace Program
{
    public class Trivia_booth : Booth_basklass
    {
        private bool morefacts = true;
        private int trivianuminput;
        public void apithing ()
        {
           
           
            Console.WriteLine("Hello and welcome to the number trivia booth!");
            Console.WriteLine("Here you can tell us a number and we will tell you a fun fact about it so go ahead and write a number in!");
          
          while(trues == false && morefacts == true)
          {
            try {

             // instansierar Game_variables så att getnumber metoden kan köras och så att inkapslingen är aktiv
             Booth_basklass linkcreate = new Booth_basklass();           
        
              /* konverterar vad avändaren skrev för numer till en int som sedan läggs imellan länkens 2 delar så den skapar en länk som 
              requestar ett random fact om numret som spelaren skrev in */  
              trivianuminput =  Convert.ToInt32(Console.ReadLine());
            
              // anropar instansen linkcreate och accessar metoden getnumber inom instansen och sätter variabeln inom metoden till trivianuminput om kraven av inkapslingen är zVBNµ|
              linkcreate.getnumber = trivianuminput;
                        
              string link = "http://numbersapi.com/" + getnumber + "/trivia";
                    

            // Här skapar man ett pull request för data från den publika API'n visad i den första parantesen
            RestClient PullingFrom = new RestClient("http://numbersapi.com/");
            
            // här specfierar vad från API'n det är för information man vill ha 
            RestRequest TriviaRequest = new RestRequest(link);
            IRestResponse response = PullingFrom.Get(TriviaRequest);
          
 
            Console.WriteLine(response.Content);
            Console.WriteLine("Want facts about more numbers?");
            string factsagain = Console.ReadLine();
           
            if( yesarray.Contains(factsagain) )
            {
              morefacts = true;
              trues = false;
            }

            if( noarray.Contains(factsagain) )
            {
              morefacts = false;
              trues = true;
            }

            Console.ReadLine();
            trues = true;
 
            }
            catch
            {
              Console.WriteLine( "Write in a number not text");
            }
         
          }

        }
        
     
    }
}
