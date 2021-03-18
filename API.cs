using System;
using Newtonsoft.Json;
using RestSharp;

namespace Program
{
    public class API : ArvSource
    {
       
        
        public void apithing ()
        {
           
           
            Console.WriteLine("Hello and welcome to the number trivia booth!");
            Console.WriteLine("Here you can tell us a number and we will tell you a fun fact about it so go ahead and write a number in!");
          
          while(trues == false && morefacts == true)
          {
            try {
            
                
            /* konverterar vad avändaren skrev för numer till en int som sedan läggs imellan länkens 2 delar så den skapar en länk som 
            requestar ett random fact om numret som spelaren skrev in */  
            int trivianum2 =  Convert.ToInt32(Console.ReadLine());
            string link = "http://numbersapi.com/" + trivianum2 + "/trivia";
            

          
            // Här skapar man ett pull request för data från den publika API'n visad i den första parantesen
            RestClient PullingFrom = new RestClient("http://numbersapi.com/");
            
            // här specfierar vad från API'n det är för information man vill ha 
            RestRequest TriviaRequest = new RestRequest(link);


            IRestResponse response = PullingFrom.Get(TriviaRequest);

           
            Console.WriteLine(response.Content);
            Console.WriteLine("Want facts about more numbers?");
            string factsagain = Console.ReadLine();
            
            if(factsagain == "y")
            {
              morefacts = true;
              trues = false;
            }

            if(factsagain == "n")
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
