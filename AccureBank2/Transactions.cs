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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");
        int Balance;
        private void CheckBalance()
        {
            Con.Open();
            string Query = "select * from AccountTbl where AcNum = " + CheckBalTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLbl.Text = "$" + dr["AcBalance"].ToString();
                Balance = Convert.ToInt32(dr["AcBalance"].ToString());
            }
            Con.Close();
        }

        private void CheckAvailableBalance()
        {
            //Con.Open();
            string Query = "select * from AccountTbl where AcNum = " + FromTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLabel.Text = "$" + dr["AcBalance"].ToString();
                Balance = Convert.ToInt32(dr["AcBalance"].ToString());
            }
            //Con.Close();
        }

        private void GetNewBalance(string text)
        {
            Con.Open();
            string Query = "select * from AccountTbl where AcNum = " + CheckBalTb.Text + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            cmd.Parameters.AddWithValue("@AcNum", CheckBalTb.Text);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BalanceLbl.Text = "$" + dr["AcBalance"].ToString();
                Balance = Convert.ToInt32(dr["AcBalance"].ToString());
            }
            Con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBalBtn_Click(object sender, EventArgs e)
        {
            if (CheckBalTb.Text == "")
            {
                MessageBox.Show("Enter account number");
            }
            else
            {
                CheckBalance();
                if (BalanceLbl.Text == "")
                {
                    MessageBox.Show("Account not found");
                    CheckBalTb.Text = "";
                }
            }
        }

        private void Deposit()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmount,TAcNum)values(@TN,@TD,@TA,@TAN)", Con);
                cmd.Parameters.AddWithValue("@TN", "Deposit");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", DepAmountTb.Text);
                cmd.Parameters.AddWithValue("@TAN", DepAccountTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }
        private void Withdraw()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into TransactionTbl(TName,TDate,TAmount,TAcNum)values(@TN,@TD,@TA,@TAN)", Con);
                cmd.Parameters.AddWithValue("@TN", "Withdrawn");
                cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@TA", WdAmountTb.Text);
                cmd.Parameters.AddWithValue("@TAN", WdAccountTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                Con.Close();
            }
        }

        private void AddBalance()
        {
            GetNewBalance(ToTb.Text);
            int newBalance = Balance + Convert.ToInt32(TransAmountTb.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBalance=@AB where AcNum=@AcKey", Con);
                cmd.Parameters.AddWithValue("@AB", newBalance);
                cmd.Parameters.AddWithValue("@AcKey", ToTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void SubtractBalance()
        {
            GetNewBalance(FromTb.Text);
            int newBalance = Balance - Convert.ToInt32(TransAmountTb.Text);
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBalance=@AB where AcNum=@AcKey", Con);
                cmd.Parameters.AddWithValue("@AB", newBalance);
                cmd.Parameters.AddWithValue("@AcKey", FromTb.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            if (DepAccountTb.Text == "" || DepAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                Deposit();
                GetNewBalance(DepAmountTb.Text);
                int newBalance = Balance + Convert.ToInt32(DepAmountTb.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBalance=@AB where AcNum=@AcKey", Con);
                    cmd.Parameters.AddWithValue("@AB", newBalance);
                    cmd.Parameters.AddWithValue("@AcKey", DepAccountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Money deposited!");
                    Con.Close();
                    DepAmountTb.Text = "";
                    DepAccountTb.Text = "";
                    BalanceLbl.Text = "Your Balance";
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            if (WdAccountTb.Text == "" || WdAmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                GetNewBalance(WdAmountTb.Text);
                Withdraw();
                if (Balance < Convert.ToInt32(WdAmountTb.Text))
                {
                    MessageBox.Show("Insufficient Balance");
                }
                else
                {
                    int newBalance = Balance - Convert.ToInt32(WdAmountTb.Text);
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("Update AccountTbl set AcBalance=@AB where AcNum=@AcKey", Con);
                        cmd.Parameters.AddWithValue("@AB", newBalance);
                        cmd.Parameters.AddWithValue("@AcKey", WdAccountTb.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Money withdrawn!");
                        Con.Close();
                        WdAmountTb.Text = "";
                        WdAccountTb.Text = "";
                        BalanceLbl.Text = "Your Balance";
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (FromTb.Text == "")
            {
                MessageBox.Show("Enter source account!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AcNum = '" + FromTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Account does not exist");
                    FromTb.Text = "";
                }
                Con.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "")
            {
                MessageBox.Show("Enter destination account!");
            }
            else
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from AccountTbl where AcNum = '" + ToTb.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    CheckAvailableBalance();
                    MessageBox.Show("Account found");
                    Con.Close();
                    if (ToTb.Text == FromTb.Text)
                    {
                        MessageBox.Show("Cannot transfer to the same account");
                        ToTb.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Account does not exist");
                    ToTb.Text = "";
                }
                Con.Close();
            }
        }

        private void Transfer()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into TransferTbl(TrSource,TrDestination,TrAmount,TrDate)values(@TS,@TDS,@TA,@TD)", Con);
            cmd.Parameters.AddWithValue("@TS", FromTb.Text);
            cmd.Parameters.AddWithValue("@TDS", ToTb.Text);
            cmd.Parameters.AddWithValue("@TA", TransAmountTb.Text);
            cmd.Parameters.AddWithValue("@TD", DateTime.Now.Date);
            cmd.ExecuteNonQuery();

            // Update the source account balance
            SqlCommand updateSourceCmd = new SqlCommand("Update AccountTbl set AcBalance = AcBalance - @TA where AcNum = @TS", Con);
            updateSourceCmd.Parameters.AddWithValue("@TA", TransAmountTb.Text);
            updateSourceCmd.Parameters.AddWithValue("@TS", FromTb.Text);
            updateSourceCmd.ExecuteNonQuery();

            // Update the destination account balance
            SqlCommand updateDestCmd = new SqlCommand("Update AccountTbl set AcBalance = AcBalance + @TA where AcNum = @TDS", Con);
            updateDestCmd.Parameters.AddWithValue("@TA", TransAmountTb.Text);
            updateDestCmd.Parameters.AddWithValue("@TDS", ToTb.Text);
            updateDestCmd.ExecuteNonQuery();

            MessageBox.Show("Transfer successful!");
            Con.Close();
        }
        private void TransferBtn_Click(object sender, EventArgs e)
        {
            if (ToTb.Text == "" || FromTb.Text == "" || TransAmountTb.Text == "")
            {
                MessageBox.Show("Missing information!");
            }
            else if (Convert.ToInt16(TransAmountTb.Text) > Balance)
            {
                MessageBox.Show("Insufficient balance!");
            }
            else
            {
                Transfer();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            BalanceLbl.Text = "Your Balance"; // Reset the label text
            CheckBalTb.Text = ""; // Optionally clear the account number textbox
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionHistory transactionHistoryForm = new TransactionHistory();
            transactionHistoryForm.Show();
            this.Hide();
        }
    }
}