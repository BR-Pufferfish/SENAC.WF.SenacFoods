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
    public partial class FrmComanda : Form
    {
        Comanda? comandaSelecionada;
        public FrmComanda()
        {
            InitializeComponent();
        }

        private void FrmComanda_Load(object sender, EventArgs e)
        {
            BuscarComanda();
        }

        private void BuscarComanda()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela cardapio item
                var comandas = bd.Comandas.AsQueryable();
                if (!string.IsNullOrEmpty(txt_Pesquisa.Text))
                {
                    comandas = comandas.Where(c => c.NumeroMesa.ToString().Contains(txt_Pesquisa.Text) ||
                                        c.NomeCliente.ToString().Contains(txt_Pesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = comandas.ToList();
            }
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            new FrmComandaCad().ShowDialog();
            BuscarComanda();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar a mesa selecionado
                comandaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Comanda;
                btn_Editar.Enabled = true;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (comandaSelecionada != null)
            {
                //abrir o formulario de edição
                var comandas = new FrmComandaCad(comandaSelecionada);
                comandas.ShowDialog();
                //atualizar a lista de mesas
                BuscarComanda();
                comandaSelecionada = null;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (comandaSelecionada != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Comandas.Remove(comandaSelecionada);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Comanda excluída com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarComanda();
                comandaSelecionada = null;
            }
            else
            {
                MessageBox.Show("Selecione uma comanda para excluir.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            //chama o método buscar comandas
            BuscarComanda();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
