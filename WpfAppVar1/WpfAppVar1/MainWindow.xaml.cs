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

namespace WpfAppVar1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void ClickS(object sender, RoutedEventArgs e)
        {
            double A = Convert.ToDouble(StorA.Text);
            double B = Convert.ToDouble(StorB.Text);
            double C = Convert.ToDouble(StorC.Text);
            PolyP.Text = ((A + B + C) / 2).ToString();
            double P = Convert.ToDouble(PolyP.Text);
            Plosh.Text = ((P - A)*(P - B)).ToString();
        }

        private void ClickClear(object sender, RoutedEventArgs e)
        {
            StorA.Clear();
            StorB.Clear();
            StorC.Clear();
            PolyP.Text = null;
            Plosh.Text = null;
        }
    }
}
