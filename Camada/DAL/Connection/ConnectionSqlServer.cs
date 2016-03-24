using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL.Connection
{
    class ConnectionSqlServer : IConnection
    {
        private SqlConnection _conn;

        public ConnectionSqlServer()
        {            
            _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString.ToString().Trim());
        }

        public void Close()
        {
            try
            {
                if (_conn.State == ConnectionState.Open || _conn.State == ConnectionState.Broken)
                    _conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            finally
            {
                if (_conn.State == ConnectionState.Open || _conn.State == ConnectionState.Broken)
                    _conn.Close();
            }
        }

        public void Dispose()
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            _conn = null;
            GC.SuppressFinalize(this);
        }

        public SqlConnection Open()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();
                return _conn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
