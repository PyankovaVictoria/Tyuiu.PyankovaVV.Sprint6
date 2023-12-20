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

using Tyuiu.PyankovaVV.Sprint6.Task6.V16.Lib;

namespace Tyuiu.PyankovaVV.Sprint6.Task6.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            textBoxOutput_PVV.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonOpen_PVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PVV.ShowDialog();
            openFilePath = openFileDialogTask_PVV.FileName;
            textBoxInput_PVV.Text = File.ReadAllText(openFilePath);
            groupBoxInput_PVV.Text = groupBoxInput_PVV.Text + " " + openFileDialogTask_PVV.FileName; ;
            buttonDone_PVV.Enabled = true;
        }

        private void buttonInfo_PVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
