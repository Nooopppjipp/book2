using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookrent
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string LoggedUser { get; private set; }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var studentId = txtStudentId.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入學號與密碼。", "登入失敗",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = UserRepository.Users
                .FirstOrDefault(u => u.StudentId == studentId && u.Password == password);
            if (user != null)
            {
                // 記錄已登入使用者
                LoggedUser = user.StudentId;
                txtStudentId.Clear();
                txtPassword.Clear();
                this.Hide();
                // 隱藏登入窗，並開啟主窗
                var mainForm = new Form1(LoggedUser);
                // 當主窗關閉時，一併關閉登入窗以結束整個應用
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("學號或密碼錯誤，請重新輸入。", "登入失敗",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
    }
}
