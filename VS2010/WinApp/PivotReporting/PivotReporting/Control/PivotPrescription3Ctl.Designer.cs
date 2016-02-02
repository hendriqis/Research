namespace PivotReporting.Control
{
    partial class PivotPrescription3Ctl
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
            this.colFromServiceUnitName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colParamedicName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colChargeClassName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPatientName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateQuarter = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPayerType = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPayerName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPrescriptionNo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colItemName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colQuantity = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colLineAmount = new DevExpress.XtraPivotGrid.PivotGridField();
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
            this.colFromServiceUnitName,
            this.colParamedicName,
            this.colChargeClassName,
            this.colPatientName,
            this.colDateYear,
            this.colDateMonth,
            this.colDateQuarter,
            this.colPayerType,
            this.colPayerName,
            this.colPrescriptionNo,
            this.colItemName,
            this.colQuantity,
            this.colLineAmount});
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
            this.colDepartment.Visible = false;
            this.colDepartment.Width = 150;
            // 
            // colShift
            // 
            this.colShift.AreaIndex = 0;
            this.colShift.Caption = "Shift";
            this.colShift.Name = "colShift";
            this.colShift.Visible = false;
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AreaIndex = 0;
            this.colRegistrationDate.Caption = "Tanggal";
            this.colRegistrationDate.FieldName = "RegistrationDate";
            this.colRegistrationDate.Name = "colRegistrationDate";
            // 
            // colFromServiceUnitName
            // 
            this.colFromServiceUnitName.Appearance.Cell.Options.UseTextOptions = true;
            this.colFromServiceUnitName.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colFromServiceUnitName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colFromServiceUnitName.AreaIndex = 0;
            this.colFromServiceUnitName.Caption = "Asal Unit Pasien";
            this.colFromServiceUnitName.FieldName = "FromServiceUnitName";
            this.colFromServiceUnitName.Name = "colFromServiceUnitName";
            this.colFromServiceUnitName.Visible = false;
            this.colFromServiceUnitName.Width = 200;
            // 
            // colParamedicName
            // 
            this.colParamedicName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colParamedicName.AreaIndex = 0;
            this.colParamedicName.Caption = "Dokter/Tenaga Medis";
            this.colParamedicName.FieldName = "ParamedicName";
            this.colParamedicName.Name = "colParamedicName";
            this.colParamedicName.Width = 200;
            // 
            // colChargeClassName
            // 
            this.colChargeClassName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colChargeClassName.AreaIndex = 1;
            this.colChargeClassName.Caption = "Kelas";
            this.colChargeClassName.FieldName = "ChargeClassName";
            this.colChargeClassName.Name = "colChargeClassName";
            // 
            // colPatientName
            // 
            this.colPatientName.AreaIndex = 1;
            this.colPatientName.Caption = "Pasien";
            this.colPatientName.FieldName = "PatientName";
            this.colPatientName.Name = "colPatientName";
            this.colPatientName.Width = 200;
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
            // 
            // colDateQuarter
            // 
            this.colDateQuarter.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea;
            this.colDateQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateQuarter.AreaIndex = 2;
            this.colDateQuarter.Caption = "Quarter";
            this.colDateQuarter.FieldName = "RegistrationDate";
            this.colDateQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter;
            this.colDateQuarter.Name = "colDateQuarter";
            this.colDateQuarter.UnboundFieldName = "colDateQuarter";
            this.colDateQuarter.Visible = false;
            // 
            // colPayerType
            // 
            this.colPayerType.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colPayerType.AreaIndex = 3;
            this.colPayerType.Caption = "Tipe Penjamin";
            this.colPayerType.FieldName = "PayerType";
            this.colPayerType.Name = "colPayerType";
            this.colPayerType.Visible = false;
            // 
            // colPayerName
            // 
            this.colPayerName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colPayerName.AreaIndex = 3;
            this.colPayerName.Caption = "Penjamin";
            this.colPayerName.FieldName = "PayerName";
            this.colPayerName.Name = "colPayerName";
            this.colPayerName.Visible = false;
            // 
            // colPrescriptionNo
            // 
            this.colPrescriptionNo.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.colPrescriptionNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colPrescriptionNo.AreaIndex = 3;
            this.colPrescriptionNo.Caption = "Nomor Resep";
            this.colPrescriptionNo.FieldName = "PrescriptionNo";
            this.colPrescriptionNo.Name = "colPrescriptionNo";
            this.colPrescriptionNo.Visible = false;
            this.colPrescriptionNo.Width = 110;
            // 
            // colItemName
            // 
            this.colItemName.Appearance.Cell.Options.UseTextOptions = true;
            this.colItemName.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colItemName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colItemName.AreaIndex = 2;
            this.colItemName.Caption = "Obat";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 200;
            // 
            // colQuantity
            // 
            this.colQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colQuantity.Appearance.Cell.Options.UseTextOptions = true;
            this.colQuantity.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colQuantity.AreaIndex = 0;
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 80;
            // 
            // colLineAmount
            // 
            this.colLineAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colLineAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colLineAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colLineAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colLineAmount.AreaIndex = 1;
            this.colLineAmount.Caption = "Jumlah";
            this.colLineAmount.CellFormat.FormatString = "n2";
            this.colLineAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLineAmount.FieldName = "LineAmount";
            this.colLineAmount.Name = "colLineAmount";
            // 
            // PivotPrescription3Ctl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pvGrid);
            this.Name = "PivotPrescription3Ctl";
            this.Size = new System.Drawing.Size(649, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pvGrid;
        private DevExpress.XtraPivotGrid.PivotGridField colDepartment;
        private DevExpress.XtraPivotGrid.PivotGridField colShift;
        private DevExpress.XtraPivotGrid.PivotGridField colRegistrationDate;
        private DevExpress.XtraPivotGrid.PivotGridField colFromServiceUnitName;
        private DevExpress.XtraPivotGrid.PivotGridField colParamedicName;
        private DevExpress.XtraPivotGrid.PivotGridField colDateYear;
        private DevExpress.XtraPivotGrid.PivotGridField colDateMonth;
        private DevExpress.XtraPivotGrid.PivotGridField colDateQuarter;
        private DevExpress.XtraPivotGrid.PivotGridField colPayerType;
        private DevExpress.XtraPivotGrid.PivotGridField colPayerName;
        private DevExpress.XtraPivotGrid.PivotGridField colItemName;
        private DevExpress.XtraPivotGrid.PivotGridField colQuantity;
        private DevExpress.XtraPivotGrid.PivotGridField colLineAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colChargeClassName;
        private DevExpress.XtraPivotGrid.PivotGridField colPatientName;
        private DevExpress.XtraPivotGrid.PivotGridField colPrescriptionNo;
    }
}
