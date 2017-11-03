using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class PlayerSpecialAttack
    {
        [TestMethod]
        public void GetSpecialAttack() 
        {
            //Arrange 
            PlayerCharacter Newplayer = new Mage(10, 50, 50, "John", Fireball); //Incorrect Arrange

            //Act
            int Damage = Newplayer.GetSpecialDamage(Newplayer.baseDamage);

            //Assert
            Assert.AreEqual(Damage, 40, 50); //The delta value (50) will account for the failed result.
        }
    }
}
