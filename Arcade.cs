using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using RestSharp;
using System;


public class Arcade
{
    LuxuryJukebox lyxinstanst = new LuxuryJukebox();
    NumberGuessBooth ng = new NumberGuessBooth();
    TriviaBooth instans = new TriviaBooth();
    Jukebox jukeinstans = new Jukebox();
    riddle riddleinstans = new riddle();
    private bool arcaderunning = true;
    private string playerchoice;
   
    public void high()
    {
        Console.WriteLine("Write which game you want to play. There is trivia, numberguess, jukebox and luxuryjukebox. ");
        
        // detta är spel loopen. sålänge true är sann så körs spelet.
        while(arcaderunning == true)
        {

            // playerchoice registrerar vad du skriver och baserat på vilket spels namn du skriver så kör den ditt önskade spel.
            Console.WriteLine("What game do you want to play?");
            playerchoice = Console.ReadLine();

            if(playerchoice == "numberguess")
            {
                ng.numberguessmetod();              
            }

            else if(playerchoice == "trivia")
            {
                instans.Trivia();             
            }

            else if(playerchoice == "jukebox")
            {
                jukeinstans.juke();
            }

            else if(playerchoice == "luxury jukebox")
            {
                lyxinstanst.Luxury();       
            }

            else if(playerchoice == "riddle")
            {
                riddleinstans.riddleme();
            }

        }
    }
}
