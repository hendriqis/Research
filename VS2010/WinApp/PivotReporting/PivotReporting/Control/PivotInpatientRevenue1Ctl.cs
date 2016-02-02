using PivotReporting.Model;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;
using System.IO;

namespace PivotReporting.Control
{
    public partial class PivotInpatientRevenue1Ctl : BasePivotControl
    {
        public PivotInpatientRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "DischargeDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotInpatientRevenue> list = BusinessLayer.GetvPivotInpatientRevenueList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();

            CacheDataSourceToLocal();
        }

        public override void CacheDataSource()
        {
            CacheDataSourceToLocal();
        }

        private void CacheDataSourceToLocal()
        {
            try
            {
                List<string> lstData = new List<string>();
                IEnumerable<vPivotInpatientRevenue> list = (IEnumerable<vPivotInpatientRevenue>)pvGrid.DataSource;
                foreach (vPivotInpatientRevenue item in list)
                {
                    // Read the data and convert it to the appropriate data type.
                    string data = string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10};{11};{12};{13};{14};{15};{16};{17};{18};{19};{20};{21};{22};{23};{24}",
                       item.DepartmentCode.TrimEnd(),
                       item.DepartmentName.TrimEnd(),
                       item.ServiceUnitCode.TrimEnd(),
                       item.ServiceUnitName.TrimEnd(),
                       item.ChargeClassCode.TrimEnd(),
                       item.ChargeClassName.TrimEnd(),
                       item.RegistrationNo.TrimEnd(),
                       item.RegistrationDate.ToString("yyyymmdd"),
                       item.DischargeDate.ToString("yyyymmdd"),
                       item.NoSEP.TrimEnd(),
                       item.LinkRegistrationNo.TrimEnd(),
                       item.MedicalNo.TrimEnd(),
                       item.FirstName.TrimEnd(),
                       item.LastName.TrimEnd(),
                       item.PayerType.TrimEnd(),
                       item.PayerCode.TrimEnd(),
                       item.PayerName.TrimEnd(),
                       item.TransactionDate.ToString("yyyymmdd"),
                       item.TransactionNo.TrimEnd(),
                       item.ParamedicCode.TrimEnd(),
                       item.ParamedicName.TrimEnd(),
                       item.ItemType.TrimEnd(),
                       item.ItemCode.TrimEnd(),
                       item.ItemName.TrimEnd(),
                       item.ItemGroupCode.TrimEnd(),
                       item.ItemGroupName.TrimEnd(),
                       item.TariffComp1.ToString(),
                       item.TariffComp2.ToString(),
                       item.TariffComp3.ToString(),
                       item.TariffComp4.ToString(),
                       item.Discount1.ToString(),
                       item.Discount2.ToString(),
                       item.Discount3.ToString(),
                       item.Discount4.ToString(),
                       item.CitoAmount.ToString(),
                       item.CompAmount.ToString(),
                       item.PatientAmount.ToString(),
                       item.PayerAmount.ToString());
                    lstData.Add(data);
                }

                string fileName = string.Format(@"{0}\app_data\cache\{1}_{2}_{3}.dat", Application.StartupPath,this.TemplateCode, this.FromDate,this.ToDate);
                File.Delete(fileName);
                File.WriteAllLines(fileName, lstData.AsEnumerable());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constant.APPLICATION_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
