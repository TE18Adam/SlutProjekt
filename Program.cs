using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
     //skapar en lista där olika instanser av ArcadeShop sparas
     List<ArcadeShop> cart = new List<ArcadeShop>();
  
     string choice;
    
     Console.WriteLine("We sell apple and pear write the one you want to buy. and when you are done write , done");
     choice = Console.ReadLine();
     
    
     while(choice != "done")
     {
    
        if(choice == "apple")
        {
            // lägger till instansen Apple i listan "cart" med texten Red framför
            cart.Add(new Apple("Red "));
        }
        else if(choice == "pear")
        {
            // lägger till instansen pear i listan "cart" med texten green framför
            cart.Add(new Pear("green "));
        }
        // en readline som låter dig välja så många frukter du vill tills du känner dig nöjd och skriver done.
        choice = Console.ReadLine();
     } 
        
        int totalamount = 0;
     
        // en foreach loop som lägger till return värdet från varje item i cart Listan in i totalamount int
        foreach(ArcadeShop item in cart)
        {
            totalamount += item.shoop;
            Console.WriteLine(item.Name(), item.shoop);
        }
     
        Console.WriteLine(totalamount);
        Console.ReadLine();
     
  
  
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
