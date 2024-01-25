using System;
using System.Data.SqlClient;

class EventoExcluir
{
    static void Main(string[] args)
    {
        try
        {
            int id = 1;

            ProjetoG3_Fotografo.DAL.EventoDal eventoDAL = new ProjetoG3_Fotografo.DAL.EventoDal();
            eventoDAL.RemoverEvento(id);
            if (eventoDAL != null)
            {
                Console.WriteLine("evento Removido com sucesso.");
            }
            else
            {
                Console.WriteLine("evento não Removido.");
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