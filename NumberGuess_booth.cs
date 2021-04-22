using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using RestSharp;
using System;

public class NumberGuessBooth : Booth
{

    private int attempts = 3;
    private int hisguess = 0;
    private int secretnumber;
    private string WnaReplay;

   

    public void numberguessmetod()
    {
        secretnumber = randomnumber.Next(2) + 1;
        trues = false;
        replay = true;
        attempts = 3;

        while (trues == false)
        {
            try
            {

                
                secretnumber = randomnumber.Next(2) + 1;


                // En while loop vars funktion är att kolla om spelaren vill spela om spelet eller gå vidare till nästa
                while (replay == true)
                {

                    // if sats som bara tillåter texten att visas om spelaren har alla gissningar kvar så den inte visas efter varje gissning
                    if (attempts == 3)
                    {
                        Console.WriteLine("You have " + attempts + " guesses, which number i am thinking of between 1-10: ");
                    }

                    // en while loop som körs medans spelaren inte har gissat rätt eller har slut på gissningar
                    while (secretnumber != hisguess && attempts > 0)
                    {

                        // tar spelarens gissning vilket är en string och omvandlar den till en int som sedan jämförts med det hemliga numret
                        hisguess = Convert.ToInt32(Console.ReadLine());
                        attempts--;

                       
                        if (hisguess != secretnumber)
                        {
                            Console.WriteLine("Wrong, " + attempts + " guesses left:");
                        }

                        if (hisguess == secretnumber)
                        {
                            replay = false;
                            highscore.Add(3 - attempts);

                            Console.WriteLine(" Congrats your guess of " + attempts + " was right!");
                            Console.Write("your highscore is ");
                            highscore.ForEach(Console.WriteLine);
                            Console.WriteLine("Do you want to play again?");
                            WnaReplay = Console.ReadLine();
                        }

                        if (WnaReplay == "highscore")
                        {
                            highscore.ForEach(Console.WriteLine);
                        }

                    }


                    // En if-sats som körs ifall spelaren fick slut på gissningar och på så sätt förlorade
                    if (attempts == 0)
                    {
                        Console.WriteLine("You ran out of guesses and lost. The secret number was " + secretnumber + ".");
                        replay = false;
                    }



                    // om spelaren vill spela om spelet igen så startas loopen om igen och spelaren återfår alla sina 3 gissningar
                    if (yesarray.Contains(WnaReplay))
                    {
                        secretnumber = randomnumber.Next(2) + 1;
                        replay = true;
                        attempts = 3;
                    }

                    if (noarray.Contains(WnaReplay))
                    {                    
                        Console.WriteLine(" ok now on to the next game!");
                        replay = false;
                    }
                }

                trues = true;
            }
            catch
            {
                Console.WriteLine("Write in a number not letters");
            }

        }
    }
}