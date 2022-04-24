using System.Windows.Controls;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            textBoxIn.TextChanged += TextBoxBase_OnTextChanged;
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            labelOut.Content = "";
            TextBox textBox = (TextBox) sender;
            string textBoxText = textBox.Text;
            for (int i = 0; i < textBoxText.Length; i++)
            {
                if ((textBoxText[i]>= '0' && textBoxText[i] <='9'))
                {
                    labelOut.Content += textBoxText[i].ToString();
                }
            }
        }
    }
}