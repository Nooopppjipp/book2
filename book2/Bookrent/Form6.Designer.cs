namespace Bookrent
{
    partial class Form6
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
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtStudentId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(184, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "登入";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(128, 197);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(234, 30);
            txtPassword.TabIndex = 1;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(128, 144);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(234, 30);
            txtStudentId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 136);
            label1.Location = new Point(45, 69);
            label1.Name = "label1";
            label1.Size = new Size(274, 41);
            label1.TabIndex = 3;
            label1.Text = "請輸入帳號與密碼";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 147);
            label2.Name = "label2";
            label2.Size = new Size(50, 24);
            label2.TabIndex = 4;
            label2.Text = "帳號:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(61, 200);
            label3.Name = "label3";
            label3.Size = new Size(50, 24);
            label3.TabIndex = 5;
            label3.Text = "密碼:";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(478, 363);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStudentId);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form6";
            Text = "登入";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtStudentId;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}