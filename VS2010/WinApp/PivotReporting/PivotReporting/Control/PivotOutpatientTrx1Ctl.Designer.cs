namespace PivotReporting.Control
{
    partial class PivotOutpatientTrx1Ctl
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
            this.colShift = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colRegistrationDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTotalPatient = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colServiceUnitName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colParamedicName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colIsNewPatient = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colIsOldPatient = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTariffComp1 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colItemGroupName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colItemName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTransactionType = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTariffComp2 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTariffComp3 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTariffComp4 = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTransactionAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDiscount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colMRN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colBusinessPartnerName = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pvGrid
            // 
            this.pvGrid.Appearance.FieldValueTotal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pvGrid.Appearance.FieldValueTotal.Options.UseFont = true;
            this.pvGrid.Appearance.GrandTotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pvGrid.Appearance.GrandTotalCell.Options.UseFont = true;
            this.pvGrid.Appearance.TotalCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.pvGrid.Appearance.TotalCell.Options.UseFont = true;
            this.pvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pvGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.colShift,
            this.colRegistrationDate,
            this.colTotalPatient,
            this.colServiceUnitName,
            this.colParamedicName,
            this.colIsNewPatient,
            this.colIsOldPatient,
            this.colTariffComp1,
            this.colItemGroupName,
            this.colItemName,
            this.colTransactionType,
            this.colTariffComp2,
            this.colTariffComp3,
            this.colTariffComp4,
            this.colTransactionAmount,
            this.colDiscount,
            this.colMRN,
            this.colBusinessPartnerName});
            this.pvGrid.Location = new System.Drawing.Point(0, 0);
            this.pvGrid.Name = "pvGrid";
            this.pvGrid.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pvGrid.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pvGrid.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pvGrid.OptionsPrint.PrintUnusedFilterFields = false;
            this.pvGrid.Size = new System.Drawing.Size(649, 400);
            this.pvGrid.TabIndex = 5;
            // 
            // colShift
            // 
            this.colShift.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colShift.AreaIndex = 0;
            this.colShift.Caption = "Shift";
            this.colShift.FieldName = "Shift";
            this.colShift.Name = "colShift";
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AreaIndex = 1;
            this.colRegistrationDate.Caption = "Tanggal";
            this.colRegistrationDate.FieldName = "RegistrationDate";
            this.colRegistrationDate.Name = "colRegistrationDate";
            // 
            // colTotalPatient
            // 
            this.colTotalPatient.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTotalPatient.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTotalPatient.AreaIndex = 2;
            this.colTotalPatient.Caption = "Total Pasien";
            this.colTotalPatient.FieldName = "RegistrationNo";
            this.colTotalPatient.Name = "colTotalPatient";
            this.colTotalPatient.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count;
            this.colTotalPatient.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalPatient.Visible = false;
            this.colTotalPatient.Width = 80;
            // 
            // colServiceUnitName
            // 
            this.colServiceUnitName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colServiceUnitName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colServiceUnitName.AreaIndex = 0;
            this.colServiceUnitName.Caption = "Unit Pelayanan";
            this.colServiceUnitName.FieldName = "ServiceUnitName";
            this.colServiceUnitName.Name = "colServiceUnitName";
            this.colServiceUnitName.Width = 200;
            // 
            // colParamedicName
            // 
            this.colParamedicName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colParamedicName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colParamedicName.AreaIndex = 1;
            this.colParamedicName.Caption = "Dokter/Tenaga Medis";
            this.colParamedicName.FieldName = "ParamedicName";
            this.colParamedicName.Name = "colParamedicName";
            this.colParamedicName.Width = 200;
            // 
            // colIsNewPatient
            // 
            this.colIsNewPatient.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colIsNewPatient.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colIsNewPatient.AreaIndex = 0;
            this.colIsNewPatient.Caption = "Pasien Baru";
            this.colIsNewPatient.FieldName = "IsNewPatient";
            this.colIsNewPatient.Name = "colIsNewPatient";
            this.colIsNewPatient.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIsNewPatient.Visible = false;
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
            this.colIsOldPatient.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIsOldPatient.Visible = false;
            this.colIsOldPatient.Width = 80;
            // 
            // colTariffComp1
            // 
            this.colTariffComp1.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTariffComp1.Appearance.Cell.Options.UseTextOptions = true;
            this.colTariffComp1.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTariffComp1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTariffComp1.AreaIndex = 0;
            this.colTariffComp1.Caption = "RS";
            this.colTariffComp1.CellFormat.FormatString = "N2";
            this.colTariffComp1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTariffComp1.FieldName = "TariffComp1";
            this.colTariffComp1.Name = "colTariffComp1";
            this.colTariffComp1.Width = 110;
            // 
            // colItemGroupName
            // 
            this.colItemGroupName.AreaIndex = 3;
            this.colItemGroupName.Caption = "Kelompok Pelayanan";
            this.colItemGroupName.FieldName = "ItemGroupName";
            this.colItemGroupName.Name = "colItemGroupName";
            this.colItemGroupName.Width = 200;
            // 
            // colItemName
            // 
            this.colItemName.AreaIndex = 4;
            this.colItemName.Caption = "Pelayanan";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Width = 300;
            // 
            // colTransactionType
            // 
            this.colTransactionType.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colTransactionType.AreaIndex = 0;
            this.colTransactionType.Caption = "Tipe Transaksi";
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Width = 150;
            // 
            // colTariffComp2
            // 
            this.colTariffComp2.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTariffComp2.Appearance.Cell.Options.UseTextOptions = true;
            this.colTariffComp2.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTariffComp2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTariffComp2.AreaIndex = 1;
            this.colTariffComp2.Caption = "Dokter";
            this.colTariffComp2.CellFormat.FormatString = "N2";
            this.colTariffComp2.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTariffComp2.FieldName = "TariffComp2";
            this.colTariffComp2.Name = "colTariffComp2";
            // 
            // colTariffComp3
            // 
            this.colTariffComp3.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTariffComp3.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTariffComp3.AreaIndex = 2;
            this.colTariffComp3.Caption = "TariffComp3";
            this.colTariffComp3.CellFormat.FormatString = "N2";
            this.colTariffComp3.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTariffComp3.FieldName = "TariffComp3";
            this.colTariffComp3.Name = "colTariffComp3";
            this.colTariffComp3.Visible = false;
            // 
            // colTariffComp4
            // 
            this.colTariffComp4.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTariffComp4.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTariffComp4.AreaIndex = 3;
            this.colTariffComp4.Caption = "TariffComp4";
            this.colTariffComp4.CellFormat.FormatString = "N2";
            this.colTariffComp4.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTariffComp4.FieldName = "TariffComp4";
            this.colTariffComp4.Name = "colTariffComp4";
            this.colTariffComp4.Visible = false;
            // 
            // colTransactionAmount
            // 
            this.colTransactionAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTransactionAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTransactionAmount.Caption = "Gross Amount";
            this.colTransactionAmount.CellFormat.FormatString = "N2";
            this.colTransactionAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionAmount.FieldName = "TransactionAmount";
            this.colTransactionAmount.Name = "colTransactionAmount";
            this.colTransactionAmount.Visible = false;
            // 
            // colDiscount
            // 
            this.colDiscount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colDiscount.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDiscount.Appearance.Cell.Options.UseFont = true;
            this.colDiscount.Appearance.Header.Options.UseTextOptions = true;
            this.colDiscount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colDiscount.Caption = "Discount";
            this.colDiscount.CellFormat.FormatString = "N2";
            this.colDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDiscount.Name = "colDiscount";
            this.colDiscount.Visible = false;
            // 
            // colMRN
            // 
            this.colMRN.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colMRN.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colMRN.AreaIndex = 2;
            this.colMRN.Caption = "Pasien";
            this.colMRN.FieldName = "MRN";
            this.colMRN.Name = "colMRN";
            this.colMRN.Width = 250;
            // 
            // colBusinessPartnerName
            // 
            this.colBusinessPartnerName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colBusinessPartnerName.AreaIndex = 2;
            this.colBusinessPartnerName.Caption = "Penjamin";
            this.colBusinessPartnerName.FieldName = "PayerName";
            this.colBusinessPartnerName.Name = "colBusinessPartnerName";
            // 
            // PivotOutpatientTrx1Ctl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pvGrid);
            this.Name = "PivotOutpatientTrx1Ctl";
            this.Size = new System.Drawing.Size(649, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pvGrid;
        private DevExpress.XtraPivotGrid.PivotGridField colShift;
        private DevExpress.XtraPivotGrid.PivotGridField colRegistrationDate;
        private DevExpress.XtraPivotGrid.PivotGridField colTotalPatient;
        private DevExpress.XtraPivotGrid.PivotGridField colServiceUnitName;
        private DevExpress.XtraPivotGrid.PivotGridField colParamedicName;
        private DevExpress.XtraPivotGrid.PivotGridField colIsNewPatient;
        private DevExpress.XtraPivotGrid.PivotGridField colIsOldPatient;
        private DevExpress.XtraPivotGrid.PivotGridField colTariffComp1;
        private DevExpress.XtraPivotGrid.PivotGridField colItemGroupName;
        private DevExpress.XtraPivotGrid.PivotGridField colItemName;
        private DevExpress.XtraPivotGrid.PivotGridField colTransactionType;
        private DevExpress.XtraPivotGrid.PivotGridField colTariffComp2;
        private DevExpress.XtraPivotGrid.PivotGridField colTariffComp3;
        private DevExpress.XtraPivotGrid.PivotGridField colTariffComp4;
        private DevExpress.XtraPivotGrid.PivotGridField colTransactionAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colDiscount;
        private DevExpress.XtraPivotGrid.PivotGridField colMRN;
        private DevExpress.XtraPivotGrid.PivotGridField colBusinessPartnerName;



    }
}
