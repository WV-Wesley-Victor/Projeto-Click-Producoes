using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoG3_Fotografo
{
    public partial class CadastrarAlbum : Form
    {
        public CadastrarAlbum()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #region metodos
        public void btn_cliente()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Close();
        }
        public void btn_Eventos()
        {
            Evento3 eventos = new Evento3();
            eventos.Show();
            this.Close();
        }
        public void btn_Album()
        {
            Album album = new Album();
            album.Show();
            this.Close();
        }
        public void btn_config()
        {
            Configuracao configuracao = new Configuracao();
            configuracao.Show();
            this.Close();
        }
        public void btn_logout()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        public void cadastrarAlbum()
        {
            try
            {
                DAL.AlbumDAL AlbumDAL = new DAL.AlbumDAL();
                AlbumDAL.CadastrarAlbum(txtNomeAlbum.Text, txtDescricaoAlbum.Text, Convert.ToInt32(txtIdCliente.Text));
                if (AlbumDAL != null)
                {
                    MessageBox.Show("ALbum cadastrado com sucesso.");
                }
                else
                {
                    MessageBox.Show("ALbum não cadastrado.");
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
        #endregion

        #region 

        #endregion

        private void btnCadastrarAlbum_Click(object sender, EventArgs e)
        {
            cadastrarAlbum();
        }

        private void bntCliente_Click_2(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnEvento_Click_2(object sender, EventArgs e)
        {
            btn_Eventos();
        }

        private void btnAlbum_Click_2(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click_2(object sender, EventArgs e)
        {
            btn_config();
        }

        private void fotoPerfil_Click(object sender, EventArgs e)
        {
            btn_logout();
        }

        private void nomeAdm_Click(object sender, EventArgs e)
        {}

        private void CadastrarAlbum_Load(object sender, EventArgs e)
        {
            nomeAdm.Text = Login.usuarioLogado.Nome;
        }
    }
}
