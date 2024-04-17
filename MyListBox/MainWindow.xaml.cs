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
using static MyListBox.MainWindow;

namespace MyListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<String> results;
        public class Values
        {
            public double xStart { get; set; }
            public double xStop {  get; set; }  
            public int step { get; set; }
            private double n;


            public double N
            {
                get { return n; }
                set
                {
                    //if (value < 5)  throw new ArgumentException("Value must be greater than 5"); 
                    n = value;
                }
            }

        }
        Values values;


        public MainWindow()
        {
            InitializeComponent();
            values = new Values();
            grid.DataContext = values;
            results = new ObservableCollection<string>();
            lResults.DataContext = results;
        }

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            //if ((values.xStop - values.xStart + 1) / values.step != values.N) throw new ArgumentException("Check your numbers");
            //double summa = 0;
            //results.Clear();
            //values.xStart = 0;
            //values.xStop = 0;
            //values.step = 0;
            //values.N = 0;
            double start = double.Parse(xStart.Text);
            double stop = double.Parse(xStop.Text);
            double myStep = double.Parse(step.Text);
            double iterator = double.Parse(n.Text);
            double s = 0;
            double y = 0;
            for (var x = start; x < stop; x += myStep )
            {
               
               
                for (var k = 1.0; k <= iterator; k += 0.1)
                {                    
                    s += (Math.Pow(x, k) * Math.Cos(k * Math.PI / 3)) / k;                                      
                }
                //y = -0.5 * (Math.Pow(Math.E, (1 - 2 * x * Math.Cos(Math.PI / 3) + Math.Pow(x, 2))));
                y = -0.5 * (Math.Log(1 - 2 * x * Math.Cos(Math.PI / 3) + Math.Pow(x, 2)));
                results.Add("S(" + x + ") = " + s + "  y(" + x + ") = " + y);
                s = 0;
                y = 0;
            }         
        }  
    }
}