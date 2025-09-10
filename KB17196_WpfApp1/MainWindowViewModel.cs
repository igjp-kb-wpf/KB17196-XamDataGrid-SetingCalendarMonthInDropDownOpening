using KB17196_WpfApp1.Infrastructure;
using KB17196_WpfApp1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KB17196_WpfApp1;
internal class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<Order> _orders;

    public ObservableCollection<Order> Orders
    {
        get { return _orders; }
        set { _orders = value; OnPropertyChanged(); }
    }

    public MainWindowViewModel()
    {
        _orders = new()
        {
            new() { OrderDate = new DateTime(2025, 4, 24) },
            new() { OrderDate = new DateTime(2025, 5, 10) },
        };
    }
}