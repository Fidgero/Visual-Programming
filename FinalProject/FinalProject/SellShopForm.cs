using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class SellShopForm : Form
    {

        public static int money;
        public SellShopForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
                // Return to ShopForm
            ShopForm shopForm = new ShopForm();
            this.Hide();
            shopForm.ShowDialog();
        }

            // Start this code when this form is loaded
        private void ShopForm_Load(object sender, EventArgs e)
        {
                // Set current cash value
            cashLabel.Text = "Cash: " + money + "$";

                // Set current catch value
            catchLabel2.Text = "Catch\n"
                    + "Salmon: " + FishGameForm.salmonCounting + "\n"
                    + "Tuna: " + FishGameForm.tunaCounting + "\n"
                    + "Tilapia: " + FishGameForm.tilapiaCounting + "\n"
                    + "Herring: " + FishGameForm.herringCounting + "\n"
                    + "Bass: " + FishGameForm.bassCounting;
        }

        private void sellAll_Click(object sender, EventArgs e)
        {

                // Math for sell
            money =
                  (FishGameForm.salmonCounting * 80)
                + (FishGameForm.tunaCounting * 40)
                + (FishGameForm.tilapiaCounting * 30)
                + (FishGameForm.herringCounting * 10)
                + (FishGameForm.bassCounting * 5);
            cashLabel.Text = "Cash: " + money + "$";

                // Set variables to 0
            FishGameForm.salmonCounting = 0;
            FishGameForm.tunaCounting = 0;
            FishGameForm.tilapiaCounting = 0;
            FishGameForm.herringCounting = 0;
            FishGameForm.bassCounting = 0;

                // Update information in form
            catchLabel2.Text = "Catch\n"
                    + "Salmon: " + FishGameForm.salmonCounting + "\n"
                    + "Tuna: " + FishGameForm.tunaCounting + "\n"
                    + "Tilapia: " + FishGameForm.tilapiaCounting + "\n"
                    + "Herring: " + FishGameForm.herringCounting + "\n"
                    + "Bass: " + FishGameForm.bassCounting;
        }
    }
}
