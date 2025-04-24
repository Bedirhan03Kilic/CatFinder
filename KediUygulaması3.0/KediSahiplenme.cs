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
    public partial class KediSahiplenme : Form
    {
        private int kullaniciID;
        private string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog = KediUygulama; Integrated Security = True; Encrypt=False";

        public KediSahiplenme(int id)
        {
            InitializeComponent();
            kullaniciID = id;
        }

        private void KediSahiplenme_Load(object sender, EventArgs e)
        {
            LoadCatAdoptionData();
            catKindFilterComboBox.Items.Add("Van Kedisi");
            catKindFilterComboBox.Items.Add("British Shorthair");
            catKindFilterComboBox.Items.Add("Sokak Kedisi");
            catKindFilterComboBox.Items.Add("Scottish Fold");

            // ComboBox'un varsayılan seçili öğesini ayarlayın (isteğe bağlı)
            catKindFilterComboBox.SelectedIndex = 0;
            catAdoptionDataGridView.Columns["Foto"].Visible = false;
            catAdoptionDataGridView.Columns["Fotoğraf"].Visible = false;
        }
        private void LoadCatAdoptionData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT IlanID, KediAdi, KediTuru, KediYasi, Aciklama, Foto FROM Ilanlar WHERE Sahiplenildi = 0";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        catAdoptionDataGridView.DataSource = dt;

                        // ID kolonu gizlemek için
                        catAdoptionDataGridView.Columns["IlanID"].Visible = false;

                        // Fotoğraf sütunu için bir ImageColumn ekleme
                        if (!catAdoptionDataGridView.Columns.Contains("Fotoğraf"))
                        {
                            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
                            imgColumn.HeaderText = "Fotoğraf";
                            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                            imgColumn.Name = "Fotoğraf"; // Kolon adını belirliyoruz
                            catAdoptionDataGridView.Columns.Add(imgColumn);
                        }

                        // Fotoğrafları doğru hücrelere ekleyin
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            byte[] photoBytes = (byte[])dt.Rows[i]["Foto"];
                            using (var ms = new System.IO.MemoryStream(photoBytes))
                            {
                                catAdoptionDataGridView.Rows[i].Cells["Fotoğraf"].Value = Image.FromStream(ms);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu(kullaniciID);
            anaMenu.Show();
            this.Close();
        }

        private void adoptYourCatButton_Click(object sender, EventArgs e)
        {
            SahiplendirmeIlani sahiplendirmeIlani = new SahiplendirmeIlani(kullaniciID);
            sahiplendirmeIlani.Show();
            this.Close();
        }

        private void catKindFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterCats();
        }

        private void catNameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterCats();
        }
        private void FilterCats()
        {

            try
            {
                string filterQuery = "SELECT IlanID, KediAdi, KediTuru, KediYasi, Aciklama, Foto FROM Ilanlar WHERE Sahiplenildi = 0";
                List<string> filterConditions = new List<string>();

                if (!string.IsNullOrEmpty(catNameSearchTextBox.Text))
                {
                    filterConditions.Add("KediAdi LIKE @KediAdi");
                }

                if (catKindFilterComboBox.SelectedItem != null)
                {
                    filterConditions.Add("KediTuru = @KediTuru");
                }

                if (filterConditions.Count > 0)
                {
                    filterQuery += " AND " + string.Join(" AND ", filterConditions);
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(filterQuery, conn))
                    {
                        if (!string.IsNullOrEmpty(catNameSearchTextBox.Text))
                        {
                            cmd.Parameters.AddWithValue("@KediAdi", "%" + catNameSearchTextBox.Text + "%");
                        }

                        if (catKindFilterComboBox.SelectedItem != null)
                        {
                            cmd.Parameters.AddWithValue("@KediTuru", catKindFilterComboBox.SelectedItem.ToString());
                        }

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            catAdoptionDataGridView.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void catAdoptionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ilanID = Convert.ToInt32(catAdoptionDataGridView.Rows[e.RowIndex].Cells["IlanID"].Value);
                ShowCatDetails(ilanID);
            }
        }
        private void ShowCatDetails(int ilanID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT KediAdi, KediTuru, KediYasi, Aciklama, Foto FROM Ilanlar WHERE IlanID = @IlanID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IlanID", ilanID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                catNameLabel.Text = reader["KediAdi"].ToString();
                                catKindLabel.Text = reader["KediTuru"].ToString();
                                catAgeLabel.Text = reader["KediYasi"].ToString();
                                catDescriptionLabel.Text = reader["Aciklama"].ToString();

                                // Fotoğraf verisini al
                                byte[] photoBytes = reader["Foto"] as byte[];

                                if (photoBytes != null)
                                {
                                    using (var ms = new System.IO.MemoryStream(photoBytes))
                                    {
                                        catPictureBox.Image = Image.FromStream(ms);
                                        catPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Fotoğrafın boyutunun uygun şekilde ayarlanmasını sağlar

                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void catPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void basvuruButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (catAdoptionDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen sahiplenmek istediğiniz kediyi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int ilanID = Convert.ToInt32(catAdoptionDataGridView.SelectedRows[0].Cells["IlanID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Basvurular (KullaniciID, IlanID) VALUES (@KullaniciID, @IlanID)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciID", kullaniciID);
                        cmd.Parameters.AddWithValue("@IlanID", ilanID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Başvurunuz başarıyla alındı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void catAgeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
