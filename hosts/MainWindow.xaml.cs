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

namespace hosts
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string hostsPath = "";

        public MainWindow()
        {
            InitializeComponent();
            initHostsPath();
        }

        private void textBox_Loaded(object sender, RoutedEventArgs e)
        {
            string text = System.IO.File.ReadAllText(hostsPath);
            textBox.Text = text;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText(hostsPath, textBox.Text);
            button.Content = "Success";
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            button.Content = "Save";
        }

        private void initHostsPath()
        {
            hostsPath = @Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\drivers\etc\hosts";
        }
    }
}
