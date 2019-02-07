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
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class IdentificadorBase : MetroForm
    {
        public IdentificadorBase()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void BTIngresar_Click_1(object sender, EventArgs e)
        {
            if (TxtIngreso.Text!="")
            {
                if (ControlColaborador.AutentificarColaborador(TxtIngreso.Text) > 0)
                {
                    ControlColaborador.Contenedor(TxtIngreso.Text);
                    ControlColaborador.CodigoColaborador = int.Parse(TxtIngreso.Text);
                    InicioBase inicioBase = new InicioBase();
                    inicioBase.Show();
                    this.Hide();    
                }
                else
                {
                    MetroMessageBox.Show(this, "Lo sentimos, el usuario que ingresaste no esta registrado en el directorio", "Error de Autentificación", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Por favor ingrese su codigo de colaborador", "Error de Autentificación", MessageBoxButtons.OK);
            }
           
        }

        private void TxtIngreso_Click(object sender, EventArgs e)
        {

        }

        private void TxtIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
    }
