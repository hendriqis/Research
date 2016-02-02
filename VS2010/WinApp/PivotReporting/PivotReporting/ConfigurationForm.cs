using System;
using System.Configuration;
using System.Reflection;
using System.Windows.Forms;
using PivotReporting.Properties;
using System.Data.SqlClient;

namespace PivotReporting
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
            LoadDataSourceConfiguration();
            //LoadPrinterList();

            chkIsAutoLoadViewer.Checked = Settings.Default.IsAutoLoadViewer;
            
            //txtRegistrationNo.Text = Settings.Default.RegistrationNoPrefix;
            //txtRemoteDataPath.Text = Settings.Default.RemoteDataPath;
        }

        private void LoadDataSourceConfiguration()
        {
            var settings = ConfigurationManager.ConnectionStrings["cnsetting"];
            if (settings != null)
            {
                SqlConnectionStringBuilder connstr = new SqlConnectionStringBuilder(settings.ConnectionString);
                txtServerName.Text = connstr.DataSource;
                txtUserName.Text = connstr.UserID;
                txtDatabaseName.Text = connstr.InitialCatalog;
                txtPassword.Text = connstr.Password;
            }
        }

        void cboBarcodeType_EditValueChanged(object sender, EventArgs e)
        {
            //cboBarcodeValue.Visible = cboBarcodeType.EditValue.ToString() != "QRCode";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            string connstr = string.Format("server={0};database={1};uid={2};pwd={3}.;Application Name=MEDINFRAS_TOOL", txtServerName.Text, txtDatabaseName.Text, txtUserName.Text, txtPassword.Text);
            var settings = ConfigurationManager.ConnectionStrings["cnsetting"];
            var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);
            fi.SetValue(settings, false);
            settings.ConnectionString = connstr;

            if (MessageBox.Show("Do you want to save the configuration changes?",Constant.APPLICATION_TITLE,MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)== System.Windows.Forms.DialogResult.Yes)
            {
                Settings.Default.Save();
                this.Close();
                MessageBox.Show("Your changes will be applied after you close and reopen this application",Constant.APPLICATION_TITLE,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            //if (pagLabelPrinter.PageVisible)
            //{
            //    string wristbandPrinterName = cboPrinterList.Text;
            //    string labelPrinterName = cboLabelPrinter.Text;

            //    if (wristbandPrinterName == labelPrinterName)
            //    {
            //        MessageBox.Show("You cannot use the same printer for Patient Wristband and Medical Form Label", "Barindo - Print Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        return;
            //    }
            //}
            //Settings.Default.IsUsingMultiWristbandPrinter = chkIsUsingMultiWristbandPrinter.Checked;
            //Settings.Default.DefaultPrinterName = cboPrinterList.Text;
            //Settings.Default.WristbandPrinter1Name = cboPrinter1List.Text;
            //Settings.Default.WristbandPrinter2Name = cboPrinter2List.Text;
            //Settings.Default.WristbandPrinter3Name = cboPrinter3List.Text;
            //Settings.Default.WristbandPrinter4Name = cboPrinter4List.Text;
            //Settings.Default.WristbandPrinter5Name = cboPrinter5List.Text;

            //Settings.Default.RegistrationNoPrefix = txtRegistrationNo.Text;
            //Settings.Default.BarcodeType = cboBarcodeType.EditValue.ToString();
            //Settings.Default.BarcodeValue = cboBarcodeValue.EditValue.ToString();
            //Settings.Default.WristbandType = cboWristbandType.EditValue.ToString();
            //Settings.Default.PrinterLabelName = cboLabelPrinter.Text;
            //Settings.Default.PrintLabelNo = spnPrintLabelNo.EditValue.ToString();

            //Settings.Default.CustomAttribute1 = txtCustomAttribute1.Text;
            //Settings.Default.CustomAttribute2 = txtCustomAttribute2.Text;
            //Settings.Default.CustomAttribute3 = txtCustomAttribute3.Text;
            //Settings.Default.CustomAttribute4 = txtCustomAttribute4.Text;
            //Settings.Default.CustomAttribute5 = txtCustomAttribute5.Text;
            //Settings.Default.PhysicianIsMandatory = chkPhysicianIsMandatory.Checked;
            //Settings.Default.WardIsMandatory = chkWardIsMandatory.Checked;
            //Settings.Default.IsUsingCompactInfoMode = chkIsUsingCompactInfo.Checked;

            //Settings.Default.DataMode = cboDataMode.EditValue.ToString();
            //Settings.Default.ServerName = txtServerName.Text;
            //Settings.Default.UserName = txtUserName.Text;
            //Settings.Default.Password = txtPassword.Text;
            //Settings.Default.DatabaseName = txtDatabaseName.Text;
            //Settings.Default.MethodName1 = txtMethodName1.Text;

            //Settings.Default.RemoteDataPath = txtRemoteDataPath.Text;

            //Settings.Default.Save();
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadPrinterList()
        {
            //string defaultPrinter = !string.IsNullOrWhiteSpace(Settings.Default.DefaultPrinterName.ToString()) ? Settings.Default.DefaultPrinterName : string.Empty;
            //string defaultPrinter1 = !string.IsNullOrWhiteSpace(Settings.Default.WristbandPrinter1Name.ToString()) ? Settings.Default.WristbandPrinter1Name : string.Empty;
            //string defaultPrinter2 = !string.IsNullOrWhiteSpace(Settings.Default.WristbandPrinter2Name.ToString()) ? Settings.Default.WristbandPrinter2Name : string.Empty;
            //string defaultPrinter3 = !string.IsNullOrWhiteSpace(Settings.Default.WristbandPrinter3Name.ToString()) ? Settings.Default.WristbandPrinter3Name : string.Empty;
            //string defaultPrinter4 = !string.IsNullOrWhiteSpace(Settings.Default.WristbandPrinter4Name.ToString()) ? Settings.Default.WristbandPrinter4Name : string.Empty;
            //string defaultPrinter5 = !string.IsNullOrWhiteSpace(Settings.Default.WristbandPrinter5Name.ToString()) ? Settings.Default.WristbandPrinter5Name : string.Empty;

            //string printerLabelName = !string.IsNullOrWhiteSpace(Settings.Default.PrinterLabelName.ToString()) ? Settings.Default.PrinterLabelName : string.Empty;
            //foreach (string printerName in PrinterSettings.InstalledPrinters)
            //{
            //    PrinterSettings printer = new PrinterSettings();
            //    printer.PrinterName = printerName;


            //    if (string.IsNullOrWhiteSpace(defaultPrinter))
            //    {
            //        if (printer.IsDefaultPrinter)
            //            defaultPrinter = printer.PrinterName;
            //    }

            //    if (printer.IsValid)
            //    {
            //        cboPrinterList.Properties.Items.Add(printer.PrinterName);
            //        cboPrinter1List.Properties.Items.Add(printer.PrinterName);
            //        cboPrinter2List.Properties.Items.Add(printer.PrinterName);
            //        cboPrinter3List.Properties.Items.Add(printer.PrinterName);
            //        cboPrinter4List.Properties.Items.Add(printer.PrinterName);
            //        cboPrinter5List.Properties.Items.Add(printer.PrinterName);
            //        cboLabelPrinter.Properties.Items.Add(printer.PrinterName);
            //    }
            //}

            //if (cboPrinterList.Properties.Items.Count > 0)
            //{
            //    cboPrinterList.EditValue = defaultPrinter;
            //    cboPrinter1List.EditValue = defaultPrinter1;
            //    cboPrinter2List.EditValue = defaultPrinter2;
            //    cboPrinter3List.EditValue = defaultPrinter3;
            //    cboPrinter4List.EditValue = defaultPrinter4;
            //    cboPrinter5List.EditValue = defaultPrinter5;
            //    cboLabelPrinter.EditValue = printerLabelName;
            //}
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtRemoteDataPath.Text = folderBrowserDialog1.SelectedPath;
        }

    }
}
