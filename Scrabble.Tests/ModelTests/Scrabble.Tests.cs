using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleCheck.Models;

namespace ScrabbleCheck.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void Constructor_CreatesWord_Word()
    {
      Scrabble newScrabble = new Scrabble();
      Scrabble.ScrabbleGame("Word");
      Assert.AreEqual("word", Scrabble.Input);
    }
    [TestMethod]
    public void ScoreCheck_WillOutPutCorrectScoreForWordInput_Score()
    {
      Scrabble newScrabble = new Scrabble();
      Scrabble.ScrabbleGame("Word");
      Scrabble.CheckScore();
      Assert.AreEqual(8, Scrabble.Score);
    }
  }
}