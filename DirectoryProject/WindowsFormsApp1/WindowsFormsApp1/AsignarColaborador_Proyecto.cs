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
using Conexion;

namespace WindowsFormsApp1
{
    public partial class AsignarColaborador_Proyecto : MetroForm
    {
        public AsignarColaborador_Proyecto()
        {
            InitializeComponent();
        }

        private void AsignarColaborador_Proyecto_Load(object sender, EventArgs e)
        {
            var select = string.Format("SELECT colaboradores.idcodigocolaborador, colaboradores.apellidoscolaborador, colaboradores.nombrescolaborador, roles.nombrerol FROM Colaboradores INNER JOIN roles ON roles.idrol = colaboradores.idrolcolaborador WHERE NOT EXISTS(SELECT FROM proyectos_colaboradores WHERE  proyectos_colaboradores.idcodigocolaborador = colaboradores.idcodigocolaborador AND proyectos_Colaboradores.idproyecto = '{0}' )",ControlProyecto.idproyecto);
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
            metroGrid1.Columns["nombrerol"].DisplayIndex = 3;
            metroGrid1.Columns["DGVBCseleccionar"].DisplayIndex = 4;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                string codigocolaborador = row.Cells["idcodigocolaborador"].Value.ToString();
                ControlProyecto.AsignarColaborador(ControlProyecto.idproyecto, int.Parse(codigocolaborador));
                MetroMessageBox.Show(this, "El Colaborador ha sido asignado al proyecto", "Asignación Exitosa", MessageBoxButtons.OK);
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

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
