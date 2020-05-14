using System;

namespace ScrabbleCheck.Models
{
  public class Scrabble
  {
    public static string Input { get; set; }
    public static int Score { get; set; }

    public static void ScrabbleGame(string userInput)
    {
      Input = userInput.ToLower();
    }
    public static void CheckScore()
    {
      char[] inputArray = Input.ToCharArray();
      for (int i = 0; i < inputArray.Length; i++)
      {

        switch (inputArray[i])
        {
          case 'a':
          case 'e':
          case 'i':
          case 'o':
          case 'u':
          case 'r':
          case 's':
          case 't':
          case 'l':
          case 'n':
            Score += 1;
            break;
          case 'd':
          case 'g':
            Score += 2;
            break;
          case 'b':
          case 'c':
          case 'm':
          case 'p':
            Score += 3;
            break;
          case 'f':
          case 'h':
          case 'v':
          case 'w':
          case 'y':
            Score += 4;
            break;
          case 'k':
            Score += 5;
            break;
          case 'j':
          case 'x':
            Score += 8;
            break;
          case 'q':
          case 'z':
            Score += 10;
            break;
        }
      }
    }
  }
}