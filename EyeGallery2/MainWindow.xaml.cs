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

namespace EyeGallery2
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

        private void image1_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            ListBox listBox = new ListBox();


            w2.ShowDialog();
        }

        private void image2_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            ListBox listBox = new ListBox();


            w2.ShowDialog();
        }

        private void image3_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            ListBox listBox = new ListBox();


            w2.ShowDialog();
        }

        private void image4_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            ListBox listBox = new ListBox();


            w2.ShowDialog();
        }

        private void image5_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            ListBox listBox = new ListBox();


            w2.ShowDialog();
        }

        private void image6_Click(object sender, RoutedEventArgs e)
        {
            Window2 w2 = new Window2();
            ListBox listBox = new ListBox();


            w2.ShowDialog();
        }

        private void maxButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState==WindowState.Normal)
            {
                this.WindowState=WindowState.Maximized;
            }
            else if (this.WindowState==WindowState.Maximized)
            {
                this.WindowState=WindowState.Normal;
            }
        }

        private void minButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState==WindowState.Normal)
            {
                this.WindowState=WindowState.Minimized;
            }
            else if (this.WindowState==WindowState.Minimized)
            {
                this.WindowState=WindowState.Normal;
            }
        }

        private void Xbutton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
