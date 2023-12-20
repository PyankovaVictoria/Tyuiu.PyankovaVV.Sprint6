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

using Tyuiu.PyankovaVV.Sprint6.Task5.V4.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask5V4.txt";

        private void buttonOpen_PVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            {
                dataGridViewOutput_PVV.ColumnCount = 2;
                dataGridViewOutput_PVV.Columns[0].Width = 20;
                dataGridViewOutput_PVV.Columns[1].Width = 50;

                this.chartOutput_PVV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartOutput_PVV.ChartAreas[0].AxisY.Title = "Ось Y";

                chartOutput_PVV.Series[0].Points.Clear();

                double[] numsMass = new double[ds.len];

                numsMass = ds.LoadFromDataFile(path);

                for (int i = 0; i < numsMass.Length; i++)
                {
                    dataGridViewOutput_PVV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                    chartOutput_PVV.Series[0].Points.AddXY(i, numsMass[i]);
                }
            }
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5, вариант 4 выполнила студент группы АСОиУб-23-2 Пьянкова Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
