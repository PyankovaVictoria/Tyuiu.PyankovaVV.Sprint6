using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.PyankovaVV.Sprint6.Task3.V21.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task3.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
                    {{26,-15,7,1,-4},
                    {14,26,22,17,27},
                    {-8,31,22,34,4},
                    {-18,16,-2,16,27},
                    { 5,2,-4,16,15}};

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            var sorted_matrix = ds.Calculate(mtrx);

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_PVV.ColumnCount = columns;
            dataGridViewResult_PVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_PVV.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PVV.Rows[i].Cells[j].Value = Convert.ToString(sorted_matrix[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_PVV.ColumnCount = columns;
            dataGridViewMatrix_PVV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_PVV.Columns[i].Width = 25;
            }

            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_PVV.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3, вариант 21 выполнила студент группы АСОиУб-23-2 Пьянкова Виктория Вячеславовна", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
