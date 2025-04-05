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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            NewPasswordTb.Text = "";
            ThemeCb.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ThemeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a theme!");
            }
            else if (ThemeCb.SelectedIndex == 0)
            {
                panel1.BackColor = Color.Red;
            }
            else if (ThemeCb.SelectedIndex == 1)
            {
                panel1.BackColor = Color.Blue;
            }
            else if (ThemeCb.SelectedIndex == 2)
            {
                panel1.BackColor = Color.Green;
            }
            else if (ThemeCb.SelectedIndex == 3)
            {
                panel1.BackColor = Color.Black;
            }
            else if (ThemeCb.SelectedIndex == 4)
            {
                panel1.BackColor = Color.HotPink;
            }
            else
            {
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (NewPasswordTb.Text == "")
            {
                MessageBox.Show("Enter new password");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AdminTbl set AdPassword=@AP where AdId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AP", NewPasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AKey", 1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password updated!");
                    Con.Close();
                    NewPasswordTb.Text = "";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddAccounts Obj = new AddAccounts();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BalanceLbl.Text = "Your Balance"; // Reset the label text
            CheckBalTb.Text = ""; // Optionally clear the account number textbox
        }
    }
}
