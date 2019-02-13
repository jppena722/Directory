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
using System.Text.RegularExpressions;

namespace WindowsFormsApp1
{
    public partial class VerColaborador : MetroForm
    {
        public VerColaborador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(72, 64);
        }

        private void VerColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.roles' Puede moverla o quitarla según sea necesario.
            this.rolesTableAdapter.Fill(this.directoryDBDataSet.roles);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.estados' Puede moverla o quitarla según sea necesario.
            this.estadosTableAdapter.Fill(this.directoryDBDataSet.estados);
            // TODO: esta línea de código carga datos en la tabla 'directoryDBDataSet.tipodocumentos' Puede moverla o quitarla según sea necesario.
            this.tipodocumentosTableAdapter.Fill(this.directoryDBDataSet.tipodocumentos);

            TBCodigoColaborador.Text = ControlColaborador.codigocolaborador.ToString();
            TBNombresColaborador.Text = ControlColaborador.nombrescolaborador.ToString();
            TBApellidosColaborador.Text = ControlColaborador.apellidoscolaborador.ToString();
            CBTipodocumentoColaborador.SelectedValue = ControlColaborador.tipodocumentocolaborador.ToString();
            TBDocumentoColaborador.Text = ControlColaborador.documentocolaborador.ToString();
            CBEstadoColaborador.SelectedValue = ControlColaborador.estadocolaborador.ToString();
            CBRolColaborador.SelectedValue = ControlColaborador.rolcolaborador.ToString();
            TBCorreoColaborador.Text = ControlColaborador.correocolaborador.ToString();
            TBMovilColaborador.Text = ControlColaborador.movilcolaborador.ToString();
            TBPisoColaborador.Text = ControlColaborador.pisocolaborador.ToString();
            TBPuestoColaborador.Text = ControlColaborador.puestocolaborador.ToString();
            TBSalarioColaborador.Value = int.Parse(ControlColaborador.salariocolaborador.ToString());
            TBTarifarealColaborador.Value = int.Parse(ControlColaborador.tarifarealcolaborador.ToString());
            TBTarifaxclaroColaborador.Value = int.Parse(ControlColaborador.ingresoxclarocolaborador.ToString());
            DTFechaingresoColaborador.Value = DateTime.Parse(ControlColaborador.fechaingresocolaborador.ToString());

            var select = string.Format("SELECT proyectos_colaboradores.idproyecto, proyectos.nombreproyecto FROM proyectos_colaboradores  INNER JOIN colaboradores on colaboradores.idcodigocolaborador = proyectos_colaboradores.idcodigocolaborador INNER JOIN proyectos on proyectos.idproyecto = proyectos_colaboradores.idproyecto WHERE colaboradores.idcodigocolaborador = {0}", ControlColaborador.codigocolaborador.ToString());
            var c = DBConection.ObtenerConexion(); 
            var dataAdapter = new NpgsqlDataAdapter(select, c);

            var commandBuilder = new NpgsqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            metroGrid1.ReadOnly = true;
            metroGrid1.DataSource = ds.Tables[0];

            metroGrid1.Columns["idproyecto"].DisplayIndex = 0;
            metroGrid1.Columns["nombreproyecto"].DisplayIndex = 1;
            metroGrid1.Columns["DGVBCdesasignarproyecto"].DisplayIndex = 2;
            metroGrid1.Columns["DGVBCverproyecto"].DisplayIndex = 3;
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TBCodigoColaborador.Enabled = false;
            TBNombresColaborador.Enabled = true;
            TBApellidosColaborador.Enabled = true;
            TBDocumentoColaborador.Enabled = true;
            TBCorreoColaborador.Enabled = true;
            TBMovilColaborador.Enabled = true;
            TBPisoColaborador.Enabled = true;
            TBPuestoColaborador.Enabled = true;
            CBTipodocumentoColaborador.Enabled = true;
            CBEstadoColaborador.Enabled = true;
            CBRolColaborador.Enabled = true;
            DTFechaingresoColaborador.Enabled = true;
            TBSalarioColaborador.Enabled = true;
            TBTarifarealColaborador.Enabled = true;
            TBTarifaxclaroColaborador.Enabled = true;

            pictureBox2.Enabled = false;
            pictureBox2.Visible = false;
            metroButton1.Visible = true;
            metroButton1.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Refresh();

            TBCodigoColaborador.Enabled = false;
            TBNombresColaborador.Enabled = false;
            TBApellidosColaborador.Enabled = false;
            TBDocumentoColaborador.Enabled = false;
            TBCorreoColaborador.Enabled = false;
            TBMovilColaborador.Enabled = false;
            TBPisoColaborador.Enabled = false;
            TBPuestoColaborador.Enabled = false;
            CBTipodocumentoColaborador.Enabled = false;
            CBEstadoColaborador.Enabled = false;
            CBRolColaborador.Enabled = false;
            DTFechaingresoColaborador.Enabled = false;
            TBSalarioColaborador.Enabled = false;
            TBTarifarealColaborador.Enabled = false;
            TBTarifaxclaroColaborador.Enabled = false;

            pictureBox2.Enabled = true;
            pictureBox2.Visible = true;
            metroButton1.Visible = false;
            metroButton1.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox3.Visible = false;

            TBCodigoColaborador.Text = ControlColaborador.codigocolaborador.ToString();
            TBNombresColaborador.Text = ControlColaborador.nombrescolaborador.ToString();
            TBApellidosColaborador.Text = ControlColaborador.apellidoscolaborador.ToString();
            CBTipodocumentoColaborador.SelectedValue = ControlColaborador.tipodocumentocolaborador.ToString();
            TBDocumentoColaborador.Text = ControlColaborador.documentocolaborador.ToString();
            CBEstadoColaborador.SelectedValue = ControlColaborador.estadocolaborador.ToString();
            CBRolColaborador.SelectedValue = ControlColaborador.rolcolaborador.ToString();
            TBCorreoColaborador.Text = ControlColaborador.correocolaborador.ToString();
            TBMovilColaborador.Text = ControlColaborador.movilcolaborador.ToString();
            TBPisoColaborador.Text = ControlColaborador.pisocolaborador.ToString();
            TBPuestoColaborador.Text = ControlColaborador.puestocolaborador.ToString();
            TBSalarioColaborador.Value = int.Parse(ControlColaborador.salariocolaborador.ToString());
            TBTarifarealColaborador.Value = int.Parse(ControlColaborador.tarifarealcolaborador.ToString());
            TBTarifaxclaroColaborador.Value = int.Parse(ControlColaborador.ingresoxclarocolaborador.ToString());
            DTFechaingresoColaborador.Value = DateTime.Parse(ControlColaborador.fechaingresocolaborador.ToString());
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (TBCodigoColaborador.Text != "")
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
                                                        ControlColaborador.ActualizarColaborador(int.Parse(TBCodigoColaborador.Text), TBNombresColaborador.Text, TBApellidosColaborador.Text, CBTipodocumentoColaborador.SelectedValue, TBDocumentoColaborador.Text, CBEstadoColaborador.SelectedValue, CBRolColaborador.SelectedValue, TBCorreoColaborador.Text, TBMovilColaborador.Text, TBPisoColaborador.Text, TBPuestoColaborador.Text, DTFechaingresoColaborador.Value, TBSalarioColaborador.Value, TBTarifarealColaborador.Value, TBTarifaxclaroColaborador.Value);
                                                        MetroMessageBox.Show(this, "El Colaborador ha sido actualizado exitosamente", "Actualizacion Exitoso", MessageBoxButtons.OK);
                                                        this.Close();
                                                }
                                                else
                                                {
                                                    MetroMessageBox.Show(this, "El campo Tarifa Real debe de ser un numero superior igual o superior a 0", "Ha ocurrido un error en la edicion", MessageBoxButtons.OK);
                                                    errorProvider9.SetError(TBTarifaxclaroColaborador, "Por favor ingrese un Numero Valido");
                                                }
                                            }
                                            else
                                            {
                                                MetroMessageBox.Show(this, "El campo Tarifa Real debe de ser un numero superior igual o superior a 0", "Ha ocurrido un error en la edicion", MessageBoxButtons.OK);
                                                errorProvider8.SetError(TBTarifarealColaborador, "Por favor ingrese un Numero Valido");
                                            }
                                        }
                                        else
                                        {
                                            MetroMessageBox.Show(this, "El campo Tarifa Real debe de ser un numero superior igual o superior a 0", "Ha ocurrido un error en la edicion", MessageBoxButtons.OK);
                                            errorProvider7.SetError(TBSalarioColaborador, "Por favor ingrese un Numero Valido");
                                        }

                                    }
                                    else
                                    {
                                        MetroMessageBox.Show(this, "El campo Movil del Colaborador es obligatorio.", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                        errorProvider6.SetError(TBMovilColaborador, "Por favor complete este campo");
                                    }
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "El campo Correo del Colaborador es obligatorio.", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                    errorProvider5.SetError(TBCorreoColaborador, "Por favor complete este campo");
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "El campo Numero de documento del Colaborador es obligatorio.", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                                errorProvider4.SetError(TBDocumentoColaborador, "Por favor complete este campo");
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "El campo Apellidos del Colaborador es obligatorio.", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                            errorProvider3.SetError(TBApellidosColaborador, "Por favor complete este campo");
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "El campo Nombres del Colaborador es obligatorio.", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                        errorProvider2.SetError(TBNombresColaborador, "Por favor complete este campo");
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "El campo Codigo de colaborador es obligatorio", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                    errorProvider1.SetError(TBCodigoColaborador, "Por favor complete este campo con el codigo Numerico del Colaborador");
                }
            }
            else
            {
                MetroMessageBox.Show(this, "El campo Codigo del Colaborador es obligatorio.", "Ha ocurrido un error en la edicion", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                errorProvider1.SetError(TBCodigoColaborador, "Por favor complete este campo");
                TBCodigoColaborador.Text = "";
            }
        }

        private void TBCodigoColaborador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[0-9\s\b]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TBNombresColaborador_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[a-zA-Z\s\b]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
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
            var regex = new Regex(@"[0-9\b+]");
            if (!regex.IsMatch(e.KeyChar.ToString()) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}

