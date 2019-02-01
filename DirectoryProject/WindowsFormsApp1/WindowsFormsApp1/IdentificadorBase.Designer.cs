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
            this.TBCodigoColaborador = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(516, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
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
            // TBCodigoColaborador
            // 
            this.TBCodigoColaborador.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TBCodigoColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCodigoColaborador.Location = new System.Drawing.Point(58, 172);
            this.TBCodigoColaborador.Name = "TBCodigoColaborador";
            this.TBCodigoColaborador.Size = new System.Drawing.Size(210, 29);
            this.TBCodigoColaborador.TabIndex = 5;
            this.TBCodigoColaborador.TextChanged += new System.EventHandler(this.TBCodigoColaborador_TextChanged_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTIngresar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TBCodigoColaborador);
            this.groupBox1.Controls.Add(this.LBTextoBienvenida);
            this.groupBox1.Location = new System.Drawing.Point(38, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // BTIngresar
            // 
            this.BTIngresar.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.BTIngresar.Location = new System.Drawing.Point(274, 169);
            this.BTIngresar.Name = "BTIngresar";
            this.BTIngresar.Size = new System.Drawing.Size(106, 32);
            this.BTIngresar.TabIndex = 6;
            this.BTIngresar.Text = "Ingresar";
            this.BTIngresar.UseVisualStyleBackColor = true;
            this.BTIngresar.Click += new System.EventHandler(this.BTIngresar_Click);
            // 
            // IdentificadorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 443);
            this.Controls.Add(this.groupBox1);
            this.Name = "IdentificadorBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresar";
            this.Load += new System.EventHandler(this.Base_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBTextoBienvenida;
        private System.Windows.Forms.TextBox TBCodigoColaborador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTIngresar;
    }
}

