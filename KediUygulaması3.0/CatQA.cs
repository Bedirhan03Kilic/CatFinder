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
    public partial class CatQA : Form
    {
        private int KullaniciID;
        public CatQA(int id)
        {
            InitializeComponent();
            KullaniciID = id;
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu(KullaniciID);
            anaMenu.Show();
            this.Close();
        }

        private void LoadQuestions()
        {
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Soru FROM SSS";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    catQAComboBox.Items.Clear(); // Önce eski verileri temizleyelim

                    while (reader.Read())
                    {
                        catQAComboBox.Items.Add(reader["Soru"].ToString());
                    }

                    reader.Close();
                }

                if (catQAComboBox.Items.Count > 0)
                {
                    catQAComboBox.SelectedIndex = 0; // İlk soruyu seçili yap
                }
                else
                {
                    MessageBox.Show("Veritabanında hiç soru bulunamadı.");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }

    

        private void catInfoRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void catQAComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQAInfo(); // Seçilen soruya ait cevabı yükle
        }
        private void LoadQAInfo()
        {
            string selectedQuestion = catQAComboBox.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedQuestion))
            {
                MessageBox.Show("Lütfen bir soru seçin.");
                return;
            }

            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Seçilen soruya ait cevabı almak için sorgu
                    string query = "SELECT Cevap FROM SSS WHERE Soru = @Soru";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Soru", selectedQuestion);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        catQARichTextBox.Text = reader["Cevap"].ToString(); // Cevap metnini RichTextBox'a yükle
                    }
                    else
                    {
                        catQARichTextBox.Text = "Bu soruya ait bir cevap bulunamadı.";
                    }

                    reader.Close();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("Veritabanı bağlantısı sırasında bir hata oluştu: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }
        private void CatQA_Load(object sender, EventArgs e)
        {
            LoadQuestions(); // Soruları yükle
            catQARichTextBox.ReadOnly = true; // RichTextBox'ı sadece okunabilir yap
        }

    }
}


