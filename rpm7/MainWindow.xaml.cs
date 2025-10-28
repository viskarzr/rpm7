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
        
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №7\r\nРабота с объектами через интерфейсы\r\nСоздать интерфейс – серия чисел (см. лекцию). Создать класс – геометрическая прогрессия.\r\n Класс должен включать конструктор. Сравнение производить по шагу прогрессии.\r\n Выполнила:\r\n Студентка гр.ИСП-31 Кирюшова В.");
        }

        private void btnClone_Click(object sender, RoutedEventArgs e)
        {
            Series ser = (Series)series1.Clone();
            lbSeries.Items.Add(ser);
        }

        private void btnSer_Click(object sender, RoutedEventArgs e)
        {
            series1.Reset();
            lbSeries.Items.Clear();
            bool Set, Limit;
            Set = int.TryParse(tbGetSet.Text, out int set);
            Limit = int.TryParse(tbLimit.Text, out int limit);
            if (Set == true && Limit == true)
            {
                series1.SetStart(set);
                for (int i = 0; i < limit; i++) // После +30 перестает работать
                {
                    lbSeries.Items.Add(series1.GetNext());
                }
            }
        }

        private void btnClean_Click(object sender, RoutedEventArgs e)
        {
            tbGetSet.Clear(); 
            tbLimit.Clear(); 
            tbRezComp.Clear(); 
            lbSeries.Items.Clear ();
            series1.Reset();
        }
    }
}