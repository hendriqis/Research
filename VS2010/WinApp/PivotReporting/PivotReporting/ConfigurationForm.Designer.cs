namespace PivotReporting
{
    partial class ConfigurationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabConfiguration = new DevExpress.XtraTab.XtraTabControl();
            this.pagDataConfig = new DevExpress.XtraTab.XtraTabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panConnectionString = new System.Windows.Forms.Panel();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnBrowse = new DevExpress.XtraEditors.SimpleButton();
            this.txtRemoteDataPath = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.pagPivotViewer = new DevExpress.XtraTab.XtraTabPage();
            this.cboWristbandType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.chkIsAutoLoadViewer = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboBarcodeType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboBarcodeValue = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pagLabelPrinter = new DevExpress.XtraTab.XtraTabPage();
            this.spnPrintLabelNo = new DevExpress.XtraEditors.SpinEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLabelPrinter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.pagPatientInformation = new DevExpress.XtraTab.XtraTabPage();
            this.chkIsUsingCompactInfo = new System.Windows.Forms.CheckBox();
            this.chkWardIsMandatory = new System.Windows.Forms.CheckBox();
            this.chkPhysicianIsMandatory = new System.Windows.Forms.CheckBox();
            this.txtRegistrationNo = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomAttribute5 = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomAttribute5 = new System.Windows.Forms.Label();
            this.txtCustomAttribute4 = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomAttribute4 = new System.Windows.Forms.Label();
            this.txtCustomAttribute3 = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomAttribute3 = new System.Windows.Forms.Label();
            this.txtCustomAttribute2 = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomAttribute2 = new System.Windows.Forms.Label();
            this.txtCustomAttribute1 = new DevExpress.XtraEditors.TextEdit();
            this.lblCustomAttribute1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabConfiguration)).BeginInit();
            this.tabConfiguration.SuspendLayout();
            this.pagDataConfig.SuspendLayout();
            this.panConnectionString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemoteDataPath.Properties)).BeginInit();
            this.pagPivotViewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboWristbandType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBarcodeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBarcodeValue.Properties)).BeginInit();
            this.pagLabelPrinter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrintLabelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLabelPrinter.Properties)).BeginInit();
            this.pagPatientInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistrationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabConfiguration);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 336);
            this.panel1.TabIndex = 0;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabConfiguration.Location = new System.Drawing.Point(0, 0);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.SelectedTabPage = this.pagDataConfig;
            this.tabConfiguration.Size = new System.Drawing.Size(450, 336);
            this.tabConfiguration.TabIndex = 1;
            this.tabConfiguration.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pagDataConfig,
            this.pagPivotViewer,
            this.pagLabelPrinter,
            this.pagPatientInformation});
            // 
            // pagDataConfig
            // 
            this.pagDataConfig.Controls.Add(this.checkBox1);
            this.pagDataConfig.Controls.Add(this.panConnectionString);
            this.pagDataConfig.Controls.Add(this.btnBrowse);
            this.pagDataConfig.Controls.Add(this.txtRemoteDataPath);
            this.pagDataConfig.Controls.Add(this.label4);
            this.pagDataConfig.Name = "pagDataConfig";
            this.pagDataConfig.Size = new System.Drawing.Size(444, 310);
            this.pagDataConfig.Text = "Data Connection";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(133, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Automatically cache viewer data";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panConnectionString
            // 
            this.panConnectionString.Controls.Add(this.txtServerName);
            this.panConnectionString.Controls.Add(this.label14);
            this.panConnectionString.Controls.Add(this.label15);
            this.panConnectionString.Controls.Add(this.txtDatabaseName);
            this.panConnectionString.Controls.Add(this.txtUserName);
            this.panConnectionString.Controls.Add(this.label17);
            this.panConnectionString.Controls.Add(this.label16);
            this.panConnectionString.Controls.Add(this.txtPassword);
            this.panConnectionString.Location = new System.Drawing.Point(9, 11);
            this.panConnectionString.Name = "panConnectionString";
            this.panConnectionString.Size = new System.Drawing.Size(428, 100);
            this.panConnectionString.TabIndex = 42;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(124, 7);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(145, 21);
            this.txtServerName.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Server Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "User Name";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(124, 75);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(145, 21);
            this.txtDatabaseName.TabIndex = 39;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(124, 30);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(145, 21);
            this.txtUserName.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(4, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Database Name";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(57, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "Password";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(145, 21);
            this.txtPassword.TabIndex = 37;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(401, 132);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(18, 21);
            this.btnBrowse.TabIndex = 29;
            this.btnBrowse.Text = "...";
            this.btnBrowse.Visible = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtRemoteDataPath
            // 
            this.txtRemoteDataPath.EditValue = "";
            this.txtRemoteDataPath.Location = new System.Drawing.Point(133, 133);
            this.txtRemoteDataPath.Name = "txtRemoteDataPath";
            this.txtRemoteDataPath.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRemoteDataPath.Properties.NullText = "i.e. 00-00-00-01";
            this.txtRemoteDataPath.Size = new System.Drawing.Size(266, 20);
            this.txtRemoteDataPath.TabIndex = 28;
            this.txtRemoteDataPath.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Remote Data Location";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Visible = false;
            // 
            // pagPivotViewer
            // 
            this.pagPivotViewer.Controls.Add(this.cboWristbandType);
            this.pagPivotViewer.Controls.Add(this.chkIsAutoLoadViewer);
            this.pagPivotViewer.Controls.Add(this.label3);
            this.pagPivotViewer.Controls.Add(this.label8);
            this.pagPivotViewer.Controls.Add(this.cboBarcodeType);
            this.pagPivotViewer.Controls.Add(this.cboBarcodeValue);
            this.pagPivotViewer.Name = "pagPivotViewer";
            this.pagPivotViewer.PageVisible = false;
            this.pagPivotViewer.Size = new System.Drawing.Size(444, 310);
            this.pagPivotViewer.Text = "Viewer Control";
            // 
            // cboWristbandType
            // 
            this.cboWristbandType.Location = new System.Drawing.Point(138, 32);
            this.cboWristbandType.Name = "cboWristbandType";
            this.cboWristbandType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboWristbandType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboWristbandType.Properties.Items.AddRange(new object[] {
            "Clip",
            "Economy",
            "Comfort",
            "Soft Infant"});
            this.cboWristbandType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboWristbandType.Size = new System.Drawing.Size(145, 20);
            this.cboWristbandType.TabIndex = 28;
            // 
            // chkIsAutoLoadViewer
            // 
            this.chkIsAutoLoadViewer.AutoSize = true;
            this.chkIsAutoLoadViewer.Location = new System.Drawing.Point(138, 58);
            this.chkIsAutoLoadViewer.Name = "chkIsAutoLoadViewer";
            this.chkIsAutoLoadViewer.Size = new System.Drawing.Size(157, 17);
            this.chkIsAutoLoadViewer.TabIndex = 29;
            this.chkIsAutoLoadViewer.Text = "Auto Load Viewer Template";
            this.chkIsAutoLoadViewer.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tipe Barcode";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Jenis Gelang";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboBarcodeType
            // 
            this.cboBarcodeType.Location = new System.Drawing.Point(138, 11);
            this.cboBarcodeType.Name = "cboBarcodeType";
            this.cboBarcodeType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboBarcodeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBarcodeType.Properties.Items.AddRange(new object[] {
            "Linear",
            "QRCode"});
            this.cboBarcodeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboBarcodeType.Size = new System.Drawing.Size(145, 20);
            this.cboBarcodeType.TabIndex = 18;
            // 
            // cboBarcodeValue
            // 
            this.cboBarcodeValue.Location = new System.Drawing.Point(284, 11);
            this.cboBarcodeValue.Name = "cboBarcodeValue";
            this.cboBarcodeValue.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboBarcodeValue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboBarcodeValue.Properties.Items.AddRange(new object[] {
            "Medical Number",
            "Registration Number"});
            this.cboBarcodeValue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboBarcodeValue.Size = new System.Drawing.Size(140, 20);
            this.cboBarcodeValue.TabIndex = 19;
            this.cboBarcodeValue.Visible = false;
            // 
            // pagLabelPrinter
            // 
            this.pagLabelPrinter.Controls.Add(this.spnPrintLabelNo);
            this.pagLabelPrinter.Controls.Add(this.label7);
            this.pagLabelPrinter.Controls.Add(this.cboLabelPrinter);
            this.pagLabelPrinter.Controls.Add(this.label6);
            this.pagLabelPrinter.Name = "pagLabelPrinter";
            this.pagLabelPrinter.PageVisible = false;
            this.pagLabelPrinter.Size = new System.Drawing.Size(444, 310);
            this.pagLabelPrinter.Text = "Printing and Export";
            // 
            // spnPrintLabelNo
            // 
            this.spnPrintLabelNo.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnPrintLabelNo.Location = new System.Drawing.Point(120, 41);
            this.spnPrintLabelNo.Name = "spnPrintLabelNo";
            this.spnPrintLabelNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.spnPrintLabelNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.spnPrintLabelNo.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spnPrintLabelNo.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnPrintLabelNo.Size = new System.Drawing.Size(53, 20);
            this.spnPrintLabelNo.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Print Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboLabelPrinter
            // 
            this.cboLabelPrinter.Location = new System.Drawing.Point(120, 19);
            this.cboLabelPrinter.Name = "cboLabelPrinter";
            this.cboLabelPrinter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.cboLabelPrinter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboLabelPrinter.Size = new System.Drawing.Size(286, 20);
            this.cboLabelPrinter.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Label Printer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pagPatientInformation
            // 
            this.pagPatientInformation.Controls.Add(this.chkIsUsingCompactInfo);
            this.pagPatientInformation.Controls.Add(this.chkWardIsMandatory);
            this.pagPatientInformation.Controls.Add(this.chkPhysicianIsMandatory);
            this.pagPatientInformation.Controls.Add(this.txtRegistrationNo);
            this.pagPatientInformation.Controls.Add(this.label2);
            this.pagPatientInformation.Controls.Add(this.txtCustomAttribute5);
            this.pagPatientInformation.Controls.Add(this.lblCustomAttribute5);
            this.pagPatientInformation.Controls.Add(this.txtCustomAttribute4);
            this.pagPatientInformation.Controls.Add(this.lblCustomAttribute4);
            this.pagPatientInformation.Controls.Add(this.txtCustomAttribute3);
            this.pagPatientInformation.Controls.Add(this.lblCustomAttribute3);
            this.pagPatientInformation.Controls.Add(this.txtCustomAttribute2);
            this.pagPatientInformation.Controls.Add(this.lblCustomAttribute2);
            this.pagPatientInformation.Controls.Add(this.txtCustomAttribute1);
            this.pagPatientInformation.Controls.Add(this.lblCustomAttribute1);
            this.pagPatientInformation.Name = "pagPatientInformation";
            this.pagPatientInformation.PageVisible = false;
            this.pagPatientInformation.Size = new System.Drawing.Size(444, 310);
            this.pagPatientInformation.Text = "Informasi Pasien";
            // 
            // chkIsUsingCompactInfo
            // 
            this.chkIsUsingCompactInfo.Location = new System.Drawing.Point(0, 0);
            this.chkIsUsingCompactInfo.Name = "chkIsUsingCompactInfo";
            this.chkIsUsingCompactInfo.Size = new System.Drawing.Size(104, 24);
            this.chkIsUsingCompactInfo.TabIndex = 0;
            // 
            // chkWardIsMandatory
            // 
            this.chkWardIsMandatory.AutoSize = true;
            this.chkWardIsMandatory.Location = new System.Drawing.Point(145, 189);
            this.chkWardIsMandatory.Name = "chkWardIsMandatory";
            this.chkWardIsMandatory.Size = new System.Drawing.Size(239, 17);
            this.chkWardIsMandatory.TabIndex = 25;
            this.chkWardIsMandatory.Text = "Cetak Nama Ruang dan Tempat Tidur Pasien";
            this.chkWardIsMandatory.UseVisualStyleBackColor = true;
            // 
            // chkPhysicianIsMandatory
            // 
            this.chkPhysicianIsMandatory.AutoSize = true;
            this.chkPhysicianIsMandatory.Location = new System.Drawing.Point(145, 172);
            this.chkPhysicianIsMandatory.Name = "chkPhysicianIsMandatory";
            this.chkPhysicianIsMandatory.Size = new System.Drawing.Size(191, 17);
            this.chkPhysicianIsMandatory.TabIndex = 24;
            this.chkPhysicianIsMandatory.Text = "Cetak Nama Dokter yang merawat";
            this.chkPhysicianIsMandatory.UseVisualStyleBackColor = true;
            // 
            // txtRegistrationNo
            // 
            this.txtRegistrationNo.EditValue = "";
            this.txtRegistrationNo.Location = new System.Drawing.Point(145, 18);
            this.txtRegistrationNo.Name = "txtRegistrationNo";
            this.txtRegistrationNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRegistrationNo.Properties.NullText = "i.e. 00-00-00-01";
            this.txtRegistrationNo.Size = new System.Drawing.Size(208, 20);
            this.txtRegistrationNo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Template No. Pendaftaran";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomAttribute5
            // 
            this.txtCustomAttribute5.EditValue = "";
            this.txtCustomAttribute5.Location = new System.Drawing.Point(145, 124);
            this.txtCustomAttribute5.Name = "txtCustomAttribute5";
            this.txtCustomAttribute5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCustomAttribute5.Properties.NullText = "i.e. 00-00-00-01";
            this.txtCustomAttribute5.Size = new System.Drawing.Size(208, 20);
            this.txtCustomAttribute5.TabIndex = 21;
            // 
            // lblCustomAttribute5
            // 
            this.lblCustomAttribute5.AutoSize = true;
            this.lblCustomAttribute5.Location = new System.Drawing.Point(10, 128);
            this.lblCustomAttribute5.Name = "lblCustomAttribute5";
            this.lblCustomAttribute5.Size = new System.Drawing.Size(122, 13);
            this.lblCustomAttribute5.TabIndex = 20;
            this.lblCustomAttribute5.Text = "Informasi Tambahan #5";
            this.lblCustomAttribute5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomAttribute4
            // 
            this.txtCustomAttribute4.EditValue = "";
            this.txtCustomAttribute4.Location = new System.Drawing.Point(145, 103);
            this.txtCustomAttribute4.Name = "txtCustomAttribute4";
            this.txtCustomAttribute4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCustomAttribute4.Properties.NullText = "i.e. 00-00-00-01";
            this.txtCustomAttribute4.Size = new System.Drawing.Size(208, 20);
            this.txtCustomAttribute4.TabIndex = 19;
            // 
            // lblCustomAttribute4
            // 
            this.lblCustomAttribute4.AutoSize = true;
            this.lblCustomAttribute4.Location = new System.Drawing.Point(10, 107);
            this.lblCustomAttribute4.Name = "lblCustomAttribute4";
            this.lblCustomAttribute4.Size = new System.Drawing.Size(122, 13);
            this.lblCustomAttribute4.TabIndex = 18;
            this.lblCustomAttribute4.Text = "Informasi Tambahan #4";
            this.lblCustomAttribute4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomAttribute3
            // 
            this.txtCustomAttribute3.EditValue = "";
            this.txtCustomAttribute3.Location = new System.Drawing.Point(145, 82);
            this.txtCustomAttribute3.Name = "txtCustomAttribute3";
            this.txtCustomAttribute3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCustomAttribute3.Properties.NullText = "i.e. 00-00-00-01";
            this.txtCustomAttribute3.Size = new System.Drawing.Size(208, 20);
            this.txtCustomAttribute3.TabIndex = 17;
            // 
            // lblCustomAttribute3
            // 
            this.lblCustomAttribute3.AutoSize = true;
            this.lblCustomAttribute3.Location = new System.Drawing.Point(10, 86);
            this.lblCustomAttribute3.Name = "lblCustomAttribute3";
            this.lblCustomAttribute3.Size = new System.Drawing.Size(122, 13);
            this.lblCustomAttribute3.TabIndex = 16;
            this.lblCustomAttribute3.Text = "Informasi Tambahan #3";
            this.lblCustomAttribute3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomAttribute2
            // 
            this.txtCustomAttribute2.EditValue = "";
            this.txtCustomAttribute2.Location = new System.Drawing.Point(145, 61);
            this.txtCustomAttribute2.Name = "txtCustomAttribute2";
            this.txtCustomAttribute2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCustomAttribute2.Properties.NullText = "i.e. 00-00-00-01";
            this.txtCustomAttribute2.Size = new System.Drawing.Size(208, 20);
            this.txtCustomAttribute2.TabIndex = 15;
            // 
            // lblCustomAttribute2
            // 
            this.lblCustomAttribute2.AutoSize = true;
            this.lblCustomAttribute2.Location = new System.Drawing.Point(10, 65);
            this.lblCustomAttribute2.Name = "lblCustomAttribute2";
            this.lblCustomAttribute2.Size = new System.Drawing.Size(122, 13);
            this.lblCustomAttribute2.TabIndex = 14;
            this.lblCustomAttribute2.Text = "Informasi Tambahan #2";
            this.lblCustomAttribute2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomAttribute1
            // 
            this.txtCustomAttribute1.EditValue = "";
            this.txtCustomAttribute1.Location = new System.Drawing.Point(145, 40);
            this.txtCustomAttribute1.Name = "txtCustomAttribute1";
            this.txtCustomAttribute1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCustomAttribute1.Properties.NullText = "i.e. 00-00-00-01";
            this.txtCustomAttribute1.Size = new System.Drawing.Size(208, 20);
            this.txtCustomAttribute1.TabIndex = 13;
            // 
            // lblCustomAttribute1
            // 
            this.lblCustomAttribute1.AutoSize = true;
            this.lblCustomAttribute1.Location = new System.Drawing.Point(10, 44);
            this.lblCustomAttribute1.Name = "lblCustomAttribute1";
            this.lblCustomAttribute1.Size = new System.Drawing.Size(122, 13);
            this.lblCustomAttribute1.TabIndex = 12;
            this.lblCustomAttribute1.Text = "Informasi Tambahan #1";
            this.lblCustomAttribute1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 47);
            this.panel2.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(285, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 22;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(366, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 336);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabConfiguration)).EndInit();
            this.tabConfiguration.ResumeLayout(false);
            this.pagDataConfig.ResumeLayout(false);
            this.pagDataConfig.PerformLayout();
            this.panConnectionString.ResumeLayout(false);
            this.panConnectionString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemoteDataPath.Properties)).EndInit();
            this.pagPivotViewer.ResumeLayout(false);
            this.pagPivotViewer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboWristbandType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBarcodeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBarcodeValue.Properties)).EndInit();
            this.pagLabelPrinter.ResumeLayout(false);
            this.pagLabelPrinter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrintLabelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboLabelPrinter.Properties)).EndInit();
            this.pagPatientInformation.ResumeLayout(false);
            this.pagPatientInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRegistrationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomAttribute1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraTab.XtraTabControl tabConfiguration;
        private DevExpress.XtraTab.XtraTabPage pagPivotViewer;
        private DevExpress.XtraTab.XtraTabPage pagPatientInformation;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit txtCustomAttribute5;
        private System.Windows.Forms.Label lblCustomAttribute5;
        private DevExpress.XtraEditors.TextEdit txtCustomAttribute4;
        private System.Windows.Forms.Label lblCustomAttribute4;
        private DevExpress.XtraEditors.TextEdit txtCustomAttribute3;
        private System.Windows.Forms.Label lblCustomAttribute3;
        private DevExpress.XtraEditors.TextEdit txtCustomAttribute2;
        private System.Windows.Forms.Label lblCustomAttribute2;
        private DevExpress.XtraEditors.TextEdit txtCustomAttribute1;
        private System.Windows.Forms.Label lblCustomAttribute1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit cboBarcodeType;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cboBarcodeValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraTab.XtraTabPage pagLabelPrinter;
        private DevExpress.XtraEditors.TextEdit txtRegistrationNo;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cboLabelPrinter;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit spnPrintLabelNo;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit cboWristbandType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkWardIsMandatory;
        private System.Windows.Forms.CheckBox chkPhysicianIsMandatory;
        private System.Windows.Forms.CheckBox chkIsAutoLoadViewer;
        private System.Windows.Forms.CheckBox chkIsUsingCompactInfo;
        private DevExpress.XtraTab.XtraTabPage pagDataConfig;
        private System.Windows.Forms.Label label14;
        private DevExpress.XtraEditors.SimpleButton btnBrowse;
        private DevExpress.XtraEditors.TextEdit txtRemoteDataPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Panel panConnectionString;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}