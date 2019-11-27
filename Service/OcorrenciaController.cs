using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Service
{
    public class OcorrenciaController
    {
        public List<Ocorrencia> Listar()
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = "SELECT o.IdOcorrencia, o.IdMoradorFkOcorrencia, o.IdSindicoFkOcorrencia, o.Tipo, o.DataOcorrencia, o.Descricao, o.Status, m.Nome, s.NomeSindico FROM ocorrencia o JOIN morador m ON o.IdMoradorFkOcorrencia = m.IdMorador JOIN sindico s ON o.IdSindicoFkOcorrencia = s.IdSindico;";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "Ocorrencia");

                        List<Ocorrencia> lstRetorno = ds.Tables["ocorrencia"].AsEnumerable().Select(x => new Ocorrencia
                        {
                            IdOcorrencia = x.Field<int>("IdOcorrencia"),
                            IdMoradorFkOcorrencia = x.Field<int>("IdMoradorFkOcorrencia"),
                            IdSindicoFkOcorrencia = x.Field<int>("IdSindicoFkOcorrencia"),
                            Tipo = x.Field<string>("Tipo"),
                            DataOcorrencia = x.Field<string>("DataOcorrencia"),
                            Descricao = x.Field<string>("Descricao"),
                            Nome = x.Field<string>("Nome"),
                            NomeSindico = x.Field<string>("NomeSindico"),
                            Status = x.Field<string>("Status"),




                        }).ToList();

                        return lstRetorno;
                    }
                }
            }
        }

        public Ocorrencia Buscar(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {

                    string query = $"SELECT * FROM ocorrencia o JOIN sindico s ON o.IdSindicoFkOcorrencia = s.IdSindico JOIN morador m ON o.IdMoradorFkOcorrencia = m.IdMorador WHERE o.IdOcorrencia = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    Ocorrencia retorno = new Ocorrencia();

                    while (reader.Read())
                    {

                        retorno.IdOcorrencia = (int)reader["IdOcorrencia"];
                        retorno.IdMoradorFkOcorrencia = (int)reader["IdMoradorFkOcorrencia"];
                        retorno.IdSindicoFkOcorrencia = (int)reader["IdSindicoFkOcorrencia"];
                        retorno.Tipo = (string)reader["Tipo"];
                        retorno.DataOcorrencia = (string)reader["DataOcorrencia"];
                        retorno.Descricao = (string)reader["Descricao"];
                        retorno.Nome = (string)reader["Nome"];
                        retorno.NomeSindico = (string)reader["NomeSindico"];
                        retorno.Status = (string)reader["Status"];

                    }

                    return retorno;
                }
            }
        }

        public void Inserir(Ocorrencia registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio;Allow User Variables=True; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"INSERT INTO ocorrencia(IdOcorrencia, IdMoradorFkOcorrencia, IdSindicoFkOcorrencia, Tipo, DataOcorrencia,Descricao, Status) VALUES('{registro.IdOcorrencia}', '{registro.IdMoradorFkOcorrencia}', '{registro.IdSindicoFkOcorrencia}', '{registro.Tipo}', '{registro.DataOcorrencia}',  '{registro.Descricao}', '{registro.Status}');";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                }

            }
        }

        public void Atualizar(Ocorrencia registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $@"";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Excluir(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"DELETE FROM ocorrencia WHERE IdOcorrencia = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
