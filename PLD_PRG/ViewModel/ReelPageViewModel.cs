using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PLD_PRG.ViewModel
{
    class ReelPageViewModel : INotifyPropertyChanged
    {
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;


    }
}
