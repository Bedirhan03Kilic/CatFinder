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
using System.IO;

namespace KediUygulaması3._0
{
    public partial class PetShop : Form
    {
        decimal toplamFiyat = 0;
        private int KullaniciID;
        public PetShop(int id)
        {
            InitializeComponent();
            KullaniciID = id;
        }
        private DataTable UrunleriGetir(string kategori = null, string arama = null)
        {
            DataTable urunlerTablo = new DataTable();
            string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT UrunID, UrunAdi, Fiyat, Stok, Kategori, UrunResmi FROM Urunler WHERE 1 = 1";

                // Kategori filtrelemesi ekliyoruz
                if (!string.IsNullOrEmpty(kategori))
                {
                    query += " AND Kategori = @Kategori";
                }

                // Arama metni filtrelemesi ekliyoruz
                if (!string.IsNullOrEmpty(arama))
                {
                    query += " AND UrunAdi LIKE @UrunAdi";
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    if (!string.IsNullOrEmpty(kategori))
                        adapter.SelectCommand.Parameters.AddWithValue("@Kategori", kategori);

                    if (!string.IsNullOrEmpty(arama))
                        adapter.SelectCommand.Parameters.AddWithValue("@UrunAdi", "%" + arama + "%");

                    adapter.Fill(urunlerTablo);
                }
            }

            return urunlerTablo;
        }

        private void PetShop_Load(object sender, EventArgs e)
        {
            // Türleri ComboBox'a ekleyelim
            filterComboBox.Items.Add("Tüm Kategoriler");
            filterComboBox.Items.Add("Tasma");
            filterComboBox.Items.Add("Mama");
            filterComboBox.Items.Add("Oyuncak");
            filterComboBox.SelectedIndex = 0; // İlk başta "Tüm Kategoriler" seçili olsun

            // Ürünleri yükleyelim
            DataTable urunlerTablo = UrunleriGetir();
            buyableThingsDataGridView.DataSource = urunlerTablo;

            // Eğer UrunResmi sütunu zaten yoksa, dinamik olarak ekleyin
            if (buyableThingsDataGridView.Columns["UrunResmi"] == null)
            {
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.Name = "UrunResmi";  // Aynı ismi verin
                imageColumn.HeaderText = "Ürün Resmi";
                buyableThingsDataGridView.Columns.Add(imageColumn);
            }

            // "UrunID" sütununu gizleyin
            buyableThingsDataGridView.Columns["UrunID"].Visible = false;

            // Resim sütununu başa alıyoruz
            buyableThingsDataGridView.Columns["UrunResmi"].DisplayIndex = 0;

            // Resim hücrelerinin boyutunu ve düzenini ayarlıyoruz
            foreach (DataGridViewRow row in buyableThingsDataGridView.Rows)
            {
                DataGridViewImageCell imageCell = row.Cells["UrunResmi"] as DataGridViewImageCell;
                if (imageCell != null)
                {
                    imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;  // Resmi hücreye sığdırarak büyüt
                }
            }

            // DataGridView'in sütunlarının boyutlarını ayarlayalım
            buyableThingsDataGridView.AutoResizeColumns();
        }

        private void buyableThingsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (buyableThingsDataGridView.SelectedRows.Count > 0)
            {
                // Seçili satırı alıyoruz
                DataGridViewRow selectedRow = buyableThingsDataGridView.SelectedRows[0];
                int urunId = Convert.ToInt32(selectedRow.Cells["UrunID"].Value);

                // Resim verisini almak için SQL sorgusu
                string connectionString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";
                string query = "SELECT UrunResmi FROM Urunler WHERE UrunID = @UrunID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UrunID", urunId);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar(); // Resmi alıyoruz

                        if (result != DBNull.Value)
                        {
                            byte[] urunResmi = (byte[])result;

                            if (urunResmi != null && urunResmi.Length > 0)
                            {
                                try
                                {
                                    // MemoryStream ile resmi yükleyip PictureBox'a atıyoruz
                                    using (MemoryStream ms = new MemoryStream(urunResmi))
                                    {
                                        Image img = Image.FromStream(ms);
                                        productPictureBox.Image = img;  // Resmi doğrudan PictureBox'a yükle
                                        productPictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Resmi sığdırarak göster
                                        productPictureBox.Width = 300; // Örneğin, genişliği 300px yapalım
                                        productPictureBox.Height = 300; // Yüksekliği 300px yapalım

                                        productPictureBox.Invalidate();  // PictureBox'ı yeniden çiz
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Resim yüklenirken hata oluştu: {ex.Message}");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bu ürüne ait resim bulunamadı.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Veritabanında resim verisi bulunamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Veritabanı hatası: {ex.Message}");
                    }
                }
            }
        }


        private void basketListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedKategori = filterComboBox.SelectedItem.ToString();
            if (selectedKategori == "Tüm Kategoriler")
            {
                selectedKategori = null;
            }

            DataTable urunlerTablo = UrunleriGetir(selectedKategori, searchTextBox.Text);
            buyableThingsDataGridView.DataSource = urunlerTablo;
        }

        private void productPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = searchTextBox.Text;
            DataTable urunlerTablo = UrunleriGetir(filterComboBox.SelectedItem.ToString() == "Tüm Kategoriler" ? null : filterComboBox.SelectedItem.ToString(), aramaMetni);
            buyableThingsDataGridView.DataSource = urunlerTablo;
        }

        private void addToBasketButton_Click(object sender, EventArgs e)
        {
            if (buyableThingsDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = buyableThingsDataGridView.SelectedRows[0];
                string urunAdi = selectedRow.Cells["UrunAdi"].Value.ToString();
                decimal fiyat = Convert.ToDecimal(selectedRow.Cells["Fiyat"].Value);

                // Sepete ürünü ekle
                basketListBox.Items.Add($"{urunAdi} - {fiyat:C}");
                toplamFiyat += fiyat; // Global toplam fiyat değişkenini güncelle
                totalPriceLabel.Text = $"Toplam Fiyat: {toplamFiyat:C}";
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            foreach (var item in basketListBox.Items)
            {
                // İşlemi burada gerçekleştirin, örn. stok güncelleme
            }

            MessageBox.Show("Satın alma işlemi başarılı!");
            basketListBox.Items.Clear();
            toplamFiyat = 0;
            totalPriceLabel.Text = "Toplam Fiyat: 0";
        }

        private void totalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu(KullaniciID);
            anaMenu.Show();
            this.Close();
        }
    }
}
