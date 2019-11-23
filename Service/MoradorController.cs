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
    public class MoradorController
    {

        public List<Morador> Listar()
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = "SELECT IdMorador, Nome, Email,Cpf, telefone FROM morador";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "Morador");

                        List<Morador> lstRetorno = ds.Tables["morador"].AsEnumerable().Select(x => new Morador
                        {
                            IdMorador = x.Field<int>("IdMorador"),
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

        public Morador Buscar(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {

                    string query = $"SELECT * FROM morador m JOIN apartamento a ON m.IdApartamentoFkMorador = a.IdApartamento WHERE m.IdMorador = {id}"; 

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    Morador retorno = new Morador();

                    while (reader.Read())
                    {

                        retorno.IdMorador = (int)reader["IdMorador"];
                        retorno.Nome = (string)reader["Nome"];
                        retorno.Email = (string)reader["Email"];
                        retorno.Cpf = (string)reader["Cpf"];
                        retorno.Telefone = (string)reader["Telefone"];
                        retorno.IdApartamentoFkMorador = (int)reader["IdApartamentoFkMorador"];
                        retorno.Apt = (int)reader["Apt"];
                        retorno.Bloco = (string)reader["Bloco"];
                        retorno.Vaga = (string)reader["Vaga"];


                    }

                    return retorno;
                }
            }
        }

        public void Inserir(Morador registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio;Allow User Variables=True; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"INSERT INTO morador(IdMorador, Nome, Email, Cpf, Telefone, IdApartamentoFkMorador) VALUES('{registro.IdMorador}', '{registro.Nome}', '{registro.Email}', '{registro.Cpf}', '{registro.Telefone}', '{registro.IdApartamentoFkMorador}');";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                        
                }

            }
        }

        public void Atualizar(Morador registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $@"UPDATE morador m SET 
                                    m.Nome = '{registro.Nome}',
                                    m.Email = '{registro.Email}',
                                    m.Cpf = '{registro.Cpf}',
                                    m.Telefone = '{registro.Telefone}',
                                    m.IdApartamentoFkMorador = '{registro.IdApartamentoFkMorador}'
                                    WHERE m.IdMorador = {registro.IdMorador};";

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
                    string query = $"DELETE FROM morador WHERE IdMorador = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

