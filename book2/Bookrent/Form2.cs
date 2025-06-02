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
    public partial class Form2 : Form
    {
        private Book _book;//9-3 宣告類別/欄位/屬性
        private string _currentUser;
        //載入書本資訊
        public Form2(Book book, string currentUser)
        {
            InitializeComponent();
            _book = book ?? throw new ArgumentNullException(nameof(book));//12-3丟出
            _currentUser = currentUser;
            lblTitle.Text = book.Title;
            lblAuthor.Text = "作者: " + book.Author;
            lblStatus.Text = "借閱狀態: " + (book.IsAvailable ? "可借閱" : "出借中");
            txtDescription.Text = book.Description;
            lblQueue.Text = "排隊人數:" + book.QueueUsers.Count;
            //檢查清單中是否有使用者以決定是否顯示"取消預約"
            btnCancelReservation.Visible = book.QueueUsers.Contains(_currentUser);
        }
        //預約按鍵
        private void btnReserve_Click(object sender, EventArgs e)//13-1 按鈕點擊事件處理
        {
            if (_book.IsAvailable)
            {
                // 將用戶加入隊列，更新書籍狀態
                _book.IsAvailable = false;
                _book.QueueUsers.Add(_currentUser);
                lblStatus.Text = "借閱狀態: 出借中";
                lblQueue.Text = "排隊人數:" + _book.QueueUsers.Count;
                //呼叫form3
                using (var f3 = new Form3("已預約，請盡快取書"))
                    f3.ShowDialog();
                // 顯示取消預約按鈕
                btnCancelReservation.Visible = true;
            }
            else
            {
                // 預約書籍
                if (_book.QueueUsers.Contains(_currentUser))
                {
                    //呼叫form3
                    using (var f3 = new Form3("你已在預約隊伍中，請耐心等待通知。"))
                        f3.ShowDialog();
                }
                else
                {
                    // 將用戶加入隊列，更新書籍狀態
                    _book.QueueUsers.Add(_currentUser);
                    int position = _book.QueueUsers.Count;
                    lblQueue.Text = "排隊人數:" + _book.QueueUsers.Count;
                    //呼叫form3
                    using (var f3 = new Form3($"你是預約隊伍中第 {position} 名，將於可借閱時通知您"))
                        f3.ShowDialog();
                    // 顯示取消預約按鈕
                    btnCancelReservation.Visible = true;
                }
            }
        }
        //取消預約按鍵
        private void btnCancelReservation_Click(object sender, EventArgs e)//13-1 按鈕點擊事件處理
        {
            if (_book.QueueUsers.Contains(_currentUser))
            {
                // 其他排在後方的使用者順位將自動往前
                _book.QueueUsers.Remove(_currentUser);
                lblQueue.Text = "排隊人數: " + _book.QueueUsers.Count;
                using (var f3 = new Form3("已取消預約，位置已釋出。"))
                    f3.ShowDialog();
                // 隱藏取消預約按鈕
                btnCancelReservation.Visible = false; 
            }
            else//偵錯
            {
                MessageBox.Show("您尚未預約此書，無法取消。", "取消失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
