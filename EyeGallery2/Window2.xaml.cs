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
using System.Windows.Shapes;

namespace EyeGallery2
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        int i = 0;
        public Window2()
        {
            InitializeComponent();
        }

 

        private void nxtBtn_Click_1(object sender, RoutedEventArgs e)
        {
            i++;
            if (i>6)
            {
                i=1;
            }
            Image img = new Image();
            img.Source=new BitmapImage(new Uri(@"images/"+i + ".jpg", UriKind.Relative));
        }

        private void previousBtn_Click(object sender, RoutedEventArgs e)
        {
            i--;
            if (i>1)
            {
                i=6;
            }
            Image img = new Image();
            img.Source=new BitmapImage(new Uri(@"images/"+i + ".jpg", UriKind.Relative));
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
        }

        private void w2maxButton_Click(object sender, RoutedEventArgs e)
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

        private void w2minButton_Click(object sender, RoutedEventArgs e)
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

        private void w2Xbutton_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
