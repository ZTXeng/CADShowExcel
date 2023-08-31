using Autodesk.AutoCAD.Runtime;
using CadMvvm.View;
using System.Windows;

[assembly: CommandClass(typeof(CADBlogDemo.DemoCmd))]
namespace CADBlogDemo
{
    public class DemoCmd
    {
        [CommandMethod("Demo")]
        public void Demo()
        {
            var view = new ShowExcelView();
            view.ShowDialog();
        }
    }
}
