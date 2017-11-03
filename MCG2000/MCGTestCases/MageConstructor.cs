using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class MageConstructor
    {
        [TestMethod]
        public void Mage()
        {
            //Arrange
            PlayerCharacter Newplayer = new Mage(10, 50, 50, "John", Fireball); //Incorrect Arrange

            //Assert
            Assert.AreEqual("John", Newplayer.name);
            Assert.AreEqual(new Fireball(), Newplayer.specialAttack); //Error asserting objects
        }
    }
}
