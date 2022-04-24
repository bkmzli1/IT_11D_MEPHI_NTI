using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var rand = new Random();
            for (int i = 0; i < sizeBox-1; i++)
            {
                int k = 0;
                for (int j = 0; j < sizeBox; j++)
                {
        
                    var next = rand.Next(0,10);
                    k += next;
                    try
                    {
                        if (j == 15)
                        {
                            dataGridView1.Rows[i].Cells[j].Value = $"строка:{i}, среднеее арф.{(k/15)}" ;
                            dataGridView1.Columns[j].Width = 1000;
                         
                        }
                        else
                        {
                            dataGridView1.Rows[i].Cells[j].Value = next.ToString();
                        }
                        
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine(i+":"+j);
                    }
                   
                }
            }
        }
    }
}