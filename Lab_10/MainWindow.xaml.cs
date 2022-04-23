using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Shapes;
using MouseEventArgs = System.Windows.Input.MouseEventArgs;

namespace Lab_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        System.Drawing.Color _color1 = System.Drawing.Color.Blue;
        System.Drawing.Color _color2 = System.Drawing.Color.Orange;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void enterMR(object sender, MouseEventArgs e)
        {
            Rectangle resource = (Rectangle) sender;
            Color color = Color.FromScRgb(1, _color2.R, _color2.G, _color2.B);
            resource.Fill =  new SolidColorBrush(color);
        }

        private void leaveMR(object sender, MouseEventArgs e)
        {
            Rectangle resource = (Rectangle) sender;
            Color color = Color.FromScRgb(1, _color1.R, _color1.G, _color1.B);
            resource.Fill = new SolidColorBrush(color);
        }

        private void leaveME(object sender, MouseEventArgs e)
        {
            Path gradientStop = (Path) sender;
            gradientStop.Fill = new SolidColorBrush(Color.FromScRgb(1, _color1.R, _color1.G, _color1.B));
        }

        private void enterME(object sender, MouseEventArgs e)
        {
            Path gradientStop = (Path) sender;
            gradientStop.Fill = new SolidColorBrush(Color.FromScRgb(1, _color2.R, _color2.G, _color2.B));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ColorDialog fontDialog = new ColorDialog();
            fontDialog.ShowDialog();
            var fontDialogColor = fontDialog.Color;
            _color1 = fontDialogColor;
        }

        private void ButtonBase_OnClick2(object sender, RoutedEventArgs e)
        {
            ColorDialog fontDialog = new ColorDialog();
            fontDialog.ShowDialog();
            var fontDialogColor = fontDialog.Color;
            _color2 = fontDialogColor;
        }
    }
}