using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Bunifu.Framework.UI;
using System.Data.SqlClient;

namespace Pabd1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            FILLDG();
            FILLDG3();


        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentCarDataSet4.Unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.rentCarDataSet4.Unit);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Dashboard");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("CRUD");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Unit");
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Information");
        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InformationPage_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button5_Click(object sender, EventArgs e)


        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM RentData where No = @No", conn);
            cmd.Parameters.AddWithValue("@No", int.Parse(text_cari.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            DataGridView1.DataSource = dt;
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand(" insert into RentData values (@No,@Nama,@Alamat,@NoTelpon,@Unit,@Lama,@Mulai_sewa,@Akhir_sewa,@Status) ", conn);
            cmd.Parameters.AddWithValue("@No", int.Parse(text_No.Text));
            cmd.Parameters.AddWithValue("@Nama",text_nama.Text);
            cmd.Parameters.AddWithValue("@Alamat", text_alamat.Text);
            cmd.Parameters.AddWithValue("@NoTelpon", text_telp.Text);

            string selectedUnit = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Unit", selectedUnit);

            cmd.Parameters.AddWithValue("@Lama", text_lama.Text);
            cmd.Parameters.AddWithValue("@Mulai_sewa", DatePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Akhir_sewa", DatePicker2.Value.ToString("yyyy-MM-dd"));

            string selectedStatus = comboBox2.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Status", selectedStatus);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Berhasil Di Tambahkan");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update RentData set Nama=@Nama, Alamat=@Alamat, NoTelpon=@NoTelpon, Unit=@Unit, lama=@Lama, Mulai_sewa=@Mulai_sewa, Akhir_sewa=@Akhir_sewa, Status=@Status where No = @No ", conn);

            cmd.Parameters.AddWithValue("@No", int.Parse(text_No.Text));
            cmd.Parameters.AddWithValue("@Nama", text_nama.Text);
            cmd.Parameters.AddWithValue("@Alamat", text_alamat.Text);
            cmd.Parameters.AddWithValue("@NoTelpon", text_telp.Text);

            string selectedUnit = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Unit", selectedUnit);

            cmd.Parameters.AddWithValue("@Lama", text_lama.Text);
            cmd.Parameters.AddWithValue("@Mulai_sewa", DatePicker1.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@Akhir_sewa", DatePicker2.Value.ToString("yyyy-MM-dd"));

            string selectedStatus = comboBox2.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Status", selectedStatus);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Berhasil Di Update");
        }

        private void bunifuButton9_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM RentData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridView2.DataSource = dt;
        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete RentData where No = @No ", conn);
            cmd.Parameters.AddWithValue("@No", int.Parse(text_No.Text));
            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Berhasil Di Hapus");
        }

        private void FILLDG()

        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            string query = "Select * From RentData";
            SqlDataAdapter sda = new SqlDataAdapter( query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridView1.DataSource = dt;
            conn.Close();

        }

        private void text_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Unit", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataGridView3.DataSource = dt;
        }

        private void FILLDG3()

        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            string query = "Select * From Unit";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DataGridView3.DataSource = dt;
            conn.Close();

        }

        private void DataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Unit set Nama_Unit=@Nama_Unit, jml_digunakan=@jml_digunakan, jml_dibooking=@jml_dibooking where id_unit = @id_unit ", conn);

            cmd.Parameters.AddWithValue("@id_unit", int.Parse(ID.Text));
            cmd.Parameters.AddWithValue("@jml_digunakan", text_digunakan.Text);
            cmd.Parameters.AddWithValue("@jml_dibooking", text_dibooking.Text);

            string selectedInit = comboBox3.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Nama_unit", selectedInit);

           

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Berhasil Di Update");
        }
    }
}
