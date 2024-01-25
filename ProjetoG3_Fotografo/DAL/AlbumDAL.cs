using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoG3_Fotografo.DAL
{
    public class AlbumDAL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public int IdCliente { get; set; }

        public void CadastrarAlbum(string nome, string descricao, int idCliente)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("INSERT INTO Album VALUES ('" + nome + "','" + descricao + "',  getdate() ," + idCliente+ ");", conn);
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

        public void ExcluirAlbum(int id)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("delete from Album where IdAlbum = " + id, conn);
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

        public AlbumDAL BuscarAlbum(int idAlbum)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Album where IdAlbum ="+ idAlbum + "", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                AlbumDAL album = new AlbumDAL();
                if (dr.HasRows)
                {
                    dr.Read();
                    album.Id = (int)dr["IdAlbum"];
                    album.Nome = (string)dr["NomeAlbum"];
                    album.Descricao = (string)dr["Descricao"];
                    album.IdCliente = (int)dr["FkCliente"];
                }
                else
                {
                    MessageBox.Show("Ops... Álbum não encontrado");
                }
                return album;
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

        public void AtualizarAlbum(int id, string nome, string descricao, int idCliente)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("update Album set NomeAlbum='" + nome + "', Descricao='" + descricao + "', DataHoraCadastro= getdate(), FkCliente= "+idCliente+ " WHERE IdAlbum =" + id, conn);
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

        public List<AlbumDAL> ListarAlbum()
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            try
            {
                string stringSql = AdmDAL.stringSQL;
                conn = new SqlConnection(stringSql);
                conn.Open();
                cmd = new SqlCommand("select * from Album", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                List<AlbumDAL> listAlbum = new List<AlbumDAL>();
                while (dr.Read())
                {
                    AlbumDAL albumDAL = new AlbumDAL();
                    albumDAL.Id = Convert.ToInt32(dr["IdAlbum"]);
                    albumDAL.Nome = (string)dr["NomeAlbum"];
                    albumDAL.Descricao = (string)dr["Descricao"];
                    albumDAL.DataCadastro = Convert.ToDateTime(dr["DataHoraCadastro"]);
                    albumDAL.IdCliente = Convert.ToInt32(dr["FkCliente"]);
                    listAlbum.Add(albumDAL);
                }
                return listAlbum;
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