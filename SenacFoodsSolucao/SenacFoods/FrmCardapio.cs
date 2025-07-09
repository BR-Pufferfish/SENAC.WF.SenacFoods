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
    public partial class FrmCardapio : Form
    {
        CardapioItem? cardapioSelecionado;
        public FrmCardapio()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCardapio_Load(object sender, EventArgs e)
        {
            BuscarCardapio();
        }

        private void BuscarCardapio()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela cardapio item
                var cardapios = bd.CardapioItems.AsQueryable();
                if (!string.IsNullOrEmpty(txt_Pesquisa.Text))
                {
                    cardapios = cardapios.Where(c => c.Titulo.Contains(txt_Pesquisa.Text) || c.Descricao.Contains(txt_Pesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = cardapios.ToList();

            }


        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            new FrmCardapioCad().ShowDialog();
            BuscarCardapio();
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            //chama o método buscar cardápio
            BuscarCardapio();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar o cardapio selecionado
                cardapioSelecionado = dataGridView1.Rows[e.RowIndex].DataBoundItem as CardapioItem;
                btn_Editar.Enabled = true;
            }
        }
        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            { 
                //abrir o formulario de edição
                var cardapio = new FrmCardapioCad(cardapioSelecionado);
                cardapio.ShowDialog();
                //atualizar a lista de cardápios
                BuscarCardapio();
                cardapioSelecionado = null;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (cardapioSelecionado != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.CardapioItems.Remove(cardapioSelecionado);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Cardápio excluído com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarCardapio();
                cardapioSelecionado = null;
            }
            else
            {
                MessageBox.Show("Selecione um cardápio para excluir.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
