using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenacFoods
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal(string nome, string senha)
        {
            InitializeComponent();
            lbl_bemvindo.Text = "Bem-Vindo " + nome;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
            var frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void btn_cardapio_Click(object sender, EventArgs e)
        {
            // cria a instância do cardapio e exibe em modo modal (não pode interagir com outra tela até fechar esta)
            var frmCardapio = new FrmCardapio();
            frmCardapio.ShowDialog();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_comanda_Click(object sender, EventArgs e)
        {
            var frmComanda = new FrmComanda();
            frmComanda.ShowDialog();
        }

        private void btn_pedido_cozinha_Click(object sender, EventArgs e)
        {
            var frmPedidoCozinha = new FrmPedidoCozinha();
            frmPedidoCozinha.ShowDialog();
        }

        private void btn_usuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuarios();
            frmUsuarios.ShowDialog();
        }
    }
}
