
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotOutpatientRevenue1Ctl : BasePivotControl
    {
        public PivotOutpatientRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "RegistrationDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotOutpatientRevenue> list = BusinessLayer.GetvPivotOutpatientRevenueList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
