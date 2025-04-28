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
using static AccureBank2.Login;

namespace AccureBank2
{
    public partial class AddAccounts : Form
    {
        public AddAccounts()
        {
            InitializeComponent();
            AccountDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DisplayAccounts();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");
        private void DisplayAccounts()
        {
            Con.Open();
            string Query = "select * from AccountTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            AccountDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            AcNameTb.Text = "";
            AcPhoneTb.Text = "";
            AcAddressTb.Text = "";
            GenderCb.SelectedIndex = -1;
            OccupationTb.Text = "";
            EducationCb.SelectedIndex = -1;
            IncomeTb.Text = "";
            Key = 0;
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenderCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AccountTbl(AcName,AcPhone,AcAddress,AcGender,AcOccupation,AcEducation,AcIncome,AcBalance)values(@AN,@AP,@AA,@AG,@AO,@AE,@AI,@AB)", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AB", 0);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account created!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
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
                MessageBox.Show("Select the Account");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AccountTbl where AcNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account deleted!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void AccountDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row based on the clicked cell
                DataGridViewRow selectedRow = AccountDGV.Rows[e.RowIndex];
                AcNameTb.Text = AccountDGV.SelectedRows[0].Cells[1].Value.ToString();
                AcPhoneTb.Text = AccountDGV.SelectedRows[0].Cells[2].Value.ToString();
                AcAddressTb.Text = AccountDGV.SelectedRows[0].Cells[3].Value.ToString();
                GenderCb.SelectedItem = AccountDGV.SelectedRows[0].Cells[4].Value.ToString();
                OccupationTb.Text = AccountDGV.SelectedRows[0].Cells[5].Value.ToString();
                EducationCb.SelectedItem = AccountDGV.SelectedRows[0].Cells[6].Value.ToString();
                IncomeTb.Text = AccountDGV.SelectedRows[0].Cells[7].Value.ToString();
                Key = string.IsNullOrEmpty(AcNameTb.Text) ? 0 : Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                if (AcNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(AccountDGV.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (AcNameTb.Text == "" || AcPhoneTb.Text == "" || AcAddressTb.Text == "" || GenderCb.SelectedIndex == -1 || OccupationTb.Text == "" || EducationCb.SelectedIndex == -1 || IncomeTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcName=@AN,AcPhone=@AP,AcAddress=@AA,AcGender=@AG,AcOccupation=@AO,AcEducation=@AE,AcIncome=@AI where AcNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AN", AcNameTb.Text);
                    cmd.Parameters.AddWithValue("@AP", AcPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@AA", AcAddressTb.Text);
                    cmd.Parameters.AddWithValue("@AG", GenderCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AO", OccupationTb.Text);
                    cmd.Parameters.AddWithValue("@AE", EducationCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@AI", IncomeTb.Text);
                    cmd.Parameters.AddWithValue("@AcKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account updated!");
                    Con.Close();
                    Reset();
                    DisplayAccounts();
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

        private void pictureBox1_Click(object sender, EventArgs e)
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
            Transactions Obj = new Transactions();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
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
