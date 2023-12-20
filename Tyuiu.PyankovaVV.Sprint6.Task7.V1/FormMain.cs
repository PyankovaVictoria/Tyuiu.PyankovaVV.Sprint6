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

using Tyuiu.PyankovaVV.Sprint6.Task7.V1.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_PVV.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_PVV.Filter = "Значения, разделённые запятыми(*.csv)| *.csv | Все файлы(*.*) | *.* ";
        }

        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonOpen_PVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PVV.ShowDialog();
            openFilePath = openFileDialogTask_PVV.FileName;

            int[,] arrayValues = new int[rows, colums];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_PVV.ColumnCount = colums;
            dataGridViewInput_PVV.RowCount = rows;
            dataGridViewOutput_PVV.ColumnCount = colums;
            dataGridViewOutput_PVV.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput_PVV.Columns[i].Width = 25;
                dataGridViewOutput_PVV.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput_PVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath); 
            buttonDone_PVV.Enabled = true;
        }

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutput_PVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_PVV.Enabled = true;
        }

        private void buttonSave_PVV_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_PVV.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_PVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_PVV.ShowDialog();

            string path = saveFileDialogTask_PVV.FileName;

            FileInfo info = new FileInfo(path);
            bool fileex = info.Exists;

            if (fileex)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_PVV.RowCount;
            int colums = dataGridViewOutput_PVV.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (j != colums - 1)
                    {
                        str = str + dataGridViewOutput_PVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_PVV.Rows[i].Cells[j].Value;
                    }
                }
            }
            File.AppendAllText(path, str + Environment.NewLine);
            str = "";
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }

        private void buttonOpen_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PVV.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PVV.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PVV.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInfo_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButtons_PVV.ToolTipTitle = "Справка";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_PVV.RowCount = 50;
            dataGridViewOutput_PVV.RowCount = 50;

            dataGridViewInput_PVV.ColumnCount = 50;
            dataGridViewOutput_PVV.ColumnCount = 50;



            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_PVV.Columns[i].Width = 25;
                dataGridViewOutput_PVV.Columns[i].Width = 25;
            }
        }
    }
}
