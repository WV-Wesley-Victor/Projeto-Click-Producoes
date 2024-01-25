using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjetoG3_Fotografo.Evento2;

namespace ProjetoG3_Fotografo.DAL
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string TipoEvento { get; set; }
        public string NomeEvento { get; set; }
        public string DescEvento { get; set; }
        public string Horario { get; set; }
        public string DataCalendario { get; set; }

    }
    public class EventoDal
    {
        string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoG3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string connCasa = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjetoG3;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;\r\n";
        public void CriarEvento(string Tipo,string evento,string hora, string desc, string Data)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Evento VALUES ('" + Tipo + "','" + evento + "','" + desc + "','" + hora + "','" + Data + "',  getdate());", conn);
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

        public List<Evento> ObterEventos()
        {
            List<Evento> eventos = new List<Evento>();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evento", conn);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Evento evento = new Evento
                        {
                            IdEvento = Convert.ToInt32(reader["idEvento"]),
                            TipoEvento = Convert.ToString(reader["TipoEvento"]),
                            NomeEvento = Convert.ToString(reader["Evento"]),
                            DescEvento = Convert.ToString(reader["Descricao"]),
                            Horario = Convert.ToString(reader["Horario"]),
                            DataCalendario = Convert.ToString(reader["DataCalendario"]),
                        };

                        eventos.Add(evento);
                    }
                }
            }
            return eventos;
        }

        public void RemoverEvento(int id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                
                conn = new SqlConnection(connString);
                conn.Open();
                cmd = new SqlCommand("delete from Evento where IdEvento = " + id, conn);
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
