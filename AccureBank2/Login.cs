using Microsoft.Data.SqlClient;
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

namespace AccureBank2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");

        private void label5_Click(object sender, EventArgs e)
        {
            UsernameTb.Text = "";
            PasswordTb.Text = "";
            RoleCb.SelectedIndex = -1;
            RoleCb.Text = "";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (RoleCb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Role");
            }
            else if (RoleCb.SelectedIndex == 0)
            {
                if (UsernameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter both admin name and password!");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AdminTbl where AdName = '" + UsernameTb.Text + "' and AdPassword = '" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong admin name or password!");
                        UsernameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }
            else
            {
                if (UsernameTb.Text == "" || PasswordTb.Text == "")
                {
                    MessageBox.Show("Enter both user name and password!");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AgentTbl where AName = '" + UsernameTb.Text + "' and APassword = '" + PasswordTb.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        MainMenu Obj = new MainMenu();
                        Obj.Show();
                        this.Hide();
                        Con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong user name or password!");
                        UsernameTb.Text = "";
                        PasswordTb.Text = "";
                    }
                    Con.Close();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
