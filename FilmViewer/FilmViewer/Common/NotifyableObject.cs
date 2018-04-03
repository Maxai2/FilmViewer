using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1.Common {
    public class NotifyableObject : INotifyPropertyChanged {
        protected void OnChanged([CallerMemberName] string name = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
