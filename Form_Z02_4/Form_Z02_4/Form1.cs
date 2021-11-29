using System;
using System.Windows.Forms;

namespace Form_Z02_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int stroka = 5;
            int probel = 0;
            for (int i = 8; i > 3; i--)
            {
                textBoxResult.Text = textBoxResult.Text + "|";
                for (int j = 0; j < stroka; j++)
                {
                    textBoxResult.Text = textBoxResult.Text + "  " + i;
                }
                for (int n = 0; n < probel; n++)
                {
                    textBoxResult.Text = textBoxResult.Text + "    ";
                }
                stroka--;
                probel++;
                textBoxResult.Text = textBoxResult.Text + " |" + "\r\n";
            }
        }
    }
}
