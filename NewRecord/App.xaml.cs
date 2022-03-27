using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using NewRecord.Abstract;
using NewRecord.DataAccess.Sql;
using NewRecord.Mappers;
using NewRecord.Models;
using NewRecord.ViewModels;

namespace NewRecord
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            /*MainWindow = new MainWindow();
            MainWindow.DataContext = new MainViewModel();
            MainWindow.Show();*/

            IMainRepository repository = new SqlMainRepository();
            MainWindow = new MainWindow();
            MainViewModel viewModel = new MainViewModel();
            MainMapper map = new MainMapper();
            //viewModel.AllMains = new List<MainModel>();
            viewModel.AllMains = new ObservableCollection<MainWindowModel>();
            var entities = repository.Get();
            foreach (var item in entities)
            {
                var x = map.Map(item);
                viewModel.AllMains.Add(x);
            }

            viewModel.Status = $"{viewModel.AllMains.Count}";
            MainWindow.DataContext = viewModel;
            MainWindow.Show();
        }
    }
}
