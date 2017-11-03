using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class ThiefConstructor
    {
        [TestMethod]
        public void Thief()
        {
            //Arrange
            PlayerCharacter Newplayer = new Thief(10, 50, 50, "Samantha", Backstab); //Incorrect Arrange

            //Assert
            Assert.AreEqual("Samantha", Newplayer.name);
            Assert.AreEqual(new Backstab(), Newplayer.specialAttack); //Error asserting objects
        }
    }
}
