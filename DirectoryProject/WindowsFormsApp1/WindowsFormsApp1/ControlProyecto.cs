using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Conexion;
using System.Data.SqlClient;
using Npgsql;
using MetroFramework;
using MetroFramework.Forms;

namespace WindowsFormsApp1
{
    class ControlProyecto
    {

        public static int RegistarProyecto(int CodigoProyecto, string NombreProyecto, object LineaProyecto, object DireccionProyecto, object CodigoGerenteProyecto)
        {
            int comprobador = 0;
            NpgsqlConnection conn = DBConection.ObtenerConexion();
            {
                NpgsqlCommand Comando = new NpgsqlCommand(string.Format("INSERT INTO proyectos(idproyecto, nombreproyecto,idlineanegocioproyecto, iddireccionproyecto,idgerenteproyecto) VALUES( '{0}', '{1}', '{2}', '{3}', '{4}')", CodigoProyecto, NombreProyecto, LineaProyecto, DireccionProyecto, CodigoGerenteProyecto), conn);
                comprobador = Comando.ExecuteNonQuery();
            }
            return comprobador;
        }
    }
}
