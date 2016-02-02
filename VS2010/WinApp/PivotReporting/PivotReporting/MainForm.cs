using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PivotReporting.Control;
using PivotReporting.Model;
using PivotReporting.Properties;
using System.Configuration;
using System.Data.SqlClient;

namespace PivotReporting
{
    public partial class MainForm : Form
    {
        #region Private Variables
        private BasePivotControl _pivotControl;
        private string _exportFileName;
        private List<TemplateGroup> templateGroupList = new List<TemplateGroup>();
        private List<Template> templateList = new List<Template>(); 
        #endregion

        #region Public Properties
        public List<TemplateGroup> TemplateGroupList
        {
            get { return templateGroupList; }
            set { templateGroupList = value; }
        }
        public List<Template> TemplateList
        {
            get { return templateList; }
            set { templateList = value; }
        }

        public BasePivotControl PivotControl
        {
            get { return _pivotControl; }
            set { _pivotControl = value; }
        }
        #endregion

        public MainForm()
        {
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            InitializeComponent();
            InitializeModel();
            InitializeConfiguration();
            InitializeParameter();
            //InitializeGrid();           
        }

        private void InitializeModel()
        {
            LoadTemplateGroupList();
        }

        private void InitializeConfiguration()
        {
            chkAutoLoad.Checked = Settings.Default.IsAutoLoadViewer;

            #region Data Source Configuration
            var settings = ConfigurationManager.ConnectionStrings["cnsetting"];
            SqlConnectionStringBuilder connstr = new SqlConnectionStringBuilder(settings.ConnectionString);
            stbServerName.Text = connstr.DataSource;
            stbDatabaseName.Text = connstr.InitialCatalog;
            #endregion
        }

        private void InitializeParameter()
        {
            cboPeriodType.SelectedIndex = 0;
            dteFromDate.Value = DateTime.Now.Date.AddMonths(-1);
            dteToDate.Value = DateTime.Now.Date;

            btnLoadTemplate.Enabled = !chkAutoLoad.Checked;
        }

        #region Data Source Methods
        private void RefreshDataSource()
        {
            this.Cursor = Cursors.WaitCursor;
            string filterExpression = string.Format("{0} BETWEEN CONVERT(DATE,'{1}',112) AND CONVERT(DATE,'{2}',112)", PivotControl.DateFieldName, dteFromDate.Value.ToString("yyyyMMdd"), dteToDate.Value.ToString("yyyyMMdd"));
            PivotControl.FilterExpression = filterExpression;
            PivotControl.RefreshDataSource();
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Event-Handler Methods
        private void cboTemplateGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateGroup item = (TemplateGroup)cboTemplateGroup.SelectedItem;
            if (templateList.Count > 0)
            {
                LoadTemplateList(item.TemplateGroupCode);
            }
        }
        void cboTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkAutoLoad.Checked)
            {
                Template item = (Template)cboTemplate.SelectedItem;
                LoadUserControl(item.TemplateCode, item.ControlName);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void btnLoadTemplate_Click(object sender, EventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cboTemplate.SelectedItem;
            LoadUserControl(item.Value, item.Tag.ToString());
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveViewerTemplate();
        }

        private void mnuExportToExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void mnuConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationForm configForm = new ConfigurationForm();
            configForm.ShowDialog();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void btnSaveLayout_Click(object sender, EventArgs e)
        {
            try
            {
                SaveViewerTemplate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occured while saving the grid layout. Exception Message : '{0}'", ex.Message), Constant.APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load Methods
        private void LoadTemplateGroupList()
        {
            #region Template Group
            string fileName = string.Format(@"{0}\app_data\master\TemplateGroup.lst", Application.StartupPath);
            FileInfo file = new FileInfo(fileName);
            if (file.Exists)
            {
                IEnumerable<string> recordList = File.ReadAllLines(file.FullName);
                templateGroupList.Clear();
                foreach (string itemInfo in recordList)
                {
                    string[] record = itemInfo.Split(';');
                    if (record[3] == "1")
                    {
                        templateGroupList.Add(new TemplateGroup() { TemplateGroupCode = record[0], TemplateGroupName = record[1], Remarks = record[2] });
                    }
                }
                cboTemplateGroup.DataSource = templateGroupList;
                cboTemplateGroup.DisplayMember = "TemplateGroupName";
                cboTemplateGroup.ValueMember = "TemplateGroupCode";
            }
            #endregion

            #region Template
            fileName = string.Format(@"{0}\app_data\master\Template.lst", Application.StartupPath);
            file = new FileInfo(fileName);
            if (file.Exists)
            {
                IEnumerable<string> recordList = File.ReadAllLines(file.FullName);
                templateList.Clear();
                foreach (string itemInfo in recordList)
                {
                    string[] record = itemInfo.Split(';');
                    if (record[5] == "1")
                    {
                        templateList.Add(new Template()
                        {
                            TemplateGroupCode = record[0],
                            TemplateCode = record[1],
                            TemplateName = record[2],
                            ControlName = record[3],
                            MethodName = record[4],
                            IsEnabled = record[5] == "1" ? true : false,
                            TemplateRemarks = record[6]
                        });
                    }
                }
            }
            #endregion

            if (cboTemplateGroup.Items.Count > 0)
            {
                cboTemplateGroup.SelectedIndex = 0;
                LoadTemplateList(((TemplateGroup)cboTemplateGroup.SelectedItem).TemplateGroupCode);
            }
        }

        private void LoadTemplateList(string groupCode)
        {
            IEnumerable<Template> list = templateList.Where(lst => lst.TemplateGroupCode.Equals(groupCode));
            cboTemplate.DataSource = list.ToList();
            cboTemplate.ValueMember = "TemplateCode";
            cboTemplate.DisplayMember = "TemplateName";
            if (cboTemplate.Items.Count > 0)
            {
                cboTemplate.SelectedIndex = 0;
            }
            cboTemplate.Enabled = cboTemplate.Items.Count > 0;
        }

        private void LoadUserControl(string templateCode, string controlName)
        {
            try
            {
                string layoutFileName = string.Format(Constant.PIVOT_CONTROL_LAYOUT_PATH, Application.StartupPath, controlName);
                panContent.Controls.Clear();
                BasePivotControl control = (BasePivotControl)Activator.CreateInstance(Type.GetType(string.Format(Constant.PIVOT_CONTROL_NAMESPACE, controlName)));
                this.WindowState = FormWindowState.Maximized;
                control.Name = "pivotViewer";
                panContent.Controls.Add(control);
                control.Dock = DockStyle.Fill;
                control.BringToFront();
                PivotControl = control;
                PivotControl.TemplateCode = templateCode;
                PivotControl.FromDate = dteFromDate.Value.ToString("yyyyMMdd");
                PivotControl.ToDate = dteToDate.Value.ToString("yyyyMMdd");
                PivotControl.LoadGridLayout(layoutFileName);
                btnSaveLayout.Enabled = PivotControl != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void ExportToExcel()
        {
            string fileName = string.Format(@"{0}\app_data\_export\{1}_{2}_{3}.xlsx", Application.StartupPath, ((Template)cboTemplate.SelectedItem).TemplateCode.Replace('.','_'), dteFromDate.Value.ToString("yyyyMMdd"), dteToDate.Value.ToString("yyyyMMdd"));
            _exportFileName = fileName;
            FileInfo file = new FileInfo(_exportFileName);
            if (file.Exists)
                file.Delete();
            PivotControl.PivotViewer.ExportToXlsx(fileName);
            Process.Start(_exportFileName);
        }

        private void SaveViewerTemplate()
        {
            if (PivotControl != null)
            {
                string fileName = string.Format(@"{0}\app_data\layout\{1}.xml", Application.StartupPath, ((Template)cboTemplate.SelectedItem).ControlName);
                FileInfo file = new FileInfo(fileName);
                if (file.Exists)
                    file.Delete();
                PivotControl.PivotViewer.SaveLayoutToXml(fileName);
            }
        }

        private void tbRefreshData_Click(object sender, EventArgs e)
        {
            RefreshDataSource();
        }
    }
}
