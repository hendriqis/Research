using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QIS.Data;
using PivotReporting.Model;

namespace PivotReporting.Control
{
    public partial class _PivotInpatientRevenue1Ctl : PivotReporting.Control.BasePivotRevenueCtl
    {
        public _PivotInpatientRevenue1Ctl()
        {
            InitializeComponent();
            DateFieldName = "DischargeDate";
            PivotViewer = pvGrid;               
        }

        public override void RefreshDataSource()
        {
            List<vPivotInpatientRevenue> list = BusinessLayer.GetvPivotInpatientRevenueList(this.FilterExpression);
            pvGrid.BeginUpdate();
            pvGrid.DataSource = list;
            pvGrid.EndUpdate();
            pvGrid.RefreshData();
        }
    }
}
