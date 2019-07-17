using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ProgressBar.xaml
    /// </summary>
    public partial class ProgressBar : UserControl
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        #region dp double Value
        public double Value
        {
            get { return (double)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                "Value", typeof(double), typeof(ProgressBar),
                new PropertyMetadata(0.0, (o, args) => ((ProgressBar)o).UpdateValues()));
        #endregion

        #region dp double Maximum
        public double Maximum
        {
            get { return (double)GetValue(MaximumProperty); }
            set { SetValue(MaximumProperty, value); }
        }

        public static readonly DependencyProperty MaximumProperty =
            DependencyProperty.Register(
                "Maximum", typeof(double), typeof(ProgressBar),
                new PropertyMetadata(100.0, (o, args) => ((ProgressBar)o).UpdateValues()));
        #endregion

        void UpdateValues()
        {
            var ratio = Maximum <= 0 ? 0.0 : Value / Maximum;
            if (ratio < 0)
                ratio = 0;
            if (ratio > 1)
                ratio = 1;
            LeftColumn.Width = new GridLength(ratio, GridUnitType.Star);
            RightColumn.Width = new GridLength(1 - ratio, GridUnitType.Star);
        }
    }
}
