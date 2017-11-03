using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Classes;

namespace MCGInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GameController gc = new GameController();
        public string name;
        public string classType;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PlayerNameBTN_Click(object sender, RoutedEventArgs e)
        {
            name = PlayerNameTB.Text;
            PlayerNameTB.Clear();
        }

        private void WarriorBTN_Click(object sender, RoutedEventArgs e)
        {
            classType = "Warrior";

            gc.ChooseClass(name, classType);
            PlayerNameTBlk.Text = gc.player.name;
            PlayerClassTBlk.Text = classType;
            PlayerHealthTBlk.Text = gc.player.currentHealthPoints.ToString();

            gc.InitiateGame();
            EnemyTypeTBlk.Text = gc.enemy.enemyType.ToString();
            EnemyHealthTBlk.Text = gc.enemy.currentHealthPoints.ToString();
        }

        private void MageBTN_Click(object sender, RoutedEventArgs e)
        {
            classType = "Mage";

            gc.ChooseClass(name, classType);
            PlayerNameTBlk.Text = gc.player.name;
            PlayerClassTBlk.Text = classType;
            PlayerHealthTBlk.Text = gc.player.currentHealthPoints.ToString();

            gc.InitiateGame();
            EnemyTypeTBlk.Text = gc.enemy.enemyType.ToString();
            EnemyHealthTBlk.Text = gc.enemy.currentHealthPoints.ToString();
        }

        private void ThiefBTN_Click(object sender, RoutedEventArgs e)
        {
            classType = "Thief";

            gc.ChooseClass(name, classType);
            PlayerNameTBlk.Text = gc.player.name;
            PlayerClassTBlk.Text = classType;
            PlayerHealthTBlk.Text = gc.player.currentHealthPoints.ToString();

            gc.InitiateGame();
            EnemyTypeTBlk.Text = gc.enemy.enemyType.ToString();
            EnemyHealthTBlk.Text = gc.enemy.currentHealthPoints.ToString();
        }

        private void NormalAttackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (gc.player.currentHealthPoints > 0 && gc.enemy.currentHealthPoints > 0)
            {
                int dmg = gc.player.GetNormalAttack();
                EnemyHealthTBlk.Text = gc.enemy.SendDamage(dmg).ToString();

                if (gc.player.currentHealthPoints > 0 && gc.enemy.currentHealthPoints > 0)
                {
                    int enemyDmg = gc.enemy.GetNormalAttack();
                    PlayerHealthTBlk.Text = gc.player.ReceiveDamage(enemyDmg).ToString();
                }
            } 
            if (gc.enemy.currentHealthPoints <= 0)
            {
                ResultTBlk.Text = "You Win";
            }
            else if (gc.player.currentHealthPoints <= 0)
            {
                ResultTBlk.Text = "You Lose";
            }
            else if (gc.player.currentHealthPoints <= 0 && gc.enemy.currentHealthPoints <= 0)
            {
                ResultTBlk.Text = "Draw";
            }
        }

        private void SpecialAttackBTN_Click(object sender, RoutedEventArgs e)
        {
            if (gc.player.currentHealthPoints > 0 && gc.enemy.currentHealthPoints > 0)
            {
                int dmg = gc.player.GetSpecialDamage(gc.player.baseDamage);

                if (dmg > 0)
                    EnemyHealthTBlk.Text = gc.enemy.SendDamage(dmg).ToString();
                else if (dmg < 0)
                    PlayerHealthTBlk.Text = gc.player.ReceiveDamage(10).ToString();

                if (gc.player.currentHealthPoints > 0 && gc.enemy.currentHealthPoints > 0)
                {
                    int enemyDmg = gc.enemy.GetNormalAttack();
                    PlayerHealthTBlk.Text = gc.player.ReceiveDamage(enemyDmg).ToString();
                }
            }
            if (gc.enemy.currentHealthPoints <= 0)
            {
                ResultTBlk.Text = "You Win";
            }
            else if (gc.player.currentHealthPoints <= 0)
            {
                ResultTBlk.Text = "You Lose";
            }
            else if (gc.player.currentHealthPoints <= 0 && gc.enemy.currentHealthPoints <= 0)
            {
                ResultTBlk.Text = "Draw";
            }
        }
    }
}
