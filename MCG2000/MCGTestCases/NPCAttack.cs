using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace MCGTestCases
{
    [TestClass]
    public class NPCAttack
    {
        [TestMethod]
        public void GetNPCAttack()
        {
            //Arrange 
            NonPlayerCharacter NewEnemy = new NonPlayerCharacter(5, 30, 30, "Goblin"); //Incorrect Arrange

            //Act
            int Damage = NewEnemy.GetNormalAttack();

            //Assert
            Assert.AreEqual(Damage, 10);
        }
    }
}
