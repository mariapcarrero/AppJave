using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JaverianaCali.Models {

    public class AbstractModel : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public AbstractModel() {
        }

        public void OnPropertyChanged([CallerMemberName]string name = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
