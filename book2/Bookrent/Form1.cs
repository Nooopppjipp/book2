
namespace Bookrent
{
    public partial class Form1 : Form
    {
        private readonly string _currentUser;
        private Form4 _statusForm;
        private Form5 _notesForm;
        private Form6 _LogoutForm;
        private List<Book> _books => BookRepository.Books;
        public Form1(string currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            user.Text = $"歡迎!用戶{_currentUser}";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayBooks(_books);
        }
        private void DisplayBooks(IEnumerable<Book> books)
        {
            var data = books.Select(b => new
            {
                書名 = b.Title,
                作者 = b.Author,
                借閱狀態 = b.IsAvailable ? "可借閱" : "出借中",
                簡介 = b.Description,
                排隊人數 = b.QueueUsers.Count
            }).ToList();

            dgvBooks.DataSource = data;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            var query = Txtsearch.Text.Trim();
            var filtered = _books
                .Where(b => b.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0
                         || b.Author.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
            DisplayBooks(filtered);
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var openForms = Application.OpenForms.Cast<Form>().ToList();
            foreach (var frm in openForms)
            {
                if (frm is Form2 || frm is Form3 || frm is Form4 || frm is Form5)
                {
                    frm.Close();
                }
            }
            this.Hide();
            _LogoutForm = new Form6();
            _LogoutForm.Show();
            _LogoutForm.FormClosed += (s, args) => this.Close();
        }
    }
}
