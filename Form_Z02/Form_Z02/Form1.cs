using System;
using System.Windows.Forms;

namespace Form_Z02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBoxPointX.Text);
                int y = Convert.ToInt32(textBoxPointY.Text);

                if (y == -100 || y == (-1) * Math.Abs(x))
                {
                    textBoxResult.Text = "Точка " + x + "," + y + " на границе";
                }
                else if (y > -100 && y < 0 && y < (-1) * Math.Abs(x))
                {
                    textBoxResult.Text = "Точка " + x + "," + y + " внутри";
                }
                else
                {
                    textBoxResult.Text = "Точка " + x + "," + y + " вне";
                }   
            }
            catch (Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
        }
    }
}
