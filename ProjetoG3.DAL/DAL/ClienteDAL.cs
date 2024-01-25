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
        public void CadastrarCliente(string nome, string senha, string rg, string cpf, string endereco, string telefone, string email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Cliente values ('"+nome+"', '"+senha+"', '"+rg+"', '"+cpf+"', '"+endereco+"', '"+telefone+"', '"+email+"')", conn);
            cmd.ExecuteNonQuery();

        }
        public void AtualizarCliente(string nome, string senha, string rg, string cpf, string endereco, string telefone, string email)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=********;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Cliente SET NomeDoCliente = '" + nome + "', Senha = '" + senha + "', RG = '" + rg + "', CPF = '" + cpf + "', Endereco = '" + endereco + "', Telefone = '" + telefone + "', Email = '" + email + "'", conn);
            cmd.ExecuteNonQuery();
        }
    }
}