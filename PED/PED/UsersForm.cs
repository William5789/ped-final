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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();

            LoadUsers();
        }
        private void LoadUsers()
        {
            DataTable users = DatabaseHelper.ExecuteQuery("SELECT * FROM Usuarios");
            dataGridViewUsers.DataSource = users;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string query = $"INSERT INTO Usuarios (Nombre) VALUES ('{name}')";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadUsers();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string query = $"INSERT INTO Usuarios (Nombre) VALUES ('{name}')";
            DatabaseHelper.ExecuteNonQuery(query);
            LoadUsers();
        }
    }
}