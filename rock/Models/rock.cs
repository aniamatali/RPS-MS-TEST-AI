using System.Collections.Generic;

namespace Rocks.Models
{
  public class Rocker
  {
    private string _inputOne;
    private string _inputTwo;

    public Rocker(string inputOne, string inputTwo)
    {
      _inputOne = inputOne;
      _inputTwo = inputTwo;
    }


    public string GetInputOne()
    {
      return _inputOne;
    }

    public string GetInputTwo()
    {
      return _inputTwo;
    }

    public string CompareValue()
    {
      if ((_inputOne == "rock" && _inputTwo == "scissors") ||
          (_inputOne == "scissors" && _inputTwo == "paper") ||
          (_inputOne == "paper" && _inputTwo == "rock"))
      {
        return "P1 Wins";
      }
      else if ((_inputTwo == "rock" && _inputOne == "scissors") ||
               (_inputTwo == "scissors" && _inputOne == "paper") ||
               (_inputTwo == "paper" && _inputOne == "rock"))
      {
        
        return "P2 Wins";
      }
      else
      {
        return "DRAW";
      }
    }
  }
}
