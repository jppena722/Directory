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
            MLApellidosGerente.Text = ControlProyecto.apellidosgerente.ToString();
            MLNombresGerente.Text = ControlProyecto.nombresgerente.ToString();
            
            var select = string.Format("SELECT proyectos_colaboradores.idcodigocolaborador, colaboradores.apellidoscolaborador, colaboradores.nombrescolaborador FROM proyectos_colaboradores  INNER JOIN colaboradores on colaboradores.idcodigocolaborador = proyectos_colaboradores.idcodigocolaborador INNER JOIN proyectos on proyectos.idproyecto = proyectos_colaboradores.idproyecto WHERE proyectos.idproyecto = {0}",ControlProyecto.idproyecto.ToString());
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
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
            pictureBox3.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TBNombreProyecto.Enabled = false;
            CBLineanegocioProyecto.Enabled = false;
            CBDireccionProyecto.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;

            TBCodigoProyecto.Text = ControlProyecto.idproyecto.ToString();
            TBNombreProyecto.Text = ControlProyecto.nombreproyecto.ToString();
            CBLineanegocioProyecto.SelectedValue = ControlProyecto.idlineanegocioproyecto.ToString();
            CBDireccionProyecto.SelectedValue = ControlProyecto.iddireccionproyecto.ToString();
            MLApellidosGerente.Text = ControlProyecto.apellidosgerente.ToString();
            MLNombresGerente.Text = ControlProyecto.nombresgerente.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SeleccionarColaborador seleccionarcolaborador = new SeleccionarColaborador();
            seleccionarcolaborador.ShowDialog();
        }
    }
}
