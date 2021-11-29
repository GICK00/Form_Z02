using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Form_Z02_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string data = Convert.ToString(textBoxData.Text);
            int mouthPast = Convert.ToInt32(textBoxMouthPast.Text);

            Regex reg = new Regex(@"\d{1,4}");
            Match n = reg.Match(data);

            try
            {
                int day = Convert.ToInt32(Convert.ToString(n));
                n = n.NextMatch();
                int month = Convert.ToInt32(Convert.ToString(n));
                n = n.NextMatch();
                int year = Convert.ToInt32(Convert.ToString(n));
                n = n.NextMatch();

                if((day.ToString().Length == 2 || day.ToString().Length == 1) && (month.ToString().Length == 2 || month.ToString().Length == 1) && (year.ToString().Length == 4) && day > 0 && day <= 31 && month <= 12 && month > 0)
                {
                    while (mouthPast > 0)
                    {
                        month--;
                        if (month <= 0)
                        {
                            month = 12;
                            year--;
                        }
                        mouthPast--;
                    }

                    string TxTmonthLost = "";
                    switch (month)
                    {
                        case 01:
                            TxTmonthLost = "Января";
                            break;
                        case 02:
                            TxTmonthLost = "Февраля";
                            break;
                        case 03:
                            TxTmonthLost = "Марта";
                            break;
                        case 04:
                            TxTmonthLost = "Апреля";
                            break;
                        case 05:
                            TxTmonthLost = "Мая";
                            break;
                        case 06:
                            TxTmonthLost = "Июня";
                            break;
                        case 07:
                            TxTmonthLost = "Июля";
                            break;
                        case 08:
                            TxTmonthLost = "Августа";
                            break;
                        case 09:
                            TxTmonthLost = "Сентября";
                            break;
                        case 10:
                            TxTmonthLost = "Октября";
                            break;
                        case 11:
                            TxTmonthLost = "Ноября";
                            break;
                        case 12:
                            TxTmonthLost = "Декабря";
                            break;
                    }
                    string result = "Старая дата: " + day + " " + TxTmonthLost + " " + year;
                    textBoxResult.Text = Convert.ToString(result);
                }
                else
                {
                    textBoxResult.Text = "Некорректный ввод данных!";
                }
            }
            catch(Exception)
            {
                textBoxResult.Text = "Некорректный ввод данных!";
            }
        }
    }
}
