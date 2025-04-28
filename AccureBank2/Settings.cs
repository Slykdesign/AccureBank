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
            else
            {
                // Set the background color based on the selected theme
                if (ThemeCb.SelectedIndex == 0)
                {
                    panel1.BackColor = Color.Red;
                }
                else if (ThemeCb.SelectedIndex == 1)
                {
                    panel1.BackColor = Color.DarkGreen;
                }
                else if (ThemeCb.SelectedIndex == 2)
                {
                    panel1.BackColor = Color.Crimson;
                }
                else if (ThemeCb.SelectedIndex == 3)
                {
                    panel1.BackColor = Color.HotPink;
                }
                else if (ThemeCb.SelectedIndex == 4)
                {
                    panel1.BackColor = Color.DarkOrange;
                }
                else
                {
                    panel1.BackColor = Color.Blue;
                }
                if (panel1.BackColor == Color.Blue || panel1.BackColor == Color.Red || panel1.BackColor == Color.DarkGreen || panel1.BackColor == Color.Crimson)
                {
                    foreach (Control control in panel1.Controls)
                    {
                        if (control is Label || control is Button)
                        {
                            control.ForeColor = Color.White;
                        }
                    }
                }
                else if (panel1.BackColor == Color.HotPink || panel1.BackColor == Color.DarkOrange)
                {
                    foreach (Control control in panel1.Controls)
                    {
                        if (control is Label || control is Button)
                        {
                            control.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Agent") // Check if the user is an agent
            {
                MessageBox.Show("You are not authorized to change this person's password!");
                NewPasswordTb.Text = ""; // Reset the text box
                return;
            }

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
            if (UserSession.Role == "Admin")
            {
                MainMenu adminMenu = new MainMenu();
                adminMenu.Show();
            }
            else if (UserSession.Role == "Agent")
            {
                MainMenu2 agentMenu = new MainMenu2();
                agentMenu.Show();
            }
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            DebitCard Obj = new DebitCard();
            Obj.Show();
            this.Hide();
        }
    }
}