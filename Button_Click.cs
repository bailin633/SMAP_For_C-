using System.Windows;

namespace SMAF
{
    internal class Button_Click
    {
        private static SettingsWindow? settingsWindow;

        public static void Setting_Click(object sender, RoutedEventArgs e)
        {
            // 检查窗口是否已打开
            if (settingsWindow == null || !settingsWindow.IsVisible)
            {
                settingsWindow = new SettingsWindow();
                settingsWindow.Show();
            }
            else
            {
                // 如果窗口已打开，可以选择激活窗口
                settingsWindow.Activate();
            }
        }
    }
}
