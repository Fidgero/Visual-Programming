using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace FinalProject
{

    public partial class FishGameForm : Form
    {

        Random rnd = new Random();
        int randomNumber;
        int randomForDoubleReward;

            // reward multipier for mk2 fishing rod
        int rewardMultiplier = 1;

            // guaranteed reward for mk3 fishing rod
        int guaranteedEvery4actionCount;
        Boolean guaranteedEvery4Action = false;

            // Chances
        int salmon = 5;             //5% chance
        int tuna = 15;              //10% chance
        int tilapia = 30;           //15% chance
        int herring = 60;           //30% chance
        int bass = 95;              //35% chance
        int chanceForDoubleReward;  //0% chance

            // Counting fishes
        public static int salmonCounting = 0;
        public static int tunaCounting = 0;
        public static int tilapiaCounting = 0;
        public static int herringCounting = 0;
        public static int bassCounting = 0;


        public FishGameForm()
        {
            InitializeComponent();
        }

        private void shop_Click(object sender, EventArgs e)
        {
            ShopForm shopForm = new ShopForm();
            this.Hide();
            shopForm.ShowDialog();
        }

        private void toFish_Click_1(object sender, EventArgs e)
        {
            randomNumber = rnd.Next(1, 101);
            randomForDoubleReward = rnd.Next(1, 101);

            if (guaranteedEvery4actionCount == 4)
            {
                rewardMultiplier += 1;
                guaranteedEvery4actionCount = 0;
            }

            if (randomForDoubleReward <= chanceForDoubleReward)
            {
                rewardMultiplier += 1;
            }

            if (randomNumber <= salmon)
            {
                salmonCounting += rewardMultiplier;
            }
            else if (randomNumber <= tuna)
            {
                tunaCounting += rewardMultiplier;
            }
            else if (randomNumber <= tilapia)
            {
                tilapiaCounting += rewardMultiplier;
            }
            else if (randomNumber <= herring)
            {
                herringCounting += rewardMultiplier;
            }
            else if (randomNumber <= bass)
            {
                bassCounting += rewardMultiplier;
            }
            else
            {
                if(rewardMultiplier > 1)
                {
                    MessageBox.Show("You get " + rewardMultiplier +" shoe.\nLook useless x" + rewardMultiplier);
                }
                else 
                {
                    MessageBox.Show("You get shoe.\nLook useless");
                }
            }
            rewardMultiplier = 1;

            if (guaranteedEvery4Action == true)
            {
                guaranteedEvery4actionCount++;
            }

            try 
            {
                catchLabel.Text = "Catch\n"
                    + "Salmon: " + salmonCounting + "\n"
                    + "Tuna: " + tunaCounting + "\n"
                    + "Tilapia: " + tilapiaCounting + "\n"
                    + "Herring: " + herringCounting + "\n"
                    + "Bass: " + bassCounting;

            } catch (Exception ex) { }

        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void FishGameForm_Load(object sender, EventArgs e)
        {
            cashLabel.Text = "Cash: " + SellShopForm.money + "$";

            if (BuyShopForm.mk3FishingRodExistence == true)
            {
                salmon = 10;        //10%
                tuna = 25;          //15%
                tilapia = 45;       //20%
                herring = 70;       //25%
                bass = 96;          //26%
            }
            else if (BuyShopForm.mk2FishingRodExistence == true)
            {
                salmon = 15;        //15%
                tuna = 30;          //15%
                tilapia = 50;       //20%
                herring = 70;       //20%
                bass = 97;          //27%
                chanceForDoubleReward = 10;
            }
            else if (BuyShopForm.mk1FishingRodExistence == true)
            {
                salmon = 20;        //20%
                tuna = 40;          //20%
                tilapia = 60;       //20%
                herring = 75;       //15%
                bass = 98;          //23%
                chanceForDoubleReward = 20;
                guaranteedEvery4Action = true;
            }
        }
    }
}
