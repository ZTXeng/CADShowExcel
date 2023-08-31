using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.GraphicsSystem;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using static Autodesk.AutoCAD.LayerManager.LayerFilter;
using PipeAutoCreate.ViewModel;
using CadMvvm.Model;
using CadMvvm.ExcelControl;

namespace CadMvvm.ViewModel
{
    public class ShowExcelViewModel : ViewModelBase<ShowExcelModel>
    {
        public IRelayCommand FileSelect { get; set; }
        public ShowExcelViewModel(Document doc)
        {
            Model = new ShowExcelModel();

            FileSelect = new RelayCommand(OnFileSelect);
        }

        public ShowExcelViewModel()
        {
            Model = new ShowExcelModel();

            FileSelect = new RelayCommand(OnFileSelect);
        }

        private void OnFileSelect()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Model.FilePath = dialog.FileName;

                Model.DataTables = ExcelToData.ReadExcelDataTbales(Model.FilePath, true);
                Model.CurrentDataTable = Model.DataTables.First();
            }
        }
    }
}
