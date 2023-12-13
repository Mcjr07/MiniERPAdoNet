using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERPAdoNET
{
    public class Produto
    {
        public int id;
        public string tipo;
        public string tamanho;
        public string cor;
        public decimal preco;
        public int quantidadeEstoque;
        public int fornecedor;

        public bool gravarProduto()
        {
            Database db = new Database();

            SqlConnection connection = db.abrirConexao();
            SqlTransaction transaction = connection.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            command.Transaction = transaction;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into produtos" +
                " values (@tipo, @preco, @quantidadeEstoque, @tamanho, @cor);";
            command.Parameters.AddWithValue("@tipo", tipo);
            command.Parameters.AddWithValue("@preco", preco.ToString());
            command.Parameters.AddWithValue("@preco", quantidadeEstoque.ToString());
            command.Parameters.AddWithValue("@tamanho", tamanho);
            command.Parameters.AddWithValue("@cor", cor);
            command.Parameters.AddWithValue("@fornecedor", fornecedor.ToString());

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
