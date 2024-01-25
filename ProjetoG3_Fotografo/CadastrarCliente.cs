using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoG3_Fotografo
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
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
        public void CadastroCliente(string nome, string senha, string rg, string cpf, string endereco, string tel, string email)
        {
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(rg) || string.IsNullOrWhiteSpace(cpf) || string.IsNullOrWhiteSpace(endereco) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar o cliente.");
            }
            else
            {
                DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
                clienteDAL.CadastrarCliente(nome, senha, rg, cpf, endereco, tel, email);
            }
        }
        #endregion
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            CadastroCliente(TxtNome.Text,TxtSenha.Text,TxtRg.Text,TxtCpf.Text,TxtEndereco.Text,TxtTel.Text,TxtEmail.Text) ;
            //if (string.IsNullOrWhiteSpace(TxtNome.Text) || string.IsNullOrWhiteSpace(TxtSenha.Text) || string.IsNullOrWhiteSpace(TxtRg.Text) || string.IsNullOrWhiteSpace(TxtCpf.Text) || string.IsNullOrWhiteSpace(TxtEndereco.Text) || string.IsNullOrWhiteSpace(TxtTel.Text) || string.IsNullOrWhiteSpace(TxtEmail.Text))
            //{
            //    MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar o cliente.");
            //}
            //else
            //{
            //    DAL.ClienteDAL clienteDAL = new DAL.ClienteDAL();
            //    clienteDAL.CadastrarCliente(TxtNome.Text, TxtSenha.Text, TxtRg.Text, TxtCpf.Text, TxtEndereco.Text, TxtTel.Text, TxtEmail.Text);
            //}
        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //CadastrarCliente
            CadastroCliente(TxtNome.Text, TxtSenha.Text, TxtRg.Text, TxtCpf.Text, TxtEndereco.Text, TxtTel.Text, TxtEmail.Text);
            MessageBox.Show("Cliente Cadastrado");
        }

        private void fotoPerfil_Click(object sender, EventArgs e)
        {
            btn_logout();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            nomeAdm.Text = Login.usuarioLogado.Nome;
        }
    }
}
