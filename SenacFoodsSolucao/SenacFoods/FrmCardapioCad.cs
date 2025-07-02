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
    public partial class FrmCardapioCad : Form
    {
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            SalvarCardapio();
        }

        private void SalvarCardapio()
        {
            // Conectar;
            using (var banco = new ComandaDBContext())
            {
                // Captar os dados da tela;
                string titulo = txt_titulo.Text;
                string descricao = rtxt_descricao.Text;
                decimal.TryParse(txt_preco.Text, out var preco);
                bool possuiPreparo = chk_preparo.Checked;

                //Criar um novo cardapio;
                var cardapio = new CardapioItem()
                {
                    Descricao = descricao,
                    Titulo = titulo,
                    Preco = preco,
                    PossuiPreparo = possuiPreparo
                };

                //Adicionar o cardapio e Salvar as alterações no banco;
                banco.CardapioItems.Add(cardapio);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCardapioCad_Load(object sender, EventArgs e)
        {

        }
    }
}
