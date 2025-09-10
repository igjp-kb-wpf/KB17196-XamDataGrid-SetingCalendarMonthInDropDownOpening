using KB17196_WpfApp1.Infrastructure;

namespace KB17196_WpfApp1.Model;
internal class Order : ObservableObject
{
    private DateTime _orderDate;
    public DateTime OrderDate
    {
        get { return _orderDate; }
        set { _orderDate = value; OnPropertyChanged(); }
    }

    private DateTime? _expectedShippingDate;
    public DateTime? ExpectedShippingDate
    {
        get { return _expectedShippingDate; }
        set { _expectedShippingDate = value; OnPropertyChanged(); }
    }

    public Order()
    {
    }
}