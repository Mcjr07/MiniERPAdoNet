using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERPAdoNET
{
    internal class Database
    {
        private string stringConexao = "Data Source=MARCELUS-23\\SQLSERVER2023; Initial Catalog=Dbo.MiniERP;Integrated Security=SSPI;TrustServerCertificate=True;";


        private SqlConnection cn; // indicando que existe um SqlConnection

        private void conexao() //fará a instância do SqlConnection
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery(); 

                SqlDataAdapter adapter = new SqlDataAdapter(command); 
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                fecharConexao();
            }
        }
    }
}
