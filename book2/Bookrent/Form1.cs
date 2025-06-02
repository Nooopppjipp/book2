
namespace Bookrent
{
    public partial class Form1 : Form
    {
        //欄位，form1存取並記錄
        private readonly string _currentUser;//9-3 宣告類別/欄位/屬性
        private Form4? _statusForm;
        private Form5? _notesForm;
        private Form6? _LogoutForm;
        //_book屬性，讀取BookRepository類別的Books
        private List<Book> _books => BookRepository.Books;
        //改變使用者
        public Form1(string currentUser)//9-3 存取參數
        {
            InitializeComponent();
            _currentUser = currentUser;
            user.Text = $"歡迎!用戶{_currentUser}";
        }
        //直接顯示DisplayBooks(_books)001
        private void Form1_Load(object sender, EventArgs e)//13-2 表單載入事件
        {
            DisplayBooks(_books);
        }
        //顯示清單
        private void DisplayBooks(IEnumerable<Book> books) //16-1chatgpt開發
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
        //搜尋按鍵
        private void Search_Click(object sender, EventArgs e)//13-1 按鈕點擊事件處理
        {
            //去掉前後空白，根據搜尋內容篩選獲得filtered
            var query = Txtsearch.Text.Trim();//14-1 trim
            var filtered = _books.Where(b => b.Title.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0
                                         || b.Author.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0);
            DisplayBooks(filtered);
        }
        //顯示form4借閱狀態，避免重覆開啟
        private void Status_Click(object sender, EventArgs e)//14-2 呼叫其他表單13-1 按鈕點擊事件處理
        {
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
        //顯示form5注意事項，避免重覆開啟
        private void Note_Click(object sender, EventArgs e)//14-2 呼叫其他表單13-1 按鈕點擊事件處理
        {
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
        //雙擊搜尋項目，呼叫form2
        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)//14-2 呼叫其他表單13-1 點擊事件處理
        {
            //防觸標題列
            if (e.RowIndex < 0) return;
            //查找點擊列的書名欄
            var title = dgvBooks.Rows[e.RowIndex].Cells["書名"].Value?.ToString();
            //確定書名不為空
            if (string.IsNullOrEmpty(title)) return;
            var selected = _books.FirstOrDefault(b => b.Title == title);
            if (selected != null)
            {
                var detailForm = new Form2(selected, _currentUser);
                detailForm.Show();
            }
        }
        //登出功能，開啟form6並關閉form2~5
        private void btnLogout_Click(object sender, EventArgs e)//14-2 呼叫其他表單13-1 點擊事件處理
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
