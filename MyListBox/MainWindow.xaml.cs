using System.Collections.ObjectModel;
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

namespace MyListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<String> result;
        public class Calculate
        {
            public double xStart { get; set; }
            public double xStop { get; set; }
            public int step { get; set; }
            private int n;
        

        public int N
            {
                get { return n; }
                set
                {
                    if (value < 5) { throw new ArgumentException("Value must be greater than 5"); }
                }
            }

        }
        Calculate calculate;
        public MainWindow()
        {
            InitializeComponent();
            calculate = new Calculate();
            grid.DataContext = calculate;
        }

    }
}