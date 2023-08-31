using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadMvvm.Model
{
    public class ShowExcelModel : ObservableObject
    {
        private string _filePath;

        public string FilePath
        {
            get => _filePath;
            set => SetProperty(ref _filePath, value);
        }

        private DataTable _currentDataTable;

        public DataTable CurrentDataTable {
            get => _currentDataTable;
            set => SetProperty(ref _currentDataTable, value);
        }


        public List<DataTable> DataTables { get; set; }

        public ShowExcelModel()
        {
            DataTables = new List<DataTable>();
        }
    }
}
