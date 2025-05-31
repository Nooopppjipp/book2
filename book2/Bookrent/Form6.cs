using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Bookrent
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public string LoggedUser { get; private set; }
        // 請務必將此路徑改成您實際的用戶.cs檔路徑
        /// <summary>
        /// /////
        /// </summary>
        private const string UserFileAbsolutePath = @"C:\Users\User\Desktop\book2\Bookrent\用戶.cs";
        /// <summary>
        /// ///
        /// </summary>
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var studentId = txtStudentId.Text.Trim();
            var password = txtPassword.Text;

            // 驗證空白
            if (string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("請輸入學號與密碼。", "註冊失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 檢查帳號是否已存在
            bool exists = UserRepository.Users.Any(u => u.StudentId == studentId);
            if (exists)
            {
                MessageBox.Show("此帳號已被使用，請換其他學號。", "註冊失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 同步寫入 UserRepository.cs 檔案
            UserRepository.Users.Add(new User { StudentId = studentId, Password = password });

            // 3. 立即寫回 用戶.cs 檔案
            try
            {
                if (!File.Exists(UserFileAbsolutePath))
                {
                    MessageBox.Show($"找不到檔案：{UserFileAbsolutePath}", "註冊失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 讀取整支檔案
                var lines = File.ReadAllLines(UserFileAbsolutePath).ToList();

                // 尋找初始化 Users 列表的結尾 "};"
                int insertIndex = -1;
                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Trim() == "};")
                    {
                        insertIndex = i;
                        break;
                    }
                }

                if (insertIndex <= 0)
                {
                    MessageBox.Show("未找到用戶清單結尾 `};`，無法寫入", "註冊失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 建立要插入的新行（注意縮排對齊）  
                string newLine = $"            new User {{ StudentId = \"{studentId}\", Password = \"{password}\" }},";

                // 在找到的行（插入位置）的上方插入
                lines.Insert(insertIndex, newLine);

                // 寫回全部內容
                File.WriteAllLines(UserFileAbsolutePath, lines);

                MessageBox.Show("註冊成功，請使用新帳號登入。", "註冊成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStudentId.Clear();
                txtPassword.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"寫入檔案時發生錯誤：{ex.Message}", "註冊警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtStudentId.Clear();
            txtPassword.Clear();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form7 = new Form7();
            // Form7關閉後再把Form6顯示回來
            form7.FormClosed += (s, args) => this.Show();
            form7.Show();
        }
    }
}
