using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Academia
{
    public partial class frmMenu : Form
    {
        Usuario user;
        public frmMenu(Usuario u)
        {
            InitializeComponent();
            user = u;
        }

        private void mostrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El nombre de usuario es: " + user.Username, "Mostrar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void volverAlLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Dispose();
        }
    }
}
