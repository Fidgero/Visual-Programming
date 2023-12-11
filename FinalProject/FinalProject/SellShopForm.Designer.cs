namespace FinalProject
{
    partial class SellShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.catchLabel2 = new System.Windows.Forms.Label();
            this.sellAllИButton = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.Location = new System.Drawing.Point(588, 388);
            this.backButton.MaximumSize = new System.Drawing.Size(200, 50);
            this.backButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 50);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.back_Click);
            // 
            // catchLabel2
            // 
            this.catchLabel2.AutoSize = true;
            this.catchLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catchLabel2.Location = new System.Drawing.Point(12, 9);
            this.catchLabel2.MinimumSize = new System.Drawing.Size(200, 200);
            this.catchLabel2.Name = "catchLabel2";
            this.catchLabel2.Size = new System.Drawing.Size(200, 200);
            this.catchLabel2.TabIndex = 1;
            this.catchLabel2.Text = "Catch\r\nSalmon: 0\r\nTuna: 0\r\nTilapia: 0\r\nHerring: 0\r\nBass: 0\r\n";
            // 
            // sellAllИButton
            // 
            this.sellAllИButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sellAllИButton.Location = new System.Drawing.Point(15, 338);
            this.sellAllИButton.MaximumSize = new System.Drawing.Size(200, 100);
            this.sellAllИButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.sellAllИButton.Name = "sellAllИButton";
            this.sellAllИButton.Size = new System.Drawing.Size(200, 100);
            this.sellAllИButton.TabIndex = 2;
            this.sellAllИButton.Text = "Sell all";
            this.sellAllИButton.UseVisualStyleBackColor = true;
            this.sellAllИButton.Click += new System.EventHandler(this.sellAll_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(218, 9);
            this.price.MinimumSize = new System.Drawing.Size(200, 200);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(200, 200);
            this.price.TabIndex = 3;
            this.price.Text = "Price 1pc.\r\n80$\r\n40$\r\n30$\r\n10$\r\n5$";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cashLabel.Location = new System.Drawing.Point(12, 245);
            this.cashLabel.MaximumSize = new System.Drawing.Size(160, 0);
            this.cashLabel.MinimumSize = new System.Drawing.Size(160, 0);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(160, 31);
            this.cashLabel.TabIndex = 4;
            this.cashLabel.Text = "Cash: 0$";
            // 
            // SellShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.price);
            this.Controls.Add(this.sellAllИButton);
            this.Controls.Add(this.catchLabel2);
            this.Controls.Add(this.backButton);
            this.Name = "SellShopForm";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label catchLabel2;
        private System.Windows.Forms.Button sellAllИButton;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label cashLabel;
    }
}