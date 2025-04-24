namespace KediUygulaması3._0
{
    partial class KullaniciBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciBilgileri));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameSurnameLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.tcNoLabel = new System.Windows.Forms.Label();
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.logOffButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::KediUygulaması3._0.Properties.Resources.cute_cat_pattern;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(25, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 102);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.AutoSize = true;
            this.nameSurnameLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.nameSurnameLabel.Location = new System.Drawing.Point(144, 170);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(108, 21);
            this.nameSurnameLabel.TabIndex = 1;
            this.nameSurnameLabel.Text = "isim soyisim";
            this.nameSurnameLabel.Click += new System.EventHandler(this.nameSurnameLabel_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.userNameLabel.Location = new System.Drawing.Point(158, 191);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(117, 21);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "kullanıcı adı";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.mailLabel.Location = new System.Drawing.Point(80, 212);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(61, 21);
            this.mailLabel.TabIndex = 3;
            this.mailLabel.Text = "e-mail";
            this.mailLabel.Click += new System.EventHandler(this.mailLabel_Click);
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.birthDateLabel.Location = new System.Drawing.Point(154, 230);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(121, 21);
            this.birthDateLabel.TabIndex = 4;
            this.birthDateLabel.Text = "doğumTarihi";
            this.birthDateLabel.Click += new System.EventHandler(this.birthDateLabel_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.phoneNumberLabel.Location = new System.Drawing.Point(103, 251);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(149, 21);
            this.phoneNumberLabel.TabIndex = 5;
            this.phoneNumberLabel.Text = "telefon numarası";
            this.phoneNumberLabel.Click += new System.EventHandler(this.phoneNumberLabel_Click);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.cityLabel.Location = new System.Drawing.Point(86, 271);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(50, 21);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "şehir";
            this.cityLabel.Click += new System.EventHandler(this.cityLabel_Click);
            // 
            // tcNoLabel
            // 
            this.tcNoLabel.AutoSize = true;
            this.tcNoLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.tcNoLabel.Location = new System.Drawing.Point(92, 293);
            this.tcNoLabel.Name = "tcNoLabel";
            this.tcNoLabel.Size = new System.Drawing.Size(49, 21);
            this.tcNoLabel.TabIndex = 7;
            this.tcNoLabel.Text = "tc-no";
            this.tcNoLabel.Click += new System.EventHandler(this.tcNoLabel_Click);
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.DarkGray;
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMenuButton.Location = new System.Drawing.Point(647, 41);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(75, 23);
            this.backToMenuButton.TabIndex = 8;
            this.backToMenuButton.Text = "Geri dön";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // logOffButton
            // 
            this.logOffButton.BackColor = System.Drawing.Color.DarkGray;
            this.logOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOffButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffButton.Location = new System.Drawing.Point(599, 70);
            this.logOffButton.Name = "logOffButton";
            this.logOffButton.Size = new System.Drawing.Size(123, 23);
            this.logOffButton.TabIndex = 9;
            this.logOffButton.Text = "Hesaptan Çıkış yap";
            this.logOffButton.UseVisualStyleBackColor = false;
            this.logOffButton.Click += new System.EventHandler(this.logOffButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.DarkGray;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Elephant", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(647, 99);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Çıkış Yap";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(21, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "İsim Soyisim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(21, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(21, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Doğum Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(21, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(21, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Şehir:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(21, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "TC no:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(21, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = "Mail:";
            // 
            // KullaniciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KediUygulaması3._0.Properties.Resources.background5__1_;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.logOffButton);
            this.Controls.Add(this.backToMenuButton);
            this.Controls.Add(this.tcNoLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.nameSurnameLabel);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciBilgileri";
            this.Text = "KullaniciBilgileri";
            this.Load += new System.EventHandler(this.KullaniciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameSurnameLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label tcNoLabel;
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Button logOffButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}