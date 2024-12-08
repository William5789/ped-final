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
    public partial class SISTEMA : Form
    {
        public SISTEMA()
        {
            InitializeComponent();
        }

        private void BTN_reserva_Click(object sender, EventArgs e)
        {
            UsersForm form2 = new UsersForm(); // Crear una instancia del formulario que quieres abrir
            form2.Show();              // Mostrar el nuevo formulario
            this.Hide();
        }
    }
}
