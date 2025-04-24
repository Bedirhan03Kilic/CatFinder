namespace KediUygulaması3._0
{
    partial class PetShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetShop));
            this.buyableThingsDataGridView = new System.Windows.Forms.DataGridView();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.basketListBox = new System.Windows.Forms.ListBox();
            this.addToBasketButton = new System.Windows.Forms.Button();
            this.buyButton = new System.Windows.Forms.Button();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.buyableThingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buyableThingsDataGridView
            // 
            this.buyableThingsDataGridView.BackgroundColor = System.Drawing.Color.DarkSalmon;
            this.buyableThingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyableThingsDataGridView.Location = new System.Drawing.Point(21, 150);
            this.buyableThingsDataGridView.Name = "buyableThingsDataGridView";
            this.buyableThingsDataGridView.Size = new System.Drawing.Size(356, 167);
            this.buyableThingsDataGridView.TabIndex = 0;
            this.buyableThingsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buyableThingsDataGridView_CellContentClick);
            // 
            // productPictureBox
            // 
            this.productPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.productPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productPictureBox.Location = new System.Drawing.Point(21, 52);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(100, 81);
            this.productPictureBox.TabIndex = 2;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.Click += new System.EventHandler(this.productPictureBox_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(157, 40);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(121, 21);
            this.filterComboBox.TabIndex = 3;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.searchTextBox.Location = new System.Drawing.Point(297, 41);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // basketListBox
            // 
            this.basketListBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.basketListBox.FormattingEnabled = true;
            this.basketListBox.Location = new System.Drawing.Point(537, 194);
            this.basketListBox.Name = "basketListBox";
            this.basketListBox.Size = new System.Drawing.Size(154, 134);
            this.basketListBox.TabIndex = 5;
            this.basketListBox.SelectedIndexChanged += new System.EventHandler(this.basketListBox_SelectedIndexChanged);
            // 
            // addToBasketButton
            // 
            this.addToBasketButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.addToBasketButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToBasketButton.Location = new System.Drawing.Point(104, 323);
            this.addToBasketButton.Name = "addToBasketButton";
            this.addToBasketButton.Size = new System.Drawing.Size(132, 39);
            this.addToBasketButton.TabIndex = 6;
            this.addToBasketButton.Text = "Sepete Ekle";
            this.addToBasketButton.UseVisualStyleBackColor = false;
            this.addToBasketButton.Click += new System.EventHandler(this.addToBasketButton_Click);
            // 
            // buyButton
            // 
            this.buyButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.buyButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(565, 351);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(97, 30);
            this.buyButton.TabIndex = 7;
            this.buyButton.Text = "Satın al";
            this.buyButton.UseVisualStyleBackColor = false;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalPriceLabel.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(618, 331);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(45, 17);
            this.totalPriceLabel.TabIndex = 8;
            this.totalPriceLabel.Text = "label1";
            this.totalPriceLabel.Click += new System.EventHandler(this.totalPriceLabel_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.backToMenuButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(701, 404);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(87, 34);
            this.backToMenuButton.TabIndex = 9;
            this.backToMenuButton.Text = "Geri Dön";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // PetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KediUygulaması3._0.Properties.Resources.petshop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.buyButton);
            this.Controls.Add(this.addToBasketButton);
            this.Controls.Add(this.basketListBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.buyableThingsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PetShop";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.PetShop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buyableThingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView buyableThingsDataGridView;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox basketListBox;
        private System.Windows.Forms.Button addToBasketButton;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button backToMenuButton;
    }
}