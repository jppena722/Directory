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
        /*
        private void AgregarColaboradorBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
            "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // If the no button was pressed ...
            if (result == DialogResult.No)
            {
                // cancel the closure of the form.
                e.Cancel = true;
            }
        }
        */
        private void BTRegistrarColaborador_Click(object sender, EventArgs e)
        {
            
            if (TBCodigoColaborador.Text !="")
            {
                errorProvider1.Clear();
                if (int.Parse(TBCodigoColaborador.Text) >= 0 & int.Parse(TBCodigoColaborador.Text) <= 2147483647)
                {
                    errorProvider1.Clear();
                    if (TBNombresColaborador.Text != "")
                    {
                        errorProvider2.Clear();
                        if (TBApellidosColaborador.Text != "")
                        {
                            errorProvider3.Clear();
                            if (TBDocumentoColaborador.Text != "")
                            {
                                errorProvider4.Clear();
                                if (TBCorreoColaborador.Text != "")
                                {
                                    errorProvider5.Clear();
                                    if (TBMovilColaborador.Text != "")
                                    {
                                        errorProvider6.Clear();
                                        if (TBSalarioColaborador.Value >= 0)
                                        {
                                            errorProvider7.Clear();
                                            if (TBTarifarealColaborador.Value >= 0)
                                            {
                                                errorProvider8.Clear();
                                                if (TBTarifaxclaroColaborador.Value >= 0)
                                                {
                                                    errorProvider9.Clear();
                                                    if (ControlColaborador.Usuarioregistrado(TBCodigoColaborador.Text, TBDocumentoColaborador.Text) == 0)
                                                    {
                                                        ControlColaborador.RegistarColaborador(int.Parse(TBCodigoColaborador.Text), TBNombresColaborador.Text, TBApellidosColaborador.Text, CBTipodocumentoColaborador.SelectedValue, TBDocumentoColaborador.Text, CBEstadoColaborador.SelectedValue, CBRolColaborador.SelectedValue, TBCorreoColaborador.Text, TBMovilColaborador.Text, TBPisoColaborador.Text, TBPuestoColaborador.Text, DTFechaingresoColaborador.Value, TBSalarioColaborador.Value, TBTarifarealColaborador.Value, TBTarifaxclaroColaborador.Value);
                                                        MetroMessageBox.Show(this, "El Colaborador ha sido registrado exitosamente", "Registro Exitoso", MessageBoxButtons.OK);
                                                    }
                                                    else
                                                    {
                                                        MetroMessageBox.Show(this, "Parece que el colaborador que intentas agregar ya se encuentra registrado en el directorio", "Error en el Registro de colaborador", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                                    }
                                                }
                                                else
                                                {
                                                    MetroMessageBox.Show(this, "El campo Tarifa Real debe de ser un numero superior igual o superior a 0", "Ha ocurrido un error en el registro", MessageBoxButtons.OK);
                                                    errorProvider9.SetError(TBTarifaxclaroColaborador, "Por favor ingrese un Numero Valido");
                                                }
                                            }
                                            else
                                            {
                                                MetroMessageBox.Show(this, "El campo Tarifa Real debe de ser un numero superior igual o superior a 0", "Ha ocurrido un error en el registro", MessageBoxButtons.OK);
                                                errorProvider8.SetError(TBTarifarealColaborador, "Por favor ingrese un Numero Valido");
                                            }
                                        }
                                        else
                                        {
                                            MetroMessageBox.Show(this, "El campo Tarifa Real debe de ser un numero superior igual o superior a 0", "Ha ocurrido un error en el registro", MessageBoxButtons.OK);
                                            errorProvider7.SetError(TBSalarioColaborador, "Por favor ingrese un Numero Valido");
                                        }

                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, "El campo Movil del Colaborador es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                        errorProvider6.SetError(TBMovilColaborador, "Por favor complete este campo");
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El campo Correo del Colaborador es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                    errorProvider5.SetError(TBCorreoColaborador, "Por favor complete este campo");
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "El campo Numero de documento del Colaborador es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                errorProvider4.SetError(TBDocumentoColaborador, "Por favor complete este campo");
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El campo Apellidos del Colaborador es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                            errorProvider3.SetError(TBApellidosColaborador, "Por favor complete este campo");
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El campo Nombres del Colaborador es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        errorProvider2.SetError(TBNombresColaborador, "Por favor complete este campo");
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo Codigo de colaborador es obligatorio", "Ha ocurrido un error en el registro",MessageBoxButtons.OKCancel,MessageBoxIcon .Hand);
                    errorProvider1.SetError(TBCodigoColaborador, "Por favor complete este campo con el codigo Numerico del Colaborador");
                }  
            }
            else
            {
                MetroMessageBox.Show(this, "El campo Codigo del Colaborador es obligatorio.", "Ha ocurrido un error en el registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                errorProvider1.SetError(TBCodigoColaborador,"Por favor complete este campo");
                TBCodigoColaborador.Text = "";
            }   
        }

        private void TBCodigoColaborador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBApellidosColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBCorreoColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[a-zA-Z0-9\s\b@._-]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBMovilColaborador_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            InicioBase inicioBase = new InicioBase();
            inicioBase.Show();
            this.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
