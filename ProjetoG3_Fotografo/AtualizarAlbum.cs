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
    public partial class AtualizarAlbum : Form
    {
        public int Album { get; set; }
        public AtualizarAlbum()
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

        public void btn_Atualizar()
        {
            try
            {
                int id = Album;
                DAL.AlbumDAL AlbumDAL = new DAL.AlbumDAL();
                AlbumDAL.AtualizarAlbum(id, txtNomeAlbum.Text, txtDescricaoAlbum.Text, Convert.ToInt32(txtIdCliente.Text));
                if (AlbumDAL != null)
                {
                    MessageBox.Show("ALbum atualizado com sucesso.");
                }
                else
                {
                    MessageBox.Show("ALbum não atualizado.");
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

        public void btn_Busca()
        {
            try
            {
                DAL.AlbumDAL albumDalInstance = new DAL.AlbumDAL();
                int idAlbum = Convert.ToInt32(txtIdAlbum.Text);
                DAL.AlbumDAL album = albumDalInstance.BuscarAlbum(idAlbum);
                if (album != null)
                {
                    MessageBox.Show("ALbum encontrado com sucesso.");
                    txtNomeAlbum.Text = album.Nome;
                    txtDescricaoAlbum.Text = album.Descricao;
                    txtIdCliente.Text = Convert.ToString(album.IdCliente);
                    Album = idAlbum;
                }
                else
                {
                    MessageBox.Show("ALbum não encontrado.");
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
        public void btn_Evento()
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
        #endregion


        private void btnAtualizarAlbum_Click(object sender, EventArgs e)
        {
           btn_Atualizar();
        }

        private void txtIdAlbum_TextChanged(object sender, EventArgs e)
        {}

        private void btnBuscarÁlbum_Click(object sender, EventArgs e)
        {
            btn_Busca();    
        }

        private void bntCliente_Click(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            btn_Evento();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btn_config();
        }

        private void fotoPerfil_Click(object sender, EventArgs e)
        {
            btn_logout();
        }

        private void AtualizarAlbum_Load(object sender, EventArgs e)
        {
            nomeAdm.Text = Login.usuarioLogado.Nome;
        }
    }
}
