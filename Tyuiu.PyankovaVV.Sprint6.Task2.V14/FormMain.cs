using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyankovaVV.Sprint6.Task2.V14.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task2.V14
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

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                this.chartFunction_PVV.Titles.Add("График функции");

                this.chartFunction_PVV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartFunction_PVV.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewOutput_PVV.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_PVV.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2, Вариант 14 выполнила студент группы АСОиУб-23-2 Пьянкова Виктория Вячеславовна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonDone_PVV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PVV.BackColor = Color.Red;
        }

        private void buttonDone_PVV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PVV.BackColor = Color.Chartreuse;
        }

        private void buttonDone_PVV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PVV.BackColor = Color.Blue;
        }
    }
}
