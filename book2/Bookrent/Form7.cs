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
    public partial class Form7 : Form
    {
        // 務必確認form6/form7已指定"用戶.cs"檔案路徑!!!!!
        private const string UserFileAbsolutePath = @"C:\Users\User\Desktop\book2\Bookrent\用戶.cs";
        //
        public Form7()
        {
            InitializeComponent();
        }

        //確認修改密碼
        private void btnChange_Click(object sender, EventArgs e)
        {
            var account = txtAccount.Text.Trim();
            var newPwd = txtNewPassword.Text;
            var confirmPwd = txtConfirmPassword.Text;

            // 1. 驗證三個文字方塊不可為空
            if (string.IsNullOrEmpty(account)
                || string.IsNullOrEmpty(newPwd)
                || string.IsNullOrEmpty(confirmPwd))
            {
                MessageBox.Show("請輸入帳號、新密碼，以及再次確認密碼。", "變更失敗",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // 2. 檢查記憶體中是否有此帳號
            var targetUser = UserRepository.Users.FirstOrDefault(u => u.StudentId == account);
            if (targetUser == null)
            {
                MessageBox.Show("查無此帳號，請確認後再試。", "變更失敗",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. 驗證兩次密碼輸入是否一致
            if (newPwd != confirmPwd)
            {
                MessageBox.Show("兩次輸入的密碼不相同，請重新確認。", "密碼不一致",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }
            // 4. 在記憶體中更新密碼
            targetUser.Password = newPwd;

            // 5. 同步寫回 UserRepository.cs 檔案
            try//8-5線性搜尋 12-2例外處裡 16-1chatgpt開發
            {
                if (!File.Exists(UserFileAbsolutePath))
                {
                    MessageBox.Show($"找不到檔案：{UserFileAbsolutePath}", "變更失敗",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 讀取檔案到字串列表
                var lines = File.ReadAllLines(UserFileAbsolutePath).ToList();
                int userLineIndex = -1;
                for (int i = 0; i < lines.Count; i++)
                {
                    var trimmed = lines[i].Trim();
                    // 以 StudentId 字串搜尋
                    if (trimmed.StartsWith("new User")
                        && trimmed.Contains($"StudentId = \"{account}\""))
                    {
                        userLineIndex = i;
                        break;
                    }
                }

                if (userLineIndex < 0)
                {
                    MessageBox.Show("在 UserRepository.cs 中找不到該帳號的初始化行。", "變更失敗",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var originalLine = lines[userLineIndex];
                //尋找指定行中，"Password = \""的位置
                int pwdStart = originalLine.IndexOf("Password = \"");
                if (pwdStart < 0)
                {
                    MessageBox.Show("無法解析 UserRepository.cs 中的 Password 欄位。", "變更失敗",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //尋找指定密碼字串的起始雙引號/結束雙引號
                int quoteStart = originalLine.IndexOf("\"", pwdStart + "Password = ".Length);
                int quoteEnd = originalLine.IndexOf("\"", quoteStart + 1);
                if (quoteStart < 0 || quoteEnd < 0)
                {
                    MessageBox.Show("Password 欄位格式異常，請確認檔案內容。", "變更失敗",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 儲存欄位前與欄位後的切段
                string beforePwd = originalLine.Substring(0, quoteStart + 1);  // 包含前面的 "
                string afterPwd = originalLine.Substring(quoteEnd);             // 從 結尾 " 開始（包含逗號）
                // 組合新的一行
                string newLine = beforePwd + newPwd + afterPwd;

                // 替換該行
                lines[userLineIndex] = newLine;

                // 寫回全部檔案
                File.WriteAllLines(UserFileAbsolutePath, lines);

                MessageBox.Show("密碼已成功變更。", "變更成功", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 關閉 Form7
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"寫入檔案時發生錯誤：{ex.Message}", "變更失敗",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //取消按鍵
        private void btnCancelChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

