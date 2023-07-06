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
            // TODO: This line of code loads data into the 'rentCarDataSet2.RentData' table. You can move, or remove it, as needed.
            this.rentDataTableAdapter1.Fill(this.rentCarDataSet2.RentData);
            // TODO: This line of code loads data into the 'rentCarDataSet1.RentData' table. You can move, or remove it, as needed.
            this.rentDataTableAdapter.Fill(this.rentCarDataSet1.RentData);

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
    }
}
