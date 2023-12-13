using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace MiniERPAdoNET
{
    public class Fornecedor
    {
        public string nome;
        public string cnpj;
        public string endereco;
        public string telefone;

        public bool gravarFornecedor()
        {
            Database db = new Database();

            SqlConnection connection = db.abrirConexao();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.Transaction = transaction;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into fornecedores" +
                " values (@nome, @cnpj, @endereco, @telefone);";
            command.Parameters.AddWithValue("@nome", nome);
            command.Parameters.AddWithValue("@cnpj", cnpj);
            command.Parameters.AddWithValue("@endereco", endereco);
            command.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                command.ExecuteNonQuery();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                db.fecharConexao();
            }
        }
    }
}
