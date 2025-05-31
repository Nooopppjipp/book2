namespace Bookrent
{
    partial class Form7
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
            btnChange = new Button();
            txtAccount = new TextBox();
            txtConfirmPassword = new TextBox();
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCancelChange = new Button();
            SuspendLayout();
            // 
            // btnChange
            // 
            btnChange.Location = new Point(56, 268);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(112, 34);
            btnChange.TabIndex = 0;
            btnChange.Text = "確認";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // txtAccount
            // 
            txtAccount.Location = new Point(56, 70);
            txtAccount.Name = "txtAccount";
            txtAccount.Size = new Size(337, 30);
            txtAccount.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(56, 212);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(337, 30);
            txtConfirmPassword.TabIndex = 2;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(56, 143);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(337, 30);
            txtNewPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 44);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "請輸入帳號";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 117);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "輸入新密碼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 186);
            label3.Name = "label3";
            label3.Size = new Size(136, 23);
            label3.TabIndex = 6;
            label3.Text = "再次輸入新密碼";
            // 
            // btnCancelChange
            // 
            btnCancelChange.Location = new Point(203, 268);
            btnCancelChange.Name = "btnCancelChange";
            btnCancelChange.Size = new Size(112, 34);
            btnCancelChange.TabIndex = 7;
            btnCancelChange.Text = "取消";
            btnCancelChange.UseVisualStyleBackColor = true;
            btnCancelChange.Click += btnCancelChange_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(457, 336);
            Controls.Add(btnCancelChange);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtAccount);
            Controls.Add(btnChange);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChange;
        private TextBox txtAccount;
        private TextBox txtConfirmPassword;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCancelChange;
    }
}