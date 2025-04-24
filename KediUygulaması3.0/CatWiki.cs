using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace KediUygulaması3._0
{
    public partial class CatWiki : Form
    {
        private int kullaniciID;

        public CatWiki(int id)
        {
            InitializeComponent();
            kullaniciID = id;   
        }

        private void CatWiki_Load(object sender, EventArgs e)
        {
            catInfoRichTextBox.ReadOnly = true;
            catKindComboBox.Items.Add("Van Kedisi");
            catKindComboBox.Items.Add("İran Kedisi");
            catKindComboBox.Items.Add("British Shorthair");
            catKindComboBox.Items.Add("Maine Coon");
            catKindComboBox.Items.Add("Siyam Kedisi");
            catKindComboBox.Items.Add("Sivas Kangalı");
            // Varsayılan seçim olarak "Van Kedisi"ni seçiyoruz
            catKindComboBox.SelectedItem = "Van Kedisi";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu(kullaniciID);
            anaMenu.Show();
            this.Close();

        }

    

        private void catInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void catInfoPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void catInfoPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void catInfoPictureBox3_Click(object sender, EventArgs e)
        {

        }

     
        

            private void LoadImage(SqlDataReader reader, string columnName, PictureBox pictureBox)
            {
                if (reader[columnName] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])reader[columnName];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    pictureBox.Image = null;  // Eğer fotoğraf yoksa, boş bırakılır
                }
            }

        private void catKindComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCatInfo();  
        }
        private void LoadCatInfo()
        {
            string kediTuru = catKindComboBox.SelectedItem?.ToString().Trim();

            if (string.IsNullOrEmpty(kediTuru))
            {
                MessageBox.Show("Lütfen bir kedi türü seçin.");
                return;
            }

            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT KediAciklama, Foto1, Foto2, Foto3 FROM KediBilgileri WHERE KediTuru = @KediTuru";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Parametreyi doğru şekilde ekliyoruz
                    cmd.Parameters.Add(new SqlParameter("@KediTuru", SqlDbType.NVarChar)).Value = kediTuru;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();

                        // Kedinin açıklamasını alıyoruz
                        catInfoRichTextBox.Text = reader["KediAciklama"].ToString();

                        // Fotoğrafları alıyoruz ve PictureBox'lara yüklüyoruz
                        LoadImage(reader, "Foto1", catInfoPictureBox1);
                        LoadImage(reader, "Foto2", catInfoPictureBox2);
                        LoadImage(reader, "Foto3", catInfoPictureBox3);
                    }
                    else
                    {
                        MessageBox.Show("Bu kedi türüyle ilgili bilgi bulunamadı.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında bir hata oluştu: " + ex.Message);
            }
        }

    }
}

