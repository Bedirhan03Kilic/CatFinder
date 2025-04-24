using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KediUygulaması3._0
{
    public partial class KayitEkrani : Form
    {
        public KayitEkrani()
        {
            InitializeComponent();
        }

        private void KayitEkrani_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void mailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dogumTarihiDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string isimSoyisim = nameTextBox.Text.Trim();
            string email = mailTextBox.Text.Trim();
            string telefonNo = phoneNumberTextBox.Text.Trim();
            string kullaniciAdi = userNameTextBox.Text.Trim();
            string sifre = passwordTextBox.Text.Trim();
            DateTime dogumTarihi = dogumTarihiDateTimePicker.Value;
            string sehir = cityComboBox.Text;
            string tcNo = tcNoTextBox.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(isimSoyisim) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefonNo) ||
                string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sehir) ||
                string.IsNullOrEmpty(tcNo))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Telefon numarası ve TC kontrolü
            if (telefonNo.Length != 10 || !telefonNo.StartsWith("5"))
            {
                MessageBox.Show("Telefon numarası 5 ile başlamalı ve 10 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tcNo.Length != 11)
            {
                MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Veritabanı bağlantısı
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Kullanıcı ekleme sorgusu
                    string query = "INSERT INTO Kullanici (IsimSoyisim, Email, TelefonNo, KullaniciAdi, Sifre, Sehir, DogumTarihi, TCNo) " +
                                   "VALUES (@IsimSoyisim, @Email, @TelefonNo, @KullaniciAdi, @Sifre, @Sehir, @DogumTarihi, @TCNo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IsimSoyisim", isimSoyisim);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@TelefonNo", telefonNo);
                        command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        command.Parameters.AddWithValue("@Sifre", sifre);
                        command.Parameters.AddWithValue("@Sehir", sehir);
                        command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                        command.Parameters.AddWithValue("@TCNo", tcNo);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başarılı bir şekilde tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearForm();
                    }
                }
                catch (SqlException ex)
                {
                    // Benzersiz kısıtlamalar hatası kontrolü
                    if (ex.Number == 2627) // Unique constraint violation
                    {
                        MessageBox.Show("Girilen e-posta, kullanıcı adı veya TC kimlik zaten mevcut.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearForm()
        {
            nameTextBox.Text = string.Empty;
            mailTextBox.Text = string.Empty;
            phoneNumberTextBox.Text = string.Empty;
            userNameTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
            tcNoTextBox.Text = string.Empty;
            cityComboBox.SelectedIndex = -1;
            dogumTarihiDateTimePicker.Value = DateTime.Now;
        }

        private void backToLoginScreenButton_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();

            // Mevcut kayıt ekranını kapat
            this.Close();
        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
