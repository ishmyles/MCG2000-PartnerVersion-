using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class GameController
    {
        public NonPlayerCharacter enemy;
        public PlayerCharacter player;

        public void ChooseClass(string pName, string pClass)
        {
            if (pClass == "Mage")
                player = new Mage(10, 50, pName);
            else if (pClass == "Thief")
                player = new Thief(10, 50, pName);
            else if (pClass == "Warrior")
                player = new Warrior(10, 50, pName);
        }

        public void InitiateGame()
        {
            Random rand = new Random();

            int num = rand.Next(1, 6);

            if (num == 1)
                enemy = new NonPlayerCharacter(5, 30, "Goblin");
            else if (num == 2)
                enemy = new NonPlayerCharacter(15, 60, "Orc");
            else if (num == 3)
                enemy = new NonPlayerCharacter(5, 90, "Golem");
            else if (num == 4)
                enemy = new NonPlayerCharacter(16, 80, "Wraith");
            else if (num == 5)
                enemy = new NonPlayerCharacter(20, 120, "Dragon");
        }
    }

    public class Character
    {
        public int baseDamage;
        public int currentHealthPoints;
        public int maxHealthPoints;

        public Character(int pBaseDamage, int healthPoints)
        {
            baseDamage = pBaseDamage;
            currentHealthPoints = healthPoints;
            maxHealthPoints = healthPoints;
        }

        public int GetNormalAttack()
        {
            int dmg = baseDamage;
            return dmg;
        }
    }

    public class PlayerCharacter : Character
    {
        public string name;
        public NormalAttack normalAttack;
        public SpecialAttack specialAttack;

        public PlayerCharacter(int baseDamage, int healthPoints, string pName)
            : base(baseDamage, healthPoints)
        {
            name = pName;
        }

        public int GetSpecialDamage(int baseDmg)
        {
            int dmg = specialAttack.ReturnAttack(baseDmg);
            return dmg;
        }

        public int ReceiveDamage(int dmg)
        {
            currentHealthPoints -= dmg;
            return currentHealthPoints;
        }
    }

    public class NonPlayerCharacter : Character
    {
        public string enemyType;
        public NormalAttack attack;

        public NonPlayerCharacter(int baseDamage, int healthPoints, string pEnemyType)
            : base(baseDamage, healthPoints)
        {
            enemyType = pEnemyType;
            attack = new NormalAttack();
        }

        public int SendDamage(int dmg)
        {
            currentHealthPoints -= dmg;
            return currentHealthPoints;
        }
    }

    public class Mage : PlayerCharacter
    {
        public Mage(int baseDamage, int healthPoints, string pName)
            : base(baseDamage, healthPoints, pName)
        {
            normalAttack = new NormalAttack();
            specialAttack = new Fireball();
        }
    }

    public class Thief : PlayerCharacter
    {
        public Thief(int baseDamage, int healthPoints, string pName)
            : base(baseDamage, healthPoints, pName)
        {
            normalAttack = new NormalAttack();
            specialAttack = new Backstab();
        }
    }

    public class Warrior : PlayerCharacter
    {
        public Warrior(int baseDamage, int healthPoints, string pName)
            : base(baseDamage, healthPoints, pName)
        {
            normalAttack = new NormalAttack();
            specialAttack = new Berserk();
        }
    }

    public class Attack
    {
    }

    public class NormalAttack : Attack
    {
    }

    public class SpecialAttack : Attack
    {
        public virtual int ReturnAttack(int baseDam)

        {
            throw new NotImplementedException();
        }
    }

    public class Fireball : SpecialAttack
    {
        public override int ReturnAttack(int baseDam)
        {
            Random rand = new Random();
            int num = rand.Next(1, 4);

            if (num == 2)
                return 40;
            else if (num == 3)
                return 40;
            else
                return -10;
        }
    }

    public class Backstab : SpecialAttack
    {
        public override int ReturnAttack(int baseDam)
        {
            Random rand = new Random();
            int num = rand.Next(1, 3);

            if (num == 2)
                return 20;
            else
                return 5;
        }
    }

    public class Berserk : SpecialAttack
    {
        public override int ReturnAttack(int baseDam)
        {
            Random rand = new Random();
            int num = rand.Next(1, 3);

            if (num == 2)
                return 30;
            else
                return 0;
        }
    }
}
