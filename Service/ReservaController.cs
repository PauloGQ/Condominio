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
    public class ReservaController
    {

        public List<Reserva> Listar()
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd="; 

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = "SELECT l.NomeLocal, l.Valor, m.Nome, r.IdReserva, r.IdMoradorFkReserva, r.IdLocalFkReserva, r.DataSolicitacao, r.DataReserva FROM reserva r JOIN morador m ON r.IdMoradorFkReserva = m.IdMorador JOIN local l ON r.IdLocalFkReserva = l.IdLocal;";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;

                        DataSet ds = new DataSet();
                        da.Fill(ds, "Reserva");

                        List<Reserva> lstRetorno = ds.Tables["reserva"].AsEnumerable().Select(x => new Reserva
                        {
                            NomeLocal = x.Field<string>("NomeLocal"),
                            Valor = x.Field<string>("Valor"),
                            Nome = x.Field<string>("Nome"),
                            IdReserva = x.Field<int>("IdReserva"),
                            IdMoradorFkReserva = x.Field<int>("IdMoradorFkReserva"),
                            IdLocalFkReserva = x.Field<int>("IdLocalFkReserva"),
                            DataSolicitacao = x.Field<DateTime>("DataSolicitacao"),
                            DataReserva = x.Field<DateTime>("DataReserva"),

                        }).ToList();

                        return lstRetorno;
                    }
                }
            }
        }

        public Reserva Buscar(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {

                    string query = $"SELECT * FROM reserva WHERE IdReserva = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    Reserva retorno = new Reserva();

                    while (reader.Read())
                    {

                        retorno.IdReserva = (int)reader["IdReserva"];
                     


                    }

                    return retorno;
                }
            }
        }

        public void Inserir(Reserva registro)
        {
            string strConexao = "SERVER=localhost; DataBase=condominio;Allow User Variables=True; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"INSERT INTO `reserva`(`IdReserva`, `IdMoradorFkReserva`, `IdLocalFkReserva`, `DataSolicitacao`, `DataReserva`) VALUES ('{registro.IdReserva}',{registro.IdMoradorFkReserva},{registro.IdLocalFkReserva},{registro.DataSolicitacao:yyyy-MM-dd},{registro.DataReserva:yyyy-MM-dd})";
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();

                }

            }
        }

        public void Atualizar(Reserva registro)
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
                    string query = $"DELETE FROM reserva WHERE IdReserva = {id}";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }

}

