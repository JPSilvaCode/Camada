using System;
using System.Data.SqlClient;

namespace DAL.Connection
{
    interface IConnection : IDisposable
    {
        SqlConnection Open();
        void Close();
    }
}
