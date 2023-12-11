namespace FinalProject
{
    partial class FishGameForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.toFishButton = new System.Windows.Forms.Button();
            this.shopButton = new System.Windows.Forms.Button();
            this.catchLabel = new System.Windows.Forms.Label();
            this.cashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(588, 388);
            this.exitButton.MaximumSize = new System.Drawing.Size(200, 50);
            this.exitButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 50);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // toFishButton
            // 
            this.toFishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toFishButton.Location = new System.Drawing.Point(12, 12);
            this.toFishButton.MaximumSize = new System.Drawing.Size(200, 100);
            this.toFishButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.toFishButton.Name = "toFishButton";
            this.toFishButton.Size = new System.Drawing.Size(200, 100);
            this.toFishButton.TabIndex = 1;
            this.toFishButton.Text = "To fish";
            this.toFishButton.UseVisualStyleBackColor = true;
            this.toFishButton.Click += new System.EventHandler(this.toFish_Click_1);
            // 
            // shopButton
            // 
            this.shopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shopButton.Location = new System.Drawing.Point(12, 388);
            this.shopButton.MaximumSize = new System.Drawing.Size(200, 50);
            this.shopButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(200, 50);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shop_Click);
            // 
            // catchLabel
            // 
            this.catchLabel.AutoSize = true;
            this.catchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.catchLabel.Location = new System.Drawing.Point(582, 22);
            this.catchLabel.MaximumSize = new System.Drawing.Size(200, 200);
            this.catchLabel.MinimumSize = new System.Drawing.Size(200, 200);
            this.catchLabel.Name = "catchLabel";
            this.catchLabel.Size = new System.Drawing.Size(200, 200);
            this.catchLabel.TabIndex = 3;
            this.catchLabel.Text = "Catch\r\nSalmon: 0\r\nTuna: 0\r\nTilapia: 0\r\nHerring: 0\r\nBass: 0";
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cashLabel.Location = new System.Drawing.Point(588, 231);
            this.cashLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.cashLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(200, 31);
            this.cashLabel.TabIndex = 4;
            this.cashLabel.Text = "Cash: 0$";
            // 
            // FishGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.catchLabel);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.toFishButton);
            this.Controls.Add(this.exitButton);
            this.Name = "FishGameForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FishGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button toFishButton;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.Label catchLabel;
        private System.Windows.Forms.Label cashLabel;
    }
}

