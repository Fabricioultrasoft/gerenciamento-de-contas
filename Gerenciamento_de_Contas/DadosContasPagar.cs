using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gerenciamento_de_Contas
{
    class DadosContasPagar
    {
        //Connection string
        string strConnection = ConfigurationManager.ConnectionStrings["Gerenciamento_de_Contas.Properties.Settings.Contas_DBConnectionString"].ConnectionString;

        //SQL strings
        string strInsert = "INSERT INTO Contas_Pagar (credor, descricao, valor, data_emissao, data_vencimento, data_pagamento, forma_pagamento, multa, juros, total_parcelas, valor_parcela, situacao) VALUES (@credor, @descricao, @valor, @data_emissao, @data_vencimento, @data_pagamento, @forma_pagamento, @multa, @juros, @total_parcelas, @valor_parcela, @situacao)";
        string strDelete = "DELETE FROM Contas_Pagar WHERE id = @id";
        string strSelectbyID = "SELECT * FROM Contas_Pagar WHERE (CAST(id AS varchar(20)) LIKE '%' + @id)";
        string strUpdate = "UPDATE Contas_pagar SET credor = @credor, descricao = @descricao, valor = @valor, data_emissao = @data_emissao, data_vencimento = @data_vencimento, data_pagamento = @data_pagamento, forma_pagamento = @forma_pagamento, multa = @multa, juros = @juros, total_parcelas = @total_parcelas, valor_parcela = @valor_parcela, situacao = @situacao WHERE id = @id";


        public void Inserir(string credor, string descricao, double valor, DateTime data_emissao, DateTime data_vencimento, DateTime data_pagamento, string forma_pagamento, int multa, int juros, int total_parcelas, double valor_parcela, string situacao)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strInsert, Connection))
                {
                    Command.Parameters.AddWithValue("@credor", credor);
                    Command.Parameters.AddWithValue("@descricao", descricao);
                    Command.Parameters.AddWithValue("@valor", valor);
                    Command.Parameters.AddWithValue("@data_emissao", data_emissao);
                    Command.Parameters.AddWithValue("@data_vencimento", data_vencimento);
                    Command.Parameters.AddWithValue("@data_pagamento", data_pagamento);
                    Command.Parameters.AddWithValue("@forma_pagamento", forma_pagamento);
                    Command.Parameters.AddWithValue("@multa", multa);
                    Command.Parameters.AddWithValue("@juros", juros);
                    Command.Parameters.AddWithValue("@total_parcelas", total_parcelas);
                    Command.Parameters.AddWithValue("@valor_parcela", valor_parcela);
                    Command.Parameters.AddWithValue("@situacao", situacao);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    Connection.Close();
                }
            }
        }

        public void Atualizar(int id, string credor, string descricao, double valor, DateTime data_emissao, DateTime data_vencimento, DateTime data_pagamento, string forma_pagamento, int multa, int juros, int total_parcelas, double valor_parcela, string situacao)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strUpdate, Connection))
                {
                    Command.Parameters.AddWithValue("@id", id);
                    Command.Parameters.AddWithValue("@credor", credor);
                    Command.Parameters.AddWithValue("@descricao", descricao);
                    Command.Parameters.AddWithValue("@valor", valor);
                    Command.Parameters.AddWithValue("@data_emissao", data_emissao);
                    Command.Parameters.AddWithValue("@data_vencimento", data_vencimento);
                    Command.Parameters.AddWithValue("@data_pagamento", data_pagamento);
                    Command.Parameters.AddWithValue("@forma_pagamento", forma_pagamento);
                    Command.Parameters.AddWithValue("@multa", multa);
                    Command.Parameters.AddWithValue("@juros", juros);
                    Command.Parameters.AddWithValue("@total_parcelas", total_parcelas);
                    Command.Parameters.AddWithValue("@valor_parcela", valor_parcela);
                    Command.Parameters.AddWithValue("@situacao", situacao);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    Connection.Close();
                }
            }
        }

        public void Excluir(int id)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strDelete, Connection))
                {
                    Command.Parameters.AddWithValue("@id", id);

                    Connection.Open();

                    Command.ExecuteNonQuery();

                    Connection.Close();
                }
            }
        }

        public void SelectbyID(int id)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strSelectbyID, Connection))
                {
                    Command.Parameters.AddWithValue("@id", id);

                    Connection.Open();

                    Command.ExecuteReader();

                    Connection.Close();
                }
            }
        }
    }
}
