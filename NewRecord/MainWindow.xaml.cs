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
using NewRecord.Abstract;
using NewRecord.Commands;
using NewRecord.DataAccess.Sql;
using NewRecord.Mappers;
using NewRecord.Models;
using NewRecord.ViewModels;

namespace NewRecord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnSubmitClick(object sender, RoutedEventArgs e)
        {
            //Commanda copy etdik bunlari
            /*MainViewModel viewModel = (MainViewModel)DataContext;
            string full = $"{viewModel.Model.Name} {viewModel.Model.Surname} {viewModel.Model.FatherName}";
            MessageBox.Show(full);
            MainMapper map = new MainMapper();
            var mainEntity = map.Map(viewModel.Model);
            IMainRepository repo = new SqlMainRepository();
            repo.Add(mainEntity);
            var newList = new List<MainWindowModel>(viewModel.AllMains);
            newList.Add(viewModel.Model);
            //viewModel.AllMains = newList;//artiq set etdik(add edende notification olmur)
            viewModel.AllMains.Add(viewModel.Model);
            viewModel.Model = new MainWindowModel();
            viewModel.Status = $"Displayed items:{viewModel.AllMains.Count}";*/
        }
    }
}
