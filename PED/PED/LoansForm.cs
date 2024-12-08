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
            LoadLoans();
        }
        private void LoadLoans()
        {
            DataTable loans = DatabaseHelper.ExecuteQuery("SELECT * FROM Prestamos");
            dataGridViewLoans.DataSource = loans;
        }
        private void buttonLoanBook_Click_1(object sender, EventArgs e)
        {
            int userId = int.Parse(textBoxUserId.Text);
            int bookId = int.Parse(textBoxBookId.Text);
            string query = $"INSERT INTO Prestamos (UsuarioID, LibroID, FechaPrestamo) VALUES ({userId}, {bookId}, GETDATE())";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadLoans();
        }
    }
}