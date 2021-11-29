using System;
using System.Windows.Forms;

namespace Form_Z02_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResultWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxA.Text);
                int b = Convert.ToInt32(textBoxB.Text);
                int x = Convert.ToInt32(textBoxX.Text);

                if (a < b && (x.ToString().Length == 1 && x >= 0))
                {
                    NumberWhile(a, b, x);
                }
                else
                {
                    textBoxResult.Text = "A должно быть меньше B и X должно быть больше 0";
                }
            }
            catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
        }

        private void buttonResultDoWhile_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxA.Text);
                int b = Convert.ToInt32(textBoxB.Text);
                int x = Convert.ToInt32(textBoxX.Text);

                if (a < b && (x.ToString().Length == 1 && x >= 0))
                {
                    NumberDoWhile(a, b, x);
                }
                else
                {
                    textBoxResult.Text = "A должно быть меньше B и X должно быть больше 0";
                }
            }
            catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
        }

        private void buttonResultFor_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBoxA.Text);
                int b = Convert.ToInt32(textBoxB.Text);
                int x = Convert.ToInt32(textBoxX.Text);

                if (a < b && (x.ToString().Length == 1 && x >= 0))
                {
                    NumberFor(a, b, x);
                }
                else
                {
                    textBoxResult.Text = "A должно быть меньше B и X должно быть больше 0";
                }
            }
            catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
        }

        private void NumberWhile(int a, int b, int x) {
            int numberWhile = a;
            while (numberWhile <= b)
            {
                if (Math.Abs(numberWhile) % 10 == x)
                {
                    textBoxResult.Text = textBoxResult.Text + numberWhile + "\r\n ";
                }
                ++numberWhile;
            }
        }

        private void NumberDoWhile(int a, int b, int x)
        {
            int numberDoWhile = a;
            do
            {
                if (Math.Abs(numberDoWhile) % 10 == x)
                {
                    textBoxResult.Text = textBoxResult.Text + numberDoWhile + "\r\n ";
                }
                ++numberDoWhile;
            } while (numberDoWhile <= b);
        }

        private void NumberFor(int a, int b, int x)
        {
            int numberFor = a;
            for (int i = numberFor; i < b; i++)
            {
                if (Math.Abs(i) % 10 == x)
                {
                    textBoxResult.Text = textBoxResult.Text + i + "\r\n ";
                }
            }
        }

        private void buttonClaer_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
    }
}
