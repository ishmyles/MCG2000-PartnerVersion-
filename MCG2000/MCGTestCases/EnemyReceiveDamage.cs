using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class EnemyReceiveDamage
    {
        [TestMethod]
        public void LoseNPCHealth()
        {
            //Arrange 
            NonPlayerCharacter NewEnemy = new NonPlayerCharacter(5, 30, 30, "Goblin"); //Incorrect Arrange

            //Act
            NewEnemy.SendDamage(5);

            //Assert
            Assert.AreEqual(NewEnemy.currentHealthPoints, 15); //Correct result = 25
        }
    }
}
