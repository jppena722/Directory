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
using Npgsql;
using Conexion;

namespace WindowsFormsApp1
{
    public partial class VerProyecto : MetroForm
    {
        public VerProyecto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(72, 64);
        }

        private void VerProyecto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.direcciones' Puede moverla o quitarla según sea necesario.
            this.direccionesTableAdapter.Fill(this.directoryDBDataSet.direcciones);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.lineanegocios' Puede moverla o quitarla según sea necesario.
            this.lineanegociosTableAdapter.Fill(this.directoryDBDataSet.lineanegocios);

            TBCodigoProyecto.Text = ControlProyecto.idproyecto.ToString();
            TBNombreProyecto.Text = ControlProyecto.nombreproyecto.ToString();
            CBLineanegocioProyecto.SelectedValue = ControlProyecto.idlineanegocioproyecto.ToString();
            CBDireccionProyecto.SelectedValue = ControlProyecto.iddireccionproyecto.ToString();
            var select = string.Format("SELECT idcodigocolaborador, apellidoscolaborador, nombrescolaborador FROM colaboradores WHERE idcodigocolaborador = {0}",ControlProyecto.idgerenteproyecto.ToString());
            var c = DBConection.ObtenerConexion();
            var dataAdapter = new NpgsqlDataAdapter(select, c);
            var commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            CBGerenteProyecto.DataSource = ds.Tables[0];
            ds.Tables[0].Columns.Add("FullName", typeof(string), "apellidoscolaborador + ' ' + nombrescolaborador");
            CBGerenteProyecto.ValueMember = "idcodigocolaborador";
            CBGerenteProyecto.DisplayMember = "FullName";

            CargarGrid();
        }
        private void CargarGrid()
        {
            var select = string.Format("SELECT proyectos_colaboradores.idcodigocolaborador, colaboradores.apellidoscolaborador, colaboradores.nombrescolaborador FROM proyectos_colaboradores  INNER JOIN colaboradores on colaboradores.idcodigocolaborador = proyectos_colaboradores.idcodigocolaborador INNER JOIN proyectos on proyectos.idproyecto = proyectos_colaboradores.idproyecto WHERE proyectos.idproyecto = {0}", ControlProyecto.idproyecto.ToString());
            var c = DBConection.ObtenerConexion();
            var dataAdapter = new NpgsqlDataAdapter(select, c);

            var commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];

            metroGrid1.Columns["idcodigocolaborador"].DisplayIndex = 0;
            metroGrid1.Columns["apellidoscolaborador"].DisplayIndex = 1;
            metroGrid1.Columns["nombrescolaborador"].DisplayIndex = 2;
            metroGrid1.Columns["DGVBCdesasignarcolaborador"].DisplayIndex = 3;
            metroGrid1.Columns["DGVBCvercolaborador"].DisplayIndex = 4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TBNombreProyecto.Enabled = true;
            CBLineanegocioProyecto.Enabled = true;
            CBDireccionProyecto.Enabled = true;
            CBGerenteProyecto.Enabled = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox3.Enabled = true;
            metroButton1.Visible = true;
            metroButton1.Enabled = true;
            CBGerenteProyecto.Text = "Seleccionar nuevo";

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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TBNombreProyecto.Enabled = false;
            CBLineanegocioProyecto.Enabled = false;
            CBDireccionProyecto.Enabled = false;
            CBGerenteProyecto.Enabled = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            metroButton1.Visible = false;
            metroButton1.Enabled = false;

            TBCodigoProyecto.Text = ControlProyecto.idproyecto.ToString();
            TBNombreProyecto.Text = ControlProyecto.nombreproyecto.ToString();
            CBLineanegocioProyecto.SelectedValue = ControlProyecto.idlineanegocioproyecto.ToString();
            CBDireccionProyecto.SelectedValue = ControlProyecto.iddireccionproyecto.ToString();
            var select = string.Format("SELECT idcodigocolaborador, apellidoscolaborador, nombrescolaborador FROM colaboradores WHERE idcodigocolaborador = {0}", ControlProyecto.idgerenteproyecto.ToString());
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SeleccionarColaborador seleccionarcolaborador = new SeleccionarColaborador();
            seleccionarcolaborador.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ControlProyecto.idproyecto = int.Parse(ControlProyecto.idproyecto.ToString());
            AsignarColaborador_Proyecto asignarColaborador_Proyecto = new AsignarColaborador_Proyecto();
            asignarColaborador_Proyecto.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            ControlProyecto.ActualizarProyecto(TBNombreProyecto.Text, CBLineanegocioProyecto.SelectedValue, CBDireccionProyecto.SelectedValue, CBGerenteProyecto.SelectedValue,int.Parse(TBCodigoProyecto.Text));
            MetroMessageBox.Show(this, "El Proyecto ha sido actualizado exitosamente", "Actualizacion Exitosa", MessageBoxButtons.OK);
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void CBGerenteProyecto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
