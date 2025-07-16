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
    public partial class FrmMesa : Form
    {
        Mesa? mesaSelecionada;
        public FrmMesa()
        {
            InitializeComponent();
        }

        private void FrmMesa_Load(object sender, EventArgs e)
        {
            BuscarMesas();
        }

        private void BuscarMesas()
        {
            //conectar no banco de dados
            using (var bd = new ComandaDBContext())
            {
                //consultar a tabela cardapio item
                var mesas = bd.Mesas.AsQueryable();
                if (!string.IsNullOrEmpty(txt_Pesquisa.Text))
                {
                    mesas = mesas.Where(c => c.NumeroMesa.Contains(txt_Pesquisa.Text) || c.SituacaoMesa.Contains(txt_Pesquisa.Text));
                }
                //popular o grid com a tabela consultada
                dataGridView1.DataSource = mesas.ToList();

            }
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            new FrmMesaCad().ShowDialog();
            BuscarMesas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //pegar a mesa selecionado
                mesaSelecionada = dataGridView1.Rows[e.RowIndex].DataBoundItem as Mesa;
                btn_Editar.Enabled = true;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (mesaSelecionada != null)
            {
                //abrir o formulario de edição
                var mesas = new FrmMesaCad(mesaSelecionada);
                mesas.ShowDialog();
                //atualizar a lista de mesas
                BuscarMesas();
                mesaSelecionada = null;
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (mesaSelecionada != null)
            {
                using (var bancoDeDados = new ComandaDBContext())
                {
                    bancoDeDados.Mesas.Remove(mesaSelecionada);
                    bancoDeDados.SaveChanges();
                }
                MessageBox.Show("Mesa excluída com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                BuscarMesas();
                mesaSelecionada = null;
            }
            else
            {
                MessageBox.Show("Selecione uma mesa para excluir.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_Pesquisa_TextChanged(object sender, EventArgs e)
        {
            //chama o método buscar mesas
            BuscarMesas();
        }
    }
}
