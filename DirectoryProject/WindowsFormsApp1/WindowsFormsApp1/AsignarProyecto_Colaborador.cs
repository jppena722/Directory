using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Npgsql;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Conexion;

namespace WindowsFormsApp1
{
    public partial class AsignarProyecto_Colaborador : MetroForm
    {
        public AsignarProyecto_Colaborador()
        {
            InitializeComponent();
        }

        private void AsignarProyecto_Colaborador_Load(object sender, EventArgs e)
        {
            var select = string.Format("SELECT Proyectos.idproyecto, Proyectos.nombreproyecto,colaboradores.apellidoscolaborador, colaboradores.nombrescolaborador FROM Proyectos INNER JOIN Colaboradores on Colaboradores.idcodigocolaborador = Proyectos.idgerenteproyecto WHERE NOT EXISTS(SELECT FROM proyectos_colaboradores INNER JOIN Colaboradores ON Colaboradores.idcodigocolaborador = Proyectos_colaboradores.idcodigocolaborador  WHERE  proyectos_colaboradores.idproyecto = proyectos.idproyecto AND proyectos_Colaboradores.idcodigocolaborador = '{0}'); ", ControlColaborador.codigocolaborador);
            var c = DBConection.ObtenerConexion();
            var dataAdapter = new NpgsqlDataAdapter(select, c);

            var commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];

            metroGrid1.Columns["idproyecto"].DisplayIndex = 0;
            metroGrid1.Columns["nombreproyecto"].DisplayIndex = 1;
            metroGrid1.Columns["apellidoscolaborador"].DisplayIndex = 2;
            metroGrid1.Columns["nombrescolaborador"].DisplayIndex = 3;
            metroGrid1.Columns["DGVBCseleccionar"].DisplayIndex = 4;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                string idproyecto = row.Cells["idproyecto"].Value.ToString();
                ControlColaborador.AsignarProyecto(int.Parse(idproyecto), ControlColaborador.codigocolaborador);
                //recargar el metrogrid1 de "VerProyecto"
                MetroMessageBox.Show(this, "El Proyecto ha sido asignado al colaborador", "Asignación Exitosa", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    int count1 = metroGrid1.ColumnCount;
                    count1 = count1 - 2;
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
