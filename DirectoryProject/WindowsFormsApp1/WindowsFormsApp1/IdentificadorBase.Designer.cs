using System;

namespace WindowsFormsApp1
{
    partial class IdentificadorBase
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IdentificadorBase));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBTextoBienvenida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtIngreso = new MetroFramework.Controls.MetroTextBox();
            this.BTIngresar = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(526, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LBTextoBienvenida
            // 
            this.LBTextoBienvenida.AutoSize = true;
            this.LBTextoBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBTextoBienvenida.Location = new System.Drawing.Point(53, 72);
            this.LBTextoBienvenida.Name = "LBTextoBienvenida";
            this.LBTextoBienvenida.Size = new System.Drawing.Size(429, 75);
            this.LBTextoBienvenida.TabIndex = 4;
            this.LBTextoBienvenida.Text = "Bienvenido al Directorio de Proyectos \r\n\r\nPor favor ingrese su codigo de Colabora" +
    "dor\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtIngreso);
            this.groupBox1.Controls.Add(this.BTIngresar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.LBTextoBienvenida);
            this.groupBox1.Location = new System.Drawing.Point(38, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // TxtIngreso
            // 
            this.TxtIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtIngreso.CustomButton.Image = null;
            this.TxtIngreso.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.TxtIngreso.CustomButton.Name = "";
            this.TxtIngreso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIngreso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIngreso.CustomButton.TabIndex = 1;
            this.TxtIngreso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIngreso.CustomButton.UseSelectable = true;
            this.TxtIngreso.CustomButton.Visible = false;
            this.TxtIngreso.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtIngreso.Lines = new string[0];
            this.TxtIngreso.Location = new System.Drawing.Point(58, 177);
            this.TxtIngreso.MaxLength = 32767;
            this.TxtIngreso.Name = "TxtIngreso";
            this.TxtIngreso.PasswordChar = '\0';
            this.TxtIngreso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIngreso.SelectedText = "";
            this.TxtIngreso.SelectionLength = 0;
            this.TxtIngreso.SelectionStart = 0;
            this.TxtIngreso.ShortcutsEnabled = false;
            this.TxtIngreso.Size = new System.Drawing.Size(225, 23);
            this.TxtIngreso.TabIndex = 9;
            this.TxtIngreso.UseSelectable = true;
            this.TxtIngreso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIngreso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIngreso.Click += new System.EventHandler(this.TxtIngreso_Click);
            this.TxtIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtIngreso_KeyPress);
            // 
            // BTIngresar
            // 
            this.BTIngresar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTIngresar.Location = new System.Drawing.Point(289, 177);
            this.BTIngresar.Name = "BTIngresar";
            this.BTIngresar.Size = new System.Drawing.Size(96, 23);
            this.BTIngresar.TabIndex = 8;
            this.BTIngresar.Text = "Ingresar";
            this.BTIngresar.UseSelectable = true;
            this.BTIngresar.Click += new System.EventHandler(this.BTIngresar_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 0;
            this.metroButton1.UseSelectable = true;
            // 
            // IdentificadorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 443);
            this.Controls.Add(this.groupBox1);
            this.Name = "IdentificadorBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Directorio de Proyectos HITSS";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void Base_Load(object sender, EventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBTextoBienvenida;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton BTIngresar;
        private MetroFramework.Controls.MetroTextBox TxtIngreso;
    }
}

