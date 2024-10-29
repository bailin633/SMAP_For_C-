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

namespace SMAF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Setting.Click += Button_Click.Setting_Click;
        }
     

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            // 创建 PerformanceCounter 对象，监测总 CPU 使用率
            PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            //首次调用Nextvalue
            cpuCounter.NextValue();
            Thread.Sleep(90);
            float cpuUsage = cpuCounter.NextValue();
            // 日志信息
            string logMessage = $"CPU使用率: "+cpuUsage;

            // 将日志信息追加到 TextBox
            LogTextBox.AppendText(logMessage + Environment.NewLine);

            // 让 TextBox 自动滚动到底部
            LogTextBox.ScrollToEnd();
        }
        private void Clear_B(object sender, RoutedEventArgs e)
        { 
            LogTextBox.Clear();
        
        }
    }
}