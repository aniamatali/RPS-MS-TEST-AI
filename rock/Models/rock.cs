using System.Collections.Generic;
using System;
using System.Threading;

namespace Rocks.Models
{
  public class Rocker
  {
    private string _inputOne;
    private string _inputTwo;
    private string _random;
    static Random rand;


    public Rocker(string inputOne)
    {
      _inputOne = inputOne;
      rand = new Random();
      int randomNumber = rand.Next(1,3);
      if(randomNumber == 1)
      {
        _random = "rock";
      }
      else if(randomNumber == 2)
      {
        _random = "scissors";
      }
      else if(randomNumber == 3)
      {
        _random = "paper";
      }
    }


    public string GetInputOne()
    {
      return _inputOne;
    }

    public string GetInputTwo()
    {
      return _inputTwo;
    }

    public string GetRandom()
    {
      return _random;
    }

    public string CompareValue()
    {
      if ((_inputOne == "rock" && _random == "scissors") ||
          (_inputOne == "scissors" && _random == "paper") ||
          (_inputOne == "paper" && _random == "rock"))
      {
        return "P1 Wins";
      }
      else if ((_random == "rock" && _inputOne == "scissors") ||
               (_random == "scissors" && _inputOne == "paper") ||
               (_random == "paper" && _inputOne == "rock"))
      {

        return "Computer Wins";
      }
      else
      {
        return "DRAW";
      }
    }
  }
}
