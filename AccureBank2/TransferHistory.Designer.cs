namespace AccureBank2
{
    partial class TransferHistory
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
            label1 = new Label();
            TranferDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox2 = new PictureBox();
            TransactionView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TranferDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // TransactionView
            // 
            TransactionView.BackColor = Color.Blue;
            TransactionView.Controls.Add(pictureBox8);
            TransactionView.Controls.Add(pictureBox3);
            TransactionView.Location = new Point(-30, -20);
            TransactionView.Name = "TransactionView";
            TransactionView.Size = new Size(127, 636);
            TransactionView.TabIndex = 3;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(493, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 39);
            label1.TabIndex = 63;
            label1.Text = "Transfer History";
            // 
            // TranferDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            TranferDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkOrange;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            TranferDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            TranferDGV.ColumnHeadersHeight = 25;
            TranferDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            TranferDGV.DefaultCellStyle = dataGridViewCellStyle3;
            TranferDGV.GridColor = Color.FromArgb(231, 229, 255);
            TranferDGV.Location = new Point(103, 97);
            TranferDGV.Name = "TranferDGV";
            TranferDGV.RowHeadersVisible = false;
            TranferDGV.RowHeadersWidth = 51;
            TranferDGV.RowTemplate.Height = 24;
            TranferDGV.Size = new Size(1004, 431);
            TranferDGV.TabIndex = 62;
            TranferDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            TranferDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            TranferDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            TranferDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            TranferDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            TranferDGV.ThemeStyle.BackColor = Color.White;
            TranferDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            TranferDGV.ThemeStyle.HeaderStyle.BackColor = Color.DarkOrange;
            TranferDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            TranferDGV.ThemeStyle.HeaderStyle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TranferDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            TranferDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            TranferDGV.ThemeStyle.HeaderStyle.Height = 25;
            TranferDGV.ThemeStyle.ReadOnly = false;
            TranferDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            TranferDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            TranferDGV.ThemeStyle.RowsStyle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TranferDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            TranferDGV.ThemeStyle.RowsStyle.Height = 24;
            TranferDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            TranferDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.close1;
            pictureBox2.Location = new Point(1075, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 64;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // TransferHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1120, 532);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(TranferDGV);
            Controls.Add(TransactionView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TransferHistory";
            Text = "TransferHistory";
            TransactionView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)TranferDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel TransactionView;
        private PictureBox pictureBox8;
        private PictureBox pictureBox3;
        private Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView TranferDGV;
        private PictureBox pictureBox2;
    }
}