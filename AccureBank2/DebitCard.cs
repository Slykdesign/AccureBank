using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace AccureBank2
{
    public partial class DebitCard : Form
    {
        public DebitCard()
        {
            InitializeComponent();
            ActionCb = comboBox1;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\13309\OneDrive - Youngstown State University\Documents\Bank.Db.mdf"";Integrated Security=True;Connect Timeout=30");

        public ComboBox ActionCb { get; private set; }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "Admin")
            {
                MainMenu adminMenu = new MainMenu();
                adminMenu.Show();
                this.Hide();
            }
            else if (UserSession.Role == "Agent")
            {
                MainMenu2 agentMenu = new MainMenu2();
                agentMenu.Show();
                this.Hide();
            }
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
            Settings Obj = new Settings();
            Obj.Show();
            this.Hide();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            if (ActionCb.SelectedItem == null || string.IsNullOrEmpty(AcNumTb.Text))
            {
                MessageBox.Show("Please select an action and enter an account number.");
                return;
            }

            string action = ActionCb.SelectedItem.ToString();
            switch (action)
            {
                case "Assign":
                    AssignCard();
                    break;
                case "Reassign":
                    ReassignCard();
                    break;
                default:
                    MessageBox.Show("Invalid action selected.");
                    break;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (ActionCb.SelectedItem == null || string.IsNullOrEmpty(AcNumTb.Text))
            {
                MessageBox.Show("Please select an action and enter an account number.");
                return;
            }
            string action = ActionCb.SelectedItem.ToString();
            if (action == "Cancel")
            {
                CancelCard();
            }
            else
            {
                MessageBox.Show("Invalid action selected.");
            }
        }

        private void AssignCard()
        {
            if (string.IsNullOrEmpty(NewCardNumTb.Text))
            {
                MessageBox.Show("Please enter a new card number.");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcDCNum = @CardNum WHERE AcNum = @AcNum", Con);
                cmd.Parameters.AddWithValue("@CardNum", NewCardNumTb.Text);
                cmd.Parameters.AddWithValue("@AcNum", AcNumTb.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Debit card assigned successfully.");
                }
                else
                {
                    MessageBox.Show("Account not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void ReassignCard()
        {
            if (string.IsNullOrEmpty(CardNumTb.Text) || string.IsNullOrEmpty(NewCardNumTb.Text))
            {
                MessageBox.Show("Please enter the current card number and a new card number.");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcDCNum = @NewCardNum WHERE AcNum = @AcNum AND AcDCNum = @CurrentCardNum", Con);
                cmd.Parameters.AddWithValue("@NewCardNum", NewCardNumTb.Text);
                cmd.Parameters.AddWithValue("@AcNum", AcNumTb.Text);
                cmd.Parameters.AddWithValue("@CurrentCardNum", CardNumTb.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Debit card reassigned successfully.");
                }
                else
                {
                    MessageBox.Show("Account or current card number not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void CancelCard()
        {
            if (string.IsNullOrEmpty(CardNumTb.Text))
            {
                MessageBox.Show("Please enter the current card number.");
                return;
            }

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE AccountTbl SET AcDCNum = NULL WHERE AcNum = @AcNum AND AcDCNum = @CurrentCardNum", Con);
                cmd.Parameters.AddWithValue("@AcNum", AcNumTb.Text);
                cmd.Parameters.AddWithValue("@CurrentCardNum", CardNumTb.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                Con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Debit card canceled successfully.");
                }
                else
                {
                    MessageBox.Show("Account or current card number not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Con.Close();
            }
        }

        private void ActionCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ActionCb.SelectedItem != null)
            {
                string selectedAction = ActionCb.SelectedItem.ToString();
                if (selectedAction == "Assign" || selectedAction == "Reassign")
                {
                    NewCardNumTb.Visible = true;
                    CardNumTb.Visible = false;
                }
                else if (selectedAction == "Cancel")
                {
                    NewCardNumTb.Visible = false;
                    CardNumTb.Visible = true;
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this);
        }

        private void ClearTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
                else if (control.HasChildren)
                {
                    ClearTextBoxes(control); // Recursively clear text boxes in child controls
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}