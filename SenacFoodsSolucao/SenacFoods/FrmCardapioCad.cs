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
        private CardapioItem _cardapioitem;
        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        public FrmCardapioCad(CardapioItem cardapioItem)
        {
            _cardapioitem = cardapioItem;
            InitializeComponent();

            //Carregar dados da tela

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            //popular os campos da tela
            if (_cardapioitem != null)
            {
                txt_titulo.Text = _cardapioitem.Titulo;
                rtxt_descricao.Text = _cardapioitem.Descricao;
                txt_preco.Text = _cardapioitem.Preco.ToString("F2");
                chk_preparo.Checked = _cardapioitem.PossuiPreparo;
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //inserir
            if (_cardapioitem == null)
            {
                InserirCardapio();
            }
            //atualizar
            else
            {
                AtualizarCardapio();
            }
        }

        private void AtualizarCardapio()
        {
            using (var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                string titulo = txt_titulo.Text;
                string descricao = rtxt_descricao.Text;
                decimal.TryParse(txt_preco.Text, out var preco);
                bool possuiPreparo = chk_preparo.Checked;

                if (banco.CardapioItems.Any(ci => ci.Titulo == titulo && ci.Id != _cardapioitem.Id))
                {
                    MessageBox.Show("Já existe um cardápio com esse título",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //atualizar o cardapio
                var cardapioItem = banco.CardapioItems.First(x => x.Id == _cardapioitem.Id);
                cardapioItem.Titulo = titulo;
                cardapioItem.Descricao = descricao;
                cardapioItem.Preco = preco;
                cardapioItem.PossuiPreparo = possuiPreparo;

                //salvar as alterações no banco
                banco.CardapioItems.Update(cardapioItem);
                banco.SaveChanges();
            }
            MessageBox.Show("Cardapio salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirCardapio()
        {
            // Conectar;
            using (var banco = new ComandaDBContext())
            {
                // Captar os dados da tela;
                string titulo = txt_titulo.Text;
                string descricao = rtxt_descricao.Text;
                decimal.TryParse(txt_preco.Text, out var preco);
                bool possuiPreparo = chk_preparo.Checked;

                if (banco.CardapioItems.Any(ci => ci.Titulo == titulo))
                {
                    MessageBox.Show("Já existe um cardápio com esse título",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

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
