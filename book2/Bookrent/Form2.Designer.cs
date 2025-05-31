namespace Bookrent
{
    partial class Form2
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
            lblTitle = new Label();
            lblAuthor = new Label();
            lblStatus = new Label();
            txtDescription = new TextBox();
            btnReserve = new Button();
            lblQueue = new Label();
            btnCancelReservation = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft JhengHei UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblTitle.Location = new Point(75, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(139, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = Color.PapayaWhip;
            lblAuthor.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            lblAuthor.Location = new Point(75, 111);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(78, 36);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "作者:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lblStatus.Location = new Point(75, 152);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(133, 36);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "書籍狀態:";
            // 
            // txtDescription
            // 
            txtDescription.BackColor = SystemColors.ButtonFace;
            txtDescription.Location = new Point(75, 210);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(479, 214);
            txtDescription.TabIndex = 3;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(442, 63);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(112, 34);
            btnReserve.TabIndex = 4;
            btnReserve.Text = "我要預約";
            btnReserve.UseVisualStyleBackColor = true;
            btnReserve.Click += btnReserve_Click;
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Location = new Point(442, 165);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(61, 23);
            lblQueue.TabIndex = 5;
            lblQueue.Text = "label1";
            // 
            // btnCancelReservation
            // 
            btnCancelReservation.AutoSize = true;
            btnCancelReservation.Location = new Point(442, 111);
            btnCancelReservation.Name = "btnCancelReservation";
            btnCancelReservation.Size = new Size(112, 34);
            btnCancelReservation.TabIndex = 6;
            btnCancelReservation.Text = "取消預約";
            btnCancelReservation.UseVisualStyleBackColor = true;
            btnCancelReservation.Click += btnCancelReservation_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(692, 450);
            Controls.Add(btnCancelReservation);
            Controls.Add(lblQueue);
            Controls.Add(btnReserve);
            Controls.Add(txtDescription);
            Controls.Add(lblStatus);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            Text = "書籍資訊與狀態";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblStatus;
        private TextBox txtDescription;
        private Button btnReserve;
        private Label lblQueue;
        private Button btnCancelReservation;
    }
}