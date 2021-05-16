using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
  
     // instansierar basklassen och derive klassen
     NumberGuessBooth deriveklass = new NumberGuessBooth();
     Booth basklass = new Booth();
     

     // kör basklassens virtual void metod samt derive klassens overrided version av basklassens virtualvoid metod.
     basklass.virtualvoid();    
     deriveklass.virtualvoid();
     
   
   
     Arcade highinstans = new Arcade();
     highinstans.high();
 
    }
}
