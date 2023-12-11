namespace FinalProject
{
    partial class BuyShopForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyShopForm));
            this.itemDescriptionLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // itemDescriptionLabel
            // 
            this.itemDescriptionLabel.AutoSize = true;
            this.itemDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.itemDescriptionLabel.Location = new System.Drawing.Point(12, 9);
            this.itemDescriptionLabel.MinimumSize = new System.Drawing.Size(300, 425);
            this.itemDescriptionLabel.Name = "itemDescriptionLabel";
            this.itemDescriptionLabel.Size = new System.Drawing.Size(411, 425);
            this.itemDescriptionLabel.TabIndex = 0;
            this.itemDescriptionLabel.Text = resources.GetString("itemDescriptionLabel.Text");
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.backButton.Location = new System.Drawing.Point(588, 388);
            this.backButton.MinimumSize = new System.Drawing.Size(200, 50);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 50);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.buyButton.Location = new System.Drawing.Point(588, 282);
            this.buyButton.MinimumSize = new System.Drawing.Size(200, 100);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(200, 100);
            this.buyButton.TabIndex = 2;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "mk1",
            "mk2",
            "mk3"});
            this.checkedListBox1.Location = new System.Drawing.Point(588, 182);
            this.checkedListBox1.MinimumSize = new System.Drawing.Size(200, 100);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(200, 94);
            this.checkedListBox1.TabIndex = 3;
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cashLabel.Location = new System.Drawing.Point(588, 148);
            this.cashLabel.MaximumSize = new System.Drawing.Size(200, 50);
            this.cashLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(200, 31);
            this.cashLabel.TabIndex = 4;
            this.cashLabel.Text = "Cash: 0$";
            // 
            // BuyShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashLabel);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.itemDescriptionLabel);
            this.Name = "BuyShopForm";
            this.Text = "BuyShopForm";
            this.Load += new System.EventHandler(this.BuyShopForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label itemDescriptionLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label cashLabel;
    }
}