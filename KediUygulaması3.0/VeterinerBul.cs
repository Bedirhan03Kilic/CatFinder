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
    public partial class VeterinerBul : Form
    {
        private int kullaniciID; // Kullanıcı ID'si bu formda saklanacak
        private string kullaniciSehir; // Kullanıcının mevcut şehri

        public VeterinerBul(int id)
        {
            InitializeComponent();
            kullaniciID = id;
        }

        private void VeterinerBul_Load(object sender, EventArgs e)
        {
            KullaniciSehriGetir();
            VeterinerleriYukle(kullaniciSehir);

        }
        private void KullaniciSehriGetir()
        {
            string connString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT Sehir FROM Kullanici WHERE KullaniciID = @KullaniciID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@KullaniciID", kullaniciID);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kullaniciSehir = reader["Sehir"].ToString();
                }
                reader.Close();
            }
        }
        private void VeterinerleriYukle(string sehir)
        {
            string connString = "Data Source=BEDIRHAN\\SQLEXPRESS;Initial Catalog=KediUygulama;Integrated Security=True;Encrypt=False";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Şehir ve adres bilgisini ekledik
                string query = "SELECT VeterinerAdi AS 'Veteriner Adı', Adres, TelefonNo AS 'Telefon Numarası', Sehir AS 'Konum' FROM Veterinerler WHERE Sehir = @Sehir";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Sehir", sehir);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // DataGridView'e verileri bağla
                cityDataGriew.DataSource = dataTable;
            }
        }

        private void cityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = cityComboBox.Text.Trim();
            if (!string.IsNullOrEmpty(selectedCity))
            {
                VeterinerleriYukle(selectedCity);
            }
        }

        private void cityDataGriew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backToMainMenuButton_Click(object sender, EventArgs e)
        {
            AnaMenu anaMenu = new AnaMenu(kullaniciID);
            anaMenu.Show();
            this.Close();
        }
    }
}
