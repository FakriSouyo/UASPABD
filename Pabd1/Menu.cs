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
          
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Dashboard");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("Paymenthistory");
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
            SqlCommand cmd = new SqlCommand("SELECT * FROM RentData", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand(" insert into RentData values (@No,@Nama,@Alamat,@NoTelpon,@Unit,@Lama,@Mulai,@Akhir,@Status) ", conn);
            cmd.Parameters.AddWithValue("@No", int.Parse(text_No.Text));
            cmd.Parameters.AddWithValue("@Nama",text_nama.Text);
            cmd.Parameters.AddWithValue("@Alamat", text_alamat.Text);
            cmd.Parameters.AddWithValue("@NoTelpon", text_telp.Text);

            string selectedUnit = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Unit", selectedUnit);

            cmd.Parameters.AddWithValue("@Lama", text_lama.Text);
            cmd.Parameters.AddWithValue("@Mulai", DatePicker1.Value);
            cmd.Parameters.AddWithValue("@Akhir", DatePicker2.Value);

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

        private void bunifuButton8_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM RentData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataGridView1.DataSource = dt;
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update RentData set Nama=@Nama, Alamat=@Alamat, No Telp=@NoTelpon, Unit=@Unit, lama=@Lama, Mulai=@Mulai, Akhir=@Akhir, Status=@Status where No = @No ", conn);

            cmd.Parameters.AddWithValue("@No", int.Parse(text_No.Text));
            cmd.Parameters.AddWithValue("@Nama", text_nama.Text);
            cmd.Parameters.AddWithValue("@Alamat", text_alamat.Text);
            cmd.Parameters.AddWithValue("@NoTelpon", text_telp.Text);

            string selectedUnit = comboBox1.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Unit", selectedUnit);

            cmd.Parameters.AddWithValue("@Lama", text_lama.Text);
            cmd.Parameters.AddWithValue("@Mulai", DatePicker1.Value);
            cmd.Parameters.AddWithValue("@Akhir", DatePicker2.Value);

            string selectedStatus = comboBox2.SelectedItem.ToString();
            cmd.Parameters.AddWithValue("@Status", selectedStatus);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Berhasil Di Update");
        }
    }
}
