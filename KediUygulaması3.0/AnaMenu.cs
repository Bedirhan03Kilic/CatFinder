using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KediUygulaması3._0
{
    public partial class AnaMenu : Form
    {
        private int kullaniciID; // Kullanıcı ID'si bu formda saklanacak

        public AnaMenu(int id)
        {
            InitializeComponent();
            kullaniciID = id; // Giriş yapan kullanıcının ID'sini al

        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            LoadUserPhoto();

        }

        private void petShopButton_Click(object sender, EventArgs e)
        {
            PetShop petShop = new PetShop(kullaniciID);
            petShop.Show();
            this.Close();
        }

        private void vetFinderButton_Click(object sender, EventArgs e)
        {
            VeterinerBul veterinerBul = new VeterinerBul(kullaniciID);
            veterinerBul.Show();
            this.Close();
        }

        private void catQA_Click(object sender, EventArgs e)
        {
            CatQA catqa = new CatQA(kullaniciID);
            catqa.Show();
            this.Close();
        }

        private void catAdoptButton_Click(object sender, EventArgs e)
        {
            KediSahiplenme kediSahiplenme = new KediSahiplenme(kullaniciID);
            kediSahiplenme.Show();
            this.Close();
        }

        private void wikiButton_Click(object sender, EventArgs e)
        {
            CatWiki catWiki = new CatWiki(kullaniciID);
            catWiki.Show(); 
            this.Close();
        }

        private void userInformationButton_Click(object sender, EventArgs e)
        {
            KullaniciBilgileri kullaniciBilgileri = new KullaniciBilgileri(kullaniciID);
            kullaniciBilgileri.Show();

            // Mevcut kayıt ekranını kapat
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void LoadUserPhoto()
        {
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Resim FROM KullaniciResimleri WHERE KullaniciID = @KullaniciID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        byte[] imageBytes = (byte[])reader["Resim"];
                        MemoryStream ms = new MemoryStream(imageBytes);
                        pictureBox1.Image = Image.FromStream(ms); // PictureBox'a yükle
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    }
                    else
                    {
                        // Eğer fotoğraf yoksa, varsayılan bir resim gösterilebilir
                       pictureBox1.Image = Properties.Resources.userpng;
                       pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uploadPhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPG Files|*.jpg|PNG Files|*.png|All files|*.*"; // Resim dosyaları için filtre

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);

                // Fotoğrafı byte array olarak alalım
                byte[] imageBytes = File.ReadAllBytes(selectedImagePath);

                // Fotoğrafı veritabanına kaydedelim
                SaveUserPhotoToDatabase(imageBytes);
            }
        }
        private void SaveUserPhotoToDatabase(byte[] imageBytes)
        {
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    // Öncelikle, bu kullanıcıya ait bir fotoğraf olup olmadığını kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM KullaniciResimleri WHERE KullaniciID = @KullaniciID";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                    int photoCount = (int)checkCmd.ExecuteScalar();

                    if (photoCount > 0)
                    {
                        // Fotoğraf varsa, mevcut fotoğrafı güncelle
                        query = "UPDATE KullaniciResimleri SET Resim = @Resim WHERE KullaniciID = @KullaniciID";
                    }
                    else
                    {
                        // Fotoğraf yoksa, yeni fotoğraf ekle
                        query = "INSERT INTO KullaniciResimleri (KullaniciID, Resim) VALUES (@KullaniciID, @Resim)";
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                    cmd.Parameters.AddWithValue("@Resim", imageBytes);

                    cmd.ExecuteNonQuery(); // Fotoğrafı veritabanına kaydet veya güncelle
                }

                MessageBox.Show("Fotoğraf başarıyla yüklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message);
            }
        }
    }
}
