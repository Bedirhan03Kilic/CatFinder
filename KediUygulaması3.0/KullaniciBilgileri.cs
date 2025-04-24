using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KediUygulaması3._0
{
    public partial class KullaniciBilgileri : Form
    {
        private int kullaniciID; // Giriş yapan kullanıcının ID'sini taşıyoruz

        public KullaniciBilgileri(int id)
        {
            InitializeComponent();
            kullaniciID = id; // Kullanıcı ID'sini alıyoruz
        }

      

        private void changeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";
          

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT IsimSoyisim, KullaniciAdi, Email, DogumTarihi, TelefonNo, Sehir, TCNo FROM Kullanici WHERE KullaniciID = @KullaniciID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        // Kullanıcı bilgilerini Label kontrollerine yazdırıyoruz
                        nameSurnameLabel.Text = reader["IsimSoyisim"].ToString();
                        userNameLabel.Text = reader["KullaniciAdi"].ToString();
                        mailLabel.Text = reader["Email"].ToString();
                        birthDateLabel.Text = Convert.ToDateTime(reader["DogumTarihi"]).ToString("dd/MM/yyyy");
                        phoneNumberLabel.Text = reader["TelefonNo"].ToString();
                        cityLabel.Text = reader["Sehir"].ToString();
                        tcNoLabel.Text = reader["TCNo"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bilgiler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadUserPhoto(); // Kullanıcı fotoğrafını yükle

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
                        pictureBox1.Image = Image.FromStream(ms); // Resmi yükle

                        // Resmi uygun boyutta göstermek için SizeMode'u ayarla
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        // Eğer fotoğraf yoksa, varsayılan bir resim gösterilebilir
                        pictureBox1.Image = Properties.Resources.resimekle;
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

        private void nameSurnameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void mailLabel_Click(object sender, EventArgs e)
        {

        }

        private void birthDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void cityLabel_Click(object sender, EventArgs e)
        {

        }

        private void tcNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu(kullaniciID);
            anaMenu.Show();
            this.Close();
        }

        private void logOffButton_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
