using ProjetoG3_Fotografo.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoG3_Fotografo
{
    public partial class Evento2 : Form
    {

        public Evento2()
        {
            InitializeComponent();
        }

        string connString = @"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region metodos


        public void pesquisa(string categoria, string pesquisa)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            if (categoria == "")
            {
                SqlCommand cmd = new SqlCommand("select * from Calendario where " + categoria + " like '%" + pesquisa + "%' order by dataCricao desc", conn);
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
                SqlCommand cmd = new SqlCommand("select * from Calendario where " + categoria + " like '%" + pesquisa + "%' order by DataCalendario desc", conn);
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
            Evento2 evento2 = new Evento2();
            evento2.Show();
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

        #endregion

        private void BtnAddEvento_Click_1(object sender, EventArgs e)
        {
            

        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            
        }

        private void Evento2_Load_1(object sender, EventArgs e)
        {
            
        }

        private void bntCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {


            


        }

        private void txtCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnAddEvento_Click(object sender, EventArgs e)
        {
            AddEvento();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            RemoverEvento();
            MessageBox.Show("Evento Excluido");
        }

        private void Evento2_Load(object sender, EventArgs e)
        {
            dadosEvento();
        }

        private void bntCliente_Click_1(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnEvento_Click_1(object sender, EventArgs e)
        {
            btn_Evento();
        }

        private void btnAlbum_Click_1(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnConfiguracao_Click_1(object sender, EventArgs e)
        {
            btn_config();
        }

        private void txtPesquisa_TextChanged_1(object sender, EventArgs e)
        {
            pesquisa(txtCategoria.Text, txtPesquisa.Text);
        }

        private void txtCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPesquisa.Enabled = true;
        }

        //System.Data.SqlDbType."converte o que vc quer"
    }
}
