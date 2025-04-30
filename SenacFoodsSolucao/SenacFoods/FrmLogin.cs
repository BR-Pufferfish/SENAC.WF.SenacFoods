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
            this.Hide();
            var frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
