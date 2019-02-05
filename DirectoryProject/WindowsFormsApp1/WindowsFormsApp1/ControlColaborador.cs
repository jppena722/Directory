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

namespace WindowsFormsApp1
{
    class ControlColaborador
    {

        public static int CodigoColaborador { get; set; }
        public static string NombresColaborador { get; set; }
        public static string ApellidosColaborador { get; set; }

        public static int AutentificarColaborador(String CodigoColaboradorp)
        {
            int resultado2 = -1;
            NpgsqlConnection conn = DBConection.ObtenerConexion();
            NpgsqlCommand comando = new NpgsqlCommand(String.Format("Select * From Colaboradores Where IdCodigoColaborador = '{0}'", CodigoColaboradorp), conn);
            NpgsqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado2 = 50;
            }
            conn.Close();
            return resultado2;
        }

        public static void Contenedor(string CodigoColaborador)
        {
            NpgsqlConnection conn = DBConection.ObtenerConexion();
            NpgsqlCommand Comando = new NpgsqlCommand(string.Format("Select * From Colaboradores where IdCodigoColaborador = '{0}'", CodigoColaborador), conn);
            NpgsqlDataReader reader = Comando.ExecuteReader();
            reader.Read();
            string NombresColaboradorDB = reader["NombresColaborador"].ToString();
            string ApellidosColaboradorDB = reader["ApellidosColaborador"].ToString();
            NombresColaborador = NombresColaboradorDB;
            ApellidosColaborador = ApellidosColaboradorDB;
            conn.Close();
            conn.Dispose();
        }

        public static int RegistarColaborador(int CodigoColaborador,string  NombresColaborador,string ApellidosColaborador,object TipodocumentoColaborador,string DocumentoColaborador,object EstadoColaborador,object RolColaborador, string CorreoColaborador, string MovilColaborador, string PisoColaborador, string PuestoColaborador, DateTime FechaingresoColaborador,string SalarioColaborador,string TarifarealColaborador,string TarifaxclaroColaborador)
        {
            int comprobador = 0;
            int Day = FechaingresoColaborador.Day;
            int Month = FechaingresoColaborador.Month;
            int Year = FechaingresoColaborador.Year;
            string Date = string.Format("{2}-{1}-{0}",Day,Month,Year); 



            NpgsqlConnection conn = DBConection.ObtenerConexion();
            {
                
                NpgsqlCommand Comando = new NpgsqlCommand(string.Format("INSERT INTO colaboradores(idcodigocolaborador, nombrescolaborador, apellidoscolaborador,idtipodocumentocolaborador, numerodocumentocolaborador, idestadocolaborador,idrolcolaborador, correocolaborador, movilcolaborador, pisocolaborador, puestocolaborador, fechaingresocolaborador, salariocolaborador,tarifarealcolaborador, ingresoxclarocolaborador) VALUES( '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')", CodigoColaborador, NombresColaborador, ApellidosColaborador, TipodocumentoColaborador, DocumentoColaborador, EstadoColaborador, RolColaborador, CorreoColaborador, MovilColaborador, PisoColaborador, PuestoColaborador, Date, SalarioColaborador, TarifarealColaborador, TarifaxclaroColaborador), conn);
                comprobador = Comando.ExecuteNonQuery();
            }
            return comprobador;
        }
        
    }
}

