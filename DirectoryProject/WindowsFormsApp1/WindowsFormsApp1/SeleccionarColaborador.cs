using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MetroFramework;
using MetroFramework.Forms;
using Npgsql;
using Conexion;

namespace WindowsFormsApp1
{
    public partial class SeleccionarColaborador : MetroForm
    {
        public SeleccionarColaborador()
        {
            InitializeComponent();
        }

        private void SeleccionarColaborador_Load(object sender, EventArgs e)
        {
            var select = string.Format("SELECT idcodigocolaborador,apellidoscolaborador, nombrescolaborador FROM colaboradores");
            var c = DBConection.ObtenerConexion();
            var dataAdapter = new NpgsqlDataAdapter(select, c);

            var commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];

            metroGrid1.Columns["idcodigocolaborador"].Visible = false;
            metroGrid1.Columns["apellidoscolaborador"].DisplayIndex = 0;
            metroGrid1.Columns["nombrescolaborador"].DisplayIndex = 1;
            metroGrid1.Columns["DGVTCseleccionar"].DisplayIndex = 2;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                //string codigoproyecto = row.Cells["idproyecto"].Value.ToString();
                //ControlProyecto.BusquedaProyecto(codigoproyecto);
                VerProyecto verProyecto = new VerProyecto();
                //verProyecto.
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string searchValue = metroTextBox1.Text;
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    int count1 = metroGrid1.ColumnCount;
                    count1 = count1 - 1;
                    for (int i = 0; i < count1; i++)
                    {
                        if (row.Cells[i].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
