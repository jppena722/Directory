namespace WindowsFormsApp1
{
    partial class AgregarColaboradorBase
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tipodocumentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoryDBDataSet = new WindowsFormsApp1.DirectoryDBDataSet();
            this.tipodocumentosTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.tipodocumentosTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.estadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadosTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.estadosTableAdapter();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new WindowsFormsApp1.DirectoryDBDataSetTableAdapters.rolesTableAdapter();
            this.TBCodigoColaborador = new MetroFramework.Controls.MetroTextBox();
            this.tipodocumentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TBNombresColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TBApellidosColaborador = new MetroFramework.Controls.MetroTextBox();
            this.CBTipodocumentoColaborador = new MetroFramework.Controls.MetroComboBox();
            this.TBDocumentoColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.TBCorreoColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.TBMovilColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.CBEstadoColaborador = new MetroFramework.Controls.MetroComboBox();
            this.CBRolColaborador = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.DTFechaingresoColaborador = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.TBPuestoColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.TBPisoColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.TBSalarioColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.TBTarifarealColaborador = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.TBTarifaxclaroColaborador = new MetroFramework.Controls.MetroTextBox();
            this.BTRegistrarColaborador = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer2);
            this.groupBox2.Location = new System.Drawing.Point(232, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(962, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.textBox1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Size = new System.Drawing.Size(956, 36);
            this.splitContainer2.SplitterDistance = 487;
            this.splitContainer2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(264, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(352, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Volver al Inicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tipodocumentosBindingSource
            // 
            this.tipodocumentosBindingSource.DataMember = "tipodocumentos";
            this.tipodocumentosBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // directoryDBDataSet
            // 
            this.directoryDBDataSet.DataSetName = "DirectoryDBDataSet";
            this.directoryDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipodocumentosTableAdapter
            // 
            this.tipodocumentosTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(418, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Formulario para registro de Colaboradores\r\n";
            // 
            // estadosBindingSource
            // 
            this.estadosBindingSource.DataMember = "estados";
            this.estadosBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // estadosTableAdapter
            // 
            this.estadosTableAdapter.ClearBeforeFill = true;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "roles";
            this.rolesBindingSource.DataSource = this.directoryDBDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // TBCodigoColaborador
            // 
            // 
            // 
            // 
            this.TBCodigoColaborador.CustomButton.Image = null;
            this.TBCodigoColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBCodigoColaborador.CustomButton.Name = "";
            this.TBCodigoColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBCodigoColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBCodigoColaborador.CustomButton.TabIndex = 1;
            this.TBCodigoColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBCodigoColaborador.CustomButton.UseSelectable = true;
            this.TBCodigoColaborador.CustomButton.Visible = false;
            this.TBCodigoColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBCodigoColaborador.Lines = new string[0];
            this.TBCodigoColaborador.Location = new System.Drawing.Point(466, 142);
            this.TBCodigoColaborador.MaxLength = 32767;
            this.TBCodigoColaborador.Name = "TBCodigoColaborador";
            this.TBCodigoColaborador.PasswordChar = '\0';
            this.TBCodigoColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBCodigoColaborador.SelectedText = "";
            this.TBCodigoColaborador.SelectionLength = 0;
            this.TBCodigoColaborador.SelectionStart = 0;
            this.TBCodigoColaborador.ShortcutsEnabled = true;
            this.TBCodigoColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBCodigoColaborador.TabIndex = 38;
            this.TBCodigoColaborador.UseSelectable = true;
            this.TBCodigoColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBCodigoColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tipodocumentosBindingSource1
            // 
            this.tipodocumentosBindingSource1.DataMember = "tipodocumentos";
            this.tipodocumentosBindingSource1.DataSource = this.directoryDBDataSet;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(256, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(155, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Codigo del Colaborador";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(256, 175);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(166, 19);
            this.metroLabel3.TabIndex = 45;
            this.metroLabel3.Text = "Nombres del Colaborador";
            // 
            // TBNombresColaborador
            // 
            // 
            // 
            // 
            this.TBNombresColaborador.CustomButton.Image = null;
            this.TBNombresColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBNombresColaborador.CustomButton.Name = "";
            this.TBNombresColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBNombresColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBNombresColaborador.CustomButton.TabIndex = 1;
            this.TBNombresColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBNombresColaborador.CustomButton.UseSelectable = true;
            this.TBNombresColaborador.CustomButton.Visible = false;
            this.TBNombresColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBNombresColaborador.Lines = new string[0];
            this.TBNombresColaborador.Location = new System.Drawing.Point(466, 171);
            this.TBNombresColaborador.MaxLength = 32767;
            this.TBNombresColaborador.Name = "TBNombresColaborador";
            this.TBNombresColaborador.PasswordChar = '\0';
            this.TBNombresColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBNombresColaborador.SelectedText = "";
            this.TBNombresColaborador.SelectionLength = 0;
            this.TBNombresColaborador.SelectionStart = 0;
            this.TBNombresColaborador.ShortcutsEnabled = true;
            this.TBNombresColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBNombresColaborador.TabIndex = 44;
            this.TBNombresColaborador.UseSelectable = true;
            this.TBNombresColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBNombresColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(256, 204);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(165, 19);
            this.metroLabel4.TabIndex = 47;
            this.metroLabel4.Text = "Apellidos del Colaborador";
            // 
            // TBApellidosColaborador
            // 
            // 
            // 
            // 
            this.TBApellidosColaborador.CustomButton.Image = null;
            this.TBApellidosColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBApellidosColaborador.CustomButton.Name = "";
            this.TBApellidosColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBApellidosColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBApellidosColaborador.CustomButton.TabIndex = 1;
            this.TBApellidosColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBApellidosColaborador.CustomButton.UseSelectable = true;
            this.TBApellidosColaborador.CustomButton.Visible = false;
            this.TBApellidosColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBApellidosColaborador.Lines = new string[0];
            this.TBApellidosColaborador.Location = new System.Drawing.Point(466, 200);
            this.TBApellidosColaborador.MaxLength = 32767;
            this.TBApellidosColaborador.Name = "TBApellidosColaborador";
            this.TBApellidosColaborador.PasswordChar = '\0';
            this.TBApellidosColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBApellidosColaborador.SelectedText = "";
            this.TBApellidosColaborador.SelectionLength = 0;
            this.TBApellidosColaborador.SelectionStart = 0;
            this.TBApellidosColaborador.ShortcutsEnabled = true;
            this.TBApellidosColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBApellidosColaborador.TabIndex = 46;
            this.TBApellidosColaborador.UseSelectable = true;
            this.TBApellidosColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBApellidosColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CBTipodocumentoColaborador
            // 
            this.CBTipodocumentoColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipodocumentoColaborador.DataSource = this.tipodocumentosBindingSource;
            this.CBTipodocumentoColaborador.DisplayMember = "nombretipodocumento";
            this.CBTipodocumentoColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBTipodocumentoColaborador.FormattingEnabled = true;
            this.CBTipodocumentoColaborador.ItemHeight = 23;
            this.CBTipodocumentoColaborador.Location = new System.Drawing.Point(466, 231);
            this.CBTipodocumentoColaborador.Name = "CBTipodocumentoColaborador";
            this.CBTipodocumentoColaborador.Size = new System.Drawing.Size(203, 29);
            this.CBTipodocumentoColaborador.TabIndex = 51;
            this.CBTipodocumentoColaborador.UseSelectable = true;
            this.CBTipodocumentoColaborador.ValueMember = "idtipodocumento";
            // 
            // TBDocumentoColaborador
            // 
            // 
            // 
            // 
            this.TBDocumentoColaborador.CustomButton.Image = null;
            this.TBDocumentoColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBDocumentoColaborador.CustomButton.Name = "";
            this.TBDocumentoColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBDocumentoColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBDocumentoColaborador.CustomButton.TabIndex = 1;
            this.TBDocumentoColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBDocumentoColaborador.CustomButton.UseSelectable = true;
            this.TBDocumentoColaborador.CustomButton.Visible = false;
            this.TBDocumentoColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBDocumentoColaborador.Lines = new string[0];
            this.TBDocumentoColaborador.Location = new System.Drawing.Point(466, 268);
            this.TBDocumentoColaborador.MaxLength = 32767;
            this.TBDocumentoColaborador.Name = "TBDocumentoColaborador";
            this.TBDocumentoColaborador.PasswordChar = '\0';
            this.TBDocumentoColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBDocumentoColaborador.SelectedText = "";
            this.TBDocumentoColaborador.SelectionLength = 0;
            this.TBDocumentoColaborador.SelectionStart = 0;
            this.TBDocumentoColaborador.ShortcutsEnabled = true;
            this.TBDocumentoColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBDocumentoColaborador.TabIndex = 52;
            this.TBDocumentoColaborador.UseSelectable = true;
            this.TBDocumentoColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBDocumentoColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(256, 241);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(208, 19);
            this.metroLabel6.TabIndex = 53;
            this.metroLabel6.Text = "Tipo documento del Colaborador";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(256, 272);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(179, 19);
            this.metroLabel7.TabIndex = 54;
            this.metroLabel7.Text = "Documento del Colaborador";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(256, 301);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(153, 19);
            this.metroLabel8.TabIndex = 56;
            this.metroLabel8.Text = "Correo del Colaborador";
            // 
            // TBCorreoColaborador
            // 
            // 
            // 
            // 
            this.TBCorreoColaborador.CustomButton.Image = null;
            this.TBCorreoColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBCorreoColaborador.CustomButton.Name = "";
            this.TBCorreoColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBCorreoColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBCorreoColaborador.CustomButton.TabIndex = 1;
            this.TBCorreoColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBCorreoColaborador.CustomButton.UseSelectable = true;
            this.TBCorreoColaborador.CustomButton.Visible = false;
            this.TBCorreoColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBCorreoColaborador.Lines = new string[0];
            this.TBCorreoColaborador.Location = new System.Drawing.Point(466, 297);
            this.TBCorreoColaborador.MaxLength = 32767;
            this.TBCorreoColaborador.Name = "TBCorreoColaborador";
            this.TBCorreoColaborador.PasswordChar = '\0';
            this.TBCorreoColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBCorreoColaborador.SelectedText = "";
            this.TBCorreoColaborador.SelectionLength = 0;
            this.TBCorreoColaborador.SelectionStart = 0;
            this.TBCorreoColaborador.ShortcutsEnabled = true;
            this.TBCorreoColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBCorreoColaborador.TabIndex = 55;
            this.TBCorreoColaborador.UseSelectable = true;
            this.TBCorreoColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBCorreoColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(256, 330);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(143, 19);
            this.metroLabel9.TabIndex = 58;
            this.metroLabel9.Text = "Movil del Colaborador";
            // 
            // TBMovilColaborador
            // 
            // 
            // 
            // 
            this.TBMovilColaborador.CustomButton.Image = null;
            this.TBMovilColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBMovilColaborador.CustomButton.Name = "";
            this.TBMovilColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBMovilColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBMovilColaborador.CustomButton.TabIndex = 1;
            this.TBMovilColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBMovilColaborador.CustomButton.UseSelectable = true;
            this.TBMovilColaborador.CustomButton.Visible = false;
            this.TBMovilColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBMovilColaborador.Lines = new string[0];
            this.TBMovilColaborador.Location = new System.Drawing.Point(466, 326);
            this.TBMovilColaborador.MaxLength = 32767;
            this.TBMovilColaborador.Name = "TBMovilColaborador";
            this.TBMovilColaborador.PasswordChar = '\0';
            this.TBMovilColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBMovilColaborador.SelectedText = "";
            this.TBMovilColaborador.SelectionLength = 0;
            this.TBMovilColaborador.SelectionStart = 0;
            this.TBMovilColaborador.ShortcutsEnabled = true;
            this.TBMovilColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBMovilColaborador.TabIndex = 57;
            this.TBMovilColaborador.UseSelectable = true;
            this.TBMovilColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBMovilColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(256, 360);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(150, 19);
            this.metroLabel10.TabIndex = 60;
            this.metroLabel10.Text = "Estado del Colaborador";
            // 
            // CBEstadoColaborador
            // 
            this.CBEstadoColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBEstadoColaborador.DataSource = this.estadosBindingSource;
            this.CBEstadoColaborador.DisplayMember = "nombreestado";
            this.CBEstadoColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBEstadoColaborador.FormattingEnabled = true;
            this.CBEstadoColaborador.ItemHeight = 23;
            this.CBEstadoColaborador.Location = new System.Drawing.Point(466, 355);
            this.CBEstadoColaborador.Name = "CBEstadoColaborador";
            this.CBEstadoColaborador.Size = new System.Drawing.Size(203, 29);
            this.CBEstadoColaborador.TabIndex = 61;
            this.CBEstadoColaborador.UseSelectable = true;
            this.CBEstadoColaborador.ValueMember = "idestado";
            // 
            // CBRolColaborador
            // 
            this.CBRolColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRolColaborador.DataSource = this.rolesBindingSource;
            this.CBRolColaborador.DisplayMember = "nombrerol";
            this.CBRolColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBRolColaborador.FormattingEnabled = true;
            this.CBRolColaborador.ItemHeight = 23;
            this.CBRolColaborador.Location = new System.Drawing.Point(466, 390);
            this.CBRolColaborador.Name = "CBRolColaborador";
            this.CBRolColaborador.Size = new System.Drawing.Size(203, 29);
            this.CBRolColaborador.TabIndex = 63;
            this.CBRolColaborador.UseSelectable = true;
            this.CBRolColaborador.ValueMember = "idrol";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(256, 395);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(130, 19);
            this.metroLabel11.TabIndex = 62;
            this.metroLabel11.Text = "Rol del Colaborador";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(256, 426);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(109, 38);
            this.metroLabel12.TabIndex = 64;
            this.metroLabel12.Text = "Fecha de ingreso\r\nColaborador";
            // 
            // DTFechaingresoColaborador
            // 
            this.DTFechaingresoColaborador.Location = new System.Drawing.Point(466, 426);
            this.DTFechaingresoColaborador.MinimumSize = new System.Drawing.Size(0, 29);
            this.DTFechaingresoColaborador.Name = "DTFechaingresoColaborador";
            this.DTFechaingresoColaborador.Size = new System.Drawing.Size(203, 29);
            this.DTFechaingresoColaborador.TabIndex = 65;
            this.DTFechaingresoColaborador.Value = new System.DateTime(2019, 2, 5, 0, 0, 0, 0);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(747, 173);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(150, 19);
            this.metroLabel13.TabIndex = 69;
            this.metroLabel13.Text = "Puesto del Colaborador";
            // 
            // TBPuestoColaborador
            // 
            // 
            // 
            // 
            this.TBPuestoColaborador.CustomButton.Image = null;
            this.TBPuestoColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBPuestoColaborador.CustomButton.Name = "";
            this.TBPuestoColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBPuestoColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBPuestoColaborador.CustomButton.TabIndex = 1;
            this.TBPuestoColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBPuestoColaborador.CustomButton.UseSelectable = true;
            this.TBPuestoColaborador.CustomButton.Visible = false;
            this.TBPuestoColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBPuestoColaborador.Lines = new string[0];
            this.TBPuestoColaborador.Location = new System.Drawing.Point(957, 171);
            this.TBPuestoColaborador.MaxLength = 32767;
            this.TBPuestoColaborador.Name = "TBPuestoColaborador";
            this.TBPuestoColaborador.PasswordChar = '\0';
            this.TBPuestoColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBPuestoColaborador.SelectedText = "";
            this.TBPuestoColaborador.SelectionLength = 0;
            this.TBPuestoColaborador.SelectionStart = 0;
            this.TBPuestoColaborador.ShortcutsEnabled = true;
            this.TBPuestoColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBPuestoColaborador.TabIndex = 68;
            this.TBPuestoColaborador.UseSelectable = true;
            this.TBPuestoColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBPuestoColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(747, 146);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(135, 19);
            this.metroLabel14.TabIndex = 67;
            this.metroLabel14.Text = "Piso del Colaborador";
            // 
            // TBPisoColaborador
            // 
            // 
            // 
            // 
            this.TBPisoColaborador.CustomButton.Image = null;
            this.TBPisoColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBPisoColaborador.CustomButton.Name = "";
            this.TBPisoColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBPisoColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBPisoColaborador.CustomButton.TabIndex = 1;
            this.TBPisoColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBPisoColaborador.CustomButton.UseSelectable = true;
            this.TBPisoColaborador.CustomButton.Visible = false;
            this.TBPisoColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBPisoColaborador.Lines = new string[0];
            this.TBPisoColaborador.Location = new System.Drawing.Point(957, 142);
            this.TBPisoColaborador.MaxLength = 32767;
            this.TBPisoColaborador.Name = "TBPisoColaborador";
            this.TBPisoColaborador.PasswordChar = '\0';
            this.TBPisoColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBPisoColaborador.SelectedText = "";
            this.TBPisoColaborador.SelectionLength = 0;
            this.TBPisoColaborador.SelectionStart = 0;
            this.TBPisoColaborador.ShortcutsEnabled = true;
            this.TBPisoColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBPisoColaborador.TabIndex = 66;
            this.TBPisoColaborador.UseSelectable = true;
            this.TBPisoColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBPisoColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(747, 231);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(85, 38);
            this.metroLabel15.TabIndex = 73;
            this.metroLabel15.Text = "Tarifa Real \r\nColaborador";
            // 
            // TBSalarioColaborador
            // 
            // 
            // 
            // 
            this.TBSalarioColaborador.CustomButton.Image = null;
            this.TBSalarioColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBSalarioColaborador.CustomButton.Name = "";
            this.TBSalarioColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBSalarioColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBSalarioColaborador.CustomButton.TabIndex = 1;
            this.TBSalarioColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBSalarioColaborador.CustomButton.UseSelectable = true;
            this.TBSalarioColaborador.CustomButton.Visible = false;
            this.TBSalarioColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBSalarioColaborador.Lines = new string[0];
            this.TBSalarioColaborador.Location = new System.Drawing.Point(957, 200);
            this.TBSalarioColaborador.MaxLength = 32767;
            this.TBSalarioColaborador.Name = "TBSalarioColaborador";
            this.TBSalarioColaborador.PasswordChar = '\0';
            this.TBSalarioColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBSalarioColaborador.SelectedText = "";
            this.TBSalarioColaborador.SelectionLength = 0;
            this.TBSalarioColaborador.SelectionStart = 0;
            this.TBSalarioColaborador.ShortcutsEnabled = true;
            this.TBSalarioColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBSalarioColaborador.TabIndex = 72;
            this.TBSalarioColaborador.UseSelectable = true;
            this.TBSalarioColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBSalarioColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(747, 204);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(151, 19);
            this.metroLabel16.TabIndex = 71;
            this.metroLabel16.Text = "Salario del Colaborador";
            // 
            // TBTarifarealColaborador
            // 
            // 
            // 
            // 
            this.TBTarifarealColaborador.CustomButton.Image = null;
            this.TBTarifarealColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBTarifarealColaborador.CustomButton.Name = "";
            this.TBTarifarealColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBTarifarealColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBTarifarealColaborador.CustomButton.TabIndex = 1;
            this.TBTarifarealColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBTarifarealColaborador.CustomButton.UseSelectable = true;
            this.TBTarifarealColaborador.CustomButton.Visible = false;
            this.TBTarifarealColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBTarifarealColaborador.Lines = new string[0];
            this.TBTarifarealColaborador.Location = new System.Drawing.Point(957, 235);
            this.TBTarifarealColaborador.MaxLength = 32767;
            this.TBTarifarealColaborador.Name = "TBTarifarealColaborador";
            this.TBTarifarealColaborador.PasswordChar = '\0';
            this.TBTarifarealColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBTarifarealColaborador.SelectedText = "";
            this.TBTarifarealColaborador.SelectionLength = 0;
            this.TBTarifarealColaborador.SelectionStart = 0;
            this.TBTarifarealColaborador.ShortcutsEnabled = true;
            this.TBTarifarealColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBTarifarealColaborador.TabIndex = 70;
            this.TBTarifarealColaborador.UseSelectable = true;
            this.TBTarifarealColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBTarifarealColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(747, 273);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(92, 38);
            this.metroLabel17.TabIndex = 75;
            this.metroLabel17.Text = "Tarifa X Claro \r\nColaborador";
            // 
            // TBTarifaxclaroColaborador
            // 
            // 
            // 
            // 
            this.TBTarifaxclaroColaborador.CustomButton.Image = null;
            this.TBTarifaxclaroColaborador.CustomButton.Location = new System.Drawing.Point(181, 1);
            this.TBTarifaxclaroColaborador.CustomButton.Name = "";
            this.TBTarifaxclaroColaborador.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TBTarifaxclaroColaborador.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TBTarifaxclaroColaborador.CustomButton.TabIndex = 1;
            this.TBTarifaxclaroColaborador.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TBTarifaxclaroColaborador.CustomButton.UseSelectable = true;
            this.TBTarifaxclaroColaborador.CustomButton.Visible = false;
            this.TBTarifaxclaroColaborador.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TBTarifaxclaroColaborador.Lines = new string[0];
            this.TBTarifaxclaroColaborador.Location = new System.Drawing.Point(957, 273);
            this.TBTarifaxclaroColaborador.MaxLength = 32767;
            this.TBTarifaxclaroColaborador.Name = "TBTarifaxclaroColaborador";
            this.TBTarifaxclaroColaborador.PasswordChar = '\0';
            this.TBTarifaxclaroColaborador.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TBTarifaxclaroColaborador.SelectedText = "";
            this.TBTarifaxclaroColaborador.SelectionLength = 0;
            this.TBTarifaxclaroColaborador.SelectionStart = 0;
            this.TBTarifaxclaroColaborador.ShortcutsEnabled = true;
            this.TBTarifaxclaroColaborador.Size = new System.Drawing.Size(203, 23);
            this.TBTarifaxclaroColaborador.TabIndex = 74;
            this.TBTarifaxclaroColaborador.UseSelectable = true;
            this.TBTarifaxclaroColaborador.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TBTarifaxclaroColaborador.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BTRegistrarColaborador
            // 
            this.BTRegistrarColaborador.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTRegistrarColaborador.Location = new System.Drawing.Point(747, 330);
            this.BTRegistrarColaborador.Name = "BTRegistrarColaborador";
            this.BTRegistrarColaborador.Size = new System.Drawing.Size(150, 23);
            this.BTRegistrarColaborador.TabIndex = 76;
            this.BTRegistrarColaborador.Text = "Registrar Colaborador";
            this.BTRegistrarColaborador.UseSelectable = true;
            this.BTRegistrarColaborador.Click += new System.EventHandler(this.BTRegistrarColaborador_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.Location = new System.Drawing.Point(5, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 554);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "LBLApellidos";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 38);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Bienvenido al directorio\r\nde proyectos";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "LBLCodigo";
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
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel2);
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
            // AgregarColaboradorBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.BTRegistrarColaborador);
            this.Controls.Add(this.metroLabel17);
            this.Controls.Add(this.TBTarifaxclaroColaborador);
            this.Controls.Add(this.metroLabel15);
            this.Controls.Add(this.TBSalarioColaborador);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.TBTarifarealColaborador);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.TBPuestoColaborador);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.TBPisoColaborador);
            this.Controls.Add(this.DTFechaingresoColaborador);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.CBRolColaborador);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.CBEstadoColaborador);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.TBMovilColaborador);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.TBCorreoColaborador);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.TBDocumentoColaborador);
            this.Controls.Add(this.CBTipodocumentoColaborador);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TBApellidosColaborador);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TBNombresColaborador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TBCodigoColaborador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Name = "AgregarColaboradorBase";
            this.Load += new System.EventHandler(this.AgregarColaboradorBase_Load);
            this.groupBox2.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoryDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipodocumentosBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private DirectoryDBDataSet directoryDBDataSet;
        private System.Windows.Forms.BindingSource tipodocumentosBindingSource;
        private DirectoryDBDataSetTableAdapters.tipodocumentosTableAdapter tipodocumentosTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.BindingSource estadosBindingSource;
        private DirectoryDBDataSetTableAdapters.estadosTableAdapter estadosTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private DirectoryDBDataSetTableAdapters.rolesTableAdapter rolesTableAdapter;
        private MetroFramework.Controls.MetroTextBox TBCodigoColaborador;
        private System.Windows.Forms.BindingSource tipodocumentosBindingSource1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TBNombresColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TBApellidosColaborador;
        private MetroFramework.Controls.MetroComboBox CBTipodocumentoColaborador;
        private MetroFramework.Controls.MetroTextBox TBDocumentoColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox TBCorreoColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox TBMovilColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox CBEstadoColaborador;
        private MetroFramework.Controls.MetroComboBox CBRolColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroDateTime DTFechaingresoColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox TBPuestoColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox TBPisoColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox TBSalarioColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox TBTarifarealColaborador;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox TBTarifaxclaroColaborador;
        private MetroFramework.Controls.MetroButton BTRegistrarColaborador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}