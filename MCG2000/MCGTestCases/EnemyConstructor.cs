using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class EnemyConstructor
    {
        [TestMethod]
        public void NonPlayerCharacter()
        {
            //Arrange
            NonPlayerCharacter NewEnemy = new NonPlayerCharacter(5, 30, 30, "Goblin"); //Incorrect Arrange

            //Assert
            Assert.AreEqual("Goblin", NewEnemy.enemyType);
        }
    }
}
