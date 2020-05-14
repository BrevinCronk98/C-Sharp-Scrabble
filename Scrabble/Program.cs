using System;
using System.Collections.Generic;
using ScrabbleCheck.Models;

namespace Program
{
  public class Game
  {
    public static void Main()
    {
      try
      {
        Scrabble game = new Scrabble();
        Console.WriteLine("Welcome to Scrabble Checker!\nPlease Input a Word:");
        Scrabble.ScrabbleGame(Console.ReadLine());
        Scrabble.CheckScore();
        Console.WriteLine("Your word, " + Scrabble.Input + ", will score " + Scrabble.Score + " points!");
      }
      catch (Exception ex)
      {

      }
    }
  }
}