using System;

class HigherLower {
  public static void Main () 
  {
    Console.WriteLine("Greetings Human. Would you like to play game?");
    Console.WriteLine("Press 'C' and I'll guess your number. Press 'H' and you can guess my number.");
    Console.Write("What will you choose? : ");
    string answer = Console.ReadLine().ToLower();
    Choose(answer);

    Console.WriteLine("...");
    Console.WriteLine("Had enough? Play Again?");
    Console.WriteLine("Press 'C' and I'll guess your number. Press 'H' and you can guess my number.");
    Console.Write("What will you choose? : ");
    answer = Console.ReadLine().ToLower();
    Choose(answer);

  }

  static void Choose(string answer)
  {
    if(answer == "c"){
      ComputerGuess();

    }
    else if (answer == "h")
    {
      HumanGuess();
    }
    else
    {
      GoodBye();
    }
  }

  static void GoodBye()
  {
    Console.WriteLine("Bye Human friend!");
  }

  static int GetAnswer()
  {
    string inputAnswer = Console.ReadLine();
    int answer;
    bool success = int.TryParse(inputAnswer, out answer);
    if(success)
    {
      return answer;
    }
    else 
    {
      return -1;
    }
  }

  static void HumanGuess()
  {
    var rand = new Random();
    int number = rand.Next(1, 101);
  
    Console.WriteLine("Human! I just guessed a number between 1 and 100!");
    Console.WriteLine("Can you guess it in 7 tries?");


    for (int i = 0; i < 8; i++)
    {
      Console.Write("Make your guess : ");
      int answer = GetAnswer();
      //Check guess is good
      if(answer == -1)
      {
        Console.WriteLine("You did not enter a number");
      }

      //Deal with guess
      if(answer == number)
      {
        //WIN
        Console.WriteLine("You did it. Very Nice Human!");
        Console.WriteLine("You got it in #{0} turns.", i);
        break;
      }
      else if (i >= 7)
      {
        //LOSE
        Console.WriteLine("HA HA HA... You failed!");
        Console.WriteLine("");
        break;
      }
      else if (answer > number)
      {
        Console.WriteLine("Turn #{0}", i);
        Console.WriteLine("LOWER!");
      }
      else if (answer < number)
      {
        Console.WriteLine("Turn #{0}", i);
        Console.WriteLine("HIGHER!");
      }
      else
      {
        //SOME KIND OF ERROR
        Console.WriteLine("Turn #{0}", i);
        Console.WriteLine("ERROR! Can not compute.");

      }
        
    }
    

  }

  static void ComputerGuess () 
  {

    bool correct = false;
    int high = 100;
    int low = 1;
    int turn = 0;

    Console.WriteLine ("Pick a number between 1-100.");
    Console.WriteLine ("See if you can pick a number that will take ME more than 7 tries.");
    Console.Write ("Are you ready? Press 'Y' to start : ");
    string start = Console.ReadLine ().ToLower();

    if (start == "y") 
    {  
      while (!correct) 
      {
        int guess = (high + low) / 2;
        turn ++;

        Console.WriteLine ("Is your number {0}?", guess);
        Console.WriteLine ("Enter 'Y' for yes. | Enter 'H' for higher | Enter 'L' for lower");
        string guessInput = Console.ReadLine().ToLower();

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
          Console.WriteLine("HA HA HA HA.... I WIN AGAIN! It only took {0} tries", turn);
        }
        else 
        {
          Console.WriteLine("ERROR, ERROR, Your input was not proccessed");
        }
      } 
    }
    else 
    {
      GoodBye();
    }
  }

}