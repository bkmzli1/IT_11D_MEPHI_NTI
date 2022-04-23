using System.Windows.Controls;

namespace Lab_8._2.MyElement
{
    public class MyLabel : Label
    {
        private int ID;

        public int Id
        {
            get => ID;
            set => ID = value;
        }
    }
}