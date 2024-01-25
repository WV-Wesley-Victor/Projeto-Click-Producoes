using System;
using System.Data.SqlClient;

class AlbumCadastro
{
    static void Main(string[] args)
    {
        try
        {
            string nome = "Album5";
            string descricao = "Descrição do album";
            int idCliente = 1;
            ProjetoG3_Fotografo.DAL.AlbumDAL AlbumDAL = new ProjetoG3_Fotografo.DAL.AlbumDAL();
            AlbumDAL.CadastrarAlbum(nome, descricao, idCliente);
            if (AlbumDAL != null)
            {
                Console.WriteLine("ALbum cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("ALbum não cadastrado.");
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