using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoG3_Fotografo.DAL
{
    public class AdmDAL
    {
        public static string stringSQL { get; set; } = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Projeto;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }

        public AdmDAL EfetuarLogin(string nome, string senha)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            try
            {
                conn = new SqlConnection(stringSQL);
                conn.Open();
                cmd = new SqlCommand("select * from Administrador where NomeAdministrador='" + nome + "' AND Senha ='" + senha + "'", conn);
                dr = cmd.ExecuteReader();
                AdmDAL usuario = new AdmDAL();
                if (dr.Read())
                {
                    usuario.Id = (int)dr["IdAdministrador"];
                    usuario.Nome = (string)dr["NomeAdministrador"];
                    usuario.Senha = (string)dr["Senha"];
                    usuario.Email = (string)dr["Email"];
                    usuario.Telefone = (string)dr["Telefone"];
                    usuario.DataCadastro = (DateTime)dr["DataHoraCadastro"];
                }
                return usuario;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
                if (dr != null)
                {
                    dr.Dispose();
                }
                if (conn != null)
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
        }
    }
}