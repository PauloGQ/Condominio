﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Service
{
    public class ComunicadoController
    {
        public List<Comunicado> Listar()
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = "SELECT s.NomeSindico, c.IdComunicado, c.Titulo, c.DataComunicado, c.Descricao, c.IdSindicoFkComunicado  FROM comunicado c JOIN sindico s ON c.IdSindicoFkComunicado = s.IdSindico";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "Comunicado");

                        List<Comunicado> lstRetorno = ds.Tables["comunicado"].AsEnumerable().Select(x => new Comunicado
                        {
                            IdComunicado = x.Field<int>("IdComunicado"),
                            Titulo = x.Field<string>("Titulo"),
                            DataComunicado = x.Field<DateTime>("DataComunicado"),
                            Descricao = x.Field<string>("Descricao"),
                            IdSindicoFkComunicado = x.Field<int>("IdSindicoFkComunicado"),
                            NomeSindico = x.Field<string>("NomeSindico"),

                        }).ToList();

                        return lstRetorno;
                    }
                }
            }
        }

        public Comunicado Buscar(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {

                    string query = $"SELECT * FROM comunicado c JOIN sindico s ON c.IdSindicoFkComunicado = s.IdSindico WHERE c.IdComunicado = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    Comunicado retorno = new Comunicado();

                    while (reader.Read())
                    {

                        retorno.IdComunicado = (int)reader["IdComunicado"];
                        retorno.DataComunicado = (DateTime)reader["DataComunicado"];
                        retorno.Titulo = (string)reader["Titulo"];
                        retorno.Descricao = (string)reader["Descricao"];
                        retorno.IdSindicoFkComunicado = (int)reader["IdSindicoFkComunicado"];
                    }

                    return retorno;
                }
            }
        }

        public void Inserir(Comunicado registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio;Allow User Variables=True; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"INSERT INTO comunicado(IdComunicado, Titulo, DataComunicado, Descricao, IdSindicoFkComunicado) VALUES('{registro.IdComunicado}', '{registro.Titulo}', '{registro.DataComunicado:yyyy-MM-dd}', '{registro.Descricao}', '{registro.IdSindicoFkComunicado}');";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                }

            }
        }

        public void Atualizar(Comunicado registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $@"UPDATE comunicado c SET 
                                    c.DataComunicado = '{registro.DataComunicado:yyyy-MM-dd}',
                                    c.Titulo = '{registro.Titulo}',
                                    c.Descricao = '{registro.Descricao}',
                                    c.IdSindicoFkComunicado = '{registro.IdSindicoFkComunicado}'
                                    WHERE c.IdComunicado = {registro.IdComunicado};";

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
                    string query = $"DELETE FROM comunicado WHERE IdComunicado = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
