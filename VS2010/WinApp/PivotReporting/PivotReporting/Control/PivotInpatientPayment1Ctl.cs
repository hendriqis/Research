
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotInpatientPayment1Ctl : BasePivotControl
    {
        public PivotInpatientPayment1Ctl()
        {
            InitializeComponent();
            DateFieldName = "DischargeDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotInpatientPayment> list = BusinessLayer.GetvPivotInpatientPaymentList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
