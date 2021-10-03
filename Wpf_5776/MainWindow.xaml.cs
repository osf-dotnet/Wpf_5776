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

namespace Wpf_5776
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         //   this.Addbutton.MouseEnter += Addbutton_MouseEnter;

           // MessageBox.Show("dasda");
        }

        private void myCanvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
                MouseButton mb = e.ChangedButton;
                Rectangle r = new Rectangle();
                r.Width = 100;
                r.Height = 50;

                switch (mb)
                {
                    case MouseButton.Left:
                        r.Fill = Brushes.Blue;
                        break;
                    case MouseButton.Middle:
                        r.Fill = Brushes.Red;
                        break;
                    case MouseButton.Right:
                        r.Fill = Brushes.Pink;
                        break;

                    case MouseButton.XButton1:
                        break;
                    case MouseButton.XButton2:
                        break;
                    default:
                        break;
                }


                myCanvas.Children.Add(r);

                Point p = Mouse.GetPosition(myCanvas);

                Canvas.SetTop(r, p.Y);
                Canvas.SetLeft(r, p.X);
         




        }

       

    }
}
