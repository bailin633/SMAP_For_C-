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
using System;
using System.Diagnostics;
using System.Threading;
using System.Net;
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Windows.Threading;
using System.Timers;

namespace SMAF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DispatcherTimer _timer;
        private PerformanceCounter _cpucounter;

        public MainWindow()
        {
            InitializeComponent();
            // 设置窗口居中
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //引用
            Setting.Click += Button_Click.Setting_Click;
            //初始化性能计数器
            _cpucounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            // 初始化定时器
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(5);
            _timer.Tick += Timer_Tick;
            _timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            // 获取CPU占用率
            float cpuUsage = _cpucounter.NextValue();
            LogTextBox.AppendText($"CPU Usage: {cpuUsage}%\n");
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("11111", "标题", MessageBoxButton.OK, MessageBoxImage.Information);

        }
        private void Clear_B(object sender, RoutedEventArgs e)
        { 
            LogTextBox.Clear();
        
        }
    }
}