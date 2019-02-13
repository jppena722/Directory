namespace WindowsFormsApp1
{
    partial class VerProyecto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerProyecto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MLApellidosGerente = new MetroFramework.Controls.MetroLabel();
            this.MLNombresGerente = new MetroFramework.Controls.MetroLabel();
            this.CBDireccionProyecto = new MetroFramework.Controls.MetroComboBox();
            this.direccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryDBDataSet = new WindowsFormsApp1.DirectoryDBDataSet();
            this.CBLineanegocioProyecto = new MetroFramework.Controls.MetroComboBox();
            this.lineanegociosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TBNombreProyecto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TBCodigoProyecto = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.DGVBCdesasignarcolaborador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DGVBCvercolaborador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lineanegociosTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.lineanegociosTableAdapter();
            this.direccionesTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.direccionesTableAdapter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineanegociosBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(9, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 461);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroButton1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.MLApellidosGerente);
            this.groupBox3.Controls.Add(this.MLNombresGerente);
            this.groupBox3.Controls.Add(this.CBDireccionProyecto);
            this.groupBox3.Controls.Add(this.CBLineanegocioProyecto);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.TBNombreProyecto);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroLabel1);
            this.groupBox3.Controls.Add(this.TBCodigoProyecto);
            this.groupBox3.Location = new System.Drawing.Point(15, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(753, 156);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // MLApellidosGerente
            // 
            this.MLApellidosGerente.AutoSize = true;
            this.MLApellidosGerente.Location = new System.Drawing.Point(232, 123);
            this.MLApellidosGerente.Name = "MLApellidosGerente";
            this.MLApellidosGerente.Size = new System.Drawing.Size(113, 19);
            this.MLApellidosGerente.TabIndex = 10;
            this.MLApellidosGerente.Text = "Apellidos Gerente";
            // 
            // MLNombresGerente
            // 
            this.MLNombresGerente.AutoSize = true;
            this.MLNombresGerente.Location = new System.Drawing.Point(351, 123);
            this.MLNombresGerente.Name = "MLNombresGerente";
            this.MLNombresGerente.Size = new System.Drawing.Size(109, 19);
            this.MLNombresGerente.TabIndex = 9;
            this.MLNombresGerente.Text = "Nombre Gerente";
            // 
            // CBDireccionProyecto
            // 
            this.CBDireccionProyecto.DataSource = this.direccionesBindingSource;
            this.CBDireccionProyecto.DisplayMember = "nombredireccion";
            this.CBDireccionProyecto.Enabled = false;
            this.CBDireccionProyecto.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CBDireccionProyecto.FormattingEnabled = true;
            this.CBDireccionProyecto.ItemHeight = 19;
            this.CBDireccionProyecto.Location = new System.Drawing.Point(510, 80);
            this.CBDireccionProyecto.Name = "CBDireccionProyecto";
            this.CBDireccionProyecto.Size = new System.Drawing.Size(237, 25);
            this.CBDireccionProyecto.TabIndex = 8;
            this.CBDireccionProyecto.UseSelectable = true;
            this.CBDireccionProyecto.ValueMember = "iddireccion";
            // 
            // direccionesBindingSource
            // 
            this.direccionesBindingSource.DataMember = "direcciones";
            this.direccionesBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // directoryDBDataSet
            // 
            this.directoryDBDataSet.DataSetName = "DirectoryDBDataSet";
            this.directoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBLineanegocioProyecto
            // 
            this.CBLineanegocioProyecto.DataSource = this.lineanegociosBindingSource;
            this.CBLineanegocioProyecto.DisplayMember = "nombrelineanegocio";
            this.CBLineanegocioProyecto.Enabled = false;
            this.CBLineanegocioProyecto.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.CBLineanegocioProyecto.FormattingEnabled = true;
            this.CBLineanegocioProyecto.ItemHeight = 19;
            this.CBLineanegocioProyecto.Location = new System.Drawing.Point(510, 19);
            this.CBLineanegocioProyecto.Name = "CBLineanegocioProyecto";
            this.CBLineanegocioProyecto.Size = new System.Drawing.Size(237, 25);
            this.CBLineanegocioProyecto.TabIndex = 7;
            this.CBLineanegocioProyecto.UseSelectable = true;
            this.CBLineanegocioProyecto.ValueMember = "idlineanegocio";
            // 
            // lineanegociosBindingSource
            // 
            this.lineanegociosBindingSource.DataMember = "lineanegocios";
            this.lineanegociosBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(85, 123);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(136, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Gerente del Proyecto:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(391, 70);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 38);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Direccion\r\ndel Proyecto:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(391, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(112, 38);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Linea de Negocio\r\ndel Proyecto:";
            // 
            // TBNombreProyecto
            // 
            // 
            // 
            // 
            this.TBNombreProyecto.CustomButton.Image = null;
            this.TBNombreProyecto.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.TBNombreProyecto.CustomButton.Name = "";
            this.TBNombreProyecto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNombreProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNombreProyecto.CustomButton.TabIndex = 1;
            this.TBNombreProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNombreProyecto.CustomButton.UseSelectable = true;
            this.TBNombreProyecto.CustomButton.Visible = false;
            this.TBNombreProyecto.Enabled = false;
            this.TBNombreProyecto.Lines = new string[] {
        "metroTextBox2"};
            this.TBNombreProyecto.Location = new System.Drawing.Point(222, 80);
            this.TBNombreProyecto.MaxLength = 32767;
            this.TBNombreProyecto.Multiline = true;
            this.TBNombreProyecto.Name = "TBNombreProyecto";
            this.TBNombreProyecto.PasswordChar = '\0';
            this.TBNombreProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNombreProyecto.SelectedText = "";
            this.TBNombreProyecto.SelectionLength = 0;
            this.TBNombreProyecto.SelectionStart = 0;
            this.TBNombreProyecto.ShortcutsEnabled = true;
            this.TBNombreProyecto.Size = new System.Drawing.Size(138, 23);
            this.TBNombreProyecto.TabIndex = 3;
            this.TBNombreProyecto.Text = "metroTextBox2";
            this.TBNombreProyecto.UseSelectable = true;
            this.TBNombreProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNombreProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(85, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Nombre del Proyecto:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(85, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(134, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Codigo del Proyecto:";
            // 
            // TBCodigoProyecto
            // 
            // 
            // 
            // 
            this.TBCodigoProyecto.CustomButton.Image = null;
            this.TBCodigoProyecto.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.TBCodigoProyecto.CustomButton.Name = "";
            this.TBCodigoProyecto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBCodigoProyecto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBCodigoProyecto.CustomButton.TabIndex = 1;
            this.TBCodigoProyecto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBCodigoProyecto.CustomButton.UseSelectable = true;
            this.TBCodigoProyecto.CustomButton.Visible = false;
            this.TBCodigoProyecto.Enabled = false;
            this.TBCodigoProyecto.Lines = new string[] {
        "metroTextBox1"};
            this.TBCodigoProyecto.Location = new System.Drawing.Point(222, 19);
            this.TBCodigoProyecto.MaxLength = 32767;
            this.TBCodigoProyecto.Multiline = true;
            this.TBCodigoProyecto.Name = "TBCodigoProyecto";
            this.TBCodigoProyecto.PasswordChar = '\0';
            this.TBCodigoProyecto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBCodigoProyecto.SelectedText = "";
            this.TBCodigoProyecto.SelectionLength = 0;
            this.TBCodigoProyecto.SelectionStart = 0;
            this.TBCodigoProyecto.ShortcutsEnabled = true;
            this.TBCodigoProyecto.Size = new System.Drawing.Size(138, 23);
            this.TBCodigoProyecto.TabIndex = 1;
            this.TBCodigoProyecto.Text = "metroTextBox1";
            this.TBCodigoProyecto.UseSelectable = true;
            this.TBCodigoProyecto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBCodigoProyecto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroGrid1);
            this.groupBox2.Location = new System.Drawing.Point(15, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 280);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colaboradores Asignados a este proyecto";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVBCdesasignarcolaborador,
            this.DGVBCvercolaborador});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 16);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(747, 261);
            this.metroGrid1.TabIndex = 2;
            // 
            // DGVBCdesasignarcolaborador
            // 
            this.DGVBCdesasignarcolaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DGVBCdesasignarcolaborador.HeaderText = "";
            this.DGVBCdesasignarcolaborador.Name = "DGVBCdesasignarcolaborador";
            this.DGVBCdesasignarcolaborador.ReadOnly = true;
            this.DGVBCdesasignarcolaborador.Text = "Desasignar Colaborador";
            this.DGVBCdesasignarcolaborador.UseColumnTextForButtonValue = true;
            this.DGVBCdesasignarcolaborador.Width = 150;
            // 
            // DGVBCvercolaborador
            // 
            this.DGVBCvercolaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DGVBCvercolaborador.HeaderText = "";
            this.DGVBCvercolaborador.Name = "DGVBCvercolaborador";
            this.DGVBCvercolaborador.ReadOnly = true;
            this.DGVBCvercolaborador.Text = "Ver Colaborador";
            this.DGVBCvercolaborador.UseColumnTextForButtonValue = true;
            this.DGVBCvercolaborador.Width = 125;
            // 
            // lineanegociosTableAdapter
            // 
            this.lineanegociosTableAdapter.ClearBeforeFill = true;
            // 
            // direccionesTableAdapter
            // 
            this.direccionesTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Enabled = false;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(18, 81);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Enabled = false;
            this.metroButton1.Location = new System.Drawing.Point(510, 123);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(138, 23);
            this.metroButton1.TabIndex = 47;
            this.metroButton1.Text = "Realizar Cambio";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            // 
            // VerProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerProyecto";
            this.Load += new System.EventHandler(this.VerProyecto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.direccionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineanegociosBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox TBCodigoProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroLabel MLApellidosGerente;
        private MetroFramework.Controls.MetroLabel MLNombresGerente;
        private MetroFramework.Controls.MetroComboBox CBDireccionProyecto;
        private MetroFramework.Controls.MetroComboBox CBLineanegocioProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TBNombreProyecto;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private DirectoryDBDataSet directoryDBDataSet;
        private System.Windows.Forms.BindingSource lineanegociosBindingSource;
        private DirectoryDBDataSetTableAdapters.lineanegociosTableAdapter lineanegociosTableAdapter;
        private System.Windows.Forms.BindingSource direccionesBindingSource;
        private DirectoryDBDataSetTableAdapters.direccionesTableAdapter direccionesTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn DGVBCdesasignarcolaborador;
        private System.Windows.Forms.DataGridViewButtonColumn DGVBCvercolaborador;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}