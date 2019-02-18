namespace WindowsFormsApp1
{
    partial class AgregarProyectoBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTRegistrarProyecto = new MetroFramework.Controls.MetroButton();
            this.label9 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TBCodigoProyecto = new MetroFramework.Controls.MetroTextBox();
            this.TBNombreProyecto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.CBLineaProyecto = new MetroFramework.Controls.MetroComboBox();
            this.lineanegociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryDBDataSet = new WindowsFormsApp1.DirectoryDBDataSet();
            this.CBDireccionProyecto = new MetroFramework.Controls.MetroComboBox();
            this.direccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.CBGerenteProyecto = new MetroFramework.Controls.MetroComboBox();
            this.colaboradoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.colaboradoresTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.colaboradoresTableAdapter();
            this.lineanegociosTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.lineanegociosTableAdapter();
            this.direccionesTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.direccionesTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.lineanegociosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // BTRegistrarProyecto
            // 
            this.BTRegistrarProyecto.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTRegistrarProyecto.Location = new System.Drawing.Point(521, 334);
            this.BTRegistrarProyecto.Name = "BTRegistrarProyecto";
            this.BTRegistrarProyecto.Size = new System.Drawing.Size(165, 25);
            this.BTRegistrarProyecto.TabIndex = 110;
            this.BTRegistrarProyecto.Text = "Registrar Proyecto\r\n";
            this.BTRegistrarProyecto.UseSelectable = true;
            this.BTRegistrarProyecto.Click += new System.EventHandler(this.BTRegistrarColaborador_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(373, 50);
            this.label9.TabIndex = 81;
            this.label9.Text = "Formulario para registro de Proyectos\r\n\r\n";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(278, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 38);
            this.metroLabel1.TabIndex = 111;
            this.metroLabel1.Text = "Codigo del Proyecto\r\n";
            // 
            // TBCodigoProyecto
            // 
            // 
            // 
            // 
            this.TBCodigoProyecto.CustomButton.Image = null;
            this.TBCodigoProyecto.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.TBCodigoProyecto.CustomButton.Name = "";
            this.TBCodigoProyecto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBCodigoProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBCodigoProyecto.CustomButton.TabIndex = 1;
            this.TBCodigoProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBCodigoProyecto.CustomButton.UseSelectable = true;
            this.TBCodigoProyecto.CustomButton.Visible = false;
            this.TBCodigoProyecto.Lines = new string[0];
            this.TBCodigoProyecto.Location = new System.Drawing.Point(449, 79);
            this.TBCodigoProyecto.MaxLength = 32767;
            this.TBCodigoProyecto.Name = "TBCodigoProyecto";
            this.TBCodigoProyecto.PasswordChar = '\0';
            this.TBCodigoProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBCodigoProyecto.SelectedText = "";
            this.TBCodigoProyecto.SelectionLength = 0;
            this.TBCodigoProyecto.SelectionStart = 0;
            this.TBCodigoProyecto.ShortcutsEnabled = true;
            this.TBCodigoProyecto.Size = new System.Drawing.Size(434, 23);
            this.TBCodigoProyecto.TabIndex = 112;
            this.TBCodigoProyecto.UseSelectable = true;
            this.TBCodigoProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBCodigoProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBCodigoProyecto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBCodigoProyecto_KeyPress);
            // 
            // TBNombreProyecto
            // 
            // 
            // 
            // 
            this.TBNombreProyecto.CustomButton.Image = null;
            this.TBNombreProyecto.CustomButton.Location = new System.Drawing.Point(412, 1);
            this.TBNombreProyecto.CustomButton.Name = "";
            this.TBNombreProyecto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNombreProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNombreProyecto.CustomButton.TabIndex = 1;
            this.TBNombreProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNombreProyecto.CustomButton.UseSelectable = true;
            this.TBNombreProyecto.CustomButton.Visible = false;
            this.TBNombreProyecto.Lines = new string[0];
            this.TBNombreProyecto.Location = new System.Drawing.Point(449, 126);
            this.TBNombreProyecto.MaxLength = 32767;
            this.TBNombreProyecto.Name = "TBNombreProyecto";
            this.TBNombreProyecto.PasswordChar = '\0';
            this.TBNombreProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNombreProyecto.SelectedText = "";
            this.TBNombreProyecto.SelectionLength = 0;
            this.TBNombreProyecto.SelectionStart = 0;
            this.TBNombreProyecto.ShortcutsEnabled = true;
            this.TBNombreProyecto.Size = new System.Drawing.Size(434, 23);
            this.TBNombreProyecto.TabIndex = 114;
            this.TBNombreProyecto.UseSelectable = true;
            this.TBNombreProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNombreProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TBNombreProyecto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBNombreProyecto_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(278, 126);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(137, 38);
            this.metroLabel3.TabIndex = 113;
            this.metroLabel3.Text = "Nombre del Proyecto\r\n";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(278, 175);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(187, 38);
            this.metroLabel4.TabIndex = 115;
            this.metroLabel4.Text = "Linea de negocio del Proyecto\r\n";
            // 
            // CBLineaProyecto
            // 
            this.CBLineaProyecto.DataSource = this.lineanegociosBindingSource;
            this.CBLineaProyecto.DisplayMember = "nombrelineanegocio";
            this.CBLineaProyecto.FormattingEnabled = true;
            this.CBLineaProyecto.ItemHeight = 23;
            this.CBLineaProyecto.Location = new System.Drawing.Point(521, 175);
            this.CBLineaProyecto.Name = "CBLineaProyecto";
            this.CBLineaProyecto.Size = new System.Drawing.Size(362, 29);
            this.CBLineaProyecto.TabIndex = 116;
            this.CBLineaProyecto.UseSelectable = true;
            this.CBLineaProyecto.ValueMember = "idlineanegocio";
            // 
            // lineanegociosBindingSource
            // 
            this.lineanegociosBindingSource.DataMember = "lineanegocios";
            this.lineanegociosBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // directoryDBDataSet
            // 
            this.directoryDBDataSet.DataSetName = "DirectoryDBDataSet";
            this.directoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBDireccionProyecto
            // 
            this.CBDireccionProyecto.DataSource = this.direccionesBindingSource;
            this.CBDireccionProyecto.DisplayMember = "nombredireccion";
            this.CBDireccionProyecto.FormattingEnabled = true;
            this.CBDireccionProyecto.ItemHeight = 23;
            this.CBDireccionProyecto.Location = new System.Drawing.Point(521, 224);
            this.CBDireccionProyecto.Name = "CBDireccionProyecto";
            this.CBDireccionProyecto.Size = new System.Drawing.Size(362, 29);
            this.CBDireccionProyecto.TabIndex = 118;
            this.CBDireccionProyecto.UseSelectable = true;
            this.CBDireccionProyecto.ValueMember = "iddireccion";
            // 
            // direccionesBindingSource
            // 
            this.direccionesBindingSource.DataMember = "direcciones";
            this.direccionesBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(278, 224);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(141, 38);
            this.metroLabel5.TabIndex = 117;
            this.metroLabel5.Text = "Direccion del Proyecto\r\n";
            // 
            // CBGerenteProyecto
            // 
            this.CBGerenteProyecto.FormattingEnabled = true;
            this.CBGerenteProyecto.ItemHeight = 23;
            this.CBGerenteProyecto.Location = new System.Drawing.Point(521, 276);
            this.CBGerenteProyecto.Name = "CBGerenteProyecto";
            this.CBGerenteProyecto.Size = new System.Drawing.Size(362, 29);
            this.CBGerenteProyecto.TabIndex = 120;
            this.CBGerenteProyecto.UseSelectable = true;
            this.CBGerenteProyecto.SelectedIndexChanged += new System.EventHandler(this.CBGerenteProyecto_SelectedIndexChanged);
            // 
            // colaboradoresBindingSource
            // 
            this.colaboradoresBindingSource.DataMember = "colaboradores";
            this.colaboradoresBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(278, 276);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 38);
            this.metroLabel6.TabIndex = 119;
            this.metroLabel6.Text = "Gerente del Proyecto\r\n";
            // 
            // colaboradoresTableAdapter
            // 
            this.colaboradoresTableAdapter.ClearBeforeFill = true;
            // 
            // lineanegociosTableAdapter
            // 
            this.lineanegociosTableAdapter.ClearBeforeFill = true;
            // 
            // direccionesTableAdapter
            // 
            this.direccionesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroPanel2);
            this.groupBox3.Location = new System.Drawing.Point(8, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 55);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.label2);
            this.metroPanel2.Controls.Add(this.label3);
            this.metroPanel2.Controls.Add(this.label4);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 16);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(216, 36);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "LBLCodigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "LBLNombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "LBLApellidos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroPanel1);
            this.groupBox2.Location = new System.Drawing.Point(233, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 55);
            this.groupBox2.TabIndex = 123;
            this.groupBox2.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 16);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(956, 36);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton4.Location = new System.Drawing.Point(802, 9);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(122, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Volver al inicio";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroPanel3);
            this.groupBox1.Location = new System.Drawing.Point(11, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 503);
            this.groupBox1.TabIndex = 124;
            this.groupBox1.TabStop = false;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.CBGerenteProyecto);
            this.metroPanel3.Controls.Add(this.BTRegistrarProyecto);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.label9);
            this.metroPanel3.Controls.Add(this.CBDireccionProyecto);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.CBLineaProyecto);
            this.metroPanel3.Controls.Add(this.TBCodigoProyecto);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.TBNombreProyecto);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 16);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1178, 484);
            this.metroPanel3.TabIndex = 111;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AgregarProyectoBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "AgregarProyectoBase";
            this.Load += new System.EventHandler(this.AgregarProyectoBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lineanegociosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.direccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradoresBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton BTRegistrarProyecto;
        private System.Windows.Forms.Label label9;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TBCodigoProyecto;
        private MetroFramework.Controls.MetroTextBox TBNombreProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox CBLineaProyecto;
        private MetroFramework.Controls.MetroComboBox CBDireccionProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroComboBox CBGerenteProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private DirectoryDBDataSet directoryDBDataSet;
        private System.Windows.Forms.BindingSource colaboradoresBindingSource;
        private DirectoryDBDataSetTableAdapters.colaboradoresTableAdapter colaboradoresTableAdapter;
        private System.Windows.Forms.BindingSource lineanegociosBindingSource;
        private DirectoryDBDataSetTableAdapters.lineanegociosTableAdapter lineanegociosTableAdapter;
        private System.Windows.Forms.BindingSource direccionesBindingSource;
        private DirectoryDBDataSetTableAdapters.direccionesTableAdapter direccionesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}