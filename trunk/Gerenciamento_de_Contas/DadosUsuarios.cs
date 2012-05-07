using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gerenciamento_de_Contas
{
    class DadosUsuarios
    {
        //Connection string
        string strConnection = ConfigurationManager.ConnectionStrings["Gerenciamento_de_Contas.Properties.Settings.Contas_DBConnectionString"].ConnectionString;

        //SQL strings
        string strSelectLogin = "SELECT * FROM Usuarios WHERE (login = @login) AND (senha = @senha)";

        public bool Login(string login, string senha)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strSelectLogin, Connection))
                {
                    Command.Parameters.AddWithValue("@login", login);
                    Command.Parameters.AddWithValue("@senha", senha);

                    Connection.Open();

                    Command.ExecuteReader();

                    Connection.Close();

                    return true;
                }
            }
        }
    }
}
