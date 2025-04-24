namespace KediUygulaması3._0
{
    partial class CatWiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatWiki));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.catKindComboBox = new System.Windows.Forms.ComboBox();
            this.backToMainMenuButton = new System.Windows.Forms.Button();
            this.catInfoPictureBox3 = new System.Windows.Forms.PictureBox();
            this.catInfoPictureBox2 = new System.Windows.Forms.PictureBox();
            this.catInfoPictureBox1 = new System.Windows.Forms.PictureBox();
            this.catInfoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catInfoPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catInfoPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catInfoPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.catKindComboBox);
            this.panel1.Controls.Add(this.backToMainMenuButton);
            this.panel1.Controls.Add(this.catInfoPictureBox3);
            this.panel1.Controls.Add(this.catInfoPictureBox2);
            this.panel1.Controls.Add(this.catInfoPictureBox1);
            this.panel1.Controls.Add(this.catInfoRichTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 432);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "CatWiki";
            // 
            // catKindComboBox
            // 
            this.catKindComboBox.BackColor = System.Drawing.Color.RosyBrown;
            this.catKindComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.catKindComboBox.FormattingEnabled = true;
            this.catKindComboBox.Location = new System.Drawing.Point(236, 28);
            this.catKindComboBox.Name = "catKindComboBox";
            this.catKindComboBox.Size = new System.Drawing.Size(121, 21);
            this.catKindComboBox.TabIndex = 8;
            this.catKindComboBox.SelectedIndexChanged += new System.EventHandler(this.catKindComboBox_SelectedIndexChanged);
            // 
            // backToMainMenuButton
            // 
            this.backToMainMenuButton.BackColor = System.Drawing.Color.RosyBrown;
            this.backToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backToMainMenuButton.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenuButton.Location = new System.Drawing.Point(602, 28);
            this.backToMainMenuButton.Name = "backToMainMenuButton";
            this.backToMainMenuButton.Size = new System.Drawing.Size(103, 23);
            this.backToMainMenuButton.TabIndex = 5;
            this.backToMainMenuButton.Text = "Geri Dön";
            this.backToMainMenuButton.UseVisualStyleBackColor = false;
            this.backToMainMenuButton.Click += new System.EventHandler(this.backToMainMenuButton_Click);
            // 
            // catInfoPictureBox3
            // 
            this.catInfoPictureBox3.Location = new System.Drawing.Point(589, 313);
            this.catInfoPictureBox3.Name = "catInfoPictureBox3";
            this.catInfoPictureBox3.Size = new System.Drawing.Size(139, 115);
            this.catInfoPictureBox3.TabIndex = 3;
            this.catInfoPictureBox3.TabStop = false;
            this.catInfoPictureBox3.Click += new System.EventHandler(this.catInfoPictureBox3_Click);
            // 
            // catInfoPictureBox2
            // 
            this.catInfoPictureBox2.Location = new System.Drawing.Point(589, 189);
            this.catInfoPictureBox2.Name = "catInfoPictureBox2";
            this.catInfoPictureBox2.Size = new System.Drawing.Size(139, 118);
            this.catInfoPictureBox2.TabIndex = 2;
            this.catInfoPictureBox2.TabStop = false;
            this.catInfoPictureBox2.Click += new System.EventHandler(this.catInfoPictureBox2_Click);
            // 
            // catInfoPictureBox1
            // 
            this.catInfoPictureBox1.Location = new System.Drawing.Point(589, 68);
            this.catInfoPictureBox1.Name = "catInfoPictureBox1";
            this.catInfoPictureBox1.Size = new System.Drawing.Size(139, 115);
            this.catInfoPictureBox1.TabIndex = 1;
            this.catInfoPictureBox1.TabStop = false;
            this.catInfoPictureBox1.Click += new System.EventHandler(this.catInfoPictureBox1_Click);
            // 
            // catInfoRichTextBox
            // 
            this.catInfoRichTextBox.BackColor = System.Drawing.Color.RosyBrown;
            this.catInfoRichTextBox.Location = new System.Drawing.Point(0, 67);
            this.catInfoRichTextBox.Name = "catInfoRichTextBox";
            this.catInfoRichTextBox.Size = new System.Drawing.Size(562, 361);
            this.catInfoRichTextBox.TabIndex = 0;
            this.catInfoRichTextBox.Text = "";
            this.catInfoRichTextBox.TextChanged += new System.EventHandler(this.catInfoRichTextBox_TextChanged);
            // 
            // CatWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::KediUygulaması3._0.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatWiki";
            this.Text = "CatWiki";
            this.Load += new System.EventHandler(this.CatWiki_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catInfoPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catInfoPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catInfoPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox catInfoPictureBox1;
        private System.Windows.Forms.RichTextBox catInfoRichTextBox;
        private System.Windows.Forms.Button backToMainMenuButton;
        private System.Windows.Forms.PictureBox catInfoPictureBox3;
        private System.Windows.Forms.PictureBox catInfoPictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox catKindComboBox;
    }
}