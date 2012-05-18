using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gerenciamento_de_Contas
{
    class DadosProjecoesPagar
    {
        //Connection string
        string strConnection = ConfigurationManager.ConnectionStrings["Gerenciamento_de_Contas.Properties.Settings.Contas_DBConnectionString"].ConnectionString;

        //SQL strings
        string strInsert = "INSERT INTO Projecoes_Pagar (mes, valor) VALUES (@mes, @valor)";
        string strDelete = "DELETE FROM Projecoes_Pagar WHERE mes = @mes";
        string strUpdate = "UPDATE Projecoes_Pagar SET valor = @valor WHERE mes = @mes";

        public void Inserir(string mes, double valor)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strInsert, Connection))
                {
                    Command.Parameters.AddWithValue("@mes", mes);
                    Command.Parameters.AddWithValue("@valor", valor);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    Connection.Close();
                }

            }
        }

        public void Atualizar(string mes, double valor)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strUpdate, Connection))
                {
                    Command.Parameters.AddWithValue("@mes", mes);
                    Command.Parameters.AddWithValue("@valor", valor);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    Connection.Close();
                }

            }
        }

        public void Excluir(string mes)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strDelete, Connection))
                {
                    Command.Parameters.AddWithValue("@mes", mes);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    Connection.Close();
                }
            }
        }
    }
}
