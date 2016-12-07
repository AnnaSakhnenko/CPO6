using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPO6
{
    public partial class Form1 : Form
    {
        List<string> ind = new List<string>() { "+", "-", "*", "/", "=", ";", "(", ")", "int", "double" };
        List<string> type = new List<string>() { "Знак операций", "Знак операций", "Знак операций", "Знак операций", "Знак присваивания", "Разделитель", "Скобка", "Скобка", "Тип данных", "Тип данных" };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            if(textBox1.Text != "")
            {
                string[] info = textBox1.Text.Trim().Replace("*", " * ").Replace("/", " / ").Replace("(", " ( ").Replace(")", " ) ").Replace("=", " = ").Replace("+", " + ").Replace("-", " - ").Replace("  ", " ").Split(' ');

                for(int i = 0; i < info.Length; i++)
                {
                    int res;
                    bool isInt = Int32.TryParse(info[i], out res);

                    if(isInt)
                    {
                        textBox2.Text += "'" + info[i] + "' - Число" + Environment.NewLine;
                    }
                    else
                    {
                        int index = ind.IndexOf(info[i]);

                        if(index != -1)
                        {
                            textBox2.Text += "'" + info[i] + "' - " + type[index] + Environment.NewLine;
                        }
                        else
                        {
                            textBox2.Text += "'" + info[i] + "' - Идентификатор" + Environment.NewLine;
                        }
                    }
                }
            }
        }
    }
}
