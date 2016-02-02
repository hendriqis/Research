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
    public partial class PivotPrescription1Ctl : BasePivotControl
    {
        public PivotPrescription1Ctl()
        {
            InitializeComponent();
            DateFieldName = "RegistrationDate";
            PivotViewer = pvGrid;          
        }

        public override void RefreshDataSource()
        {
            List<vPivotBPJSInpatientPrescription> list = BusinessLayer.GetvPivotBPJSInpatientPrescriptionList(this.FilterExpression);

            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
