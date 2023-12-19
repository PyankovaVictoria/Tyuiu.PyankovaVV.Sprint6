
namespace Tyuiu.PyankovaVV.Sprint6.Task2.V14
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxYslovie_PVV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_PVV = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxYslovie_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStart_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStop_PVV = new System.Windows.Forms.TextBox();
            this.labelStart_PVV = new System.Windows.Forms.Label();
            this.labelStop_PVV = new System.Windows.Forms.Label();
            this.buttonInfo_PVV = new System.Windows.Forms.Button();
            this.buttonDone_PVV = new System.Windows.Forms.Button();
            this.dataGridViewOutput_PVV = new System.Windows.Forms.DataGridView();
            this.ColumnX_PVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFX_PVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_PVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxYslovie_PVV.SuspendLayout();
            this.groupBoxOutput_PVV.SuspendLayout();
            this.groupBoxInput_PVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PVV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxYslovie_PVV
            // 
            this.groupBoxYslovie_PVV.Controls.Add(this.textBoxYslovie_PVV);
            this.groupBoxYslovie_PVV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxYslovie_PVV.Name = "groupBoxYslovie_PVV";
            this.groupBoxYslovie_PVV.Size = new System.Drawing.Size(523, 328);
            this.groupBoxYslovie_PVV.TabIndex = 0;
            this.groupBoxYslovie_PVV.TabStop = false;
            this.groupBoxYslovie_PVV.Text = "Условие";
            // 
            // groupBoxOutput_PVV
            // 
            this.groupBoxOutput_PVV.Controls.Add(this.chartFunction_PVV);
            this.groupBoxOutput_PVV.Controls.Add(this.dataGridViewOutput_PVV);
            this.groupBoxOutput_PVV.Location = new System.Drawing.Point(542, 13);
            this.groupBoxOutput_PVV.Name = "groupBoxOutput_PVV";
            this.groupBoxOutput_PVV.Size = new System.Drawing.Size(581, 425);
            this.groupBoxOutput_PVV.TabIndex = 1;
            this.groupBoxOutput_PVV.TabStop = false;
            this.groupBoxOutput_PVV.Text = "Вывод данных";
            // 
            // groupBoxInput_PVV
            // 
            this.groupBoxInput_PVV.Controls.Add(this.labelStop_PVV);
            this.groupBoxInput_PVV.Controls.Add(this.labelStart_PVV);
            this.groupBoxInput_PVV.Controls.Add(this.textBoxStop_PVV);
            this.groupBoxInput_PVV.Controls.Add(this.textBoxStart_PVV);
            this.groupBoxInput_PVV.Location = new System.Drawing.Point(13, 347);
            this.groupBoxInput_PVV.Name = "groupBoxInput_PVV";
            this.groupBoxInput_PVV.Size = new System.Drawing.Size(270, 90);
            this.groupBoxInput_PVV.TabIndex = 2;
            this.groupBoxInput_PVV.TabStop = false;
            this.groupBoxInput_PVV.Text = "Ввод данных";
            // 
            // textBoxYslovie_PVV
            // 
            this.textBoxYslovie_PVV.Location = new System.Drawing.Point(6, 21);
            this.textBoxYslovie_PVV.Multiline = true;
            this.textBoxYslovie_PVV.Name = "textBoxYslovie_PVV";
            this.textBoxYslovie_PVV.ReadOnly = true;
            this.textBoxYslovie_PVV.Size = new System.Drawing.Size(511, 301);
            this.textBoxYslovie_PVV.TabIndex = 0;
            this.textBoxYslovie_PVV.Text = "Протабулировать функцию 5 - 3х + (1 + sin(x) / 2x - 0,5) на заданном диапазоне.\r\n" +
    "Результат вывести в DataGridView и построить график функции.";
            // 
            // textBoxStart_PVV
            // 
            this.textBoxStart_PVV.Location = new System.Drawing.Point(6, 38);
            this.textBoxStart_PVV.Name = "textBoxStart_PVV";
            this.textBoxStart_PVV.Size = new System.Drawing.Size(111, 22);
            this.textBoxStart_PVV.TabIndex = 0;
            // 
            // textBoxStop_PVV
            // 
            this.textBoxStop_PVV.Location = new System.Drawing.Point(153, 38);
            this.textBoxStop_PVV.Name = "textBoxStop_PVV";
            this.textBoxStop_PVV.Size = new System.Drawing.Size(111, 22);
            this.textBoxStop_PVV.TabIndex = 1;
            // 
            // labelStart_PVV
            // 
            this.labelStart_PVV.AutoSize = true;
            this.labelStart_PVV.Location = new System.Drawing.Point(6, 18);
            this.labelStart_PVV.Name = "labelStart_PVV";
            this.labelStart_PVV.Size = new System.Drawing.Size(87, 17);
            this.labelStart_PVV.TabIndex = 2;
            this.labelStart_PVV.Text = "Старт шага:";
            // 
            // labelStop_PVV
            // 
            this.labelStop_PVV.AutoSize = true;
            this.labelStop_PVV.Location = new System.Drawing.Point(150, 17);
            this.labelStop_PVV.Name = "labelStop_PVV";
            this.labelStop_PVV.Size = new System.Drawing.Size(89, 17);
            this.labelStop_PVV.TabIndex = 3;
            this.labelStop_PVV.Text = "Конец шага:";
            // 
            // buttonInfo_PVV
            // 
            this.buttonInfo_PVV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_PVV.Location = new System.Drawing.Point(290, 347);
            this.buttonInfo_PVV.Name = "buttonInfo_PVV";
            this.buttonInfo_PVV.Size = new System.Drawing.Size(98, 90);
            this.buttonInfo_PVV.TabIndex = 3;
            this.buttonInfo_PVV.Text = "Справка";
            this.buttonInfo_PVV.UseVisualStyleBackColor = false;
            this.buttonInfo_PVV.Click += new System.EventHandler(this.buttonInfo_PVV_Click);
            // 
            // buttonDone_PVV
            // 
            this.buttonDone_PVV.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonDone_PVV.Location = new System.Drawing.Point(407, 347);
            this.buttonDone_PVV.Name = "buttonDone_PVV";
            this.buttonDone_PVV.Size = new System.Drawing.Size(129, 90);
            this.buttonDone_PVV.TabIndex = 4;
            this.buttonDone_PVV.Text = "Выполнить";
            this.buttonDone_PVV.UseVisualStyleBackColor = false;
            this.buttonDone_PVV.Click += new System.EventHandler(this.buttonDone_PVV_Click);
            this.buttonDone_PVV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_PVV_MouseDown);
            this.buttonDone_PVV.MouseEnter += new System.EventHandler(this.buttonDone_PVV_MouseEnter);
            this.buttonDone_PVV.MouseLeave += new System.EventHandler(this.buttonDone_PVV_MouseLeave);
            // 
            // dataGridViewOutput_PVV
            // 
            this.dataGridViewOutput_PVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput_PVV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX_PVV,
            this.ColumnFX_PVV});
            this.dataGridViewOutput_PVV.Location = new System.Drawing.Point(6, 32);
            this.dataGridViewOutput_PVV.Name = "dataGridViewOutput_PVV";
            this.dataGridViewOutput_PVV.RowHeadersVisible = false;
            this.dataGridViewOutput_PVV.RowHeadersWidth = 51;
            this.dataGridViewOutput_PVV.RowTemplate.Height = 24;
            this.dataGridViewOutput_PVV.Size = new System.Drawing.Size(149, 387);
            this.dataGridViewOutput_PVV.TabIndex = 0;
            // 
            // ColumnX_PVV
            // 
            this.ColumnX_PVV.HeaderText = "X";
            this.ColumnX_PVV.MinimumWidth = 6;
            this.ColumnX_PVV.Name = "ColumnX_PVV";
            this.ColumnX_PVV.ReadOnly = true;
            this.ColumnX_PVV.Width = 50;
            // 
            // ColumnFX_PVV
            // 
            this.ColumnFX_PVV.HeaderText = "F(X)";
            this.ColumnFX_PVV.MinimumWidth = 6;
            this.ColumnFX_PVV.Name = "ColumnFX_PVV";
            this.ColumnFX_PVV.ReadOnly = true;
            this.ColumnFX_PVV.Width = 50;
            // 
            // chartFunction_PVV
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_PVV.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chartFunction_PVV.Legends.Add(legend4);
            this.chartFunction_PVV.Location = new System.Drawing.Point(161, 32);
            this.chartFunction_PVV.Name = "chartFunction_PVV";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_PVV.Series.Add(series4);
            this.chartFunction_PVV.Size = new System.Drawing.Size(414, 387);
            this.chartFunction_PVV.TabIndex = 1;
            this.chartFunction_PVV.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 450);
            this.Controls.Add(this.buttonDone_PVV);
            this.Controls.Add(this.buttonInfo_PVV);
            this.Controls.Add(this.groupBoxInput_PVV);
            this.Controls.Add(this.groupBoxOutput_PVV);
            this.Controls.Add(this.groupBoxYslovie_PVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 14 | Пьянкова В. В.";
            this.groupBoxYslovie_PVV.ResumeLayout(false);
            this.groupBoxYslovie_PVV.PerformLayout();
            this.groupBoxOutput_PVV.ResumeLayout(false);
            this.groupBoxInput_PVV.ResumeLayout(false);
            this.groupBoxInput_PVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_PVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_PVV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxYslovie_PVV;
        private System.Windows.Forms.TextBox textBoxYslovie_PVV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PVV;
        private System.Windows.Forms.DataGridView dataGridViewOutput_PVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_PVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFX_PVV;
        private System.Windows.Forms.GroupBox groupBoxInput_PVV;
        private System.Windows.Forms.Label labelStop_PVV;
        private System.Windows.Forms.Label labelStart_PVV;
        private System.Windows.Forms.TextBox textBoxStop_PVV;
        private System.Windows.Forms.TextBox textBoxStart_PVV;
        private System.Windows.Forms.Button buttonInfo_PVV;
        private System.Windows.Forms.Button buttonDone_PVV;
    }
}

