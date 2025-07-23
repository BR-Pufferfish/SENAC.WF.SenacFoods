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
    public partial class FrmUsuarioCad : Form
    {
        private Usuario? _usuarioSelecionado;
        public FrmUsuarioCad()
        {
            InitializeComponent();
        }

        public FrmUsuarioCad(Usuario usuario)
        {
            InitializeComponent();
            _usuarioSelecionado = usuario;

            //Carregar dados da tela

            CarregarDadosDaTela();
        }

        private void CarregarDadosDaTela()
        {
            if (_usuarioSelecionado != null)
            {
                txt_nome.Text = _usuarioSelecionado.Nome.ToString();
                txt_email.Text = _usuarioSelecionado.Email.ToString();
                txt_senha.Text = _usuarioSelecionado.Senha.ToString();
                cbx_perfil.SelectedItem = _usuarioSelecionado.ToString();
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
            if (_usuarioSelecionado == null)
            {
                InserirUsuario();
            }
            //atualizar
            else
            {
                AtualizarUsuario();
            }
        }

        private void AtualizarUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                string nome = txt_nome.Text;
                string email = txt_email.Text;
                string senha = txt_senha.Text;
                string confirmaSenha = txt_confirmaSenha.Text;
                

                //atualizar o cardapio
                var usuario = banco.Usuarios.First(x => x.Id == _usuarioSelecionado.Id);
                usuario.Nome = nome;
                usuario.Email = email;
                usuario.Senha = senha;
                

                //salvar as alterações no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void InserirUsuario()
        {
            using (var banco = new ComandaDBContext())
            {
                //captar os dados da tela
                string nome = txt_nome.Text;
                string email = txt_email.Text;
                string senha = txt_senha.Text;
                string confirmaSenha = txt_confirmaSenha.Text;


                //Criar um novo usuário;
                var usuario = new Usuario()
                {
                    Nome = nome,
                    Email = email,
                    Senha = senha
                    // confirmaSenha
                };


                //salvar as alterações no banco
                banco.Usuarios.Update(usuario);
                banco.SaveChanges();
            }
            MessageBox.Show("Usuário salvo com sucesso",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }
    }
}
