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

namespace rpm7
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
        Series series1 = new Series();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool Set, Limit;
            Set = int.TryParse(tbGetSet.Text, out int set);
            Limit = int.TryParse(tbLimit.Text, out int limit);
            if (Set == true && Limit == true)
            {
                for ( int i = set; i < limit; i++)
                {
                    lbSeries.Items.Add(series1.GetNext());
                }
            }
        }
    }

}