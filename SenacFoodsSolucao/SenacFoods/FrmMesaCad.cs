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
    public partial class FrmMesaCad : Form
    {
        private Mesa _mesa;
        public FrmMesaCad()
        {
            InitializeComponent();
        }

        public FrmMesaCad(Mesa mesaSelecionada)
        {
            _mesa = mesaSelecionada;
            InitializeComponent();

            //Carregar dados da tela

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_mesa != null)
            {
                txt_numeroMesa.Text = _mesa.NumeroMesa.ToString();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //inserir
            if (_mesa == null)
            {
                InserirMesa();
            }
            //atualizar
            else
            {
                AtualizarMesa();
            }
        }

        private void AtualizarMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                int.TryParse(txt_numeroMesa.Text, out var nMesa);

                if (banco.Mesas.Any(m => m.NumeroMesa == nMesa && m.Id != _mesa.Id))
                {
                    MessageBox.Show("Já existe uma mesa com esse número",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //atualizar a mesa
                var mesa = banco.Mesas.First(x => x.Id == _mesa.Id);
                mesa.NumeroMesa = nMesa;

                //salvar as alterações no banco
                banco.Mesas.Update(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirMesa()
        {
            using (var banco = new ComandaDBContext())
            {
                //Captar os dados da tela
                int.TryParse(txt_numeroMesa.Text, out var nMesa);

                if (banco.Mesas.Any(x => x.NumeroMesa == nMesa))
                {
                    MessageBox.Show("Já existe uma mesa com esse número",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                //Criar uma nova mesa;
                var mesa = new Mesa()
                {
                    NumeroMesa = nMesa
                };

                //Adicionar a mesa e salvar as alterações no banco;
                banco.Mesas.Add(mesa);
                banco.SaveChanges();
            }
            MessageBox.Show("Mesa salva com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}
