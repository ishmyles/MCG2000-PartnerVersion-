using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class WarriorConstructor
    {
        [TestMethod]
        public void Warrior()
        {
            //Arrange
            PlayerCharacter Newplayer = new Warrior(10, 50, 50, "Fred", Berserk); //Incorrect Arrange

            //Assert
            Assert.AreEqual("Fred", Newplayer.name);
            Assert.AreEqual(new Berserk(), Newplayer.specialAttack); //Error asserting objects
        }
    }
}
