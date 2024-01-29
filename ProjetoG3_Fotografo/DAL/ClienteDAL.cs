using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjetoG3_Fotografo.DAL
{
    public class ClienteDAL

    {
        string connString = @"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void CadastrarCliente(string nome, string senha, string rg, string cpf, string endereco, string telefone, string email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Cliente values ('"+nome+"', '"+senha+"', '"+rg+"', '"+cpf+"', '"+endereco+"', '"+telefone+"', '"+email+"', GETDATE())", conn);
            cmd.ExecuteNonQuery();

        }
        public void AtualizarCliente(string nome, string senha, string rg, string cpf, string endereco, string telefone, string email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Cliente SET NomeDoCliente = '" + nome + "', Senha = '" + senha + "', RG = '" + rg + "', CPF = '" + cpf + "', Endereco = '" + endereco + "', Telefone = '" + telefone + "', Email = '" + email + "'", conn);
            cmd.ExecuteNonQuery();
        }
        public void ExcluirCliente(int id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {

                conn = new SqlConnection(connString);
                conn.Open();
                cmd = new SqlCommand("delete from Cliente where IdCliente = " + id, conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
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