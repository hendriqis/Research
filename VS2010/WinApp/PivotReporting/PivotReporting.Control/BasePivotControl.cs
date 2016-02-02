using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace PivotReporting.Control
{
    public class BasePivotControl : UserControl
    {
        PivotGridControl pivotViewer;
        BindingSource odsPivot;
        string filterExpression;

        public BindingSource DataSource
        {
            get { return odsPivot; }
            set { odsPivot = value; }
        }
        public string FilterExpression
        {
            get { return filterExpression; }
            set { filterExpression = value; }
        }
        public PivotGridControl PivotViewer
        {
            get { return pivotViewer; }
            set { pivotViewer = value; }
        }
        public string DateFieldName { get; set; }
        public Boolean IsPivotLayoutChanged { get; set; }
        public void LoadGridLayout(string fileName)
        {
            pivotViewer.RestoreLayoutFromXml(fileName);
        }
        public virtual void RefreshDataSource()
        {
            throw new Exception("Method is not implemented yet."); ;
        }
    }
}
