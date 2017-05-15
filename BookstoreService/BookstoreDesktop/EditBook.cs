using BookstoreDesktop.BookstoreService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreDesktop
{
    public partial class EditBook : Form
    {
        private readonly BooksServiceClient _service = new BooksServiceClient();

        private int _selectedBookID;
        private Book _selectedBook;
        private IList<Book> _allBooks;
        public EditBook()
        {
            InitializeComponent();
        }
        public EditBook(int selectedBookID)
        {
            _selectedBookID = selectedBookID;
            _allBooks = _service.GetAllBooks().ToList();
            _selectedBook = _service.GetBook(_selectedBookID);
            InitializeComponent();
        }
        private void EditBook_Load(object sender, EventArgs e)
        {
            var categories = _service.GetAllCategories();
            categoryBindingSource.DataSource = categories;

            bookBindingSource.DataSource = _allBooks;
            bookBindingSource.Position = _allBooks.IndexOf(_selectedBook);

            UpdateInfo();
        }
        private void bookBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        private void UpdateInfo()
        {
            _selectedBook = _service.GetBook(((Book)bookBindingSource.Current).BookID);
            categoryIDComboBox.SelectedValue = 0;
            categoryIDComboBox.SelectedValue = _selectedBook.CategoryID;

            if (_selectedBook.Cover != null)
            {
                coverPictureBox.Image = Image.FromStream(new MemoryStream(_selectedBook.Cover));
                coverPictureBox.Refresh();
            }
        }
    }
}
