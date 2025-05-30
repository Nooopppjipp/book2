
namespace Bookrent
{
    public partial class Form1 : Form
    {
        private string _currentUser = "Alice";
        private Form4 _statusForm;
        private Form5 _notesForm;
        private List<Book> _books = new List<Book>
        {
            new Book{ Title="C#�J��",       Author="�i�T", IsAvailable=true,  Description="�q�s�}�l�� C# ���̨ΤJ����" ,QueueCount=0, QueueUsers=new List<string>()},
            new Book{ Title="WinForms���", Author="���|", IsAvailable=false, Description="��@�M�ױa�A�� WinForms",QueueCount=5, QueueUsers=new List<string>() },
            new Book{ Title="��Ƶ��c",     Author="����", IsAvailable=false,  Description="�g���Ƶ��c�d�ҸѪR" ,QueueCount=0, QueueUsers=new List<string>()},
            // �K �i�A�[�J��h
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
                    �ѦW = b.Title,
                    �@�� = b.Author,
                    �ɾ\���A = b.IsAvailable ? "�i�ɾ\" : "�X�ɤ�",
                    ²�� = b.Description,
                    �ƶ��H�� = b.QueueCount
                })
                .ToList();
            dgvBooks.DataSource = results;
        }
        private void Status_Click(object sender, EventArgs e)
        {
            // TODO: ��@ Form4�A��ܥثe�ɾ\���w�����A
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
            // TODO: ��@ Form5�A��ܪ`�N�ƶ�
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
            var title = dgvBooks.Rows[e.RowIndex].Cells["�ѦW"].Value?.ToString();
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
