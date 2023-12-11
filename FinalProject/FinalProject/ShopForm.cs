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
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
                // Return to FishGameForm
            FishGameForm fishGameForm = new FishGameForm();
            this.Hide();
            fishGameForm.ShowDialog();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            BuyShopForm buyShopForm = new BuyShopForm();
            this.Hide();
            buyShopForm.ShowDialog();
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            SellShopForm shopForm = new SellShopForm();
            this.Hide();
            shopForm.ShowDialog();
        }
    }
}
