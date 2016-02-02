namespace PivotReporting.Control
{
    partial class PivotRegistrationCtl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pvGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colDepartment = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colShift = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colRegistrationDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTotalPatient = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colServiceUnitName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colParamedicName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colIsNewPatient = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colIsOldPatient = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPayerType = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPayerName = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pvGrid
            // 
            this.pvGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pvGrid.Appearance.FieldValue.Options.UseTextOptions = true;
            this.pvGrid.Appearance.FieldValue.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.pvGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colDepartment,
            this.colShift,
            this.colRegistrationDate,
            this.colTotalPatient,
            this.colServiceUnitName,
            this.colParamedicName,
            this.colDateYear,
            this.colDateMonth,
            this.colDateQuarter,
            this.colIsNewPatient,
            this.colIsOldPatient,
            this.colPayerType,
            this.colPayerName});
            this.pvGrid.Location = new System.Drawing.Point(0, 0);
            this.pvGrid.Name = "pvGrid";
            this.pvGrid.Size = new System.Drawing.Size(649, 400);
            this.pvGrid.TabIndex = 3;
            // 
            // colDepartment
            // 
            this.colDepartment.AreaIndex = 0;
            this.colDepartment.Caption = "Departemen";
            this.colDepartment.FieldName = "DepartmentName";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Width = 150;
            // 
            // colShift
            // 
            this.colShift.AreaIndex = 1;
            this.colShift.Caption = "Shift";
            this.colShift.Name = "colShift";
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AreaIndex = 2;
            this.colRegistrationDate.Caption = "Tanggal";
            this.colRegistrationDate.FieldName = "RegistrationDate";
            this.colRegistrationDate.Name = "colRegistrationDate";
            // 
            // colTotalPatient
            // 
            this.colTotalPatient.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTotalPatient.AreaIndex = 2;
            this.colTotalPatient.Caption = "Total Pasien";
            this.colTotalPatient.FieldName = "RegistrationNo";
            this.colTotalPatient.Name = "colTotalPatient";
            this.colTotalPatient.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            this.colTotalPatient.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPatient.Width = 80;
            // 
            // colServiceUnitName
            // 
            this.colServiceUnitName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colServiceUnitName.AreaIndex = 0;
            this.colServiceUnitName.Caption = "Unit Pelayanan";
            this.colServiceUnitName.FieldName = "ServiceUnitName";
            this.colServiceUnitName.Name = "colServiceUnitName";
            this.colServiceUnitName.Width = 200;
            // 
            // colParamedicName
            // 
            this.colParamedicName.AreaIndex = 3;
            this.colParamedicName.Caption = "Dokter/Tenaga Medis";
            this.colParamedicName.FieldName = "ParamedicName";
            this.colParamedicName.Name = "colParamedicName";
            this.colParamedicName.Width = 200;
            // 
            // colDateYear
            // 
            this.colDateYear.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.colDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateYear.AreaIndex = 0;
            this.colDateYear.Caption = "Tahun";
            this.colDateYear.FieldName = "RegistrationDate";
            this.colDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.colDateYear.Name = "colDateYear";
            this.colDateYear.UnboundFieldName = "colDateYear";
            // 
            // colDateMonth
            // 
            this.colDateMonth.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.colDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateMonth.AreaIndex = 1;
            this.colDateMonth.Caption = "Bulan";
            this.colDateMonth.FieldName = "RegistrationDate";
            this.colDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.colDateMonth.Name = "colDateMonth";
            this.colDateMonth.UnboundFieldName = "colDateMonth";
            this.colDateMonth.Visible = false;
            // 
            // colDateQuarter
            // 
            this.colDateQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.colDateQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateQuarter.AreaIndex = 1;
            this.colDateQuarter.Caption = "Quarter";
            this.colDateQuarter.FieldName = "RegistrationDate";
            this.colDateQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.colDateQuarter.Name = "colDateQuarter";
            this.colDateQuarter.UnboundFieldName = "colDateQuarter";
            // 
            // colIsNewPatient
            // 
            this.colIsNewPatient.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colIsNewPatient.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colIsNewPatient.AreaIndex = 0;
            this.colIsNewPatient.Caption = "Pasien Baru";
            this.colIsNewPatient.FieldName = "IsNewPatient";
            this.colIsNewPatient.Name = "colIsNewPatient";
            this.colIsNewPatient.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            this.colIsNewPatient.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIsNewPatient.Width = 80;
            // 
            // colIsOldPatient
            // 
            this.colIsOldPatient.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colIsOldPatient.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colIsOldPatient.AreaIndex = 1;
            this.colIsOldPatient.Caption = "Pasien Lama";
            this.colIsOldPatient.FieldName = "IsOldPatient";
            this.colIsOldPatient.Name = "colIsOldPatient";
            this.colIsOldPatient.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            this.colIsOldPatient.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIsOldPatient.Width = 80;
            // 
            // colPayerType
            // 
            this.colPayerType.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colPayerType.AreaIndex = 4;
            this.colPayerType.Caption = "Tipe Penjamin";
            this.colPayerType.FieldName = "PayerType";
            this.colPayerType.Name = "colPayerType";
            // 
            // colPayerName
            // 
            this.colPayerName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colPayerName.AreaIndex = 5;
            this.colPayerName.Caption = "Penjamin";
            this.colPayerName.FieldName = "PayerName";
            this.colPayerName.Name = "colPayerName";
            // 
            // PivotRegistrationCtl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pvGrid);
            this.Name = "PivotRegistrationCtl";
            this.Size = new System.Drawing.Size(649, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pvGrid;
        private DevExpress.XtraPivotGrid.PivotGridField colDepartment;
        private DevExpress.XtraPivotGrid.PivotGridField colShift;
        private DevExpress.XtraPivotGrid.PivotGridField colRegistrationDate;
        private DevExpress.XtraPivotGrid.PivotGridField colTotalPatient;
        private DevExpress.XtraPivotGrid.PivotGridField colServiceUnitName;
        private DevExpress.XtraPivotGrid.PivotGridField colParamedicName;
        private DevExpress.XtraPivotGrid.PivotGridField colIsNewPatient;
        private DevExpress.XtraPivotGrid.PivotGridField colIsOldPatient;
        private DevExpress.XtraPivotGrid.PivotGridField colDateYear;
        private DevExpress.XtraPivotGrid.PivotGridField colDateMonth;
        private DevExpress.XtraPivotGrid.PivotGridField colDateQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField colPayerType;
        private DevExpress.XtraPivotGrid.PivotGridField colPayerName;
    }
}
