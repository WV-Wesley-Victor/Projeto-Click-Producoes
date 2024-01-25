using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoG3_Fotografo
{
    public partial class Configuracao : Form
    {
        public Configuracao()
        {
            InitializeComponent();
        }

        #region metodos
        public void btnClientes()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Close();
        }

        public void btnEventos()
        {
            Evento3 eventos = new Evento3();
            eventos.Show();
            this.Close();
        }

        public void btnAlbums()
        {
            Album album = new Album();
            album.Show();
            this.Close();
        }

        public void btnConfigs()
        {
            Configuracao configuracao = new Configuracao();
            configuracao.Show();
            this.Close();
        }
        #endregion

        private void bntCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            btnEventos();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            btnAlbums();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btnConfigs();
        }

        private void bntCliente_Click_1(object sender, EventArgs e)
        {
            btnClientes();
        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {

            if(TxtNome.Text == "" || TxtSenha.Text == "" || TxtTelefone.Text == "" || TxtEmail.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                try
                {
                    DAL.AdmDAL admDAL = new DAL.AdmDAL();
                    int id = Login.usuarioLogado.Id;
                    admDAL.AtualizarAdm(id, TxtNome.Text, TxtEmail.Text, TxtTelefone.Text, TxtSenha.Text);
                    if (admDAL != null)
                    {
                        MessageBox.Show("Adm atualizado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Adm não atualizado.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
                }

            }
        }

        private void Configuracao_Load(object sender, EventArgs e)
        {
            TxtNome.Text = Login.usuarioLogado.Nome;
            TxtEmail.Text = Login.usuarioLogado.Email;
            TxtSenha.Text = Login.usuarioLogado.Senha;
            TxtTelefone.Text = Login.usuarioLogado.Telefone;
        }
    }
}
