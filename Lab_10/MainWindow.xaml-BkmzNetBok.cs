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
        Color _color1 = Colors.Blue;
        Color _color2 = Colors.Orange;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void enterMR(object sender, MouseEventArgs e)
        {
            Rectangle resource = (Rectangle) sender;
            resource.Fill = new SolidColorBrush(_color1);
        }

        private void leaveMR(object sender, MouseEventArgs e)
        {
            Rectangle resource = (Rectangle) sender;
            resource.Fill = new SolidColorBrush(_color2);
        }

        private void leaveME(object sender, MouseEventArgs e)
        {
            Path gradientStop = (Path) sender;
            gradientStop.Fill = new SolidColorBrush(_color2);
        }

        private void enterME(object sender, MouseEventArgs e)
        {
            Path gradientStop = (Path) sender;
            gradientStop.Fill = new SolidColorBrush(_color1);
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            ColorDialog fontDialog = new ColorDialog();
            fontDialog.ShowDialog();
            var fontDialogColor = fontDialog.Color;
            var button = new Button();
            button.ForeColor =  System.Drawing.Color.Red;;
            _color1 = button.ForeColor;
        }
    }
}