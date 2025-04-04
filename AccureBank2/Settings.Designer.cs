namespace AccureBank2
{
    partial class Settings
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
            label10 = new Label();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            NewPasswordTb = new TextBox();
            label2 = new Label();
            ThemeCb = new ComboBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label5 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Location = new Point(-4, -74);
            panel1.Name = "panel1";
            panel1.Size = new Size(125, 649);
            panel1.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(14, 152);
            label10.Name = "label10";
            label10.Size = new Size(102, 23);
            label10.TabIndex = 67;
            label10.Text = "Main Menu";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.accoint;
            pictureBox5.Location = new Point(27, 262);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(70, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 63;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(7, 319);
            label11.Name = "label11";
            label11.Size = new Size(112, 23);
            label11.TabIndex = 66;
            label11.Text = "Transactions";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.transactions;
            pictureBox1.Location = new Point(27, 345);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.bank;
            pictureBox4.Location = new Point(27, 178);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(70, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 65;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.settings;
            pictureBox3.Location = new Point(16, 80);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(88, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(408, 12);
            label1.Name = "label1";
            label1.Size = new Size(142, 48);
            label1.TabIndex = 24;
            label1.Text = "Settings";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 88);
            label4.Name = "label4";
            label4.Size = new Size(230, 29);
            label4.TabIndex = 26;
            label4.Text = "Admin New Password:";
            // 
            // NewPasswordTb
            // 
            NewPasswordTb.Location = new Point(234, 120);
            NewPasswordTb.Multiline = true;
            NewPasswordTb.Name = "NewPasswordTb";
            NewPasswordTb.Size = new Size(382, 59);
            NewPasswordTb.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 197);
            label2.Name = "label2";
            label2.Size = new Size(79, 29);
            label2.TabIndex = 29;
            label2.Text = "Theme:";
            // 
            // ThemeCb
            // 
            ThemeCb.FormattingEnabled = true;
            ThemeCb.Items.AddRange(new object[] { "Red", "Blue", "Green", "Black", "Hot Pink" });
            ThemeCb.Location = new Point(234, 229);
            ThemeCb.Name = "ThemeCb";
            ThemeCb.Size = new Size(382, 28);
            ThemeCb.TabIndex = 35;
            // 
            // button1
            // 
            button1.BackColor = Color.ForestGreen;
            button1.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(659, 120);
            button1.Name = "button1";
            button1.Size = new Size(115, 38);
            button1.TabIndex = 36;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.close1;
            pictureBox2.Location = new Point(880, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(659, 229);
            button2.Name = "button2";
            button2.Size = new Size(115, 38);
            button2.TabIndex = 39;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(457, 315);
            label5.Name = "label5";
            label5.Size = new Size(62, 29);
            label5.TabIndex = 40;
            label5.Text = "Reset";
            label5.Click += label5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(23, 235);
            label15.Name = "label15";
            label15.Size = new Size(81, 23);
            label15.TabIndex = 68;
            label15.Text = "Accounts";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 500);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(ThemeCb);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(NewPasswordTb);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox NewPasswordTb;
        private Label label2;
        private ComboBox ThemeCb;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label10;
        private PictureBox pictureBox5;
        private Label label11;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private Label label15;
    }
}