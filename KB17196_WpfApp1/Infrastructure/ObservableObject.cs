using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace KB17196_WpfApp1.Infrastructure;
internal class ObservableObject : INotifyPropertyChanged
{
    protected ObservableObject()
    {
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] String? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}