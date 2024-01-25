using System;
using System.Data.SqlClient;

class AlbumAtualizar
{
    static void Main(string[] args)
    {
        try
        {
            
            int id = 9;
            string nome = "Wesley";
            string descricao = "Descrição das fotos";
            int idCliente = 2;
            ProjetoG3_Fotografo.DAL.AlbumDAL AlbumDAL = new ProjetoG3_Fotografo.DAL.AlbumDAL();
            AlbumDAL.AtualizarAlbum(id, nome, descricao, idCliente);
            if (AlbumDAL != null)
            {
                Console.WriteLine("ALbum atualizado com sucesso.");
            }
            else
            {
                Console.WriteLine("ALbum não atualizado.");
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