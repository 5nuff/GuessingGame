using System;

namespace GuessingGame
{
  class Program
  {
    static void Main(string[] args)
    {
      var count = 0;
      var min = 0;
      var max = 100;
      var guess = 50;
      var guessing = true;
      string input;

      Console.WriteLine("Think of a number between 1 and 100, type 'ready' when ready");
      input = Console.ReadLine();
      if (input == "ready")
      {
        while (guessing == true)
        {
          Console.WriteLine($"Is it {guess}?");
          input = Console.ReadLine();
          count++;
          if (input == "no")
          {
            Console.WriteLine("Higher or lower?");
            input = Console.ReadLine();
            if (input == "higher")
            {
              min = guess;
              guess = (min + max) / 2;
            }
            else if (input == "lower")
            {
              max = guess;
              guess = (min + max) / 2;
            }
          }
          else if (input == "yes")
          {
            guessing = false;
          }
        }
        Console.WriteLine($"Your number is {guess}! Guessed in {count} tries!");
      }
    }
  }
}