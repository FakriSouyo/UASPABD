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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Pabd1
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=FAKRIE\FAKRI;Initial Catalog=RentCar;User ID=sa;Password=123");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            String username, user_pass;

            username = txt_Username.Text;
            user_pass = txt_Password.Text;

            try
            {
                string query = "SELECT * FROM Login WHERE Username = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", txt_Username.Text);
                cmd.Parameters.AddWithValue("@password", txt_Password.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0 )
                {
                    username = txt_Username.Text;
                    user_pass = txt_Password.Text;

                    //page
                    Menu form2 = new Menu();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("invalid details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Username.Clear();
                    txt_Password.Clear();

                    txt_Username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Account");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
