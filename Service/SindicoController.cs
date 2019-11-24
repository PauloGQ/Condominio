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
    public class SindicoController
    {
            public List<Sindico> Listar()
            {
                string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

                using (MySqlConnection conn = new MySqlConnection(strConexao))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        string query = "SELECT IdSindico, Nome, Email,Cpf, telefone FROM sindico";

                        cmd.Connection = conn;
                        cmd.CommandText = query;

                        using (MySqlDataAdapter da = new MySqlDataAdapter())
                        {
                            da.SelectCommand = cmd;

                            DataSet ds = new DataSet();
                            da.Fill(ds, "Sindico");

                            List<Sindico> lstRetorno = ds.Tables["sindico"].AsEnumerable().Select(x => new Sindico
                            {
                                IdSindico = x.Field<int>("IdSindico"),
                                Nome = x.Field<string>("Nome"),
                                Email = x.Field<string>("Email"),
                                Cpf = x.Field<string>("Cpf"),
                                Telefone = x.Field<string>("Telefone")

                            }).ToList();

                            return lstRetorno;
                        }
                    }
                }
            }

            public Sindico Buscar(int id)
            {
                string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

                using (MySqlConnection conn = new MySqlConnection(strConexao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {

                        string query = $"SELECT * FROM sindico WHERE IdSindico = {id}";

                        cmd.Connection = conn;
                        cmd.CommandText = query;

                        MySqlDataReader reader = cmd.ExecuteReader();

                        Sindico retorno = new Sindico();

                        while (reader.Read())
                        {

                            retorno.IdSindico = (int)reader["IdSindico"];
                            retorno.Nome = (string)reader["Nome"];
                            retorno.Email = (string)reader["Email"];
                            retorno.Cpf = (string)reader["Cpf"];
                            retorno.Telefone = (string)reader["Telefone"];


                        }

                        return retorno;
                    }
                }
            }

            public void Inserir(Sindico registro)
            {
                string strConexao = "SERVER=localhost; DataBase=condominio;Allow User Variables=True; UID=root; pwd=";

                using (MySqlConnection conn = new MySqlConnection(strConexao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        string query = $"INSERT INTO sindico(IdSindico, Nome, Email, Cpf, Telefone) VALUES('{registro.IdSindico}', '{registro.Nome}', '{registro.Email}', '{registro.Cpf}', '{registro.Telefone}');";
                        cmd.Connection = conn;
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();

                    }

                }
            }

            public void Atualizar(Sindico registro)
            {
                string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

                using (MySqlConnection conn = new MySqlConnection(strConexao))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        string query = $@"UPDATE sindico s SET 
                                    s.Nome = '{registro.Nome}',
                                    s.Email = '{registro.Email}',
                                    s.Cpf = '{registro.Cpf}',
                                    s.Telefone = '{registro.Telefone}'
                                    WHERE s.IdSindico = {registro.IdSindico};";

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
                        string query = $"DELETE FROM sindico WHERE IdSindico = {id}";

                        cmd.Connection = conn;
                        cmd.CommandText = query;

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
