using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccureBank2
{
    public partial class TransferHistory : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");
        public TransferHistory()
        {
            InitializeComponent();
            LoadTranferData();
        }

        private void LoadTranferData()
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM TransferTbl";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                TranferDGV.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Con.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Transactions transactionsForm = new Transactions();
            transactionsForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
