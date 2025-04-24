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
    public partial class SahiplendirmeIlani : Form
    {
        private int KullaniciID;
        private string fotoYolu = "";
        public SahiplendirmeIlani(int id)
        {
            InitializeComponent();
            KullaniciID = id;
         }

        private void SahiplendirmeIlani_Load(object sender, EventArgs e)
        {
            // Kedi türlerini listelemek için örnek veri
            catKindComboBox.Items.Add("Van Kedisi");
            catKindComboBox.Items.Add("British Shorthair");
            catKindComboBox.Items.Add("Sokak Kedisi");
            catKindComboBox.Items.Add("Scottish Fold");
        }


        private void catPictureBox_Click_1(object sender, EventArgs e)
        {
            // Fotoğraf seçimi için OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoYolu = openFileDialog.FileName; // Seçilen fotoğraf yolunu sakla
                catPictureBox.Image = Image.FromFile(fotoYolu); // Fotoğrafı PictureBox'ta göster
            }
        }

        private void addCatImageButton_Click_1(object sender, EventArgs e)
        {
            // Fotoğraf seçimi için OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fotoYolu = openFileDialog.FileName; // Seçilen fotoğraf yolunu sakla
                catPictureBox.Image = Image.FromFile(fotoYolu); // Fotoğrafı PictureBox'ta göster
            }
        }

        private void ilanVerButton_Click_1(object sender, EventArgs e)
        {


            // Kullanıcıdan gelen verileri al
            string kediAdi = catNameTextBox.Text;
            int kediYasi;
            bool yasGecerli = int.TryParse(catAgeTextBox.Text, out kediYasi);
            string kediTuru = catKindComboBox.SelectedItem?.ToString();
            string aciklama = richTextBox1.Text;

            if (string.IsNullOrEmpty(kediAdi) || !yasGecerli || string.IsNullOrEmpty(kediTuru) || string.IsNullOrEmpty(aciklama) || string.IsNullOrEmpty(fotoYolu))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve bir fotoğraf seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Fotoğrafı byte dizisine çevir
                byte[] fotoBytes;
                using (FileStream fs = new FileStream(fotoYolu, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        fotoBytes = br.ReadBytes((int)fs.Length);
                    }
                }

                // Veritabanına bağlantı
                using (SqlConnection conn = new SqlConnection("Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    string query = "INSERT INTO Ilanlar (KullaniciID, KediAdi, KediTuru, KediYasi, Aciklama, Foto) " +
                                   "VALUES (@KullaniciID, @KediAdi, @KediTuru, @KediYasi, @Aciklama, @Foto)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", KullaniciID);
                        cmd.Parameters.AddWithValue("@KediAdi", kediAdi);
                        cmd.Parameters.AddWithValue("@KediTuru", kediTuru);
                        cmd.Parameters.AddWithValue("@KediYasi", kediYasi);
                        cmd.Parameters.AddWithValue("@Aciklama", aciklama);
                        cmd.Parameters.AddWithValue("@Foto", fotoBytes);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("İlan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void catNameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void catAgeTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void catKindComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            KediSahiplenme kediSahiplenme = new KediSahiplenme(KullaniciID);
            kediSahiplenme.Show();
            this.Close();
        }
    }
}
