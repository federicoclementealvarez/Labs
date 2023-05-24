using Clases;
namespace Academia
{
    public partial class Login : Form
    {
        private BD usuariosBD;
        public Login()
        {
            InitializeComponent();
            usuariosBD = new BD();
            usuariosBD.AddUser("fduser", "pass123");
            usuariosBD.AddUser("fitorojo", "maratea");
            usuariosBD.AddUser("fabri99", "civil");
            usuariosBD.AddUser("mauroF", "quimica");
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text.Trim();
            string pass = txtPass.Text.Trim();
            if (name.Length <= 0 || pass.Length <= 0)
            {
                MessageBox.Show("ERROR: Usuario o Contraseña no ingresados", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int index = usuariosBD.IndexUser(name);
                if (index < usuariosBD.GetLength())
                {
                    if (usuariosBD.ValidatePass(pass, index))
                    {
                        MessageBox.Show("Bienvenido al sistema " + name, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMenu frmMenu = new frmMenu(new Usuario(name, pass));
                        frmMenu.Show();
                        this.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("¡Contraseña incorrecta!\nIntente de nuevo", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR - Usuario no existente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Deberías recordarla", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}