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

namespace Do_U_love_me
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Love U too");
            this.Close();
        }

        private void Button2_MouseEnter(object sender, MouseEventArgs e)
        {
            //Give this Button a new coordinate
            //The Button must be in this window
            double x = this.Width - 2 * Button2.Width;
            double y = this.Height - 2 * Button2.Height;

            Random r = new Random();
            //random coord
            Button2.Margin = new Thickness(r.Next(0, (int)x + 1), r.Next((int)y + 1), 0, 0);
            //new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }
    }
}
