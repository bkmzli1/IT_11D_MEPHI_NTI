using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Lab_8._2.MyElement;

namespace Lab_8._2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private IList _list; //лист содержащиё элементы выражения
        private int _idMethod;
        Dictionary<string, TextBox> _uiElements = new Dictionary<string, TextBox>();

        public MainWindow()
        {
            _list = new List<UIElement>();


            InitializeComponent();
        }

        private void Type_Metod(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox) sender;
            MyLabel label = (MyLabel) comboBox.SelectedItem;
            _idMethod = label.Id;
            if (label.Id == 0)
            {
                methodOneModel();
            }
            else
            {
                methodTwoModel();
            }
        }

        private void methodOneModel()
        {
            _uiElements.Clear();
            clearGrid();

            createElements("X", 1, 0);
            createElements("Y", 1, 1);
            createElements("N", 1, 2);
        }


        private void methodTwoModel()
        {
            _uiElements.Clear();
            clearGrid();
            createElements("A", 1, 0);
            createElements("B", 1, 1);
            createElements("C", 1, 2);
            createElements("R", 2, 0);
            createElements("N", 2, 1);
        }


        private void createElements(string s, int h, int w)
        {
            var myGrid = new MyLabelTextBox(s);
            Grid.SetRow(myGrid, h);
            Grid.SetColumn(myGrid, w);
            gridRoot.Children.Add(myGrid);
            _uiElements.Add(s, myGrid.TextBox);
            _list.Add(myGrid);
        }

        private double methodOne(double y, double x, int n)
        {
            double s = 0;
            double j = 2;
            double k = 1;
            for (int i = 0; i < n; i++)
            {
                double g = Math.Pow(-1, i + 1);
                if (i % 3 != 0)
                {
                    k *= j;
                    j++;
                    s += (Math.Pow(y, i + 1) / k) * Math.Pow(-1, i + 1);
                }
                else
                {
                    k *= j;
                    j++;
                    s += (Math.Pow(x, i + 1) / k) * Math.Pow(-1, i + 1);
                }
            }

            return s;
        }

        private double methodTwo(int N, int R, double a, double b, double c)
        {
            double s = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    s += ((a * i) + (b * j)) / (c * Math.Pow(i, j));
                }
            }

            return s;
        }

        private void clearGrid()
        {
            foreach (UIElement element in _list)
            {
                gridRoot.Children.Remove(element);
            }

            _list.Clear();
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

        private void Сalculation(object sender, RoutedEventArgs e)
        {
            if (_idMethod == 0)
            {
                answer.Content = Convert.ToString(methodOne(Convert.ToDouble(getValue("Y").Text),
                    Convert.ToDouble(getValue("X").Text),
                    Convert.ToInt32(getValue("N").Text)));
            }
            else
            {
                answer.Content = Convert.ToString(methodTwo(Convert.ToInt32(getValue("N").Text),
                    Convert.ToInt32(getValue("R").Text),
                    Convert.ToDouble(getValue("A").Text), Convert.ToDouble(getValue("B").Text),
                    Convert.ToDouble(getValue("C").Text)));
            }
        }
    }
}