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
using Npgsql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class InicioBase : MetroForm
    {
        public InicioBase()
        {
            InitializeComponent();
        }

        private void LobbyBase_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.DataTable1' Puede moverla o quitarla según sea necesario.
            this.dataTable1TableAdapter.Fill_Consulta_inicio_colaborador(this.directoryDBDataSet.DataTable1);
            this.dataTable2TableAdapter.Fill_Consulta_inicio_proyecto(this.directoryDBDataSet.DataTable2);
            metroGrid1.Hide();
            metroGrid2.Hide();
            label2.Text = ControlColaborador.CodigoColaborador.ToString();
            label3.Text = ControlColaborador.NombresColaborador;
            label4.Text = ControlColaborador.ApellidosColaborador;
            IdentificadorBase identificadorBase = new IdentificadorBase();
            identificadorBase.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IdentificadorBase identificador = new IdentificadorBase();
            identificador.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // this.dataTable2TableAdapter.Fill_Consulta_inicio_proyecto(this.directoryDBDataSet.DataTable2);
        } 
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            AgregarColaboradorBase agregarColaboradorBase = new AgregarColaboradorBase();
            agregarColaboradorBase.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroGrid2.Show();
            metroGrid1.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            metroGrid1.Show();
            metroGrid2.Hide();
        }

        private void metroButton4_Click_1(object sender, EventArgs e)
        {
            AgregarProyectoBase agregarProyectoBase = new AgregarProyectoBase();
            agregarProyectoBase.Show();
            this.Hide();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                string codigocolaborador = row.Cells["idcodigocolaborador"].Value.ToString();
                ControlColaborador.BusquedaColaborador(codigocolaborador);
                VerColaborador verColaborador = new VerColaborador();
                verColaborador.Show();
            }
        }

        private void metroGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                DataGridViewRow row = this.metroGrid2.Rows[e.RowIndex];
                string codigoproyecto = row.Cells["idproyecto"].Value.ToString();
                ControlProyecto.BusquedaProyecto(codigoproyecto);
                VerProyecto verProyecto = new VerProyecto();
                verProyecto.Show();
            }

            if (e.ColumnIndex == 7)
            {
                DataGridViewRow row = this.metroGrid2.Rows[e.RowIndex];
                string codigoproyecto = row.Cells["idproyecto"].Value.ToString();
                ControlProyecto.idproyecto = int.Parse(codigoproyecto);
                AsignarColaborador_Proyecto asignarColaborador_Proyecto = new AsignarColaborador_Proyecto();
                asignarColaborador_Proyecto.ShowDialog();
            }

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

            metroGrid2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in metroGrid2.Rows)
                {
                    int count2 = metroGrid2.ColumnCount;
                    count2 = count2 - 2;
                    for (int i = 0; i < count2; i++)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill_Consulta_inicio_colaborador(this.directoryDBDataSet.DataTable1);
            this.dataTable2TableAdapter.Fill_Consulta_inicio_proyecto(this.directoryDBDataSet.DataTable2);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
