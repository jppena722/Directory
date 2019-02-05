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
            label2.Text = ControlColaborador.CodigoColaborador.ToString();
            label3.Text = ControlColaborador.NombresColaborador;
            label4.Text = ControlColaborador.ApellidosColaborador;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }



        private void button3_Click(object sender, EventArgs e)
        {
            IdentificadorBase identificador = new IdentificadorBase();
            identificador.Show();
            this.Close();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           // this.dataTable2TableAdapter.Fill_Consulta_inicio_proyecto(this.directoryDBDataSet.DataTable2);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            AgregarColaboradorBase agregarColaboradorBase = new AgregarColaboradorBase();
            agregarColaboradorBase.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            metroGrid1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in metroGrid1.Rows)
                {
                    int count = metroGrid1.ColumnCount;
                    for (int i = 0; i < count; i++)
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            IdentificadorBase identificadorBase = new IdentificadorBase();
            identificadorBase.Show();
        }
    }
}
