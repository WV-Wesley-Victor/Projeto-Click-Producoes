using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoG3_Fotografo
{
    public partial class CriarEvento2 : Form
    {
        string connString = @"Data Source=FAC0539680W10-1;Initial Catalog=ProjetoG3;User ID=sa;Password=123456;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public CriarEvento2()
        {
            InitializeComponent();
        }

        #region Metodo
        public void CriarEvento(string Tipo, string evento, string desc, string Hora, string Data)
        {
            DAL.EventoDal eventoDal = new DAL.EventoDal();
            eventoDal.CriarEvento(Tipo, evento, desc, Hora, Data);

        }

        public void Voltar()
        {
            Evento3 eventos = new Evento3();
            eventos.Show();
            
        }


        #endregion

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnFechar_Click_1(object sender, EventArgs e)
        {
            

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string data = CbDia.Text + "/" + CbMes.Text + "/" + CbAno.Text;
            string hora = CbHora.Text + ":" + CbMin.Text;
            CriarEvento(cbTipoEvento.Text, TxtEvento.Text, txtDesc.Text, hora, data);

            MessageBox.Show("Novo Evento Salvo");


            Voltar();
            this.Close();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Voltar();
            this.Close();
        }
    }
}
