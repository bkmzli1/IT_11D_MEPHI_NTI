using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab_8._2.MyElement
{
    public class MyLabelComboBox : Grid
    {
        Label _label = new Label();
        ComboBox _comboBox = new ComboBox();

        public MyLabelComboBox(String s)
        {
            ColumnDefinition columnDefinition = new ColumnDefinition();
            ColumnDefinition columnDefinition2 = new ColumnDefinition();
            RowDefinition rowDefinition = new RowDefinition();
            RowDefinition rowDefinition2 = new RowDefinition();
            ColumnDefinitions.Add(columnDefinition);
            ColumnDefinitions.Add(columnDefinition2);
            RowDefinitions.Add(rowDefinition);
            RowDefinitions.Add(rowDefinition2);


            _label.Content = s;

            _comboBox.MinWidth = 100;
            _comboBox.Margin = new Thickness(5, 5, 5, 5);;
            _label.Margin = new Thickness(5, 5, 5, 5);;

            SetRow(_label, 0);
            SetColumn(_label, 0);
            SetRow(_comboBox, 0);
            SetColumn(_comboBox, 1);

            for (int i = 1; i < 99; i++)
            {
                _comboBox.Items.Add(Convert.ToString(i));
            }


            Children.Add(_label);
            Children.Add(_comboBox);
        }

        public Label Label
        {
            get => _label;
            set => _label = value;
        }

        public ComboBox TextBox
        {
            get => _comboBox;
            set => _comboBox = value;
        }
    }
}