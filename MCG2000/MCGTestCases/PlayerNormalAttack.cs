using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class PlayerNormalAttack
    {
        [TestMethod]
        public void GetNormalAttack()
        {
            //Arrange 
            PlayerCharacter Newplayer = new Mage(10, 50, 50, "John", Fireball); //Incorrect Arrange

            //Act
            int Damage = Newplayer.GetNormalAttack();

            //Assert
            Assert.AreEqual(Damage, 10); 
        }
    }
}
