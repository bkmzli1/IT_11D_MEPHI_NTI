using System;
using System.Windows;
using System.Windows.Controls;

namespace Lab_8._2.MyElement
{
    public class MyLabelTextBox : Grid
    {
        Label _label = new Label();
        TextBox _textBox = new TextBox();

        public MyLabelTextBox(String s, string value)
        {
            constr(s,value);
        }

        public MyLabelTextBox(string name)
        {
           constr(name,"");
        }

        private void constr(String s, string value)
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

            _textBox.MinWidth = 100;
            _textBox.SelectedText = value;
            _textBox.Margin = new Thickness(5, 5, 5, 5);
            _label.Margin = new Thickness(5, 5, 5, 5);
            
            SetRow(_label, 0);
            SetColumn(_label, 0);
            SetRow(_textBox, 0);
            SetColumn(_textBox, 1);
            Children.Add(_label);
            Children.Add(_textBox);
        }
        
        
        

        public Label Label
        {
            get => _label;
            set => _label = value;
        }

        public TextBox TextBox
        {
            get => _textBox;
            set => _textBox = value;
        }
    }
}