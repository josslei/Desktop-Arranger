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
using Desktop_Arranger;

namespace Desktop_Arranger
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Set initial location
            double ScreenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            this.Top = 40.0;
            this.Left = ScreenWidth - this.Width - 10.0;
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            Helper.WindowsHelper.setWindowsBottom(this);
        }

        protected override void OnStateChanged(EventArgs e)
        {
            base.OnStateChanged(e);
            Helper.WindowsHelper.setWindowsBottom(this);
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
