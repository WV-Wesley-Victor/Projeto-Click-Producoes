using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace LojaVirtualWebUI
{
    public partial class Login : System.Web.UI.Page
    {
        public static UsuarioDAL usuarioLogado;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtPassword.Text;
            UsuarioDAL usuario = new UsuarioDAL();
            usuario = usuario.EfetuarLogin(email, senha);
            if (usuario == null || usuario.Email == null || usuario.Senha == null)
            {
                LblResposta.Text = "Ops.. dados não encontrados.";

                ClientScript.RegisterStartupScript(this.GetType(), "clearMessage", "setTimeout(function() { document.getElementById('" + LblResposta.ClientID + "').innerHTML = ''; }, 3000);", true);
            }
            else
            {
                usuarioLogado = usuario;
                Session["ClienteId"] = usuario.Id;
                Session["ClienteNome"] = usuario.Nome;

                AlbumDAL albumDAL = new AlbumDAL();

                string nomeAlbum = albumDAL.AlbumCliente(Convert.ToInt32(usuario.Id));

                usuario.NomeAlbum = nomeAlbum;
                Session["ClienteAlbum"] = usuario.NomeAlbum;
                Response.Redirect("Portfolio.aspx");
            }
        }

        protected void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class UsuarioDAL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        public string NomeAlbum { get; set; }

        public UsuarioDAL EfetuarLogin(string email, string senha)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoG3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Cliente where Email='" + email + "' AND Senha ='" + senha + "'", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            UsuarioDAL usuario = new UsuarioDAL();
            if (dr.Read())
            {
                usuario.Id = Convert.ToInt32(dr["IdUsuario"]);
                usuario.Nome = (string)dr["NomeDoCliente"];
                usuario.Senha = (string)dr["Senha"];
                usuario.Email = (string)dr["Email"];
                usuario.Telefone = (string)dr["Telefone"];
                usuario.DataCadastro = Convert.ToDateTime(dr["DataHoraCadastro"]);
            }
            return usuario;
        }
    }

    public class AlbumDAL
    {
        public string NomeAlbum { get; set; }

        public string AlbumCliente(int id)
        {
            string nomeAlbum = "";
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoG3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT NomeAlbum FROM Album WHERE FkCliente =" + id, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                nomeAlbum = dr["NomeAlbum"].ToString();
            }
            dr.Close();
            cmd.Dispose();
            conn.Close();
            return nomeAlbum;
        }
    }
}