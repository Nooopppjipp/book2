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
            lblQueue.Text = "排隊人數:" + book.QueueCount;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (_book.QueueUsers.Contains(_currentUser))
            {
            using (var f3 = new Form3("你已在預約隊伍中，請耐心等待通知。"))
            f3.ShowDialog();
            return;
            }
            if (_book.IsAvailable)
            {
                _book.IsAvailable = false;
                lblStatus.Text = "借閱狀態: " + (_book.IsAvailable ? "可借閱" : "出借中");
                using (var f3 = new Form3("預約成功，請72小時內至圖書館取書"))
                    f3.ShowDialog();
            }
            else
            {
                int position = _book.QueueCount + 1;
                _book.QueueCount ++;
                _book.QueueUsers.Add(_currentUser);
                using (var f3 = new Form3($"你是預約隊伍中第 {position} 名，將於可取書時通知您"))
                    f3.ShowDialog();
                lblQueue.Text = "排隊人數:" + _book.QueueCount;
            }
            _book.QueueUsers.Add(_currentUser);



        }

    }
}
