using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class BuyShopForm : Form
    {

        private Dictionary<string, int> itemPrices = new Dictionary<string, int>();
        public static Boolean mk1FishingRodExistence = false;
        public static Boolean mk2FishingRodExistence = false;
        public static Boolean mk3FishingRodExistence = false;

        public BuyShopForm()
        {
            InitializeComponent();
            itemPrices.Add("mk1", 100);
            itemPrices.Add("mk2", 200);
            itemPrices.Add("mk3", 400);
        }

        private void BuyShopForm_Load(object sender, EventArgs e)
        {
            // Set current cash value
            cashLabel.Text = "Cash: " + SellShopForm.money + "$";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ShopForm shopForm = new ShopForm();
            this.Hide();
            shopForm.ShowDialog();
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                string selectedItem = checkedListBox1.Items[e.Index].ToString();
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                string selectedItem = checkedListBox1.SelectedItem.ToString();
                int selectedItemCost = itemPrices[selectedItem];

                if (SellShopForm.money >= selectedItemCost)
                {
                    
                    if (selectedItem == "mk1" && mk1FishingRodExistence == false)
                    {
                        SellShopForm.money -= selectedItemCost;
                        mk1FishingRodExistence = true;
                        MessageBox.Show("Thank you, now you have " + selectedItem + " fishing rod");
                    } 
                    else if (selectedItem == "mk2" && mk2FishingRodExistence == false)
                    {
                        SellShopForm.money -= selectedItemCost;
                        mk2FishingRodExistence = true;
                        MessageBox.Show("Thank you, now you have " + selectedItem + " fishing rod");
                    } 
                    else if (selectedItem == "mk3" && mk3FishingRodExistence == false)
                    {
                        SellShopForm.money -= selectedItemCost;
                        mk3FishingRodExistence = true;
                        MessageBox.Show("Thank you, now you have " + selectedItem + " fishing rod");
                    }
                    else
                    {
                        if (mk1FishingRodExistence == true && selectedItem == "mk1"
                        || mk2FishingRodExistence == true && selectedItem == "mk2"
                        || mk3FishingRodExistence == true && selectedItem == "mk3")
                        {
                            MessageBox.Show("Allready in use");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Not enough cash");
                }
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
