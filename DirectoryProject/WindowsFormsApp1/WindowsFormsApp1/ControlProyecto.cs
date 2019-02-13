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
        public static int idproyecto;
        public static string nombreproyecto;
        public static int idlineanegocioproyecto;
        public static int iddireccionproyecto;
        public static int idgerenteproyecto;
        public static string nombresgerente;
        public static string apellidosgerente;

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

        public static void BusquedaProyecto(string pcodigoproyecto)
        {
            NpgsqlConnection conn = DBConection.ObtenerConexion();
            NpgsqlCommand command = new NpgsqlCommand(string.Format("SELECT idproyecto, nombreproyecto, idlineanegocioproyecto, iddireccionproyecto, idgerenteproyecto, colaboradores.nombrescolaborador, colaboradores.apellidoscolaborador FROM proyectos INNER JOIN lineanegocios ON lineanegocios.idlineanegocio = proyectos.idlineanegocioproyecto INNER JOIN direcciones ON direcciones.iddireccion = proyectos.iddireccionproyecto INNER JOIN colaboradores ON colaboradores.idcodigocolaborador = proyectos.idgerenteproyecto  WHERE proyectos.idproyecto = {0}", pcodigoproyecto), conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();

            idproyecto = int.Parse(reader["idproyecto"].ToString());
            nombreproyecto = reader["nombreproyecto"].ToString();
            idlineanegocioproyecto = int.Parse(reader["idlineanegocioproyecto"].ToString());
            iddireccionproyecto = int.Parse(reader["iddireccionproyecto"].ToString());
            idgerenteproyecto = int.Parse(reader["idgerenteproyecto"].ToString());
            nombresgerente = reader["nombrescolaborador"].ToString();
            apellidosgerente = reader["apellidoscolaborador"].ToString();

        }

        public static int AsignarColaborador(int pcodigoproyecto, int pcodigocolaborador)
        {
            int comprobador = 0;
            NpgsqlConnection conn = DBConection.ObtenerConexion();
            {
                NpgsqlCommand Comando = new NpgsqlCommand(string.Format("INSERT INTO proyectos_colaboradores(idproyecto, idcodigocolaborador) VALUES( '{0}', '{1}')", pcodigoproyecto, pcodigocolaborador), conn);
                comprobador = Comando.ExecuteNonQuery();
            }
            return comprobador;
        }
    }
}
