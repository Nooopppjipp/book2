namespace Bookrent
{
    partial class Form4
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
            dgvReservations = new DataGridView();
            lblEmpty = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.AllowUserToResizeColumns = false;
            dgvReservations.AllowUserToResizeRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = SystemColors.Control;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.Location = new Point(0, 0);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.RowHeadersWidth = 62;
            dgvReservations.Size = new Size(543, 450);
            dgvReservations.TabIndex = 0;
            // 
            // lblEmpty
            // 
            lblEmpty.AutoSize = true;
            lblEmpty.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblEmpty.Location = new Point(160, 219);
            lblEmpty.Name = "lblEmpty";
            lblEmpty.Size = new Size(205, 30);
            lblEmpty.TabIndex = 1;
            lblEmpty.Text = "目前沒有預約資料";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 450);
            Controls.Add(lblEmpty);
            Controls.Add(dgvReservations);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservations;
        private Label lblEmpty;
    }
}