using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Rocks.Models;

namespace Rocks.Tests
{

  [TestClass]
  public class RockerTests
  {
    [TestMethod]
    public void Draw()
    {
      // Arrange
      Rocker newRock = new Rocker("rock", "rock");

      var output = "DRAW";

      // Act
      string result = newRock.CompareValue();

      // Assert
      Assert.AreEqual(result, output);
      //Assert.AreEqual(result, "DRAW"); this will return the same thing as above
    }

    [TestMethod]
    public void Player1Wins()
    {
      // Arrange
      Rocker newRock = new Rocker("paper", "rock");

      var output = "P1 Wins";

      // Act
      string result = newRock.CompareValue();

      // Assert
      Assert.AreEqual(result, output);
      //Assert.AreEqual(result, "DRAW"); this will return the same thing as above
    }
  }
}
