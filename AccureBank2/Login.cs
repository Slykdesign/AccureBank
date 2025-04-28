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
    public static class UserSession
    {
        public static string Role { get; set; } // "Admin" or "Agent"
    }

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
            else if (RoleCb.SelectedIndex == 0) // Admin
            {
                if (IsValidAdmin(UsernameTb.Text, PasswordTb.Text))
                {
                    UserSession.Role = "Admin"; // Store role
                    MainMenu adminMenu = new MainMenu();
                    adminMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials!");
                }
            }
            else if (RoleCb.SelectedIndex == 1) // Agent
            {
                if (IsValidAgent(UsernameTb.Text, PasswordTb.Text))
                {
                    UserSession.Role = "Agent"; // Store role
                    MainMenu2 agentMenu = new MainMenu2();
                    agentMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid agent credentials!");
                }
            }
        }

        private bool IsValidAdmin(string username, string password)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT COUNT(*) FROM AdminTbl WHERE AdName = '{username}' AND AdPassword = '{password}'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0][0].ToString() == "1";
        }

        private bool IsValidAgent(string username, string password)
        {
            SqlDataAdapter sda = new SqlDataAdapter($"SELECT COUNT(*) FROM AgentTbl WHERE AName = '{username}' AND APassword = '{password}'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows[0][0].ToString() == "1";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
