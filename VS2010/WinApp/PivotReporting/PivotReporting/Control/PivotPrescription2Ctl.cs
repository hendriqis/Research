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
    public partial class PivotPrescription2Ctl : BasePivotControl
    {
        public PivotPrescription2Ctl()
        {
            InitializeComponent();
            DateFieldName = "RegistrationDate";
            PivotViewer = pvGrid;          
        }

        public override void RefreshDataSource()
        {
            List<vPivotBPJSOutpatientPrescription> list = BusinessLayer.GetvPivotBPJSOutpatientPrescriptionList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
