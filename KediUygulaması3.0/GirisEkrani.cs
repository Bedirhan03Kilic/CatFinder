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


namespace KediUygulaması3._0
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            // Data Source=BEDIRHAN\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False
            falseLoginLabel.Visible = false;
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT KullaniciID FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@KullaniciAdi", username);
                    command.Parameters.AddWithValue("@Sifre", password);

                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        int kullaniciID = Convert.ToInt32(result);

                        // Ana menüye geçiş
                        AnaMenu anaMenu = new AnaMenu(kullaniciID);
                        anaMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        falseLoginLabel.Visible=true;
                        uyariLabel.Visible=false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

    }
        private void registerButton_Click(object sender, EventArgs e)
        {
            KayitEkrani kayitEkrani = new KayitEkrani();
            kayitEkrani.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uyariLabel_Click(object sender, EventArgs e)
        {

        }

        private void falseLoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) // Checkbox işaretlendiğinde
            {
                passwordTextBox.PasswordChar = '\0'; // Şifreyi açık şekilde göster
                checkBox1.Text = "👁️";
            }
            else // Checkbox işareti kaldırıldığında
            {
                passwordTextBox.PasswordChar = '*'; // Şifreyi gizle
                checkBox1.Text = "🔑";
            }
        }
    }
}
