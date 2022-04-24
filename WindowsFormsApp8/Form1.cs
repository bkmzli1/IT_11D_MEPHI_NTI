using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        List<Rectangle> MyRect;

        public Form1()
        {
            InitializeComponent();
            MyRect = new List<Rectangle>();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Point startCenter = new Point(200, 0);  // центр первой окружности
            float startRadius = 10;                  // радиус первой окружности
            float increaseRadiusPercent = 50;       // изменение радиуса следующей окружности в процентах
            int ellipsesAmount = 8;                 // кол-во нарисованных окружностей
 
 
            // запуск рекурсии по рисованию окружностей
            DrawEllipseRequrse(startCenter, startRadius, increaseRadiusPercent, ellipsesAmount);
        }

        private int x2 = 1;

        private void AddEllipse(int angel)
        {
            int x1 = angel*2;
            angel += 20;
            if (angel != 0)
            {
                MyRect.Add(new Rectangle(x1 , x1, angel, angel));
            }


            if (angel <= 20 * 5)

                AddEllipse(angel);
        }
      
 
        // рекурсивный метод, который рисует заданное кол-во соприкасающихся окружностей, изменяющие свой радиус в процентах.
        private void DrawEllipseRequrse(PointF center, float radius, float increaseRadiusPercent, int amount)
        {
            // рисует окружность
            DrawEllipse(center, radius);
 
 
            // рисуем следующую окружность, если их кол-во ещё больше единицы 
            if (amount > 1)
            {
                // находим центр для следующей окружности
                PointF newCenter = new PointF(center.X + radius, center.Y);
 
                // изменяем радиус следующей окружности
                radius += (radius / 100) * increaseRadiusPercent;
 
                // ещё раз корректируем центр для следующей окружности, учитывая НОВЫЙ радиус новой окружности
             
 
 
                // рисуем новую окружность
                
                DrawEllipseRequrse(newCenter, radius, increaseRadiusPercent, amount - 1);
            }
 
        }
 
        // Метод рисует окружность, принимая её центр и радиус.
        private void DrawEllipse(PointF center, float radius)
        {
            Graphics g = CreateGraphics();
            g.DrawEllipse(Pens.Black,
                            center.X - radius,
                            (int)(-(center.Y - radius)/0.5),
                            radius * 2,
                            radius * 2);
            g.Dispose();
        }
    }
    }
