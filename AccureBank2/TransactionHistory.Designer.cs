namespace AccureBank2
{
    partial class TransactionHistory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            TransactionView = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            TransactionDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            TransactionView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TransactionDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TransactionView
            // 
            TransactionView.BackColor = Color.Goldenrod;
            TransactionView.Controls.Add(pictureBox8);
            TransactionView.Controls.Add(pictureBox3);
            TransactionView.Location = new Point(-15, -16);
            TransactionView.Name = "TransactionView";
            TransactionView.Size = new Size(123, 604);
            TransactionView.TabIndex = 2;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Screenshot_2025_03_27_171629_removebg_preview;
            pictureBox8.Location = new Point(40, 28);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(69, 56);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 67;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.back;
            pictureBox3.Location = new Point(40, 91);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(69, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 66;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // TransactionDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            TransactionDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOrange;
            dataGridViewCellStyle2.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TransactionDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TransactionDGV.ColumnHeadersHeight = 25;
            TransactionDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TransactionDGV.DefaultCellStyle = dataGridViewCellStyle3;
            TransactionDGV.GridColor = Color.FromArgb(231, 229, 255);
            TransactionDGV.Location = new Point(114, 105);
            TransactionDGV.Name = "TransactionDGV";
            TransactionDGV.RowHeadersVisible = false;
            TransactionDGV.RowHeadersWidth = 51;
            TransactionDGV.RowTemplate.Height = 24;
            TransactionDGV.Size = new Size(1038, 431);
            TransactionDGV.TabIndex = 41;
            TransactionDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            TransactionDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            TransactionDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            TransactionDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            TransactionDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            TransactionDGV.ThemeStyle.BackColor = Color.White;
            TransactionDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            TransactionDGV.ThemeStyle.HeaderStyle.BackColor = Color.DarkOrange;
            TransactionDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            TransactionDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransactionDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            TransactionDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TransactionDGV.ThemeStyle.HeaderStyle.Height = 25;
            TransactionDGV.ThemeStyle.ReadOnly = false;
            TransactionDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            TransactionDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TransactionDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe Script", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TransactionDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            TransactionDGV.ThemeStyle.RowsStyle.Height = 24;
            TransactionDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            TransactionDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            TransactionDGV.CellContentClick += TransactionDGV_CellContentClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.close1;
            pictureBox2.Location = new Point(1118, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 57;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 12);
            label1.Name = "label1";
            label1.Size = new Size(340, 48);
            label1.TabIndex = 61;
            label1.Text = "Transaction History";
            // 
            // TransactionHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1163, 563);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(TransactionDGV);
            Controls.Add(TransactionView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransactionHistory";
            Text = "TransactionHistory";
            TransactionView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)TransactionDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TransactionView;
        private Guna.UI2.WinForms.Guna2DataGridView TransactionDGV;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox8;
    }
}