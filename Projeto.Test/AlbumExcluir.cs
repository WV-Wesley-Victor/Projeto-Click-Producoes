using System;
using System.Data.SqlClient;

class AlbumExcluir
{
    static void Main(string[] args)
    {
        try
        {
            int id = 8;
            ProjetoG3_Fotografo.DAL.AlbumDAL AlbumDAL = new ProjetoG3_Fotografo.DAL.AlbumDAL();
            AlbumDAL.ExcluirAlbum(id);
            if (AlbumDAL != null)
            {
                Console.WriteLine("ALbum excluido com sucesso.");
            }
            else
            {
                Console.WriteLine("ALbum não excluido.");
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