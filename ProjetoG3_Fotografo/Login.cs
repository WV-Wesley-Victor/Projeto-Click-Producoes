using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoG3_Fotografo.DAL;

namespace ProjetoG3_Fotografo
{
    public partial class Login : Form
    {
        public static AdmDAL usuarioLogado;
        public Login()
        {
            InitializeComponent();
        }

        #region 
        private void AlteracaoSenha()
        {
            RecadastrarSenha recadastrarSenha = new RecadastrarSenha();
            recadastrarSenha.Show();
            this.Hide();
        }

        private void btn_login()
        {
            if(TxtEmail.Text == "" || TxtSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                AdmDAL usuario = EfetuarLogin(TxtEmail.Text, TxtSenha.Text);
                if (usuario != null && usuario.Id > 0)
                {
                    usuarioLogado = usuario;
                    Funcionario funcionario = new Funcionario();
                    funcionario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Nome do usuario ou senha incorretos");
                }
            }
        }
        private AdmDAL EfetuarLogin(string nome, string senha)
        {
            AdmDAL admDal = new AdmDAL();
            return admDal.EfetuarLogin(nome, senha);
        }
        #endregion

        private void LinkAlteracaoSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AlteracaoSenha();
        }


        #region
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion  

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            btn_login();
        }
        
    }
}
