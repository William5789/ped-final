using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PED
{
    public partial class BooksForm : Form
    {
        public BooksForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            DataTable books = DatabaseHelper.ExecuteQuery("SELECT * FROM Libros");
            dataGridViewBooks.DataSource = books;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string author = textBoxAuthor.Text;
            int copies = int.Parse(textBoxCopies.Text);
            string query = $"INSERT INTO Libros (Titulo, Autor, CantidadCopias) VALUES ('{title}', '{author}', {copies})";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadBooks();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

