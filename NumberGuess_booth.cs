using System;
using Newtonsoft.Json;
using RestSharp;

namespace Program
{
    public class NumberGuess_booth : Booth_basklass
    {

        private int attempts = 3;
        private int hisguess = 0;
        private int secretnumber;
        private string WnaReplay;
    public void numberguessmetod()
    {
           
           
        while(trues == false)
        {
            try{

            // Random generator som slumpar det hemliga numret som spelaren ska gissa
            secretnumber = randomnumber.Next(10);
           
           
            // En while loop vars funktion är att kolla om spelaren vill spela om spelet eller gå vidare till nästa
            while(replay == true)
            {
            
                // if sats som bara tillåter texten att visas om spelaren har alla gissningar kvar så den inte visas efter varje gissning
                if(attempts == 3)
                {
                    Console.WriteLine("You have " + attempts + " guesses, which number i am thinking of between 1-10: ");
                }
            
               // en while loop som körs medans spelaren inte har gissat rätt eller har slut på gissningar
               while(secretnumber !=  hisguess && attempts > 0)
               {
                   
                   // tar spelarens gissning vilket är en string och omvandlar den till en int som sedan jämförts med det hemliga numret
                   hisguess = Convert.ToInt32(Console.ReadLine());
                   attempts--;
                   
                   // om spelaren gissar fel så säger programmet till spelaren att han hade fel
                   if(hisguess != secretnumber)
                   {
                       Console.WriteLine("Wrong, " + attempts + " guesses left:");                   
                   }
                 
                 
                   // om spelaren gissar rätt visas texten inom console.Writeline
                   if(hisguess == secretnumber)
                   {
                       Console.Write(" Congrats your guess of " + attempts + " was right!");
                       replay = false;
                   }
   
               }
           
               
               // En if-sats som körs ifall spelaren fick slut på gissningar och på så sätt förlorade
               if(attempts == 0)
               {
                   Console.WriteLine("You ran out of guesses and lost. The secret number was " + secretnumber + ".");
                   replay = false;
               }

               /* ett block kod som frågar spelaren om han vill spepa om spelet eller inte, om han vill det så blur replay bool sann
               igen vilket gör att spel loopen fortfarande körs. om svaret är nej avslutas loopen */
               Console.WriteLine("do you wish to replay? respond with a yes or no");
               WnaReplay = Console.ReadLine();

               // om spelaren vill spela om spelet igen så startas loopen om igen och spelaren återfår alla sina 3 gissningar
               if(WnaReplay == "yes")
               {
                   secretnumber = randomnumber.Next(10);
                   replay = true;
                   attempts = 3;
                  
               }

               if(WnaReplay == "no")
               {
                   replay = false;
                   Console.WriteLine(" ok now on to the next game!");
               }
            }

            Console.ReadLine();
            trues = true;
        }
            catch
            {
                Console.WriteLine("Write in a number not letters");
            }

            }
    }
}

}
