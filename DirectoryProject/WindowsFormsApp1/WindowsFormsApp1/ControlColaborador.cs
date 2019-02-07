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
    class ControlColaborador
    {

        public static int CodigoColaborador { get; set; }
        public static string NombresColaborador { get; set; }
        public static string ApellidosColaborador { get; set; }

        public static int codigocolaborador;
        public static string nombrescolaborador;
        public static string apellidoscolaborador;
        public static int tipodocumentocolaborador;
        public static string nombretipodocumentocolaborador;
        public static string documentocolaborador;
        public static int estadocolaborador;
        public static string nombreestadocolaborador;
        public static int rolcolaborador;
        public static string nombrerolcolaborador;
        public static string correocolaborador;
        public static string movilcolaborador;
        public static string pisocolaborador;
        public static string puestocolaborador;
        public static System.DateTime fechaingresocolaborador;
        public static int salariocolaborador;
        public static int tarifarealcolaborador;
        public static int tarifaxclarocolaborador;

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

        public static int RegistarColaborador(int CodigoColaborador,string  NombresColaborador,string ApellidosColaborador,object TipodocumentoColaborador,string DocumentoColaborador,object EstadoColaborador,object RolColaborador, string CorreoColaborador, string MovilColaborador, string PisoColaborador, string PuestoColaborador, DateTime FechaingresoColaborador,decimal SalarioColaborador,decimal TarifarealColaborador,decimal TarifaxclaroColaborador)
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

        public static int Usuarioregistrado(string codigocolaborador, string documentocolaborador)
        {
            int contador = 0;
            try
            {
                NpgsqlConnection conn = DBConection.ObtenerConexion();
                {
                    NpgsqlCommand comando = new NpgsqlCommand(string.Format("SELECT * FROM colaboradores WHERE idcodigocolaborador = '{0}' or numerodocumentocolaborador ='{1}'",codigocolaborador,documentocolaborador),conn);
                    NpgsqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        contador++;
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(AgregarColaboradorBase.ActiveForm,"No se puede hacer la consulta" + ex.ToString());
            }
            return contador;
        }

        public static void BusquedaColaborador(string codigocolaborador)
        {
            NpgsqlConnection conn = DBConection.ObtenerConexion();
            NpgsqlCommand command = new NpgsqlCommand(string.Format("SELECT colaboradores.idcodigocolaborador, colaboradores.nombrescolaborador, colaboradores.apellidoscolaborador, colaboradores.correocolaborador, colaboradores.movilcolaborador, estados.nombreestado, roles.nombrerol FROM colaboradores INNER JOIN estados ON estados.idestado = colaboradores.idestadocolaborador INNER JOIN tipodocumentos ON tipodocumentos.idtipodocumento = colaboradores.idtipodocumentocolaborador INNER JOIN roles ON roles.idrol = colaboradores.idrolcolaborador WHERE colaboradores.idcodigocolaborador = {0}", codigocolaborador), conn);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();

            nombrescolaborador = reader["nombrescolaborador"].ToString();

            //SqlConnection conn = DBComun.ObtenerConexion();
            //SqlCommand Comando = new SqlCommand(string.Format("Select * From Clientes where NameClient = '{0}'", pName_client), conn);
            //SqlDataReader reader = Comando.ExecuteReader();
            //reader.Read();
            //string hola = reader["Id_client"].ToString();
            //Num_cuenta = hola;
            //conn.Close();
            //conn.Dispose();
        }
    }
}

