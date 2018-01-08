namespace ConsignmentShop
{
    partial class ConsignmentShop
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
            this.headerText = new System.Windows.Forms.Label();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsListBoxLabel = new System.Windows.Forms.Label();
            this.addToCard = new System.Windows.Forms.Button();
            this.shoppingListBoxLabel = new System.Windows.Forms.Label();
            this.shoppingListBox = new System.Windows.Forms.ListBox();
            this.purchaseButton = new System.Windows.Forms.Button();
            this.shoppingListLabel = new System.Windows.Forms.Label();
            this.vendorListBoxLabel = new System.Windows.Forms.Label();
            this.vendorsListBox = new System.Windows.Forms.ListBox();
            this.storeProfitLabel = new System.Windows.Forms.Label();
            this.storeProfitValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerText
            // 
            this.headerText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headerText.AutoSize = true;
            this.headerText.Font = new System.Drawing.Font("Maiandra GD", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerText.ForeColor = System.Drawing.Color.Bisque;
            this.headerText.Location = new System.Drawing.Point(121, 0);
            this.headerText.Name = "headerText";
            this.headerText.Size = new System.Drawing.Size(537, 72);
            this.headerText.TabIndex = 0;
            this.headerText.Text = "Consignment Shop";
            this.headerText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // itemsListBox
            // 
            this.itemsListBox.BackColor = System.Drawing.Color.Bisque;
            this.itemsListBox.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBox.ForeColor = System.Drawing.Color.LightCoral;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 18;
            this.itemsListBox.Location = new System.Drawing.Point(17, 129);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(289, 202);
            this.itemsListBox.TabIndex = 1;
            // 
            // itemsListBoxLabel
            // 
            this.itemsListBoxLabel.AutoSize = true;
            this.itemsListBoxLabel.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBoxLabel.ForeColor = System.Drawing.Color.Bisque;
            this.itemsListBoxLabel.Location = new System.Drawing.Point(94, 97);
            this.itemsListBoxLabel.Name = "itemsListBoxLabel";
            this.itemsListBoxLabel.Size = new System.Drawing.Size(139, 29);
            this.itemsListBoxLabel.TabIndex = 2;
            this.itemsListBoxLabel.Text = "Store Items";
            // 
            // addToCard
            // 
            this.addToCard.BackColor = System.Drawing.Color.Bisque;
            this.addToCard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToCard.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToCard.ForeColor = System.Drawing.Color.LightCoral;
            this.addToCard.Location = new System.Drawing.Point(330, 205);
            this.addToCard.Name = "addToCard";
            this.addToCard.Size = new System.Drawing.Size(126, 49);
            this.addToCard.TabIndex = 3;
            this.addToCard.Text = "Add To Card >";
            this.addToCard.UseVisualStyleBackColor = false;
            this.addToCard.Click += new System.EventHandler(this.addToCard_Click);
            // 
            // shoppingListBoxLabel
            // 
            this.shoppingListBoxLabel.Location = new System.Drawing.Point(0, 0);
            this.shoppingListBoxLabel.Name = "shoppingListBoxLabel";
            this.shoppingListBoxLabel.Size = new System.Drawing.Size(100, 23);
            this.shoppingListBoxLabel.TabIndex = 7;
            // 
            // shoppingListBox
            // 
            this.shoppingListBox.BackColor = System.Drawing.Color.Bisque;
            this.shoppingListBox.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListBox.ForeColor = System.Drawing.Color.LightCoral;
            this.shoppingListBox.FormattingEnabled = true;
            this.shoppingListBox.ItemHeight = 18;
            this.shoppingListBox.Location = new System.Drawing.Point(484, 129);
            this.shoppingListBox.Name = "shoppingListBox";
            this.shoppingListBox.Size = new System.Drawing.Size(289, 202);
            this.shoppingListBox.TabIndex = 4;
            // 
            // purchaseButton
            // 
            this.purchaseButton.BackColor = System.Drawing.Color.Bisque;
            this.purchaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.purchaseButton.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseButton.ForeColor = System.Drawing.Color.LightCoral;
            this.purchaseButton.Location = new System.Drawing.Point(680, 337);
            this.purchaseButton.Name = "purchaseButton";
            this.purchaseButton.Size = new System.Drawing.Size(90, 40);
            this.purchaseButton.TabIndex = 6;
            this.purchaseButton.Text = "Purchase";
            this.purchaseButton.UseVisualStyleBackColor = false;
            this.purchaseButton.Click += new System.EventHandler(this.purchaseButton_Click);
            // 
            // shoppingListLabel
            // 
            this.shoppingListLabel.AutoSize = true;
            this.shoppingListLabel.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoppingListLabel.ForeColor = System.Drawing.Color.Bisque;
            this.shoppingListLabel.Location = new System.Drawing.Point(540, 97);
            this.shoppingListLabel.Name = "shoppingListLabel";
            this.shoppingListLabel.Size = new System.Drawing.Size(174, 29);
            this.shoppingListLabel.TabIndex = 8;
            this.shoppingListLabel.Text = "Shopping Cart";
            // 
            // vendorListBoxLabel
            // 
            this.vendorListBoxLabel.AutoSize = true;
            this.vendorListBoxLabel.Font = new System.Drawing.Font("Maiandra GD", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorListBoxLabel.ForeColor = System.Drawing.Color.Bisque;
            this.vendorListBoxLabel.Location = new System.Drawing.Point(94, 382);
            this.vendorListBoxLabel.Name = "vendorListBoxLabel";
            this.vendorListBoxLabel.Size = new System.Drawing.Size(106, 29);
            this.vendorListBoxLabel.TabIndex = 10;
            this.vendorListBoxLabel.Text = "Vendors";
            // 
            // vendorsListBox
            // 
            this.vendorsListBox.BackColor = System.Drawing.Color.Bisque;
            this.vendorsListBox.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorsListBox.ForeColor = System.Drawing.Color.LightCoral;
            this.vendorsListBox.FormattingEnabled = true;
            this.vendorsListBox.ItemHeight = 18;
            this.vendorsListBox.Location = new System.Drawing.Point(12, 414);
            this.vendorsListBox.Name = "vendorsListBox";
            this.vendorsListBox.Size = new System.Drawing.Size(289, 202);
            this.vendorsListBox.TabIndex = 9;
            // 
            // storeProfitLabel
            // 
            this.storeProfitLabel.AutoSize = true;
            this.storeProfitLabel.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitLabel.ForeColor = System.Drawing.Color.Bisque;
            this.storeProfitLabel.Location = new System.Drawing.Point(491, 535);
            this.storeProfitLabel.Name = "storeProfitLabel";
            this.storeProfitLabel.Size = new System.Drawing.Size(223, 45);
            this.storeProfitLabel.TabIndex = 11;
            this.storeProfitLabel.Text = "Store Profit:";
            // 
            // storeProfitValue
            // 
            this.storeProfitValue.AutoSize = true;
            this.storeProfitValue.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeProfitValue.ForeColor = System.Drawing.Color.Bisque;
            this.storeProfitValue.Location = new System.Drawing.Point(672, 580);
            this.storeProfitValue.Name = "storeProfitValue";
            this.storeProfitValue.Size = new System.Drawing.Size(106, 39);
            this.storeProfitValue.TabIndex = 12;
            this.storeProfitValue.Text = "$0.00";
            // 
            // ConsignmentShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(790, 628);
            this.Controls.Add(this.storeProfitValue);
            this.Controls.Add(this.storeProfitLabel);
            this.Controls.Add(this.vendorListBoxLabel);
            this.Controls.Add(this.vendorsListBox);
            this.Controls.Add(this.shoppingListLabel);
            this.Controls.Add(this.purchaseButton);
            this.Controls.Add(this.shoppingListBoxLabel);
            this.Controls.Add(this.shoppingListBox);
            this.Controls.Add(this.addToCard);
            this.Controls.Add(this.itemsListBoxLabel);
            this.Controls.Add(this.itemsListBox);
            this.Controls.Add(this.headerText);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "ConsignmentShop";
            this.Text = "ConsignmentShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerText;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsListBoxLabel;
        private System.Windows.Forms.Button addToCard;
        private System.Windows.Forms.Label shoppingListBoxLabel;
        private System.Windows.Forms.ListBox shoppingListBox;
        private System.Windows.Forms.Button purchaseButton;
        private System.Windows.Forms.Label shoppingListLabel;
        private System.Windows.Forms.Label vendorListBoxLabel;
        private System.Windows.Forms.ListBox vendorsListBox;
        private System.Windows.Forms.Label storeProfitLabel;
        private System.Windows.Forms.Label storeProfitValue;
    }
}

