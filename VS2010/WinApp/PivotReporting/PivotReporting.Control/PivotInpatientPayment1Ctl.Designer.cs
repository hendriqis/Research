namespace PivotReporting.Control
{
    partial class PivotInpatientPayment1Ctl
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
            DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition pivotGridStyleFormatCondition1 = new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition();
            this.colOutstandingAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pvGrid = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.colRegistrationDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDischargeDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colServiceUnitName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colBusinessPartnerName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colParamedicName = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colRegistrationNo = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colMRN = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colServiceAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDrugSuppliesAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPharmacyAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colLaboratoryAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colOtherDiagnosticAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colTransactionAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colCashAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDebitCardAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colCreditCardAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colBankTransferAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPersonalARAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPayerARAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDownPaymentAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPaymentAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateYear = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateMonth = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colDateMonthWeek = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colPayerType = new DevExpress.XtraPivotGrid.PivotGridField();
            this.colNoSEP = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // colOutstandingAmount
            // 
            this.colOutstandingAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colOutstandingAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Appearance.CellGrandTotal.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.CellGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Appearance.CellTotal.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Appearance.Value.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Appearance.ValueTotal.Options.UseTextOptions = true;
            this.colOutstandingAmount.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colOutstandingAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colOutstandingAmount.AreaIndex = 3;
            this.colOutstandingAmount.Caption = "Sisa Tagihan";
            this.colOutstandingAmount.CellFormat.FormatString = "N2";
            this.colOutstandingAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOutstandingAmount.FieldName = "OutstandingAmount";
            this.colOutstandingAmount.Name = "colOutstandingAmount";
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
            this.colRegistrationDate,
            this.colDischargeDate,
            this.colServiceUnitName,
            this.colBusinessPartnerName,
            this.colParamedicName,
            this.colRegistrationNo,
            this.colMRN,
            this.colServiceAmount,
            this.colDrugSuppliesAmount,
            this.colPharmacyAmount,
            this.colLaboratoryAmount,
            this.colOtherDiagnosticAmount,
            this.colTransactionAmount,
            this.colCashAmount,
            this.colDebitCardAmount,
            this.colCreditCardAmount,
            this.colBankTransferAmount,
            this.colPersonalARAmount,
            this.colPayerARAmount,
            this.colDownPaymentAmount,
            this.colPaymentAmount,
            this.colOutstandingAmount,
            this.colDateYear,
            this.colDateMonth,
            this.colDateMonthWeek,
            this.colPayerType,
            this.colNoSEP});
            pivotGridStyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            pivotGridStyleFormatCondition1.Appearance.Options.UseForeColor = true;
            pivotGridStyleFormatCondition1.Expression = "[OutstandingAmount] > 0";
            pivotGridStyleFormatCondition1.Field = this.colOutstandingAmount;
            pivotGridStyleFormatCondition1.FieldName = "colOutstandingAmount";
            this.pvGrid.FormatConditions.AddRange(new DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition[] {
            pivotGridStyleFormatCondition1});
            this.pvGrid.Location = new System.Drawing.Point(0, 0);
            this.pvGrid.Name = "pvGrid";
            this.pvGrid.OptionsPrint.PrintColumnHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pvGrid.OptionsPrint.PrintDataHeaders = DevExpress.Utils.DefaultBoolean.False;
            this.pvGrid.OptionsPrint.PrintFilterHeaders = DevExpress.Utils.DefaultBoolean.True;
            this.pvGrid.OptionsPrint.PrintUnusedFilterFields = false;
            this.pvGrid.Size = new System.Drawing.Size(649, 400);
            this.pvGrid.TabIndex = 5;
            // 
            // colRegistrationDate
            // 
            this.colRegistrationDate.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.colRegistrationDate.Appearance.Cell.Options.UseTextOptions = true;
            this.colRegistrationDate.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegistrationDate.Appearance.Header.Options.UseTextOptions = true;
            this.colRegistrationDate.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegistrationDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colRegistrationDate.AreaIndex = 1;
            this.colRegistrationDate.Caption = "Tanggal Masuk";
            this.colRegistrationDate.FieldName = "RegistrationDateInString";
            this.colRegistrationDate.Name = "colRegistrationDate";
            this.colRegistrationDate.Width = 110;
            // 
            // colDischargeDate
            // 
            this.colDischargeDate.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.colDischargeDate.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colDischargeDate.Caption = "Tanggal Keluar";
            this.colDischargeDate.FieldName = "DischargeDateInString";
            this.colDischargeDate.Name = "colDischargeDate";
            this.colDischargeDate.Visible = false;
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
            // colBusinessPartnerName
            // 
            this.colBusinessPartnerName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colBusinessPartnerName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colBusinessPartnerName.AreaIndex = 4;
            this.colBusinessPartnerName.Caption = "Penjamin";
            this.colBusinessPartnerName.FieldName = "PayerName";
            this.colBusinessPartnerName.Name = "colBusinessPartnerName";
            // 
            // colParamedicName
            // 
            this.colParamedicName.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colParamedicName.AreaIndex = 0;
            this.colParamedicName.Caption = "Dokter/Tenaga Medis";
            this.colParamedicName.FieldName = "ParamedicName";
            this.colParamedicName.Name = "colParamedicName";
            this.colParamedicName.Width = 200;
            // 
            // colRegistrationNo
            // 
            this.colRegistrationNo.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.colRegistrationNo.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colRegistrationNo.AreaIndex = 2;
            this.colRegistrationNo.Caption = "Nomor Registrasi";
            this.colRegistrationNo.FieldName = "RegistrationNo";
            this.colRegistrationNo.Name = "colRegistrationNo";
            this.colRegistrationNo.Width = 120;
            // 
            // colMRN
            // 
            this.colMRN.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colMRN.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colMRN.AreaIndex = 3;
            this.colMRN.Caption = "Pasien";
            this.colMRN.FieldName = "MRN";
            this.colMRN.Name = "colMRN";
            this.colMRN.Width = 250;
            // 
            // colServiceAmount
            // 
            this.colServiceAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colServiceAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colServiceAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colServiceAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colServiceAmount.Caption = "Pelayanan";
            this.colServiceAmount.CellFormat.FormatString = "N2";
            this.colServiceAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colServiceAmount.FieldName = "ServiceAmount";
            this.colServiceAmount.Name = "colServiceAmount";
            this.colServiceAmount.Visible = false;
            this.colServiceAmount.Width = 110;
            // 
            // colDrugSuppliesAmount
            // 
            this.colDrugSuppliesAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colDrugSuppliesAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colDrugSuppliesAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDrugSuppliesAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colDrugSuppliesAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDrugSuppliesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colDrugSuppliesAmount.Caption = "Obat dan BHP";
            this.colDrugSuppliesAmount.CellFormat.FormatString = "N2";
            this.colDrugSuppliesAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDrugSuppliesAmount.FieldName = "DrugSuppliesAmount";
            this.colDrugSuppliesAmount.Name = "colDrugSuppliesAmount";
            this.colDrugSuppliesAmount.Visible = false;
            // 
            // colPharmacyAmount
            // 
            this.colPharmacyAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colPharmacyAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colPharmacyAmount.AreaIndex = 2;
            this.colPharmacyAmount.Caption = "Resep";
            this.colPharmacyAmount.CellFormat.FormatString = "N2";
            this.colPharmacyAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPharmacyAmount.FieldName = "PharmacyAmount";
            this.colPharmacyAmount.Name = "colPharmacyAmount";
            this.colPharmacyAmount.Visible = false;
            // 
            // colLaboratoryAmount
            // 
            this.colLaboratoryAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colLaboratoryAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colLaboratoryAmount.AreaIndex = 3;
            this.colLaboratoryAmount.Caption = "Laboratorium";
            this.colLaboratoryAmount.CellFormat.FormatString = "N2";
            this.colLaboratoryAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLaboratoryAmount.FieldName = "LaboratoryAmount";
            this.colLaboratoryAmount.Name = "colLaboratoryAmount";
            this.colLaboratoryAmount.Visible = false;
            // 
            // colOtherDiagnosticAmount
            // 
            this.colOtherDiagnosticAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colOtherDiagnosticAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colOtherDiagnosticAmount.Caption = "Penunjang Medis";
            this.colOtherDiagnosticAmount.CellFormat.FormatString = "N2";
            this.colOtherDiagnosticAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOtherDiagnosticAmount.FieldName = "OtherDiagnosticAmount";
            this.colOtherDiagnosticAmount.Name = "colOtherDiagnosticAmount";
            this.colOtherDiagnosticAmount.Visible = false;
            // 
            // colTransactionAmount
            // 
            this.colTransactionAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colTransactionAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.CellGrandTotal.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.CellGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.CellTotal.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.Value.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Appearance.ValueTotal.Options.UseTextOptions = true;
            this.colTransactionAmount.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colTransactionAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colTransactionAmount.AreaIndex = 0;
            this.colTransactionAmount.Caption = "Tagihan";
            this.colTransactionAmount.CellFormat.FormatString = "N2";
            this.colTransactionAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransactionAmount.FieldName = "TransactionAmount";
            this.colTransactionAmount.Name = "colTransactionAmount";
            // 
            // colCashAmount
            // 
            this.colCashAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colCashAmount.Appearance.Cell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCashAmount.Appearance.Cell.Options.UseFont = true;
            this.colCashAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colCashAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colCashAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colCashAmount.Caption = "Cash";
            this.colCashAmount.CellFormat.FormatString = "N2";
            this.colCashAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCashAmount.Name = "colCashAmount";
            this.colCashAmount.Visible = false;
            // 
            // colDebitCardAmount
            // 
            this.colDebitCardAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colDebitCardAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colDebitCardAmount.Caption = "Debit Card";
            this.colDebitCardAmount.CellFormat.FormatString = "N2";
            this.colDebitCardAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDebitCardAmount.FieldName = "DebitCardAmount";
            this.colDebitCardAmount.Name = "colDebitCardAmount";
            this.colDebitCardAmount.Visible = false;
            // 
            // colCreditCardAmount
            // 
            this.colCreditCardAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colCreditCardAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colCreditCardAmount.Caption = "Credit Card";
            this.colCreditCardAmount.CellFormat.FormatString = "N2";
            this.colCreditCardAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCreditCardAmount.FieldName = "CreditCardAmount";
            this.colCreditCardAmount.Name = "colCreditCardAmount";
            this.colCreditCardAmount.Visible = false;
            // 
            // colBankTransferAmount
            // 
            this.colBankTransferAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colBankTransferAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Appearance.CellGrandTotal.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.CellGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Appearance.CellTotal.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Appearance.Value.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Appearance.ValueTotal.Options.UseTextOptions = true;
            this.colBankTransferAmount.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colBankTransferAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colBankTransferAmount.Caption = "Transfer Bank";
            this.colBankTransferAmount.CellFormat.FormatString = "N2";
            this.colBankTransferAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBankTransferAmount.FieldName = "BankTransferAmount";
            this.colBankTransferAmount.Name = "colBankTransferAmount";
            this.colBankTransferAmount.Visible = false;
            // 
            // colPersonalARAmount
            // 
            this.colPersonalARAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colPersonalARAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colPersonalARAmount.Caption = "Piutang Pribadi";
            this.colPersonalARAmount.CellFormat.FormatString = "N2";
            this.colPersonalARAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPersonalARAmount.FieldName = "PersonalARAmount";
            this.colPersonalARAmount.Name = "colPersonalARAmount";
            this.colPersonalARAmount.Visible = false;
            // 
            // colPayerARAmount
            // 
            this.colPayerARAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colPayerARAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colPayerARAmount.Caption = "Piutang Instansi";
            this.colPayerARAmount.CellFormat.FormatString = "N2";
            this.colPayerARAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPayerARAmount.FieldName = "PayerARAmount";
            this.colPayerARAmount.Name = "colPayerARAmount";
            this.colPayerARAmount.Visible = false;
            // 
            // colDownPaymentAmount
            // 
            this.colDownPaymentAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colDownPaymentAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colDownPaymentAmount.AreaIndex = 1;
            this.colDownPaymentAmount.Caption = "Uang Muka";
            this.colDownPaymentAmount.CellFormat.FormatString = "N2";
            this.colDownPaymentAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDownPaymentAmount.FieldName = "DownPaymentAmount";
            this.colDownPaymentAmount.Name = "colDownPaymentAmount";
            // 
            // colPaymentAmount
            // 
            this.colPaymentAmount.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea;
            this.colPaymentAmount.Appearance.Cell.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Appearance.CellGrandTotal.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.CellGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Appearance.CellTotal.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.CellTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Appearance.Header.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Appearance.Value.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Appearance.ValueGrandTotal.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.ValueGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Appearance.ValueTotal.Options.UseTextOptions = true;
            this.colPaymentAmount.Appearance.ValueTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colPaymentAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.colPaymentAmount.AreaIndex = 2;
            this.colPaymentAmount.Caption = "Pembayaran";
            this.colPaymentAmount.CellFormat.FormatString = "N2";
            this.colPaymentAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPaymentAmount.FieldName = "PaymentAmount";
            this.colPaymentAmount.Name = "colPaymentAmount";
            // 
            // colDateYear
            // 
            this.colDateYear.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colDateYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateYear.Caption = "Tahun";
            this.colDateYear.FieldName = "TransactionDate";
            this.colDateYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear;
            this.colDateYear.Name = "colDateYear";
            this.colDateYear.UnboundFieldName = "colDateYear";
            this.colDateYear.Visible = false;
            // 
            // colDateMonth
            // 
            this.colDateMonth.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colDateMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateMonth.Caption = "Bulan";
            this.colDateMonth.FieldName = "TransactionDate";
            this.colDateMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth;
            this.colDateMonth.Name = "colDateMonth";
            this.colDateMonth.UnboundFieldName = "colDateMonth";
            this.colDateMonth.Visible = false;
            // 
            // colDateMonthWeek
            // 
            this.colDateMonthWeek.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.colDateMonthWeek.Caption = "Minggu";
            this.colDateMonthWeek.FieldName = "TransactionDate";
            this.colDateMonthWeek.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekOfMonth;
            this.colDateMonthWeek.Name = "colDateMonthWeek";
            this.colDateMonthWeek.UnboundFieldName = "colMonthWeek";
            this.colDateMonthWeek.Visible = false;
            // 
            // colPayerType
            // 
            this.colPayerType.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.colPayerType.AreaIndex = 1;
            this.colPayerType.Caption = "Tipe Penjamin";
            this.colPayerType.FieldName = "PayerType";
            this.colPayerType.Name = "colPayerType";
            // 
            // colNoSEP
            // 
            this.colNoSEP.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea;
            this.colNoSEP.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.colNoSEP.AreaIndex = 5;
            this.colNoSEP.Caption = "No. SEP";
            this.colNoSEP.FieldName = "NoSEP";
            this.colNoSEP.Name = "colNoSEP";
            this.colNoSEP.Width = 120;
            // 
            // PivotInpatientPayment1Ctl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pvGrid);
            this.Name = "PivotInpatientPayment1Ctl";
            this.Size = new System.Drawing.Size(649, 400);
            ((System.ComponentModel.ISupportInitialize)(this.pvGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pvGrid;
        private DevExpress.XtraPivotGrid.PivotGridField colRegistrationDate;
        private DevExpress.XtraPivotGrid.PivotGridField colServiceUnitName;
        private DevExpress.XtraPivotGrid.PivotGridField colParamedicName;
        private DevExpress.XtraPivotGrid.PivotGridField colServiceAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colDrugSuppliesAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colPharmacyAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colLaboratoryAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colTransactionAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colCashAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colMRN;
        private DevExpress.XtraPivotGrid.PivotGridField colBusinessPartnerName;
        private DevExpress.XtraPivotGrid.PivotGridField colPaymentAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colOutstandingAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colDateYear;
        private DevExpress.XtraPivotGrid.PivotGridField colDateMonth;
        private DevExpress.XtraPivotGrid.PivotGridField colDateMonthWeek;
        private DevExpress.XtraPivotGrid.PivotGridField colOtherDiagnosticAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colDebitCardAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colCreditCardAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colPersonalARAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colPayerARAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colPayerType;
        private DevExpress.XtraPivotGrid.PivotGridField colRegistrationNo;
        private DevExpress.XtraPivotGrid.PivotGridField colDischargeDate;
        private DevExpress.XtraPivotGrid.PivotGridField colBankTransferAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colDownPaymentAmount;
        private DevExpress.XtraPivotGrid.PivotGridField colNoSEP;



    }
}
