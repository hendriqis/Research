
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotMDRevenue1Ctl : BasePivotControl
    {
        public PivotMDRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "TransactionDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotMDRevenue> list = BusinessLayer.GetvPivotMDRevenueList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
