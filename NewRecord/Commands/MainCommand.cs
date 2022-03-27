using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NewRecord.Abstract;
using NewRecord.DataAccess.Sql;
using NewRecord.Mappers;
using NewRecord.Models;
using NewRecord.ViewModels;

namespace NewRecord.Commands
{
    public class MainCommand:ICommand
    {
        private readonly MainViewModel viewModel;

        public MainCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }


        public bool CanExecute(object? parameter)
        {
            /*if (viewModel.AllMains.Count<5)
            {
                return true;
            }
            else
            {
                MessageBox.Show("You can't add new item!!!");
            }*/
            //return true;
            /*if (string.IsNullOrEmpty(viewModel.Model.Name))
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(viewModel.Model.Surname))
            {
                return false;
            }*/

            return true;

        }

        public void Execute(object? parameter)
        {
            //string full = $"{viewModel.Model.Name} {viewModel.Model.Surname} {viewModel.Model.FatherName}";
            //MessageBox.Show(full);
            MainMapper map = new MainMapper();
            var mainEntity = map.Map(viewModel.Model);
            IMainRepository repo = new SqlMainRepository();
            repo.Add(mainEntity);
            var newList = new List<MainWindowModel>(viewModel.AllMains);
            newList.Add(viewModel.Model);
            //viewModel.AllMains = newList;//artiq set etdik(add edende notification olmur)
            viewModel.AllMains.Add(viewModel.Model);
            viewModel.Model = new MainWindowModel();
            viewModel.Status = $"Displayed items:{viewModel.AllMains.Count}";

        }

        public event EventHandler? CanExecuteChanged;
    }

}
