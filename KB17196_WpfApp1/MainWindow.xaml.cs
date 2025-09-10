using Infragistics.Windows.Editors;
using KB17196_WpfApp1.Model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KB17196_WpfApp1
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

        // 出荷予定日のカレンダーが開いた際に呼ばれるイベントハンドラー
        private void XamDateTimeEditor_DropDownOpened(object sender, RoutedEventArgs e)
        {
            if (sender == null)
            {
                System.Diagnostics.Debug.WriteLine("sender is null");
                return;
            }
            System.Diagnostics.Debug.WriteLine("sender type: " + sender.GetType().FullName);

            var editor = sender as XamDateTimeEditor;
            if (editor == null)
            {
                System.Diagnostics.Debug.WriteLine("sender is not a XamDateTimeEditor");
                return;
            }

            // DataContext が DataRecord の場合、DataItem プロパティから Order を取得する
            if (editor.DataContext is Infragistics.Windows.DataPresenter.DataRecord dataRecord &&
                dataRecord.DataItem is Order order)
            {
                DateTime orderDate = order.OrderDate;

                // エディターの Value を更新
                editor.Value = orderDate;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Order オブジェクトが取得できませんでした。");
            }
        }
    }
}