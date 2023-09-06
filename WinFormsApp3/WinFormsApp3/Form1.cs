namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private List<Book> books;
        private List<Book> displayedBook;
        int index;


        public Form1()
        {
            InitializeComponent();
            books = new List<Book>();
            displayedBook = new List<Book>();
            Book aBook1 = new Book("Conan", "Akira", "2001", "tfg", 222.5, 4);
            Book aBook2 = new Book("Doraemon", "Fujiko", "1888", "sasd", 744.55, 8);
            books.Add(aBook1);
            books.Add(aBook2);
            displayedBook = books;
        }     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text == "" ||
               txtAuthorName.Text == "" ||
               txtCategory.Text == "" ||
               txtDate.Text == "" ||
               txtPrice.Text == "" ||
               txtQuantity.Text == "")
            {
                MessageBox.Show("Please enter all required fields", "Null data found!", MessageBoxButtons.OK);
            }
            else
            {
                string bookName = txtBookName.Text;
                string authorName = txtAuthorName.Text;
                string dateOfPublishing = txtDate.Text;
                string category = txtCategory.Text;
                if (Double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtQuantity.Text, out int quantity))
                {
                    Book aBook = new Book(bookName, authorName, dateOfPublishing, category, price, quantity);
                    books.Add(aBook);
                    displayedBook = books;
                    clear();
                    refresh();
                    MessageBox.Show("Added successfully", "Complete", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Invalid data of price or quantity", "ERROR", MessageBoxButtons.OK);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].bookName == displayedBook[index].bookName)
                {
                    books.RemoveAt(i);
                }
            }
            displayedBook = books;
            refresh();
            clear();
            MessageBox.Show("Deleted successfully", "Complete", MessageBoxButtons.OK);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Book> newBookList = new List<Book>();
            if (txtSearch.Text == "")
            {
                newBookList = books;
            }
            else
            {
                for (int i = 0; i < books.Count; i++)
                {
                    if (books[i].bookName == txtSearch.Text ||
                        books[i].authorName == txtSearch.Text ||
                        books[i].category == txtSearch.Text)
                    {
                        newBookList.Add(books[i]);
                    }
                }
            }
            displayedBook = newBookList;
            refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].bookName == displayedBook[index].bookName)
                {
                    books.RemoveAt(i);
                }
            }
            string bookName = txtBookName.Text;
            string authorName = txtAuthorName.Text;
            string dateOfPublishing = txtDate.Text;
            string category = txtCategory.Text;
            if (Double.TryParse(txtPrice.Text, out double price) && int.TryParse(txtQuantity.Text, out int quantity))
            {
                Book aBook = new Book(bookName, authorName, dateOfPublishing, category, price, quantity);
                books.Add(aBook);
                displayedBook = books;
                clear();
                refresh();
                MessageBox.Show("Added successfully", "Complete", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Invalid data of price or quantity", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (displayedBook.Count >= 0)
            {
                txtBookName.Text = displayedBook[index].bookName;
                txtAuthorName.Text = displayedBook[index].authorName;
                txtDate.Text = displayedBook[index].dateOfPublishing;
                txtCategory.Text = displayedBook[index].category;
                txtPrice.Text = displayedBook[index].price.ToString();
                txtQuantity.Text = displayedBook[index].quantity.ToString();
            }
        }

        private void clear()
        {
            txtBookName.Text = "";
            txtAuthorName.Text = "";
            txtCategory.Text = "";
            txtDate.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtSearch.Text = "";
        }

        private void refresh()
        {
            // Gán null trước khi gán lại data để refresh lại bảng - datasource
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = displayedBook;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}