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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
            DisplayAgents();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void DisplayAgents()
        {
            Con.Open();
            string Query = "select * from AgentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AgentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            ANameTb.Text = "";
            APhoneTb.Text = "";
            APasswordTb.Text = "";
            AAddressTb.Text = "";
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APhoneTb.Text == "" || APasswordTb.Text == "" || AAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AgentTbl(AName,APhone,APassword,AAddress)values(@AN,@APH,@AP,@AA)", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APH", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AP", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent added!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select the Agent");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AgentTbl where AId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent removed!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void AgentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = AgentDGV.SelectedRows[0];
            ANameTb.Text = AgentDGV.SelectedRows[0].Cells[1].Value.ToString();
            APhoneTb.Text = AgentDGV.SelectedRows[0].Cells[2].Value.ToString();
            APasswordTb.Text = AgentDGV.SelectedRows[0].Cells[3].Value.ToString();
            AAddressTb.Text = AgentDGV.SelectedRows[0].Cells[4].Value.ToString();
            Key = string.IsNullOrEmpty(ANameTb.Text) ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
            if (ANameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(AgentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ANameTb.Text == "" || APhoneTb.Text == "" || APasswordTb.Text == "" || AAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AgentTbl set AName=@AN,APhone=@APH,APassword=@AP,AAddress=@AA where AId=@AKey", Con);
                    cmd.Parameters.AddWithValue("@AN", ANameTb.Text);
                    cmd.Parameters.AddWithValue("@APH", APhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AP", APasswordTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Agent updated!");
                    Con.Close();
                    Reset();
                    DisplayAgents();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsLbl_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
