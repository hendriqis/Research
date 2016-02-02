
using PivotReporting.Model;
using System.Collections.Generic;
namespace PivotReporting.Control
{
    public partial class PivotOutpatientPayment1Ctl : BasePivotControl
    {
        public PivotOutpatientPayment1Ctl()
        {
            InitializeComponent();
            DateFieldName = "RegistrationDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotOutpatientPayment> list = BusinessLayer.GetvPivotOutpatientPaymentList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
