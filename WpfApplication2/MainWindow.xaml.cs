using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Lab_8._2.MyElement;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private IList _list; //лист содержащиё элементы выражения
        Dictionary<string, TextBox> _uiElements = new Dictionary<string, TextBox>();

        public MainWindow()
        {
            _list = new List<UIElement>();


            InitializeComponent();
            _uiElements.Clear();
            clearGrid();

            createElements("X0", 0, 0,5.3D);
            createElements("Xk", 0, 1,10.3D);
            createElements("dx", 0, 2,0.25D);
            createElements("a", 0, 3,1.35D);
            createElements("b", 0, 4,-6.25D);
        }
        private void clearGrid()
        {
            foreach (UIElement element in _list)
            {
                gridRoot.Children.Remove(element);
            }

            _list.Clear();
        }
        private void Сalculation(object sender, RoutedEventArgs e)
        {
            answer.Content = "Ответ:";
            double x0 = Convert.ToDouble(getValue("X0").Text);
            double xk= Convert.ToDouble(getValue("Xk").Text);
            double dx = Convert.ToDouble(getValue("dx").Text);
            double a = Convert.ToDouble(getValue("a").Text);
            double b = Convert.ToDouble(getValue("b").Text);
     
            for (double x = Convert.ToDouble(getValue("X0").Text); x <= Convert.ToDouble(getValue("Xk").Text); x += Convert.ToDouble(getValue("dx").Text))
            {
                double d=  Convert.ToDouble(getValue("a").Text)*(x*x*x)+Math.Cos(x*x*x-Convert.ToDouble(getValue("b").Text));
                answer.Content +="x="+x+" y="+ Convert.ToString(d) + "\n";
            }
        }
        private void createElements(string name, int h, int w,String value)
        {
            var myGrid = new MyLabelTextBox(name,value);
            Grid.SetRow(myGrid, h);
            Grid.SetColumn(myGrid, w);
            gridRoot.Children.Add(myGrid);
            _uiElements.Add(name, myGrid.TextBox);
            _list.Add(myGrid);
        }

        private void createElements(string name, int h, int w, double value)
        {
            createElements(name, h, w, Convert.ToString(value));
        }

        private void createElements(string name, int h, int w)
        {
            createElements(name, h, w, "");
        }
        
        
        private TextBox getValue(string s)
        {
            foreach (var element in _uiElements)
            {
                if (s.Equals(element.Key))
                    return element.Value;
            }

            return null;
        }
    }
}