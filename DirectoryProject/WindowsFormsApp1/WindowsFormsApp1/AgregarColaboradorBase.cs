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
    public partial class AgregarColaboradorBase : MetroForm
    {
        public AgregarColaboradorBase()
        {
            InitializeComponent();
        }

        private void AgregarColaboradorBase_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.directoryDBDataSet.roles);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.directoryDBDataSet.estados);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.tipodocumentos' Puede moverla o quitarla según sea necesario.
            this.tipodocumentosTableAdapter.Fill(this.directoryDBDataSet.tipodocumentos);

            label2.Text = ControlColaborador.CodigoColaborador.ToString();
            label3.Text = ControlColaborador.NombresColaborador;
            label4.Text = ControlColaborador.ApellidosColaborador;

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InicioBase inicioBase = new InicioBase();
            inicioBase.Show();
            this.Close();
        }

        private void BTRegistrarColaborador_Click(object sender, EventArgs e)
        {
            ControlColaborador.RegistarColaborador(int.Parse(TBCodigoColaborador.Text),TBNombresColaborador.Text,TBApellidosColaborador.Text,CBTipodocumentoColaborador.SelectedValue,TBDocumentoColaborador.Text, CBEstadoColaborador.SelectedValue, CBRolColaborador.SelectedValue, TBCorreoColaborador.Text,TBMovilColaborador.Text,TBPisoColaborador.Text, TBPuestoColaborador.Text, DTFechaingresoColaborador.Value, TBSalarioColaborador.Text,TBTarifarealColaborador.Text,TBTarifaxclaroColaborador.Text);
        }
    }
}
