using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

public class Booth
{

    // En random generator som kan instansieras
    protected Random randomnumber = new Random();

    protected List<int> highscore = new List<int>();

    int[] hisguessinkapsling = new int[10];

    // arrays som kollar om du skrivit ja eller nej. används av triviabooth, jukebox och luxuryjukebox
    protected string[] yesarray = { "Y", "y", "Yes", "yes" };
    protected string[] noarray = { "N", "n", "No", "no" };




    //Används av triviabooth och NumberGuess
    protected bool trues = false;
    //Används av triviabooth och NumberGuess
    protected bool replay = true;


    private int trivianum2 { get; set; }


    public int getnumber
    {
        get { return trivianum2; }

        set
        {
            if (value > 0)
            {
                value = trivianum2;
            }
        }
    }
}