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
        private Book _book;
        private string _currentUser;
        public Form2(Book book, string currentUser)
        {
            InitializeComponent();
            _book = book ?? throw new ArgumentNullException(nameof(book));
            _currentUser = currentUser;
            lblTitle.Text = book.Title;
            lblAuthor.Text = "作者: " + book.Author;
            lblStatus.Text = "借閱狀態: " + (book.IsAvailable ? "可借閱" : "出借中");
            txtDescription.Text = book.Description;
            lblQueue.Text = "排隊人數:" + book.QueueUsers.Count;
            btnCancelReservation.Visible = book.QueueUsers.Contains(_currentUser);
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (_book.IsAvailable)
            {
                // 直接借閱：設為出借中，並將自己加入隊列的第一位
                _book.IsAvailable = false;
                _book.QueueUsers.Insert(0, _currentUser);
                lblStatus.Text = "借閱狀態: 出借中";
                lblQueue.Text = "排隊人數: " + _book.QueueUsers.Count;
                using (var f3 = new Form3("已預約，請盡快取書"))
                    f3.ShowDialog();
                lblQueue.Text = "排隊人數:" + _book.QueueUsers.Count;
                // 顯示取消預約按鈕
                btnCancelReservation.Visible = true;
            }
            else
            {
                // 預約書籍
                if (_book.QueueUsers.Contains(_currentUser))
                {
                    using (var f3 = new Form3("你已在預約隊伍中，請耐心等待通知。"))
                        f3.ShowDialog();
                }
                else
                {
                    _book.QueueUsers.Add(_currentUser);
                    int position = _book.QueueUsers.Count;
                    lblQueue.Text = "排隊人數: " + position;
                    using (var f3 = new Form3($"你是預約隊伍中第 {position} 名，將於可借閱時通知您"))
                        f3.ShowDialog();
                    lblQueue.Text = "排隊人數:" + _book.QueueUsers.Count;
                    btnCancelReservation.Visible = true;
                }
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            if (_book.QueueUsers.Contains(_currentUser))
            {
                int removedIndex = _book.QueueUsers.IndexOf(_currentUser);
                _book.QueueUsers.Remove(_currentUser);
                lblQueue.Text = "排隊人數: " + _book.QueueUsers.Count;

                using (var f3 = new Form3("已取消預約，位置已釋出。"))
                    f3.ShowDialog();

                // 隱藏取消預約按鈕
                btnCancelReservation.Visible = false;

                // 其他排在後方的使用者順位將自動往前（Form4 顯示時會即時計算）
            }
            else
            {
                MessageBox.Show("您尚未預約此書，無法取消。", "取消失敗", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
