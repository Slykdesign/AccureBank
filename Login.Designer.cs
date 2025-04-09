namespace AccureBank2
{
    partial class Login
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
            panel1 = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            UsernameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordTb = new TextBox();
            pictureBox1 = new PictureBox();
            LoginBtn = new Button();
            RoleCb = new ComboBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 426);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 276);
            label4.Name = "label4";
            label4.Size = new Size(206, 36);
            label4.TabIndex = 59;
            label4.Text = "Hayden M. Slyk";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bank;
            pictureBox4.Location = new Point(46, 72);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(170, 198);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(402, 9);
            label1.Name = "label1";
            label1.Size = new Size(311, 70);
            label1.TabIndex = 2;
            label1.Text = "AccureBank";
            // 
            // UsernameTb
            // 
            UsernameTb.Location = new Point(390, 188);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(346, 27);
            UsernameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(268, 188);
            label2.Name = "label2";
            label2.Size = new Size(109, 29);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(268, 230);
            label3.Name = "label3";
            label3.Size = new Size(109, 29);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(390, 230);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(346, 27);
            PasswordTb.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2025_03_27_171629_removebg_preview;
            pictureBox1.Location = new Point(522, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(467, 276);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(189, 51);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RoleCb
            // 
            RoleCb.FormattingEnabled = true;
            RoleCb.Items.AddRange(new object[] { "Admin", "Agent" });
            RoleCb.Location = new Point(390, 144);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(346, 28);
            RoleCb.TabIndex = 36;
            RoleCb.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(522, 341);
            label5.Name = "label5";
            label5.Size = new Size(62, 29);
            label5.TabIndex = 38;
            label5.Text = "Reset";
            label5.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.close1;
            pictureBox3.Location = new Point(801, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 426);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(RoleCb);
            Controls.Add(LoginBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(PasswordTb);
            Controls.Add(label2);
            Controls.Add(UsernameTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox UsernameTb;
        private Label label2;
        private Label label3;
        private TextBox PasswordTb;
        private PictureBox pictureBox1;
        private Button LoginBtn;
        private PictureBox pictureBox2;
        private ComboBox RoleCb;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label4;
    }
}