namespace KediUygulaması3._0
{
    partial class VeterinerBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeterinerBul));
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityDataGriew = new System.Windows.Forms.DataGridView();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGriew)).BeginInit();
            this.SuspendLayout();
            // 
            // cityComboBox
            // 
            this.cityComboBox.BackColor = System.Drawing.Color.DarkTurquoise;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Şanlıurfa",
            "Siirt",
            "Sinop",
            "Şırnak",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cityComboBox.Location = new System.Drawing.Point(303, 76);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(183, 21);
            this.cityComboBox.TabIndex = 1;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // cityDataGriew
            // 
            this.cityDataGriew.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.cityDataGriew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGriew.Location = new System.Drawing.Point(12, 122);
            this.cityDataGriew.Name = "cityDataGriew";
            this.cityDataGriew.Size = new System.Drawing.Size(435, 283);
            this.cityDataGriew.TabIndex = 2;
            this.cityDataGriew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cityDataGriew_CellContentClick);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.backToMainMenuButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenuButton.Location = new System.Drawing.Point(704, 411);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(94, 37);
            this.backToMainMenuButton.TabIndex = 3;
            this.backToMainMenuButton.Text = "Geri Dön";
            this.backToMainMenuButton.UseVisualStyleBackColor = false;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bulunduğunuz şehri seçiniz...";
            // 
            // VeterinerBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KediUygulaması3._0.Properties.Resources.vetbackground;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToMainMenuButton);
            this.Controls.Add(this.cityDataGriew);
            this.Controls.Add(this.cityComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VeterinerBul";
            this.Text = "VeterinerBul";
            this.Load += new System.EventHandler(this.VeterinerBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGriew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.DataGridView cityDataGriew;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.Label label1;
    }
}