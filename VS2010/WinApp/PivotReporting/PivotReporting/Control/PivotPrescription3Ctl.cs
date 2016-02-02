using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PivotReporting.Model;

namespace PivotReporting.Control
{
    public partial class PivotPrescription3Ctl : BasePivotControl
    {
        public PivotPrescription3Ctl()
        {
            InitializeComponent();
            DateFieldName = "TransactionDate";
            PivotViewer = pvGrid;          
        }

        public override void RefreshDataSource()
        {
            List<vPivotPrescription> list = BusinessLayer.GetvPivotPrescriptionList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
