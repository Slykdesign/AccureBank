namespace AccureBank2
{
    partial class Agents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            CancelBtn = new Button();
            EditBtn = new Button();
            SubmitBtn = new Button();
            label6 = new Label();
            AAddressTb = new TextBox();
            label5 = new Label();
            APhoneTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ANameTb = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            APasswordTb = new TextBox();
            AgentDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            SettingsLbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.Red;
            CancelBtn.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CancelBtn.ForeColor = Color.Transparent;
            CancelBtn.Location = new Point(786, 242);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(115, 38);
            CancelBtn.TabIndex = 56;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(128, 128, 255);
            EditBtn.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditBtn.ForeColor = Color.Transparent;
            EditBtn.Location = new Point(422, 242);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(115, 38);
            EditBtn.TabIndex = 55;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.ForestGreen;
            SubmitBtn.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubmitBtn.ForeColor = Color.White;
            SubmitBtn.Location = new Point(607, 242);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(115, 38);
            SubmitBtn.TabIndex = 54;
            SubmitBtn.Text = "Submit";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(254, 209);
            label6.Name = "label6";
            label6.Size = new Size(91, 29);
            label6.TabIndex = 48;
            label6.Text = "Address:";
            // 
            // AAddressTb
            // 
            AAddressTb.Location = new Point(351, 209);
            AAddressTb.Name = "AAddressTb";
            AAddressTb.Size = new Size(681, 27);
            AAddressTb.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(755, 155);
            label5.Name = "label5";
            label5.Size = new Size(109, 29);
            label5.TabIndex = 46;
            label5.Text = "Password:";
            // 
            // APhoneTb
            // 
            APhoneTb.Location = new Point(597, 157);
            APhoneTb.Name = "APhoneTb";
            APhoneTb.Size = new Size(141, 27);
            APhoneTb.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(511, 155);
            label3.Name = "label3";
            label3.Size = new Size(80, 29);
            label3.TabIndex = 44;
            label3.Text = "Phone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(254, 155);
            label4.Name = "label4";
            label4.Size = new Size(71, 29);
            label4.TabIndex = 43;
            label4.Text = "Name:";
            // 
            // ANameTb
            // 
            ANameTb.Location = new Point(351, 157);
            ANameTb.Name = "ANameTb";
            ANameTb.Size = new Size(142, 27);
            ANameTb.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(561, 12);
            label1.Name = "label1";
            label1.Size = new Size(258, 48);
            label1.TabIndex = 41;
            label1.Text = "Manage Agents";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(-19, -26);
            panel1.Name = "panel1";
            panel1.Size = new Size(128, 649);
            panel1.TabIndex = 40;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.transactions;
            pictureBox4.Location = new Point(31, 38);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(80, 75);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // APasswordTb
            // 
            APasswordTb.Location = new Point(870, 155);
            APasswordTb.Name = "APasswordTb";
            APasswordTb.Size = new Size(162, 27);
            APasswordTb.TabIndex = 60;
            // 
            // AgentDGV
            // 
            dataGridViewCellStyle7.BackColor = Color.White;
            AgentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.DarkOrange;
            dataGridViewCellStyle8.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            AgentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            AgentDGV.ColumnHeadersHeight = 25;
            AgentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            AgentDGV.DefaultCellStyle = dataGridViewCellStyle9;
            AgentDGV.GridColor = Color.FromArgb(231, 229, 255);
            AgentDGV.Location = new Point(115, 305);
            AgentDGV.Name = "AgentDGV";
            AgentDGV.RowHeadersVisible = false;
            AgentDGV.RowHeadersWidth = 51;
            AgentDGV.RowTemplate.Height = 24;
            AgentDGV.Size = new Size(1116, 279);
            AgentDGV.TabIndex = 61;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            AgentDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            AgentDGV.ThemeStyle.BackColor = Color.White;
            AgentDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            AgentDGV.ThemeStyle.HeaderStyle.BackColor = Color.DarkOrange;
            AgentDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            AgentDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgentDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            AgentDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            AgentDGV.ThemeStyle.HeaderStyle.Height = 25;
            AgentDGV.ThemeStyle.ReadOnly = false;
            AgentDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            AgentDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            AgentDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgentDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            AgentDGV.ThemeStyle.RowsStyle.Height = 24;
            AgentDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            AgentDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            AgentDGV.CellContentClick += AgentDGV_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.close1;
            pictureBox2.Location = new Point(1198, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.settings;
            pictureBox3.Location = new Point(115, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(68, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 63;
            pictureBox3.TabStop = false;
            // 
            // SettingsLbl
            // 
            SettingsLbl.AutoSize = true;
            SettingsLbl.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SettingsLbl.Location = new Point(189, 37);
            SettingsLbl.Name = "SettingsLbl";
            SettingsLbl.Size = new Size(70, 23);
            SettingsLbl.TabIndex = 64;
            SettingsLbl.Text = "Settings";
            SettingsLbl.Click += SettingsLbl_Click;
            // 
            // Agents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1243, 596);
            Controls.Add(SettingsLbl);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(AgentDGV);
            Controls.Add(APasswordTb);
            Controls.Add(CancelBtn);
            Controls.Add(EditBtn);
            Controls.Add(SubmitBtn);
            Controls.Add(label6);
            Controls.Add(AAddressTb);
            Controls.Add(label5);
            Controls.Add(APhoneTb);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(ANameTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Agents";
            Text = "Agents";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox GenderCb;
        private Button CancelBtn;
        private Button EditBtn;
        private Button SubmitBtn;
        private Label label6;
        private TextBox AAddressTb;
        private Label label5;

        public TextBox APhoneTb;
        private TextBox AcPhoneTb;
        private Label label3;
        private Label label4;
        private TextBox ANameTb;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox4;
        private TextBox APasswordTb;
        private Guna.UI2.WinForms.Guna2DataGridView AgentDGV;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label SettingsLbl;
    }
}