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
using ProjetoG3_Fotografo.DAL;

namespace ProjetoG3_Fotografo
{
    public partial class Evento3 : Form
    {
        public Evento3()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string connCasa = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ClickProducoesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;\r\n";


        #region metodos


        public void pesquisa(string categoria, string pesquisa)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            if (categoria == "")
            {
                SqlCommand cmd = new SqlCommand("select * from Evento where " + categoria + " like '%" + pesquisa + "%' order by dataCricao desc", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    gridEventos.DataSource = bs;
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from Evento where " + categoria + " like '%" + pesquisa + "%' order by DataCalendario desc", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    gridEventos.DataSource = bs;
                }
            }
        }


        public void dadosEvento()
        {

            DAL.EventoDal eventoDal = new DAL.EventoDal();
            List<Evento> eventos = eventoDal.ObterEventos();

            BindingSource bs = new BindingSource();
            bs.DataSource = eventos;

            gridEventos.DataSource = bs;
        }

        public void RemoverEvento()
        {
            DAL.EventoDal eventoDal = new DAL.EventoDal();
            if (gridEventos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = gridEventos.SelectedRows[0];
                eventoDal.RemoverEvento(Convert.ToInt32(selectedRow.Cells[0].Value));
                List<Evento> eventos = eventoDal.ObterEventos();
                BindingSource bs = new BindingSource();
                bs.DataSource = eventos;
                gridEventos.DataSource = bs;
            }

        }

        public void AddEvento()
        {
            CriarEvento2 criarEvento2 = new CriarEvento2();
            criarEvento2.Show();
            this.Hide();
        }

        public void btn_cliente()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Close();
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
            AtualizarAlbum atualizarAlbum = new AtualizarAlbum();
            atualizarAlbum.Show();
            this.Hide();
        }

        #endregion

        private void Evento3_Load(object sender, EventArgs e)
        {
            gridEventos.ColumnHeadersHeight = 40;
            dadosEvento();

            txtNomeAdm.Text = Login.usuarioLogado.Nome;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            RemoverEvento();
            MessageBox.Show("Evento Excluido");
        }

        private void btnAddEvento_Click(object sender, EventArgs e)
        {
            AddEvento();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btn_logout();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            pesquisa(txtCategoria.Text, txtPesquisa.Text);
        }

        private void txtCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarAlbum_Click(object sender, EventArgs e)
        {
           Eventos eventos = new Eventos();
            eventos.Show();
        }
    }
}
