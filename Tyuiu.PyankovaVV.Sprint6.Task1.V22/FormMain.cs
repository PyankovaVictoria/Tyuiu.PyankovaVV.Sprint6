using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyankovaVV.Sprint6.Task1.V22.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart_PVV.Text);
                int stopValue = Convert.ToInt32(textBoxStop_PVV.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_PVV.Text = "";
                textBoxResult_PVV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_PVV.AppendText("|     x    |   f(x)   |" + Environment.NewLine);
                textBoxResult_PVV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i<=len-1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,7:f2}  |", startValue, valueArray[i]);
                    textBoxResult_PVV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_PVV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, вариант 22 выполнила студент группы АСОиУб-23-2 Пьянкова Виктория Вячеславовна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
