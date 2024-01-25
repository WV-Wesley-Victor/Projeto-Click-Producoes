using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoG3_Fotografo
{
    public partial class Eventos : Form
    {
        int mes, ano;
        public static int static_mes, static_ano;

        public Eventos()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        #region Metodos
        public void MostrarDias()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            ano = now.Year;



            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = NomeMes + " " + ano;

            static_mes = mes;
            static_ano = ano;

            //primeiro dia do mes
            DateTime ComecoSemana = new DateTime(ano, mes, 1);

            //contagem dos dias do mes
            int Dias = DateTime.DaysInMonth(ano, mes);

            int DiaSemana = Convert.ToInt32(ComecoSemana.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiaSemana; i++)
            {
                UserControlCampos ucCampos = new UserControlCampos();
                DatasContainer.Controls.Add(ucCampos);
            }

            for (int i = 1; i <= Dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.days(i);
                DatasContainer.Controls.Add(ucdias);
            }
        }

        public void AvancarMes()
        {
            // Limpa o conteiner
            DatasContainer.Controls.Clear();

            mes++;

            if (mes > 12)
            {
                mes = 1;
                ano++;
            }

            static_mes = mes;
            static_ano = ano;

            // Mostra Mes e Ano
            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = NomeMes + " " + ano;

            // Dia 1 do mes
            DateTime ComecoSemana = new DateTime(ano, mes, 1);

            // Contar os dias do Mes
            int Dias = DateTime.DaysInMonth(ano, mes);

            // Converte ComeçoSemana para Inteiro
            int DiaSemana = Convert.ToInt32(ComecoSemana.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiaSemana; i++)
            {
                UserControlCampos ucCampos = new UserControlCampos();
                DatasContainer.Controls.Add(ucCampos);
            }

            for (int i = 1; i <= Dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.days(i);
                DatasContainer.Controls.Add(ucdias);
            }
        }

        public void RetrocederMes()
        {
            // Limpa o conteiner
            DatasContainer.Controls.Clear();

            mes--;


            if (mes < 1)
            {
                mes = 12;
                ano--;
            }

            static_mes = mes;
            static_ano = ano;

            // Mostra Mes e Ano
            String NomeMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lbData.Text = NomeMes + " " + ano;

            // Dia 1 do mes
            DateTime ComecoSemana = new DateTime(ano, mes, 1);

            // Contar os dias do Mes
            int Dias = DateTime.DaysInMonth(ano, mes);

            // Converte ComeçoSemana para Inteiro
            int DiaSemana = Convert.ToInt32(ComecoSemana.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < DiaSemana; i++)
            {
                UserControlCampos ucCampos = new UserControlCampos();
                DatasContainer.Controls.Add(ucCampos);
            }

            for (int i = 1; i <= Dias; i++)
            {
                UserControlDias ucdias = new UserControlDias();
                ucdias.days(i);
                DatasContainer.Controls.Add(ucdias);
            }
        }
        #endregion

        private void guna2Button14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAvancar_Click(object sender, EventArgs e)
        {
            AvancarMes();
        }

        private void bntCliente_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Show();
            this.Hide();
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.Show();
            this.Hide();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            RetrocederMes();
        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            MostrarDias();
        }
    }
}
