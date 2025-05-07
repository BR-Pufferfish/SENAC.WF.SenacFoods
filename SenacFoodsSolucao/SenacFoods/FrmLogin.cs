namespace SenacFoods
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            bool loginValido = ValidarLogin(txt_username.Text, txt_password.Text);
            if (loginValido) {
                this.Hide();
                var frmPrincipal = new FrmPrincipal(txt_username.Text, txt_password.Text);
                frmPrincipal.Show();
            }
        }

        private bool ValidarLogin(string nome, string senha)
        {
            if (nome == "admin" && senha == "12345678")
            {
                return true;
            }
            else {
                MessageBox.Show("Usuário ou Senha incorreto(s)");
            }
            return false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Usuário")
                txt_username.Text = string.Empty;
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == string.Empty)
                txt_username.Text = "Usuário";
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Senha")
                txt_password.Text = string.Empty;
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == string.Empty)
                txt_password.Text = "Senha";
        }
    }
}
