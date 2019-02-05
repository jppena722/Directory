using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;


namespace Conexion
{
    class DBConection
    {
        public static NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432; User Id=postgres;Password=12345;Database = DirectoryDB");
            conn.Open();
            return conn;
        }
    }
}
