using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace TimerWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       Stopwatch stopwatch;
       bool isTimerRun = false;
       Thread timerThread;



        public MainWindow()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();

        }


        void runTimer()
        {
            while(isTimerRun)
            {
                string timerText = stopwatch.Elapsed.ToString();
                // 00:00:00.000000 ==> 00:00:00
                timerText = timerText.Substring(0, 8);
              // this.timerTextBlock.Text = timerText;

                Action<string> action = setTextInvok;
               // Dispatcher.BeginInvoke(action, timerText);
                timerTextBlock.Dispatcher.BeginInvoke(action, timerText);
                Thread.Sleep(1000);
            }
        }

        void setTextInvok(string text) 
        { 
            this.timerTextBlock.Text = text;
          //  Thread.Sleep(1000);
        } 

        private void startTimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isTimerRun)
            {
                stopwatch.Restart();
                isTimerRun = true;

                timerThread = new Thread(runTimer);
                timerThread.Start();
               // runTimer();
            }
        }

        private void stopTimerButton_Click(object sender, RoutedEventArgs e)
        {
            if (isTimerRun)
            {
                stopwatch.Stop();
                isTimerRun = false;
            }
        }
    }
}
