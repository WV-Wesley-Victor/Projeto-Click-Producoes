using System;
using System.Data.SqlClient;

class Program
{
    public static ProjetoG3_Fotografo.DAL.AdmDAL admLogado { get; set; }

    static void Main(string[] args)
    {
        try
        {
            string nome = "Victor";
            string senha = "qwe";
            ProjetoG3_Fotografo.DAL.AdmDAL usuario = new ProjetoG3_Fotografo.DAL.AdmDAL().EfetuarLogin(nome, senha);
            if (usuario.Nome != null && usuario.Senha != null)
            {
                Console.WriteLine("Adm logado com sucesso.");
                admLogado = usuario;
            }
            else
            {
                Console.WriteLine("Adm não encontrado.");
            }
        }
        catch (SqlException ex)
        {
            Console.WriteLine("Erro ao acessar o banco de dados: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocorreu um erro inesperado: " + ex.Message);
        }
        Console.ReadKey();
    }
}