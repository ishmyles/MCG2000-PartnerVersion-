using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class PlayerReceiveDamage
    {
        [TestMethod]
        public void LosePlayerHealth()
        {
            //Arrange 
            PlayerCharacter Newplayer = new Mage(10, 50, 50, "John", Fireball); //Incorrect Arrange

            //Act
            Newplayer.ReceiveDamage(5);

            //Assert
            Assert.AreEqual(Newplayer.currentHealthPoints, 45);
        }
    }
}
