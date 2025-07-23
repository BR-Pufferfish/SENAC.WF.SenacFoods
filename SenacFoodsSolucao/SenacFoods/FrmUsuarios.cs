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
    public partial class FrmUsuarios : Form
    {
        Usuario? usuarioSelecionado;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            BuscarUsuarios();
        }

        private void BuscarUsuarios()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela cardapio item
                var users = bd.Usuarios.AsQueryable();
                if (!string.IsNullOrEmpty(txt_Pesquisa.Text))
                {
                    users = users.Where(c => c.Nome.ToString().Contains(txt_Pesquisa.Text) ||
                                        c.Email.ToString().Contains(txt_Pesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = users.ToList();
            }
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            new FrmUsuarioCad().ShowDialog();
            BuscarUsuarios();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar a mesa selecionado
                usuarioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as Usuario;
                btn_Editar.Enabled = true;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                //abrir o formulario de edição
                var users = new FrmUsuarioCad(usuarioSelecionado);
                users.ShowDialog();
                //atualizar a lista de mesas
                BuscarUsuarios();
                usuarioSelecionado = null;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (usuarioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Usuarios.Remove(usuarioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Usuário excluída com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarUsuarios();
                usuarioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um UsuárioS para excluir.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            //chama o método buscar mesas
            BuscarUsuarios();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
