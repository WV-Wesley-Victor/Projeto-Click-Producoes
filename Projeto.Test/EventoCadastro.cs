using System;
using System.Data.SqlClient;

class EventoCadastro
{
    static void Main(string[] args)
    {
        try
        {
            string tipo = "casamento";
            string evento = "fetsas";
            string horario = "12:15";
            string data = "25/10/15";


            ProjetoG3_Fotografo.DAL.EventoDal eventoDAL = new ProjetoG3_Fotografo.DAL.EventoDal();
            eventoDAL.CriarEvento(tipo, evento, horario,data);
            if (eventoDAL != null)
            {
                Console.WriteLine("evento cadastrado com sucesso.");
            }
            else
            {
                Console.WriteLine("evento não cadastrado.");
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