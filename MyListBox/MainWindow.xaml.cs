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
        public class Calculate
        {
            public double xStart { get; set; }
            public double xStop { get; set; }
            public double step { get; set; }
            public double n { get; set; }  

        }
        
        Calculate calculate;
        public MainWindow()
        {
            InitializeComponent();
            calculate = new Calculate();
            grid.DataContext = calculate;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}