namespace KediUygulaması3._0
{
    partial class KediSahiplenme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KediSahiplenme));
            this.catAdoptionDataGridView = new System.Windows.Forms.DataGridView();
            this.adoptYourCatButton = new System.Windows.Forms.Button();
            this.catKindFilterComboBox = new System.Windows.Forms.ComboBox();
            this.catNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.returnToMainMenuButton = new System.Windows.Forms.Button();
            this.catNameLabel = new System.Windows.Forms.Label();
            this.catAgeLabel = new System.Windows.Forms.Label();
            this.catDescriptionLabel = new System.Windows.Forms.Label();
            this.catKindLabel = new System.Windows.Forms.Label();
            this.basvuruButton = new System.Windows.Forms.Button();
            this.catPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.catAdoptionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // catAdoptionDataGridView
            // 
            this.catAdoptionDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.catAdoptionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catAdoptionDataGridView.Location = new System.Drawing.Point(11, 39);
            this.catAdoptionDataGridView.Name = "catAdoptionDataGridView";
            this.catAdoptionDataGridView.Size = new System.Drawing.Size(489, 192);
            this.catAdoptionDataGridView.TabIndex = 0;
            this.catAdoptionDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.catAdoptionDataGridView_CellContentClick);
            // 
            // adoptYourCatButton
            // 
            this.adoptYourCatButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.adoptYourCatButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptYourCatButton.Location = new System.Drawing.Point(517, 143);
            this.adoptYourCatButton.Name = "adoptYourCatButton";
            this.adoptYourCatButton.Size = new System.Drawing.Size(271, 102);
            this.adoptYourCatButton.TabIndex = 3;
            this.adoptYourCatButton.Text = "Kedini Sahiplendir";
            this.adoptYourCatButton.UseVisualStyleBackColor = false;
            this.adoptYourCatButton.Click += new System.EventHandler(this.adoptYourCatButton_Click);
            // 
            // catKindFilterComboBox
            // 
            this.catKindFilterComboBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.catKindFilterComboBox.FormattingEnabled = true;
            this.catKindFilterComboBox.Location = new System.Drawing.Point(12, 12);
            this.catKindFilterComboBox.Name = "catKindFilterComboBox";
            this.catKindFilterComboBox.Size = new System.Drawing.Size(148, 21);
            this.catKindFilterComboBox.TabIndex = 4;
            this.catKindFilterComboBox.SelectedIndexChanged += new System.EventHandler(this.catKindFilterComboBox_SelectedIndexChanged);
            // 
            // catNameSearchTextBox
            // 
            this.catNameSearchTextBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.catNameSearchTextBox.Location = new System.Drawing.Point(166, 12);
            this.catNameSearchTextBox.Name = "catNameSearchTextBox";
            this.catNameSearchTextBox.Size = new System.Drawing.Size(148, 20);
            this.catNameSearchTextBox.TabIndex = 5;
            this.catNameSearchTextBox.TextChanged += new System.EventHandler(this.catNameSearchTextBox_TextChanged);
            // 
            // returnToMainMenuButton
            // 
            this.returnToMainMenuButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.returnToMainMenuButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToMainMenuButton.Location = new System.Drawing.Point(568, 251);
            this.returnToMainMenuButton.Name = "returnToMainMenuButton";
            this.returnToMainMenuButton.Size = new System.Drawing.Size(166, 61);
            this.returnToMainMenuButton.TabIndex = 6;
            this.returnToMainMenuButton.Text = "Geri Dön";
            this.returnToMainMenuButton.UseVisualStyleBackColor = false;
            this.returnToMainMenuButton.Click += new System.EventHandler(this.returnToMainMenuButton_Click);
            // 
            // catNameLabel
            // 
            this.catNameLabel.AutoSize = true;
            this.catNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.catNameLabel.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catNameLabel.Location = new System.Drawing.Point(279, 275);
            this.catNameLabel.Name = "catNameLabel";
            this.catNameLabel.Size = new System.Drawing.Size(0, 17);
            this.catNameLabel.TabIndex = 7;
            // 
            // catAgeLabel
            // 
            this.catAgeLabel.AutoSize = true;
            this.catAgeLabel.BackColor = System.Drawing.Color.Transparent;
            this.catAgeLabel.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catAgeLabel.Location = new System.Drawing.Point(279, 357);
            this.catAgeLabel.Name = "catAgeLabel";
            this.catAgeLabel.Size = new System.Drawing.Size(0, 17);
            this.catAgeLabel.TabIndex = 8;
            this.catAgeLabel.Click += new System.EventHandler(this.catAgeLabel_Click);
            // 
            // catDescriptionLabel
            // 
            this.catDescriptionLabel.AutoSize = true;
            this.catDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.catDescriptionLabel.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catDescriptionLabel.Location = new System.Drawing.Point(336, 357);
            this.catDescriptionLabel.Name = "catDescriptionLabel";
            this.catDescriptionLabel.Size = new System.Drawing.Size(0, 17);
            this.catDescriptionLabel.TabIndex = 9;
            // 
            // catKindLabel
            // 
            this.catKindLabel.AutoSize = true;
            this.catKindLabel.BackColor = System.Drawing.Color.Transparent;
            this.catKindLabel.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catKindLabel.Location = new System.Drawing.Point(336, 275);
            this.catKindLabel.Name = "catKindLabel";
            this.catKindLabel.Size = new System.Drawing.Size(0, 17);
            this.catKindLabel.TabIndex = 10;
            // 
            // basvuruButton
            // 
            this.basvuruButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.basvuruButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basvuruButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.basvuruButton.Location = new System.Drawing.Point(517, 39);
            this.basvuruButton.Name = "basvuruButton";
            this.basvuruButton.Size = new System.Drawing.Size(271, 98);
            this.basvuruButton.TabIndex = 2;
            this.basvuruButton.Text = "Başvur";
            this.basvuruButton.UseVisualStyleBackColor = false;
            this.basvuruButton.Click += new System.EventHandler(this.basvuruButton_Click);
            // 
            // catPictureBox
            // 
            this.catPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.catPictureBox.Location = new System.Drawing.Point(12, 251);
            this.catPictureBox.Name = "catPictureBox";
            this.catPictureBox.Size = new System.Drawing.Size(202, 147);
            this.catPictureBox.TabIndex = 1;
            this.catPictureBox.TabStop = false;
            this.catPictureBox.Click += new System.EventHandler(this.catPictureBox_Click);
            // 
            // KediSahiplenme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KediUygulaması3._0.Properties.Resources._18334359_Handdrawn_Cat_Pattern_01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.catKindLabel);
            this.Controls.Add(this.catDescriptionLabel);
            this.Controls.Add(this.catAgeLabel);
            this.Controls.Add(this.catNameLabel);
            this.Controls.Add(this.returnToMainMenuButton);
            this.Controls.Add(this.catNameSearchTextBox);
            this.Controls.Add(this.catKindFilterComboBox);
            this.Controls.Add(this.adoptYourCatButton);
            this.Controls.Add(this.basvuruButton);
            this.Controls.Add(this.catPictureBox);
            this.Controls.Add(this.catAdoptionDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KediSahiplenme";
            this.Text = "KediSahiplenme";
            this.Load += new System.EventHandler(this.KediSahiplenme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.catAdoptionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView catAdoptionDataGridView;
        private System.Windows.Forms.PictureBox catPictureBox;
        private System.Windows.Forms.Button basvuruButton;
        private System.Windows.Forms.Button adoptYourCatButton;
        private System.Windows.Forms.ComboBox catKindFilterComboBox;
        private System.Windows.Forms.TextBox catNameSearchTextBox;
        private System.Windows.Forms.Button returnToMainMenuButton;
        private System.Windows.Forms.Label catNameLabel;
        private System.Windows.Forms.Label catAgeLabel;
        private System.Windows.Forms.Label catDescriptionLabel;
        private System.Windows.Forms.Label catKindLabel;
    }
}