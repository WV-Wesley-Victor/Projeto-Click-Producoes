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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string connString = @"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        #region metodos

        public void btn_addCliente()
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
            this.Hide();
        }
        public void btn_cliente()
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Hide();
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
            this.Hide();
        }
        public void btn_config()
        {
            Configuracao configuracao = new Configuracao();
            configuracao.Show();
            this.Hide();
        }

        public void btn_logout()
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        public void dadosCliente()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", conn);

            SqlDataReader dr = cmd.ExecuteReader();
            BindingSource bs = new BindingSource();

            bs.DataSource = dr;
            gridCliente.DataSource = bs;
        }


        public void buscaCliente()
        {
            string stringSql = DAL.AdmDAL.stringSQL;
            SqlConnection conn = new SqlConnection(stringSql);
            conn.Open();
            if (comboBox.Text == "")
            {
                comboBox.Text = "NomeDoCliente";
                SqlCommand cmd = new SqlCommand("select * from Cliente where " + comboBox.Text + " like '%" + txtPesquisa.Text + "%' order by DataHoraCadastro desc", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    gridCliente.DataSource = bs;
                }
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select * from Cliente where " + comboBox.Text + " like '%" + txtPesquisa.Text + "%' order by DataHoraCadastro desc", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = dr;
                    gridCliente.DataSource = bs;
                }
            }
        }

        public void excluirCliente()
        {

            DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
            int IdCliente = Convert.ToInt32(gridCliente.CurrentRow.Cells["IdUsuario"].Value);

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM Cliente WHERE IdUsuario = @ID", conn))
                {
                    cmd.Parameters.AddWithValue("@ID", IdCliente);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        gridCliente.Rows.Remove(gridCliente.CurrentRow);

                    }
                }
                conn.Close();
            }
        }
        #endregion

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            gridCliente.ColumnHeadersHeight = 40;
            dadosCliente();
            nomeAdm.Text = Login.usuarioLogado.Nome;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            btn_Eventos();
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            btn_Album();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            btn_addCliente();
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            buscaCliente();
            
        }

        private void gridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bntCliente_Click(object sender, EventArgs e)
        {
            btn_cliente();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            btn_config();
        }

        private void btnCadastrarCliente2_Click(object sender, EventArgs e)
        {
            btn_addCliente();
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            excluirCliente();
        }

        private void fotoPerfil_Click(object sender, EventArgs e)
        {
            btn_logout();
        }
    }
}
