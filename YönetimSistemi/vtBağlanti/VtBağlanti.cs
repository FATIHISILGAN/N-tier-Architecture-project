using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace YönetimSistemi.vtBağlanti
{
    class VtBağlanti
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection bağlanti;

        public VtBağlanti(){

            dataAdapter = new SqlDataAdapter();
            bağlanti = new SqlConnection(@"Data Source=DESKTOP-JUST06P\MSSQLSERVER01;Initial Catalog=DBYönetimSistemi;Integrated Security=True");

        }
        private SqlConnection openConnection()
        {
            if(bağlanti.State==ConnectionState.Closed||bağlanti.State== ConnectionState.Broken)
            {
                bağlanti.Open();
            }
            
            return bağlanti;
        }

        public DataTable exucuteSelectQuery(String _query,SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                dataAdapter.SelectCommand = sqlCommand;
                dataAdapter.Fill(ds);
                dataTable = ds.Tables[0];

            }
            catch(SqlException e) {
                Console.WriteLine("seçme hatası: " + e.Message);
                return null;
            }

            return dataTable;
        }

        public bool exucuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();
            
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameter);

                dataAdapter.InsertCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();

           

            }
            catch (SqlException e)
            {
                Console.WriteLine(" ekleme hatası: " + e.Message);
                return false;
            }

            return true;
        }



        public bool exucuteUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand sqlCommand = new SqlCommand();
            
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameter);
                dataAdapter.UpdateCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();

            
            }
            catch (SqlException e)
            {
                Console.WriteLine(" güncelleme hatası: " + e.Message);
                return false;
            }

            return true;
        }



        public bool exucuteDeleteQuery(String _query)
        {
            SqlCommand sqlCommand = new SqlCommand();
            
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                dataAdapter.SelectCommand = sqlCommand;

                sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(" silme hatası: " + e.Message);
                return false;
            }

            return true;
        }
    }
}
