using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;

namespace ESP

{
    class Conexion
    {
        
        private SqlConnection conexion = new SqlConnection("server=HP-ELITEBOOK\\SQLEXPRESS ; database=doctorado ; integrated security = true");
        public SqlConnection abrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
    }
}
