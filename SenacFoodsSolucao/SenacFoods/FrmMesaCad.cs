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

            }
        }

        private void InserirMesa()
        {
            using (var banco = new ComandaDBContext())
            {

            }
        }
    }
}
