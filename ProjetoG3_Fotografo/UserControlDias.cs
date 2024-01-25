using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjetoG3_Fotografo
{
    public partial class UserControlDias : UserControl
    {
        public static string static_dia;
           public UserControlDias()
        {
            InitializeComponent();
            // Chamar o método MostrarEvento no evento Load
            Load += OnLoad;
        }


        #region Metodos

        public void MostrarEvento()
        {
            string connString = @"Data Source=FAC0539641W10-1;Initial Catalog=ClickProducoesDB;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string connCasa = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ClickProducoesDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;\r\n";


            using (SqlConnection conn = new SqlConnection(connString))
            {
                // Open the connection
                conn.Open();

                //string sql = "SELECT *FROM Calendario WHERE DataCalendario = @DataCalendario";

                //using (SqlCommand cmd = new SqlCommand(sql, conn))
                //{
                //    cmd.Parameters.AddWithValue("@DataCalendario", UserControlDias.static_dia + "/" + Eventos.static_mes + "/" + Eventos.static_ano);

                //    using (SqlDataReader reader = cmd.ExecuteReader())
                //    {
                //        if (reader.Read())
                //        {
                //            LbEvento.Text = reader["Evento"].ToString();
                //        }
                //    }
                //}
            }
        }




        private void OnLoad(object sender, EventArgs e)
        {
            static_dia = lbDias.Text;
            MostrarEvento();
        }

        private void OnUserControlDiasClick(object sender, EventArgs e)
        {
            EventoCalendario eventoCalendario = new EventoCalendario();
            eventoCalendario.Show();
        }

        #endregion

        private void UserControlDias_Load(object sender, EventArgs e)
        {
            static_dia = lbDias.Text;
            MostrarEvento();
        }


        public void days(int numday)
        {
            lbDias.Text = numday + "";
        }

        private void UserControlDias_Click(object sender, EventArgs e)
        {
            static_dia = lbDias.Text;
           
            //EventoCalendario eventoCalendario = new EventoCalendario();
            //eventoCalendario.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void LbEvento_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}
