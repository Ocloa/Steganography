using Steganography.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Steganography.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand EmbedViewCommand { get; set; }

        public  HomeViewModel HomeVM { get; set; }
        public EmbedTextViewModel EmbedVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            EmbedVM = new EmbedTextViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });
            EmbedViewCommand = new RelayCommand(o =>
           {
               CurrentView = EmbedVM;
           });
        }
    }
}
