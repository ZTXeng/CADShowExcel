﻿using Autodesk.AutoCAD.ApplicationServices;
using CadMvvm.ViewModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CadMvvm.View
{
    /// <summary>
    /// ShowExcelView.xaml 的交互逻辑
    /// </summary>
    public partial class ShowExcelView : Window
    {
        public ShowExcelView(Document doc)
        {
            InitializeComponent();
            var _viewModel = new ShowExcelViewModel(doc);
            DataContext = _viewModel;
        }

        public ShowExcelView()
        {
            InitializeComponent();
            var _viewModel = new ShowExcelViewModel();
            DataContext = _viewModel;
        }
    }
}
