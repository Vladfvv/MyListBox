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
            private int n;


            public int N
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
            



            double summa = 0;
            //results.Clear();
            values.xStart = 0;//не нужно обнулять
            values.xStop = 0;//не нужно обнулять
            values.step = 0;//не нужно обнулять
            values.N = 0;//не нужно обнулять
            values.xStart = double.Parse(xStart.Text);// задайте переменные name и туда спрарсите значение из xStart
            values.xStop = double.Parse(xStop.Text);// задайте переменные name и туда спрарсите значение из xStop
            values.step = int.Parse(step.Text);// задайте переменные name и туда спрарсите значение из step
            values.N = int.Parse(n.Text);// задайте переменные name и туда спрарсите значение из n
            

            for (var k = 1; k <= values.N; k++)//должно быть два цикла (внешний и внутренний). Во внешнем идет вычисления значения Y(x) и запись значение Y(x) , S(x) в results. Во внутреннем происходит вычисление S(x) на нсновании k и n. Каждый раз в конце выполнения внешнего цикла переменыые, отвечающие за "накопление" значений (S(x), Y(x)) должны обнуляться. 
            {
                double y = -0.5 * (Math.Log(1 - 2 * values.xStart * Math.Cos(Math.PI / 3) + Math.Pow(values.xStart, 2)));
                summa += Math.Round((Math.Pow(values.xStart, k) * Math.Cos(k * Math.PI / 3)) / 3, 2);                
                results.Add("S(" + k + ") = " + summa + "  y(" + k + ") = " + y);
                values.xStart += values.step;
            }         
        }
    }
}
