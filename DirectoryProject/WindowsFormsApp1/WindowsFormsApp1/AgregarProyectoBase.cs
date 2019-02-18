using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Text.RegularExpressions;
using Conexion;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class AgregarProyectoBase : MetroForm
    {
        public AgregarProyectoBase()
        {
            InitializeComponent();
            label2.Text = ControlColaborador.CodigoColaborador.ToString();
            label3.Text = ControlColaborador.NombresColaborador;
            label4.Text = ControlColaborador.ApellidosColaborador;
        }

        private void AgregarProyectoBase_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.direcciones' Puede moverla o quitarla según sea necesario.
            this.direccionesTableAdapter.Fill(this.directoryDBDataSet.direcciones);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.lineanegocios' Puede moverla o quitarla según sea necesario.
            this.lineanegociosTableAdapter.Fill(this.directoryDBDataSet.lineanegocios);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.colaboradores' Puede moverla o quitarla según sea necesario.
            this.colaboradoresTableAdapter.Fill(this.directoryDBDataSet.colaboradores);

            var select = string.Format("SELECT idcodigocolaborador, apellidoscolaborador, nombrescolaborador FROM colaboradores WHERE idrolcolaborador = 1");
            var c = DBConection.ObtenerConexion();
            var dataAdapter = new NpgsqlDataAdapter(select, c);
            var commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CBGerenteProyecto.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("FullName", typeof(string), "apellidoscolaborador + ' ' + nombrescolaborador");
            CBGerenteProyecto.ValueMember = "idcodigocolaborador";
            CBGerenteProyecto.DisplayMember = "FullName";
        }

        private void BTRegistrarColaborador_Click(object sender, EventArgs e)
        {
            //Enviar datos de registro
            if (TBCodigoProyecto.Text != "")
            {
                if (int.Parse(TBCodigoProyecto.Text) >= 0 & int.Parse(TBCodigoProyecto.Text) <= 2147483647)
                {
                    if (TBNombreProyecto.Text != "")
                    {
                        ControlProyecto.RegistarProyecto(int.Parse(TBCodigoProyecto.Text), TBNombreProyecto.Text, CBLineaProyecto.SelectedValue, CBDireccionProyecto.SelectedValue, CBGerenteProyecto.SelectedValue);
                        MetroMessageBox.Show(this, "El Proyecto se registro exitosamente", "Registro Exitoso", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El campo Nombre del Proyecto es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        errorProvider2.SetError(TBNombreProyecto, "Por favor complete este campo");
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Se ingreso un codigo superior al limite ", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    errorProvider1.SetError(TBNombreProyecto, "Por favor complete este campo con los datos adecuados");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "El campo Codigo del Proyecto es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                errorProvider1.SetError(TBCodigoProyecto, "Por favor complete este campo");
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            InicioBase inicioBase = new InicioBase();
            inicioBase.Show();
            this.Hide();
        }

        private void TBCodigoProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombreProyecto_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[a-zA-Z0-9\s\b_-]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CBGerenteProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
