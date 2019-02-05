namespace WindowsFormsApp1
{
    partial class InicioBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryDBDataSet = new WindowsFormsApp1.DirectoryDBDataSet();
            this.directoryDBDataSet1 = new WindowsFormsApp1.DirectoryDBDataSet();
            this.dataTable1TableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.DataTable1TableAdapter();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.button3 = new MetroFramework.Controls.MetroButton();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.directoryDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idcodigocolaboradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrescolaboradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoscolaboradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correocolaboradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movilcolaboradorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreestadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrerolDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNAsignarproyecto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BTNVercolaborador = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(2, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 554);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroButton3);
            this.splitContainer1.Panel2.Controls.Add(this.metroButton2);
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(213, 535);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Location = new System.Drawing.Point(227, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 55);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Panel2.Controls.Add(this.metroButton1);
            this.splitContainer2.Size = new System.Drawing.Size(956, 36);
            this.splitContainer2.SplitterDistance = 487;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.directoryDBDataSet;
            // 
            // directoryDBDataSet
            // 
            this.directoryDBDataSet.DataSetName = "DirectoryDBDataSet";
            this.directoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directoryDBDataSet1
            // 
            this.directoryDBDataSet1.DataSetName = "DirectoryDBDataSet";
            this.directoryDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton1.Location = new System.Drawing.Point(3, 10);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Agregar Colaborador";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(284, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(230, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(3, 10);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.Size = new System.Drawing.Size(252, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(322, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir del Directorio";
            this.button3.UseSelectable = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "LBLCodigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "LBLNombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "LBLApellidos";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 38);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Bienvenido al directorio\r\nde proyectos";
            // 
            // metroStyleExtender1
            // 
            this.metroStyleExtender1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton2
            // 
            this.metroButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton2.Location = new System.Drawing.Point(0, 10);
            this.metroButton2.Margin = new System.Windows.Forms.Padding(0);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(213, 23);
            this.metroButton2.TabIndex = 0;
            this.metroButton2.Text = "Proyectos ";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.UseSelectable = true;
            // 
            // metroButton3
            // 
            this.metroButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButton3.Location = new System.Drawing.Point(0, 36);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(213, 23);
            this.metroButton3.TabIndex = 1;
            this.metroButton3.Text = "Colaboradores";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton3.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcodigocolaboradorDataGridViewTextBoxColumn1,
            this.nombrescolaboradorDataGridViewTextBoxColumn1,
            this.apellidoscolaboradorDataGridViewTextBoxColumn1,
            this.correocolaboradorDataGridViewTextBoxColumn1,
            this.movilcolaboradorDataGridViewTextBoxColumn1,
            this.nombreestadoDataGridViewTextBoxColumn1,
            this.nombrerolDataGridViewTextBoxColumn1,
            this.BTNAsignarproyecto,
            this.BTNVercolaborador});
            this.metroGrid1.DataSource = this.dataTable1BindingSource1;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(230, 81);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(956, 493);
            this.metroGrid1.TabIndex = 4;
            // 
            // directoryDBDataSetBindingSource
            // 
            this.directoryDBDataSetBindingSource.DataSource = this.directoryDBDataSet;
            this.directoryDBDataSetBindingSource.Position = 0;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.directoryDBDataSetBindingSource;
            // 
            // idcodigocolaboradorDataGridViewTextBoxColumn1
            // 
            this.idcodigocolaboradorDataGridViewTextBoxColumn1.DataPropertyName = "idcodigocolaborador";
            this.idcodigocolaboradorDataGridViewTextBoxColumn1.HeaderText = "idcodigocolaborador";
            this.idcodigocolaboradorDataGridViewTextBoxColumn1.Name = "idcodigocolaboradorDataGridViewTextBoxColumn1";
            this.idcodigocolaboradorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombrescolaboradorDataGridViewTextBoxColumn1
            // 
            this.nombrescolaboradorDataGridViewTextBoxColumn1.DataPropertyName = "nombrescolaborador";
            this.nombrescolaboradorDataGridViewTextBoxColumn1.HeaderText = "nombrescolaborador";
            this.nombrescolaboradorDataGridViewTextBoxColumn1.Name = "nombrescolaboradorDataGridViewTextBoxColumn1";
            this.nombrescolaboradorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // apellidoscolaboradorDataGridViewTextBoxColumn1
            // 
            this.apellidoscolaboradorDataGridViewTextBoxColumn1.DataPropertyName = "apellidoscolaborador";
            this.apellidoscolaboradorDataGridViewTextBoxColumn1.HeaderText = "apellidoscolaborador";
            this.apellidoscolaboradorDataGridViewTextBoxColumn1.Name = "apellidoscolaboradorDataGridViewTextBoxColumn1";
            this.apellidoscolaboradorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // correocolaboradorDataGridViewTextBoxColumn1
            // 
            this.correocolaboradorDataGridViewTextBoxColumn1.DataPropertyName = "correocolaborador";
            this.correocolaboradorDataGridViewTextBoxColumn1.HeaderText = "correocolaborador";
            this.correocolaboradorDataGridViewTextBoxColumn1.Name = "correocolaboradorDataGridViewTextBoxColumn1";
            this.correocolaboradorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // movilcolaboradorDataGridViewTextBoxColumn1
            // 
            this.movilcolaboradorDataGridViewTextBoxColumn1.DataPropertyName = "movilcolaborador";
            this.movilcolaboradorDataGridViewTextBoxColumn1.HeaderText = "movilcolaborador";
            this.movilcolaboradorDataGridViewTextBoxColumn1.Name = "movilcolaboradorDataGridViewTextBoxColumn1";
            this.movilcolaboradorDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreestadoDataGridViewTextBoxColumn1
            // 
            this.nombreestadoDataGridViewTextBoxColumn1.DataPropertyName = "nombreestado";
            this.nombreestadoDataGridViewTextBoxColumn1.HeaderText = "nombreestado";
            this.nombreestadoDataGridViewTextBoxColumn1.Name = "nombreestadoDataGridViewTextBoxColumn1";
            this.nombreestadoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombrerolDataGridViewTextBoxColumn1
            // 
            this.nombrerolDataGridViewTextBoxColumn1.DataPropertyName = "nombrerol";
            this.nombrerolDataGridViewTextBoxColumn1.HeaderText = "nombrerol";
            this.nombrerolDataGridViewTextBoxColumn1.Name = "nombrerolDataGridViewTextBoxColumn1";
            this.nombrerolDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // BTNAsignarproyecto
            // 
            this.BTNAsignarproyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNAsignarproyecto.HeaderText = "";
            this.BTNAsignarproyecto.Name = "BTNAsignarproyecto";
            this.BTNAsignarproyecto.ReadOnly = true;
            this.BTNAsignarproyecto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BTNAsignarproyecto.Text = "Asignar Proyecto";
            this.BTNAsignarproyecto.UseColumnTextForButtonValue = true;
            // 
            // BTNVercolaborador
            // 
            this.BTNVercolaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNVercolaborador.HeaderText = "";
            this.BTNVercolaborador.Name = "BTNVercolaborador";
            this.BTNVercolaborador.ReadOnly = true;
            this.BTNVercolaborador.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.BTNVercolaborador.Text = "Ver Colaborador";
            this.BTNVercolaborador.UseColumnTextForButtonValue = true;
            // 
            // InicioBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InicioBase";
            this.Load += new System.EventHandler(this.LobbyBase_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipodocumentocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestadocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrolcolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingresocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salariocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifarealcolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingresoxclarocolaboradorDataGridViewTextBoxColumn;
        private DirectoryDBDataSet directoryDBDataSet1;
        private DirectoryDBDataSet directoryDBDataSet;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DirectoryDBDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerodocumentocolaboradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretipodocumentoDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroButton button3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource directoryDBDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcodigocolaboradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrescolaboradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoscolaboradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn correocolaboradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn movilcolaboradorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreestadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrerolDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn BTNAsignarproyecto;
        private System.Windows.Forms.DataGridViewButtonColumn BTNVercolaborador;
    }
}