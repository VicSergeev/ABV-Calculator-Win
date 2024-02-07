using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlcVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // vars
        double initDens;
        double finDens;
        double resultVol;

        double initDensValue;
        double finDensValue;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resultButton_Click(object sender, EventArgs e)
        {
             
            if (initDensBox.Text != string.Empty)
            {
                initDens = double.Parse(initDensBox.Text);
                if (initDens >= 0.50 && initDens <= 0.99)
                {
                    initDensValue = 0.0;
                }
                else if (initDens >= 1.0 && initDens <= 1.49)
                {
                    initDensValue = 0.25;
                }
                else if (initDens >= 1.5 && initDens <= 1.99)
                {
                    initDensValue = 0.50;
                }
                else if (initDens >= 2.0 && initDens <= 2.49)
                {
                    initDensValue = 0.75;
                }
                else if (initDens >= 2.50 && initDens <= 2.99)
                {
                    initDensValue = 1.0;
                }
                else if (initDens >= 3.0 && initDens <= 3.49)
                {
                    initDensValue = 1.25;
                }
                else if (initDens >= 3.5 && initDens <= 3.99)
                {
                    initDensValue = 1.5;
                }
                else if (initDens >= 4.0 && initDens <= 4.49)
                {
                    initDensValue = 1.75;
                }
                else if (initDens >= 4.5 && initDens <= 4.99)
                {
                    initDensValue = 2.0;
                }
                else if (initDens >= 5.0 && initDens <= 5.49)
                {
                    initDensValue = 2.25;
                }
                else if (initDens >= 5.50 && initDens <= 5.99)
                {
                    initDensValue = 2.5;
                }
                else if (initDens >= 6.0 && initDens <= 6.49)
                {
                    initDensValue = 2.75;
                }
                else if (initDens >= 6.5 && initDens <= 6.99)
                {
                    initDensValue = 3.0;
                }
                else if (initDens >= 7.0 && initDens <= 7.49)
                {
                    initDensValue = 3.25;
                }
                else if (initDens >= 7.5 && initDens <= 7.99)
                {
                    initDensValue = 3.5;
                }
                else if (initDens >= 8.0 && initDens <= 8.49)
                {
                    initDensValue = 3.75;
                }
                else if (initDens >= 8.5 && initDens <= 8.99)
                {
                    initDensValue = 4.0;
                }
                else if (initDens >= 9.0 && initDens <= 9.49)
                {
                    initDensValue = 4.25;
                }
                else if (initDens >= 9.50 && initDens <= 9.87)
                {
                    initDensValue = 4.5;
                }
                else if (initDens >= 9.88 && initDens <= 10.24)
                {
                    initDensValue = 4.75;
                }
                else if (initDens >= 10.25 && initDens <= 10.74)
                {
                    initDensValue = 5.0;
                }
                else if (initDens >= 10.75 && initDens <= 11.24)
                {
                    initDensValue = 5.25;
                }
                else if (initDens >= 11.25 && initDens <= 11.74)
                {
                    initDensValue = 5.5;
                }
                else if (initDens >= 11.75 && initDens <= 12.24)
                {
                    initDensValue = 5.75;
                }
                else if (initDens >= 12.25 && initDens <= 12.74)
                {
                    initDensValue = 6.0;
                }
                else if (initDens >= 12.75 && initDens <= 13.24)
                {
                    initDensValue = 6.25;
                }
                else if (initDens >= 13.25 && initDens <= 13.37)
                {
                    initDensValue = 6.5;
                }
                else if (initDens >= 13.38 && initDens <= 13.99)
                {
                    initDensValue = 6.75;
                }
                else if (initDens >= 14.0 && initDens <= 14.49)
                {
                    initDensValue = 7.0;
                }
                else if (initDens >= 14.5 && initDens <= 14.99)
                {
                    initDensValue = 7.25;
                }
                else if (initDens >= 15.0 && initDens <= 15.37)
                {
                    initDensValue = 7.5;
                }
                else if (initDens >= 15.38 && initDens <= 15.74)
                {
                    initDensValue = 7.75;
                }
                else if (initDens >= 15.75 && initDens <= 16.24)
                {
                    initDensValue = 8.0;
                }
                else if (initDens >= 16.25 && initDens <= 16.74)
                {
                    initDensValue = 8.25;
                }
                else if (initDens >= 16.75 && initDens <= 17.24)
                {
                    initDensValue = 8.5;
                }
                else if (initDens >= 17.25 && initDens <= 17.74)
                {
                    initDensValue = 8.75;
                }
                else if (initDens >= 17.75 && initDens <= 18.49)
                {
                    initDensValue = 9.0;
                }
                else if (initDens >= 18.50 && initDens <= 18.74)
                {
                    initDensValue = 9.25;
                }
                else if (initDens >= 18.75 && initDens <= 19.12)
                {
                    initDensValue = 9.5;
                }
                else if (initDens >= 19.13 && initDens <= 19.49)
                {
                    initDensValue = 9.75;
                }
                else if (initDens >= 19.5 && initDens <= 19.99)
                {
                    initDensValue = 10.0;
                }
                else if (initDens >= 20.0 && initDens <= 20.49)
                {
                    initDensValue = 10.25;
                }
                else if (initDens >= 20.5 && initDens <= 20.99)
                {
                    initDensValue = 10.5;
                }
                else if (initDens >= 21.0 && initDens <= 21.49)
                {
                    initDensValue = 10.75;
                }
                else if (initDens >= 21.5 && initDens <= 21.99)
                {
                    initDensValue = 11.0;
                }
                else if (initDens >= 22.0 && initDens <= 22.49)
                {
                    initDensValue = 11.25;
                }
                else if (initDens >= 22.5 && initDens <= 23.12)
                {
                    initDensValue = 11.5;
                }
                else if (initDens >= 23.13 && initDens <= 23.24)
                {
                    initDensValue = 11.75;
                }
                else if (initDens >= 23.25 && initDens <= 23.74)
                {
                    initDensValue = 12.0;
                }
                else if (initDens >= 23.75 && initDens <= 24.24)
                {
                    initDensValue = 12.25;
                }
                else if (initDens >= 24.25 && initDens <= 24.49)
                {
                    initDensValue = 12.5;
                }
                else if (initDens >= 24.5 && initDens <= 24.99)
                {
                    initDensValue = 12.75;
                }
                else if (initDens >= 25.0 && initDens <= 25.49)
                {
                    initDensValue = 13.0;
                }
                else if (initDens >= 25.5 && initDens <= 25.99)
                {
                    initDensValue = 13.25;
                }
                else if (initDens >= 26.0 && initDens <= 26.49)
                {
                    initDensValue = 13.5;
                }
                else if (initDens >= 26.5 && initDens <= 26.74)
                {
                    initDensValue = 13.75;
                }
                else if (initDens >= 26.75 && initDens <= 27.24)
                {
                    initDensValue = 14.0;
                }
                else if (initDens >= 27.25 && initDens <= 27.74)
                {
                    initDensValue = 14.25;
                }
                else if (initDens >= 27.75 && initDens <= 28.19)
                {
                    initDensValue = 14.5;
                }
                else if (initDens >= 28.2 && initDens <= 28.79)
                {
                    initDensValue = 14.75;
                }
            }
            else
            {
                MessageBox.Show("Поле начальной плотности не должно быть пустым", "Ошибка нахуй", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (finDensBox.Text != string.Empty)
            {
                finDens = double.Parse(finDensBox.Text);
                // final density claculation

                if (finDens >= 0.50 && finDens <= 0.99)
                {
                    finDensValue = 0.0;
                }
                else if (finDens >= 1.0 && finDens <= 1.49)
                {
                    finDensValue = 0.25;
                }
                else if (finDens >= 1.5 && finDens <= 1.99)
                {
                    finDensValue = 0.50;
                }
                else if (finDens >= 2.0 && finDens <= 2.49)
                {
                    finDensValue = 0.75;
                }
                else if (finDens >= 2.50 && finDens <= 2.99)
                {
                    finDensValue = 1.0;
                }
                else if (finDens >= 3.0 && finDens <= 3.49)
                {
                    finDensValue = 1.25;
                }
                else if (finDens >= 3.5 && finDens <= 3.99)
                {
                    finDensValue = 1.5;
                }
                else if (finDens >= 4.0 && finDens <= 4.49)
                {
                    finDensValue = 1.75;
                }
                else if (finDens >= 4.5 && finDens <= 4.99)
                {
                    finDensValue = 2.0;
                }
                else if (finDens >= 5.0 && finDens <= 5.49)
                {
                    finDensValue = 2.25;
                }
                else if (finDens >= 5.50 && finDens <= 5.99)
                {
                    finDensValue = 2.5;
                }
                else if (finDens >= 6.0 && finDens <= 6.49)
                {
                    finDensValue = 2.75;
                }
                else if (finDens >= 6.5 && finDens <= 6.99)
                {
                    finDensValue = 3.0;
                }
                else if (finDens >= 7.0 && finDens <= 7.49)
                {
                    finDensValue = 3.25;
                }
                else if (finDens >= 7.5 && finDens <= 7.99)
                {
                    finDensValue = 3.5;
                }
                else if (finDens >= 8.0 && finDens <= 8.49)
                {
                    finDensValue = 3.75;
                }
                else if (finDens >= 8.5 && finDens <= 8.99)
                {
                    finDensValue = 4.0;
                }
                else if (finDens >= 9.0 && finDens <= 9.49)
                {
                    finDensValue = 4.25;
                }
                else if (finDens >= 9.50 && finDens <= 9.87)
                {
                    finDensValue = 4.5;
                }
                else if (finDens >= 9.88 && finDens <= 10.24)
                {
                    finDensValue = 4.75;
                }
                else if (finDens >= 10.25 && finDens <= 10.74)
                {
                    finDensValue = 5.0;
                }
                else if (finDens >= 10.75 && finDens <= 11.24)
                {
                    finDensValue = 5.25;
                }
                else if (finDens >= 11.25 && finDens <= 11.74)
                {
                    finDensValue = 5.5;
                }
                else if (finDens >= 11.75 && finDens <= 12.24)
                {
                    finDensValue = 5.75;
                }
                else if (finDens >= 12.25 && finDens <= 12.74)
                {
                    finDensValue = 6.0;
                }
                else if (finDens >= 12.75 && finDens <= 13.24)
                {
                    finDensValue = 6.25;
                }
                else if (finDens >= 13.25 && finDens <= 13.37)
                {
                    finDensValue = 6.5;
                }
                else if (finDens >= 13.38 && finDens <= 13.99)
                {
                    finDensValue = 6.75;
                }
                else if (finDens >= 14.0 && finDens <= 14.49)
                {
                    finDensValue = 7.0;
                }
                else if (finDens >= 14.5 && finDens <= 14.99)
                {
                    finDensValue = 7.25;
                }
                else if (finDens >= 15.0 && finDens <= 15.37)
                {
                    finDensValue = 7.5;
                }
                else if (finDens >= 15.38 && finDens <= 15.74)
                {
                    finDensValue = 7.75;
                }
                else if (finDens >= 15.75 && finDens <= 16.24)
                {
                    finDensValue = 8.0;
                }
                else if (finDens >= 16.25 && finDens <= 16.74)
                {
                    finDensValue = 8.25;
                }
                else if (finDens >= 16.75 && finDens <= 17.24)
                {
                    finDensValue = 8.5;
                }
                else if (finDens >= 17.25 && finDens <= 17.74)
                {
                    finDensValue = 8.75;
                }
                else if (finDens >= 17.75 && finDens <= 18.49)
                {
                    finDensValue = 9.0;
                }
                else if (finDens >= 18.50 && finDens <= 18.74)
                {
                    finDensValue = 9.25;
                }
                else if (finDens >= 18.75 && finDens <= 19.12)
                {
                    finDensValue = 9.5;
                }
                else if (finDens >= 19.13 && finDens <= 19.49)
                {
                    finDensValue = 9.75;
                }
                else if (finDens >= 19.5 && finDens <= 19.99)
                {
                    finDensValue = 10.0;
                }
                else if (finDens >= 20.0 && finDens <= 20.49)
                {
                    finDensValue = 10.25;
                }
                else if (finDens >= 20.5 && finDens <= 20.99)
                {
                    finDensValue = 10.5;
                }
                else if (finDens >= 21.0 && finDens <= 21.49)
                {
                    finDensValue = 10.75;
                }
                else if (finDens >= 21.5 && finDens <= 21.99)
                {
                    finDensValue = 11.0;
                }
                else if (finDens >= 22.0 && finDens <= 22.49)
                {
                    finDensValue = 11.25;
                }
                else if (finDens >= 22.5 && finDens <= 23.12)
                {
                    finDensValue = 11.5;
                }
                else if (finDens >= 23.13 && finDens <= 23.24)
                {
                    finDensValue = 11.75;
                }
                else if (finDens >= 23.25 && finDens <= 23.74)
                {
                    finDensValue = 12.0;
                }
                else if (finDens >= 23.75 && finDens <= 24.24)
                {
                    finDensValue = 12.25;
                }
                else if (finDens >= 24.25 && finDens <= 24.49)
                {
                    finDensValue = 12.5;
                }
                else if (finDens >= 24.5 && finDens <= 24.99)
                {
                    finDensValue = 12.75;
                }
                else if (finDens >= 25.0 && finDens <= 25.49)
                {
                    finDensValue = 13.0;
                }
                else if (finDens >= 25.5 && finDens <= 25.99)
                {
                    finDensValue = 13.25;
                }
                else if (finDens >= 26.0 && finDens <= 26.49)
                {
                    finDensValue = 13.5;
                }
                else if (finDens >= 26.5 && finDens <= 26.74)
                {
                    finDensValue = 13.75;
                }
                else if (finDens >= 26.75 && finDens <= 27.24)
                {
                    finDensValue = 14.0;
                }
                else if (finDens >= 27.25 && finDens <= 27.74)
                {
                    finDensValue = 14.25;
                }
                else if (finDens >= 27.75 && finDens <= 28.19)
                {
                    finDensValue = 14.5;
                }
                else if (finDens >= 28.2 && finDens <= 28.79)
                {
                    finDensValue = 14.75;
                }
            }
            else
            {
                MessageBox.Show("Поле конечной плотности не должно быть пустым", "Ошибка нахуй", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            // MAIN CALCULATION

            if (initDensValue != null && finDensValue != null)
            {
                resultVol = initDens - finDensValue;
            }
            showResultLabel.Text = "Объем алкоголя составляет " + resultVol.ToString() + "%";

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            showResultLabel.Text = string.Empty;
            initDensBox.Text = string.Empty;
            finDensBox.Text = string.Empty;
        }

        private void initDensBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void initDensBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') >= 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') >= 0)
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void finDensBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') >= 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-' && (sender as TextBox).Text.IndexOf('-') >= 0)
            {
                e.Handled = true;
            }
        }

        private void finDensBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void faqButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор рассчитывает объем алкоголя после брожения сусла на базе таблицы ареометра АС-3, чтобы не ебаться и не проверять по таблице - юзай эту прогу", "Инфо", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
