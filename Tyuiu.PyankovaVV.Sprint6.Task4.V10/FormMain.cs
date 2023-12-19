using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Tyuiu.PyankovaVV.Sprint6.Task4.V10.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task4.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V10.txt";
                File.WriteAllText(path, textBoxOutput_PVV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл: " + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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



                this.chartFunction_PVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PVV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutput_PVV.Text = "";

                chartFunction_PVV.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_PVV.Series[0].Points.AddXY(startValue, valueArray[i]);
                    textBoxOutput_PVV.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("Таск 4, вариант 10 выполнила студент группы АСОиУб-23-2 Пьянкова Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
