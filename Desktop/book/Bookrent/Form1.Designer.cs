namespace Bookrent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Search = new Button();
            Status = new Button();
            Note = new Button();
            Txtsearch = new TextBox();
            dgvBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(502, 73);
            Search.Name = "Search";
            Search.Size = new Size(88, 33);
            Search.TabIndex = 0;
            Search.Text = "搜尋";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(86, 360);
            Status.Name = "Status";
            Status.Size = new Size(92, 33);
            Status.TabIndex = 1;
            Status.Text = "借閱狀況";
            Status.UseVisualStyleBackColor = true;
            Status.Click += Status_Click;
            // 
            // Note
            // 
            Note.AutoSize = true;
            Note.Location = new Point(184, 360);
            Note.Name = "Note";
            Note.Size = new Size(92, 33);
            Note.TabIndex = 2;
            Note.Text = "注意事項";
            Note.UseVisualStyleBackColor = true;
            Note.Click += Note_Click;
            // 
            // Txtsearch
            // 
            Txtsearch.BackColor = SystemColors.InactiveBorder;
            Txtsearch.Location = new Point(86, 75);
            Txtsearch.Name = "Txtsearch";
            Txtsearch.Size = new Size(410, 30);
            Txtsearch.TabIndex = 3;
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AllowUserToResizeColumns = false;
            dgvBooks.AllowUserToResizeRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBooks.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(86, 111);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(765, 243);
            dgvBooks.TabIndex = 4;
            dgvBooks.CellDoubleClick += dgvBooks_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(935, 447);
            Controls.Add(dgvBooks);
            Controls.Add(Txtsearch);
            Controls.Add(Note);
            Controls.Add(Status);
            Controls.Add(Search);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "圖書借閱系統";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Search;
        private Button Status;
        private Button Note;
        private TextBox Txtsearch;
        private DataGridView dgvBooks;
    }
}
