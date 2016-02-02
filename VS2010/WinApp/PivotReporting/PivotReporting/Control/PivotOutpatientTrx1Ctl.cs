
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotOutpatientTrx1Ctl : BasePivotControl
    {
        public PivotOutpatientTrx1Ctl()
        {
            InitializeComponent();
            PivotViewer = pvGrid;
            DateFieldName = "RegistrationDate";
        }

        public override void RefreshDataSource()
        {
            List<vPivotOutpatientTrx> list = BusinessLayer.GetvPivotOutpatientTrxList(this.FilterExpression);
            //odsPivot.DataSource = list;

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
