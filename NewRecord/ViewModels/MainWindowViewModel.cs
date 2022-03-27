using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using NewRecord.Commands;
using NewRecord.Models;

namespace NewRecord.ViewModels
{
    public class MainViewModel :INotifyPropertyChanged
    {
        
        //public MainCommand Submit => new MainCommand(this);
        public MainCommand Submit { get; set; }
        public MainViewModel()
        {
            
            Submit = new MainCommand(this);
        }


        //public int Count =>(int) Math.Log10(Status) + 1;

        //public MainModel Model { get; set; } = new MainModel();
        //public MainModel Model { get; set; }
        private MainWindowModel model = new MainWindowModel();

        public MainWindowModel Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged(nameof(Model));
            }
        }

        //public List<MainModel> AllMains { get; set; }
        private ObservableCollection<MainWindowModel> allMains;

        public ObservableCollection<MainWindowModel> AllMains //List idi,observable etdik
        {
            get { return allMains; }
            set
            {
                allMains = value;
                OnPropertyChanged(nameof(AllMains));
            }
        }

        //public string Status { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private string status;

        public string Status
        {
            get { return status; }
            set
            {
                status = value;
                //OnPropertyChanged("Count");
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("status"));
                OnPropertyChanged("Status");
            }
        }

        /*[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }*/

        private void OnPropertyChanged(string propName)
        {
            if (PropertyChanged == null)
            {
                return;
            }

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}


