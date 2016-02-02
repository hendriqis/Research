
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotEmergencyRevenue1Ctl : BasePivotControl
    {
        public PivotEmergencyRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "RegistrationDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotEmergencyRevenue> list = BusinessLayer.GetvPivotEmergencyRevenueList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
