using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfCustomControlTest
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            //ObservableCollection<ProgressBar> collection = new ObservableCollection<ProgressBar>();
            //ProgressBar bar = new ProgressBar();
            //collection.Add(bar);

            //TimerList.ItemsSource = collection;
            //TimerList.MouseDoubleClick += doubleClickEventHandler;

        }

        private void doubleClickEventHandler(object sender, MouseButtonEventArgs e)
        {
            ObservableCollection<ProgressBar> collection = new ObservableCollection<ProgressBar>();
            ProgressBar bar = new ProgressBar() { Width = 50, Height = 30 };
            collection.Add(bar);

            TimerList.ItemsSource = collection;
        }

        private void Grid_DragEnter(object sender, DragEventArgs e)
        {
           
            
        }

     
    }
}
