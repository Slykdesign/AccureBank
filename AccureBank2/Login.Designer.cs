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
            pictureBox4 = new PictureBox();
            label1 = new Label();
            UsernameTb = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PasswordTb = new TextBox();
            LoginBtn = new Button();
            RoleCb = new ComboBox();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Screenshot_2025_03_27_171629_removebg_preview;
            pictureBox4.Location = new Point(12, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(85, 81);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 12);
            label1.Name = "label1";
            label1.Size = new Size(237, 51);
            label1.TabIndex = 2;
            label1.Text = "AccureBank";
            // 
            // UsernameTb
            // 
            UsernameTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameTb.Location = new Point(244, 188);
            UsernameTb.Name = "UsernameTb";
            UsernameTb.Size = new Size(346, 27);
            UsernameTb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 187);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(124, 230);
            label3.Name = "label3";
            label3.Size = new Size(108, 26);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // PasswordTb
            // 
            PasswordTb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordTb.Location = new Point(244, 230);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.PasswordChar = '*';
            PasswordTb.Size = new Size(346, 27);
            PasswordTb.TabIndex = 5;
            // 
            // LoginBtn
            // 
            LoginBtn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginBtn.Location = new Point(321, 276);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(189, 51);
            LoginBtn.TabIndex = 12;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // RoleCb
            // 
            RoleCb.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoleCb.FormattingEnabled = true;
            RoleCb.Items.AddRange(new object[] { "Admin", "Agent" });
            RoleCb.Location = new Point(244, 144);
            RoleCb.Name = "RoleCb";
            RoleCb.Size = new Size(346, 27);
            RoleCb.TabIndex = 36;
            RoleCb.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(384, 341);
            label5.Name = "label5";
            label5.Size = new Size(62, 26);
            label5.TabIndex = 38;
            label5.Text = "Reset";
            label5.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.close1;
            pictureBox3.Location = new Point(655, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 58;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(110, 410);
            panel1.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(696, 410);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(RoleCb);
            Controls.Add(LoginBtn);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox UsernameTb;
        private Label label2;
        private Label label3;
        private TextBox PasswordTb;
        private Button LoginBtn;
        private PictureBox pictureBox2;
        private ComboBox RoleCb;
        private Label label5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel1;
    }
}