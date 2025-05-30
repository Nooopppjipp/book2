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
    public partial class Form4 : Form
    {
        private string _currentUser;
        private List<Book> _bookList;
        public Form4(string currentUser, List<Book> bookList)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _bookList = bookList;
            LoadQueueData();
        }
        private void LoadQueueData()
        {
            var data = _bookList
                .Where(b => b.QueueUsers.Contains(_currentUser))
                .Select(b => new
                {
                    書名 = b.Title,
                    作者 = b.Author,
                    順位 = b.QueueCount
                })
                .ToList();

            dgvReservations.DataSource = data;
            lblEmpty.Visible = data.Count == 0;
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            lblEmpty.Left = (this.ClientSize.Width - lblEmpty.Width) / 2;
            lblEmpty.Top = (this.ClientSize.Height - lblEmpty.Height) / 2;
        }
    }
}
