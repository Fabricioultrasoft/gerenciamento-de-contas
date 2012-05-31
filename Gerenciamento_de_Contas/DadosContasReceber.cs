using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Gerenciamento_de_Contas
{
    class DadosContasReceber
    {
        //Connection string
        string strConnection = ConfigurationManager.ConnectionStrings["Gerenciamento_de_Contas.Properties.Settings.Contas_DBConnectionString"].ConnectionString;

        //SQL strings
        string strInsert = "INSERT INTO Contas_Receber (devedor, descricao, valor, data_emissao, data_vencimento, data_pagamento, forma_pagamento, multa, juros, total_parcelas, valor_parcela, situacao) VALUES (@devedor, @descricao, @valor, @data_emissao, @data_vencimento, @data_pagamento, @forma_pagamento, @multa, @juros, @total_parcelas, @valor_parcela, @situacao)";
        string strDelete = "DELETE FROM Contas_Receber WHERE id = @id";
        string strSelectbyID = "SELECT * FROM Contas_Receber WHERE (CAST(id AS varchar(20)) LIKE '%' + @id)";
        string strUpdate = "UPDATE Contas_Receber SET devedor = @devedor, descricao = @descricao, valor = @valor, data_emissao = @data_emissao, data_vencimento = @data_vencimento, data_pagamento = @data_pagamento, forma_pagamento = @forma_pagamento, multa = @multa, juros = @juros, total_parcelas = @total_parcelas, valor_parcela = @valor_parcela, situacao = @situacao WHERE id = @id";
        string strUpdateDate = "UPDATE Contas_Receber SET situacao = 'VENCIDO' WHERE data_pagamento > @data_pagamento AND situacao = 'PENDENTE'";

        public void Inserir(string devedor, string descricao, double valor, DateTime data_emissao, DateTime data_vencimento, DateTime data_pagamento, string forma_pagamento, int multa, int juros, int total_parcelas, double valor_parcela, string situacao)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strInsert, Connection))
                {
                    Command.Parameters.AddWithValue("@devedor", devedor);
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

        public void Atualizar(int id, string devedor, string descricao, double valor, DateTime data_emissao, DateTime data_vencimento, DateTime data_pagamento, string forma_pagamento, int multa, int juros, int total_parcelas, double valor_parcela, string situacao)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strUpdate, Connection))
                {
                    Command.Parameters.AddWithValue("@id", id);
                    Command.Parameters.AddWithValue("@devedor", devedor);
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

        public void AtualizarDatas(DateTime data_pag)
        {
            using (SqlConnection Connection = new SqlConnection(strConnection))
            {
                using (SqlCommand Command = new SqlCommand(strUpdateDate, Connection))
                {
                    Command.Parameters.AddWithValue("@data_pagamento", data_pag);

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
