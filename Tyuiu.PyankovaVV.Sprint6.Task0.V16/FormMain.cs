using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyankovaVV.Sprint6.Task0.V16.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task0.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutput_PVV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_PVV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0, вариант 16 выполнила студент группы АСОиУб-23-2 Пьянкова Виктория Вячеславовна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxInput_PVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar<=47 || e.KeyChar>=58)&&(e.KeyChar!=',')&&(e.KeyChar!=8))
            {
                e.Handled = true;
            }
        }
    }
}
