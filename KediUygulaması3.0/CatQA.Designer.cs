namespace KediUygulaması3._0
{
    partial class CatQA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatQA));
            this.backToMenuButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.catQAComboBox = new System.Windows.Forms.ComboBox();
            this.catQARichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backToMenuButton
            // 
            this.backToMenuButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.backToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToMenuButton.Location = new System.Drawing.Point(671, 394);
            this.backToMenuButton.Name = "backToMenuButton";
            this.backToMenuButton.Size = new System.Drawing.Size(88, 38);
            this.backToMenuButton.TabIndex = 1;
            this.backToMenuButton.Text = "Geri Dön";
            this.backToMenuButton.UseVisualStyleBackColor = false;
            this.backToMenuButton.Click += new System.EventHandler(this.backToMenuButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.catQAComboBox);
            this.panel1.Controls.Add(this.backToMenuButton);
            this.panel1.Controls.Add(this.catQARichTextBox);
            this.panel1.Location = new System.Drawing.Point(19, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 432);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // catQAComboBox
            // 
            this.catQAComboBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.catQAComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.catQAComboBox.FormattingEnabled = true;
            this.catQAComboBox.Location = new System.Drawing.Point(220, 28);
            this.catQAComboBox.Name = "catQAComboBox";
            this.catQAComboBox.Size = new System.Drawing.Size(236, 21);
            this.catQAComboBox.TabIndex = 8;
            this.catQAComboBox.SelectedIndexChanged += new System.EventHandler(this.catQAComboBox_SelectedIndexChanged);
            // 
            // catQARichTextBox
            // 
            this.catQARichTextBox.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.catQARichTextBox.Location = new System.Drawing.Point(14, 68);
            this.catQARichTextBox.Name = "catQARichTextBox";
            this.catQARichTextBox.Size = new System.Drawing.Size(636, 361);
            this.catQARichTextBox.TabIndex = 0;
            this.catQARichTextBox.Text = "";
            this.catQARichTextBox.TextChanged += new System.EventHandler(this.catInfoRichTextBox_TextChanged);
            // 
            // CatQA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KediUygulaması3._0.Properties.Resources.ssss;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CatQA";
            this.Text = "CatQA";
            this.Load += new System.EventHandler(this.CatQA_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button backToMenuButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox catQAComboBox;
        private System.Windows.Forms.RichTextBox catQARichTextBox;
    }
}