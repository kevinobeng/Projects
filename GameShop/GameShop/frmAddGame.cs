using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameShop
{

    public partial class frmAddGame : Form
    {
        private Game game;
        private Shop shop;

        public frmAddGame(Game game, Shop shop)
        {
            this.game = game;
            this.shop = shop;
            InitializeComponent();
        }
        private void frmAddGame_Load(object sender, EventArgs e)
        {
            //give values to the dropdown
            comboBoxConsole.Items.Add("Xbox");
            comboBoxConsole.Items.Add("PS4");
            comboBoxConsole.Items.Add("PC");
            comboBoxConsole.Items.Add("Wii");

            //give values for conditon dropdown
            comboBoxCondition.Items.Add("Poor");
            comboBoxCondition.Items.Add("fair");
            comboBoxCondition.Items.Add("good");
            comboBoxCondition.Items.Add("mint");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            //validate will check details are correct and complete
            if (Validate())
            {
                Game.Condition condition = Game.Condition.poor;
                if (comboBoxCondition.SelectedIndex == 0)
                    condition = Game.Condition.fair;
                else if (comboBoxCondition.SelectedIndex == 1)
                    condition = Game.Condition.good;
                else if (comboBoxCondition.SelectedIndex == 2)
                    condition = Game.Condition.mint;
                if (comboBoxConsole.SelectedIndex == 0)
                {
                  game = new XboxGame(txtGameTitle.Text, txtGameDeveloper.Text, condition, decimal.Parse(txtCurrentValue.Text), dateTimePicker.MaxDate);
                }

                else if (comboBoxConsole.SelectedIndex == 1)
                {
                  game = new PSGame(txtGameTitle.Text, txtGameDeveloper.Text, condition, decimal.Parse(txtCurrentValue.Text), dateTimePicker.MaxDate);
                }

                else if (comboBoxConsole.SelectedIndex == 2)
                {
                    game = new PCGame(txtGameTitle.Text, txtGameDeveloper.Text, condition, decimal.Parse(txtCurrentValue.Text), dateTimePicker.MaxDate);
                }

                else if (comboBoxConsole.SelectedIndex == 3)
                {
                    game = new NintendoWiiGame(txtGameTitle.Text, txtGameDeveloper.Text, condition, decimal.Parse(txtCurrentValue.Text), dateTimePicker.MaxDate);
                }
                shop.AddGame(game);
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxConsole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
