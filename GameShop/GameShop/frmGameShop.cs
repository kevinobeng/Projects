using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Windows.Forms;
using GameShop;
using System.IO;
using System.Diagnostics;


namespace GameShop
{
    public partial class frmGameShop : Form
    {
        // a Shop contains the list of games and a current index
        Shop shop;
        public frmGameShop()
        {
            InitializeComponent();
        }

        private void frmGameShop_Load(object sender, EventArgs e)
        {
            shop = new Shop();
            // xbox games are added here:
            XboxGame xboxGame = new XboxGame("NBA 2K19", "Visual Concept", Game.Condition.fair, 22.99m, new DateTime(2018, 9, 11));
            XboxGame xboxGame1 = new XboxGame("FIFA 19", "EA Sport", Game.Condition.mint, 40.00m, new DateTime(2018, 9, 28));
            XboxGame xboxGame2 = new XboxGame("Assassins Creed Odyssey", "Ubisoft Quebec", Game.Condition.good, 47.99m, new DateTime(2018, 10, 5));
            XboxGame xboxGame3 = new XboxGame("WWE 2K19", "Visual", Game.Condition.poor, 24.99m, new DateTime(2018, 10, 9));
            XboxGame xboxGame4 = new XboxGame("Hitman 2", "IO Interactive", Game.Condition.fair, 34.99m, new DateTime(2018, 11, 13));
            XboxGame xboxGame5 = new XboxGame("Call of Duty: Black Ops 4", "Treyarch", Game.Condition.good, 32.99m, new DateTime(2018, 10, 12));

            //PS Games are added here:
            PSGame psGame = new PSGame("Grand Theft Auto V", "Rockstar North", Game.Condition.good, 20.00m, new DateTime(2013, 9, 17));
            PSGame psGame1 = new PSGame("Mortal Kombat X", "NetherRealm Studios", Game.Condition.mint, 15.00m, new DateTime(2015, 4, 14));
            PSGame psGame2 = new PSGame("Marvel's Spider-Man", "Insomniac Games", Game.Condition.good, 49.00m, new DateTime(2018, 9, 7));
            PSGame psGame3 = new PSGame("God of War", "SIE Santa Monic Studio", Game.Condition.poor, 44.99m, new DateTime(2018, 4, 20));
            PSGame psGame4 = new PSGame("Just Cause 4", "Avalanche Studios", Game.Condition.mint, 49.00m, new DateTime(2018, 12, 4));
            PSGame psGame5 = new PSGame("Battlefield V", "EA DICE", Game.Condition.fair, 39.00m, new DateTime(2018, 11, 20));
            PSGame psGame6 = new PSGame("Assassin's Creed Orgins", "Ubisoft Montreal", Game.Condition.fair, 25.99m, new DateTime(2017, 10, 27));
            PSGame psGame7 = new PSGame("assassin's creed revelations", "Ubisort Montreal", Game.Condition.fair, 5.99m, new DateTime(2011, 11, 15));
            
            //PC GAMES ARE ADDED HERE:
            PCGame pcGame = new PCGame("Grand Theft Auto V", "Rockstar North", Game.Condition.good, 20.00m, new DateTime(2013, 9, 17));
            PCGame pcGame1 = new PCGame("Minecraft", "Mojang", Game.Condition.poor, 21.00m, new DateTime(2011, 11, 18));
            PCGame pcGame2 = new PCGame("Five Nights at Freddy's", "Scott Cawthon", Game.Condition.mint, 11.00m, new DateTime(2014, 8, 8));

            //Nintendo Wii Games are added here
            NintendoWiiGame wiiGame = new NintendoWiiGame("Mario Kart", "Nintendo EAD", Game.Condition.good, 23.00m, new DateTime(2017, 8, 28));


            //Games added to the system are here

            //Xbox games list
            shop.AddGame(xboxGame);
            shop.AddGame(xboxGame1);
            shop.AddGame(xboxGame2);
            shop.AddGame(xboxGame3);
            shop.AddGame(xboxGame4);
            shop.AddGame(xboxGame5);

            //ps games list
            shop.AddGame(psGame);
            shop.AddGame(psGame1);
            shop.AddGame(psGame2);
            shop.AddGame(psGame3);
            shop.AddGame(psGame4);
            shop.AddGame(psGame5);
            shop.AddGame(psGame6);
            shop.AddGame(psGame7);

            //pc games list
            shop.AddGame(pcGame);
            shop.AddGame(pcGame1);
            shop.AddGame(pcGame2);

            //wii games list
            shop.AddGame(wiiGame);

            DisplayGame();
        }
        private void DisplayGame()
        {
            lblCurrentGame.Text = string.Format("Viewing {0} of {1}", shop.GameCurrentlyDisplayed + 1,
                shop.NumberOfGames);
            txtGame.Text = shop.DescribeCurrentGame();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            shop.StepToPreviousGame();
            DisplayGame();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            shop.StepToNextGame();
            DisplayGame();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //remove the using the remove game at method from shop
            shop.RemoveGameAt(shop.GameCurrentlyDisplayed);
            //display the updated on the form
            DisplayGame();
        }


         
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            Game AddGame = null;
            frmAddGame NewGame = new frmAddGame(AddGame, shop);

            if ((NewGame.ShowDialog()) == System.Windows.Forms.DialogResult.OK)
            {
                shop.GameCurrentlyDisplayed = shop.NumberOfGames;
                DisplayGame();
            }
        }
        private void lblSearchforGame_Click(object sender, EventArgs e)
        {

        }

        private void btnFindGame_Click(object sender, EventArgs e)
        {
            // to find the game searched for
            bool found = false;
            string searchForGame = txtSearchForGame.Text;
            string result;

            //for loop is placed here 
            for(int i = 0; i < shop.NumberOfGames; i++)
            {
                //if statement placed here
                if(shop.GamesForSale[i].GameTitle == searchForGame)
                {
                    found = true;
                    result = searchForGame;
                    if (found == true)
                    {
                        shop.GameCurrentlyDisplayed = i;
                    }
                }
            }
            DisplayGame();
        }

        private void txtGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}