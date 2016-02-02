
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotLBRevenue1Ctl : BasePivotControl
    {
        public PivotLBRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "TransactionDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotLBRevenue> list = BusinessLayer.GetvPivotLBRevenueList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
