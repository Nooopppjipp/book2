
namespace Bookrent
{
    public partial class Form1 : Form
    {
        private string _currentUser = "Alice";
        private Form4 _statusForm;
        private Form5 _notesForm;
        private List<Book> _books = new List<Book>
        {
            new Book{ Title="C#入門",       Author="張三", IsAvailable=true,  Description="從零開始學 C# 的最佳入門書" ,QueueCount=0, QueueUsers=new List<string>()},
            new Book{ Title="WinForms實戰", Author="李四", IsAvailable=false, Description="實作專案帶你玩 WinForms",QueueCount=5, QueueUsers=new List<string>() },
            new Book{ Title="資料結構",     Author="王五", IsAvailable=false,  Description="經典資料結構範例解析" ,QueueCount=0, QueueUsers=new List<string>()},
            // … 可再加入更多
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void Search_Click(object sender, EventArgs e)
        {
            var query = Txtsearch.Text.Trim();
            var results = _books
                .Where(b => b.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(b => new
                {
                    書名 = b.Title,
                    作者 = b.Author,
                    借閱狀態 = b.IsAvailable ? "可借閱" : "出借中",
                    簡介 = b.Description,
                    排隊人數 = b.QueueCount
                })
                .ToList();
            dgvBooks.DataSource = results;
        }
        private void Status_Click(object sender, EventArgs e)
        {
            // TODO: 實作 Form4，顯示目前借閱／預約狀態
            if (_statusForm == null || _statusForm.IsDisposed)
            {
                _statusForm = new Form4(_currentUser, _books);
                _statusForm.Show();
            }
            else
            {
                _statusForm.BringToFront();
            }
        }

        private void Note_Click(object sender, EventArgs e)
        {
            // TODO: 實作 Form5，顯示注意事項
            if (_notesForm == null || _notesForm.IsDisposed)
            {
                _notesForm = new Form5();
                _notesForm.Show();
            }
            else
            {
                _notesForm.BringToFront();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var title = dgvBooks.Rows[e.RowIndex].Cells["書名"].Value?.ToString();
            if (string.IsNullOrEmpty(title)) return;
            var selected = _books.FirstOrDefault(b => b.Title == title);
            if (selected != null)
            {
                var detailForm = new Form2(selected, _currentUser);
                detailForm.Show();
            }
        }
    }
}
