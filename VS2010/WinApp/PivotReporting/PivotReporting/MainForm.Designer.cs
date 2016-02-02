namespace PivotReporting
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panContent = new System.Windows.Forms.Panel();
            this.lblBlankControl = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.btnSaveAsNew = new System.Windows.Forms.Button();
            this.cboTemplateGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCacheData = new System.Windows.Forms.CheckBox();
            this.chkAutoLoad = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.imlButton = new System.Windows.Forms.ImageList(this.components);
            this.cboTemplate = new System.Windows.Forms.ComboBox();
            this.btnLoadTemplate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPeriodType = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dteToDate = new System.Windows.Forms.DateTimePicker();
            this.dteFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveLayout = new System.Windows.Forms.Button();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.printExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stbStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbServerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbDatabaseName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRowCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbMain = new System.Windows.Forms.ToolStrip();
            this.tbSaveAsNew = new System.Windows.Forms.ToolStripButton();
            this.tbRefreshData = new System.Windows.Forms.ToolStripButton();
            this.odsPivot = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panContent.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.mnMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odsPivot)).BeginInit();
            this.SuspendLayout();
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.lblBlankControl);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 134);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(738, 276);
            this.panContent.TabIndex = 2;
            // 
            // lblBlankControl
            // 
            this.lblBlankControl.BackColor = System.Drawing.Color.White;
            this.lblBlankControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBlankControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlankControl.Location = new System.Drawing.Point(0, 0);
            this.lblBlankControl.Name = "lblBlankControl";
            this.lblBlankControl.Size = new System.Drawing.Size(738, 276);
            this.lblBlankControl.TabIndex = 0;
            this.lblBlankControl.Text = "Please Select and Load Template";
            this.lblBlankControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.SystemColors.Control;
            this.panHeader.Controls.Add(this.button1);
            this.panHeader.Controls.Add(this.btnSaveAsNew);
            this.panHeader.Controls.Add(this.cboTemplateGroup);
            this.panHeader.Controls.Add(this.label4);
            this.panHeader.Controls.Add(this.chkCacheData);
            this.panHeader.Controls.Add(this.chkAutoLoad);
            this.panHeader.Controls.Add(this.btnExport);
            this.panHeader.Controls.Add(this.cboTemplate);
            this.panHeader.Controls.Add(this.btnLoadTemplate);
            this.panHeader.Controls.Add(this.label3);
            this.panHeader.Controls.Add(this.cboPeriodType);
            this.panHeader.Controls.Add(this.btnRefresh);
            this.panHeader.Controls.Add(this.label2);
            this.panHeader.Controls.Add(this.dteToDate);
            this.panHeader.Controls.Add(this.dteFromDate);
            this.panHeader.Controls.Add(this.label1);
            this.panHeader.Controls.Add(this.btnSaveLayout);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panHeader.Location = new System.Drawing.Point(0, 24);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(738, 110);
            this.panHeader.TabIndex = 4;
            // 
            // btnSaveAsNew
            // 
            this.btnSaveAsNew.Enabled = false;
            this.btnSaveAsNew.Location = new System.Drawing.Point(284, 77);
            this.btnSaveAsNew.Name = "btnSaveAsNew";
            this.btnSaveAsNew.Size = new System.Drawing.Size(93, 26);
            this.btnSaveAsNew.TabIndex = 16;
            this.btnSaveAsNew.Text = "Save As New";
            this.btnSaveAsNew.UseVisualStyleBackColor = true;
            // 
            // cboTemplateGroup
            // 
            this.cboTemplateGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemplateGroup.FormattingEnabled = true;
            this.cboTemplateGroup.Location = new System.Drawing.Point(101, 31);
            this.cboTemplateGroup.Name = "cboTemplateGroup";
            this.cboTemplateGroup.Size = new System.Drawing.Size(397, 21);
            this.cboTemplateGroup.TabIndex = 15;
            this.cboTemplateGroup.SelectedIndexChanged += new System.EventHandler(this.cboTemplateGroup_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Template Group";
            // 
            // chkCacheData
            // 
            this.chkCacheData.AutoSize = true;
            this.chkCacheData.Checked = true;
            this.chkCacheData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCacheData.Location = new System.Drawing.Point(623, 82);
            this.chkCacheData.Name = "chkCacheData";
            this.chkCacheData.Size = new System.Drawing.Size(109, 17);
            this.chkCacheData.TabIndex = 13;
            this.chkCacheData.Text = "Local Data Cache";
            this.chkCacheData.UseVisualStyleBackColor = true;
            this.chkCacheData.Visible = false;
            // 
            // chkAutoLoad
            // 
            this.chkAutoLoad.AutoSize = true;
            this.chkAutoLoad.Checked = true;
            this.chkAutoLoad.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoLoad.Location = new System.Drawing.Point(379, 82);
            this.chkAutoLoad.Name = "chkAutoLoad";
            this.chkAutoLoad.Size = new System.Drawing.Size(163, 17);
            this.chkAutoLoad.TabIndex = 12;
            this.chkAutoLoad.Text = "Automatically Load Template";
            this.chkAutoLoad.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.ImageList = this.imlButton;
            this.btnExport.Location = new System.Drawing.Point(520, 8);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(71, 69);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // imlButton
            // 
            this.imlButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlButton.ImageStream")));
            this.imlButton.TransparentColor = System.Drawing.Color.Transparent;
            this.imlButton.Images.SetKeyName(0, "refresh.png");
            // 
            // cboTemplate
            // 
            this.cboTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTemplate.FormattingEnabled = true;
            this.cboTemplate.Location = new System.Drawing.Point(101, 53);
            this.cboTemplate.Name = "cboTemplate";
            this.cboTemplate.Size = new System.Drawing.Size(397, 21);
            this.cboTemplate.TabIndex = 9;
            this.cboTemplate.SelectedIndexChanged += new System.EventHandler(this.cboTemplate_SelectedIndexChanged);
            // 
            // btnLoadTemplate
            // 
            this.btnLoadTemplate.Location = new System.Drawing.Point(100, 77);
            this.btnLoadTemplate.Name = "btnLoadTemplate";
            this.btnLoadTemplate.Size = new System.Drawing.Size(93, 26);
            this.btnLoadTemplate.TabIndex = 8;
            this.btnLoadTemplate.Text = "Load Template";
            this.btnLoadTemplate.UseVisualStyleBackColor = true;
            this.btnLoadTemplate.Click += new System.EventHandler(this.btnLoadTemplate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Template";
            // 
            // cboPeriodType
            // 
            this.cboPeriodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodType.Enabled = false;
            this.cboPeriodType.FormattingEnabled = true;
            this.cboPeriodType.Items.AddRange(new object[] {
            "Custom Period"});
            this.cboPeriodType.Location = new System.Drawing.Point(101, 9);
            this.cboPeriodType.Name = "cboPeriodType";
            this.cboPeriodType.Size = new System.Drawing.Size(164, 21);
            this.cboPeriodType.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRefresh.ImageIndex = 0;
            this.btnRefresh.ImageList = this.imlButton;
            this.btnRefresh.Location = new System.Drawing.Point(661, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(71, 69);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Pull Data";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "s/d";
            // 
            // dteToDate
            // 
            this.dteToDate.CustomFormat = "dd-MMM-yyyy";
            this.dteToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteToDate.Location = new System.Drawing.Point(398, 9);
            this.dteToDate.Name = "dteToDate";
            this.dteToDate.Size = new System.Drawing.Size(100, 21);
            this.dteToDate.TabIndex = 2;
            // 
            // dteFromDate
            // 
            this.dteFromDate.CustomFormat = "dd-MMM-yyyy";
            this.dteFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dteFromDate.Location = new System.Drawing.Point(271, 9);
            this.dteFromDate.Name = "dteFromDate";
            this.dteFromDate.Size = new System.Drawing.Size(100, 21);
            this.dteFromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Period";
            // 
            // btnSaveLayout
            // 
            this.btnSaveLayout.Enabled = false;
            this.btnSaveLayout.Location = new System.Drawing.Point(192, 77);
            this.btnSaveLayout.Name = "btnSaveLayout";
            this.btnSaveLayout.Size = new System.Drawing.Size(93, 26);
            this.btnSaveLayout.TabIndex = 10;
            this.btnSaveLayout.Text = "Save Template";
            this.btnSaveLayout.UseVisualStyleBackColor = true;
            this.btnSaveLayout.Click += new System.EventHandler(this.btnSaveLayout_Click);
            // 
            // mnMain
            // 
            this.mnMain.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printExportToolStripMenuItem});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(738, 24);
            this.mnMain.TabIndex = 5;
            this.mnMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfiguration,
            this.mnuExit});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuConfiguration
            // 
            this.mnuConfiguration.Name = "mnuConfiguration";
            this.mnuConfiguration.Size = new System.Drawing.Size(146, 22);
            this.mnuConfiguration.Text = "Configuration";
            this.mnuConfiguration.Click += new System.EventHandler(this.mnuConfiguration_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(146, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // printExportToolStripMenuItem
            // 
            this.printExportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExportToExcel});
            this.printExportToolStripMenuItem.Name = "printExportToolStripMenuItem";
            this.printExportToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.printExportToolStripMenuItem.Text = "Print and Export";
            // 
            // mnuExportToExcel
            // 
            this.mnuExportToExcel.Name = "mnuExportToExcel";
            this.mnuExportToExcel.Size = new System.Drawing.Size(158, 22);
            this.mnuExportToExcel.Text = "Export to Excel";
            this.mnuExportToExcel.Click += new System.EventHandler(this.mnuExportToExcel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbStatusText,
            this.stbServerName,
            this.stbDatabaseName,
            this.lblRowCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(738, 23);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stbStatusText
            // 
            this.stbStatusText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.stbStatusText.Name = "stbStatusText";
            this.stbStatusText.Size = new System.Drawing.Size(471, 18);
            this.stbStatusText.Spring = true;
            // 
            // stbServerName
            // 
            this.stbServerName.Name = "stbServerName";
            this.stbServerName.Size = new System.Drawing.Size(87, 18);
            this.stbServerName.Text = "[Server Name]";
            this.stbServerName.ToolTipText = "Connected To";
            // 
            // stbDatabaseName
            // 
            this.stbDatabaseName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.stbDatabaseName.Name = "stbDatabaseName";
            this.stbDatabaseName.Size = new System.Drawing.Size(106, 18);
            this.stbDatabaseName.Text = "[Database Name]";
            // 
            // lblRowCountLabel
            // 
            this.lblRowCountLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowCountLabel.ForeColor = System.Drawing.Color.Blue;
            this.lblRowCountLabel.Name = "lblRowCountLabel";
            this.lblRowCountLabel.Size = new System.Drawing.Size(59, 18);
            this.lblRowCountLabel.Text = "Connected";
            // 
            // tbMain
            // 
            this.tbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbSaveAsNew,
            this.tbRefreshData});
            this.tbMain.Location = new System.Drawing.Point(0, 24);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(738, 25);
            this.tbMain.TabIndex = 7;
            this.tbMain.Text = "toolStrip1";
            this.tbMain.Visible = false;
            // 
            // tbSaveAsNew
            // 
            this.tbSaveAsNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSaveAsNew.Image = ((System.Drawing.Image)(resources.GetObject("tbSaveAsNew.Image")));
            this.tbSaveAsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSaveAsNew.Name = "tbSaveAsNew";
            this.tbSaveAsNew.Size = new System.Drawing.Size(23, 22);
            this.tbSaveAsNew.Text = "Save As New Template";
            // 
            // tbRefreshData
            // 
            this.tbRefreshData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbRefreshData.Image = ((System.Drawing.Image)(resources.GetObject("tbRefreshData.Image")));
            this.tbRefreshData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbRefreshData.Name = "tbRefreshData";
            this.tbRefreshData.Size = new System.Drawing.Size(23, 22);
            this.tbRefreshData.Text = "Refresh Data";
            this.tbRefreshData.Click += new System.EventHandler(this.tbRefreshData_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imlButton;
            this.button1.Location = new System.Drawing.Point(590, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 69);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cache Data";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 433);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.mnMain);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnMain;
            this.Name = "MainForm";
            this.Text = "MEDINFRAS - Pivot Reporting Tool (BETA VERSION)";
            this.panContent.ResumeLayout(false);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tbMain.ResumeLayout(false);
            this.tbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odsPivot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.BindingSource odsPivot;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dteToDate;
        private System.Windows.Forms.DateTimePicker dteFromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPeriodType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadTemplate;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuConfiguration;
        private System.Windows.Forms.ComboBox cboTemplate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblRowCountLabel;
        private System.Windows.Forms.Label lblBlankControl;
        private System.Windows.Forms.ToolStripMenuItem printExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExportToExcel;
        private System.Windows.Forms.Button btnSaveLayout;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkAutoLoad;
        private System.Windows.Forms.CheckBox chkCacheData;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ImageList imlButton;
        private System.Windows.Forms.ComboBox cboTemplateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip tbMain;
        private System.Windows.Forms.ToolStripButton tbSaveAsNew;
        private System.Windows.Forms.ToolStripButton tbRefreshData;
        private System.Windows.Forms.ToolStripStatusLabel stbServerName;
        private System.Windows.Forms.ToolStripStatusLabel stbDatabaseName;
        private System.Windows.Forms.ToolStripStatusLabel stbStatusText;
        private System.Windows.Forms.Button btnSaveAsNew;
        private System.Windows.Forms.Button button1;

    }
}

