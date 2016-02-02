
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotRevenue1Ctl : BasePivotControl
    {
        public PivotRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "RegistrationDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotRevenue> list = BusinessLayer.GetvPivotRevenueList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
