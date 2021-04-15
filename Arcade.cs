using System;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
          luxuryjukebox lyxinstanst = new luxuryjukebox();
          lyxinstanst.luxury();     
        
            // instans för jukebox klassen
            jukebox jukeinstans = new jukebox();
            jukeinstans.juke();

            // här instansieras klassen NumberGuess så att spelet vars logik klassen själv sköter körs i main
            NumberGuess_booth ng = new NumberGuess_booth();
            ng.numberguessmetod();
           
            // instas för API klassen
            Trivia_booth instans = new Trivia_booth();
            instans.apithing();       
            
        }
    }
}
