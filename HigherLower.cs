using System;

class HigherLower {
  public static void Main () 
  {
    Console.WriteLine ("Pick a number between 1-100");
    Console.Write ("Are you ready? Press 'Y' to start : ");
    string start = Console.ReadLine ();

    if (start == "Y" || start == "y") 
    {
      Guess ();
    } 
    else 
    {
      Console.WriteLine ("Well maybe next time.");
    }

  }

  static void Guess () 
  {
    Console.WriteLine ("You started the guessing");
    bool correct = false;
    int high = 100;
    int low = 1;
    int turn = 0;


    while (!correct) 
    {
      int guess = (high + low) / 2;
      turn ++;

      Console.WriteLine ("Is your number {0}?", guess);
      Console.WriteLine ("Enter 'Y' for yes.");
      Console.WriteLine ("Enter 'H' for higher");
      Console.WriteLine ("Enter 'L' for lower");
      string guessInput = Console.ReadLine().ToLower();
      Console.WriteLine(guessInput);

      if(guessInput == "l")
      {
        high = guess;
      }
      else if (guessInput == "h")
      {
        low = guess;
      }
      else if (guessInput == "y")
      {
        correct = true;
        Console.WriteLine("HA HA HA HA.... I WIN AGAIN! It only took {0} amount of turns", turn);
      }
      else 
      {
        Console.WriteLine("ERROR, ERROR, Your input was not proccessed");
      }



    }
  }

}