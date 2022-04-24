using System;
using System.Windows;

namespace WpfApplication4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
           
            InitializeComponent();
            RandomClik(null, null);

        }
        

        private void RandomClik(object sender, RoutedEventArgs e)
        {
            ListBoxIn.Items.Clear();;
            ListBoxOut.Items.Clear();;
            Random rnd = new Random();
            for (int i = 0; i < 25; i++)
            {
                int next = rnd.Next(-100, 100);
                ListBoxIn.Items.Add(next );
                if (next<0)
                {
                    ListBoxOut.Items.Add(next * next);
                }
                else if (next!= 0)
                {
                    ListBoxOut.Items.Add(next + 7);
                }
               
            }
        }
    }
}