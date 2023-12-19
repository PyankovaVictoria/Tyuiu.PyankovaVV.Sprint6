
namespace Tyuiu.PyankovaVV.Sprint6.Task3.V21
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
            this.groupBoxYslovie_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxYslovie_PVV = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix_PVV = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult_PVV = new System.Windows.Forms.DataGridView();
            this.groupBoxOutput_PVV = new System.Windows.Forms.GroupBox();
            this.buttonInfo_PVV = new System.Windows.Forms.Button();
            this.buttonDone_PVV = new System.Windows.Forms.Button();
            this.groupBoxYslovie_PVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PVV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PVV)).BeginInit();
            this.groupBoxOutput_PVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxYslovie_PVV
            // 
            this.groupBoxYslovie_PVV.Controls.Add(this.textBoxYslovie_PVV);
            this.groupBoxYslovie_PVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxYslovie_PVV.Name = "groupBoxYslovie_PVV";
            this.groupBoxYslovie_PVV.Size = new System.Drawing.Size(326, 221);
            this.groupBoxYslovie_PVV.TabIndex = 0;
            this.groupBoxYslovie_PVV.TabStop = false;
            this.groupBoxYslovie_PVV.Text = "Условие";
            // 
            // textBoxYslovie_PVV
            // 
            this.textBoxYslovie_PVV.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxYslovie_PVV.Location = new System.Drawing.Point(6, 21);
            this.textBoxYslovie_PVV.Multiline = true;
            this.textBoxYslovie_PVV.Name = "textBoxYslovie_PVV";
            this.textBoxYslovie_PVV.ReadOnly = true;
            this.textBoxYslovie_PVV.Size = new System.Drawing.Size(314, 194);
            this.textBoxYslovie_PVV.TabIndex = 1;
            this.textBoxYslovie_PVV.Text = "Дана матрица 5 на 5\r\n 26 -15  7  1 -4\r\n 14  26 22 17 27\r\n -8  31 22 34  4\r\n-18  1" +
    "6 -2 16 27\r\n  5   2 -4 16 15\r\nВыполнить сортировку по возрастанию в первом столб" +
    "це.";
            // 
            // dataGridViewMatrix_PVV
            // 
            this.dataGridViewMatrix_PVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_PVV.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_PVV.Location = new System.Drawing.Point(344, 33);
            this.dataGridViewMatrix_PVV.Name = "dataGridViewMatrix_PVV";
            this.dataGridViewMatrix_PVV.RowHeadersVisible = false;
            this.dataGridViewMatrix_PVV.RowHeadersWidth = 51;
            this.dataGridViewMatrix_PVV.RowTemplate.Height = 24;
            this.dataGridViewMatrix_PVV.Size = new System.Drawing.Size(194, 194);
            this.dataGridViewMatrix_PVV.TabIndex = 1;
            this.dataGridViewMatrix_PVV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewResult_PVV
            // 
            this.dataGridViewResult_PVV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_PVV.ColumnHeadersVisible = false;
            this.dataGridViewResult_PVV.Location = new System.Drawing.Point(8, 22);
            this.dataGridViewResult_PVV.Name = "dataGridViewResult_PVV";
            this.dataGridViewResult_PVV.RowHeadersVisible = false;
            this.dataGridViewResult_PVV.RowHeadersWidth = 51;
            this.dataGridViewResult_PVV.RowTemplate.Height = 24;
            this.dataGridViewResult_PVV.Size = new System.Drawing.Size(194, 194);
            this.dataGridViewResult_PVV.TabIndex = 2;
            // 
            // groupBoxOutput_PVV
            // 
            this.groupBoxOutput_PVV.Controls.Add(this.dataGridViewResult_PVV);
            this.groupBoxOutput_PVV.Location = new System.Drawing.Point(546, 12);
            this.groupBoxOutput_PVV.Name = "groupBoxOutput_PVV";
            this.groupBoxOutput_PVV.Size = new System.Drawing.Size(210, 221);
            this.groupBoxOutput_PVV.TabIndex = 3;
            this.groupBoxOutput_PVV.TabStop = false;
            this.groupBoxOutput_PVV.Text = "Вывод данных";
            // 
            // buttonInfo_PVV
            // 
            this.buttonInfo_PVV.Location = new System.Drawing.Point(770, 193);
            this.buttonInfo_PVV.Name = "buttonInfo_PVV";
            this.buttonInfo_PVV.Size = new System.Drawing.Size(35, 35);
            this.buttonInfo_PVV.TabIndex = 4;
            this.buttonInfo_PVV.Text = "?";
            this.buttonInfo_PVV.UseVisualStyleBackColor = true;
            this.buttonInfo_PVV.Click += new System.EventHandler(this.buttonInfo_PVV_Click);
            // 
            // buttonDone_PVV
            // 
            this.buttonDone_PVV.Location = new System.Drawing.Point(811, 192);
            this.buttonDone_PVV.Name = "buttonDone_PVV";
            this.buttonDone_PVV.Size = new System.Drawing.Size(95, 35);
            this.buttonDone_PVV.TabIndex = 5;
            this.buttonDone_PVV.Text = "Выполнить";
            this.buttonDone_PVV.UseVisualStyleBackColor = true;
            this.buttonDone_PVV.Click += new System.EventHandler(this.buttonDone_PVV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 245);
            this.Controls.Add(this.buttonDone_PVV);
            this.Controls.Add(this.buttonInfo_PVV);
            this.Controls.Add(this.groupBoxOutput_PVV);
            this.Controls.Add(this.dataGridViewMatrix_PVV);
            this.Controls.Add(this.groupBoxYslovie_PVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 21 | Пьянкова В. В.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxYslovie_PVV.ResumeLayout(false);
            this.groupBoxYslovie_PVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_PVV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_PVV)).EndInit();
            this.groupBoxOutput_PVV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxYslovie_PVV;
        private System.Windows.Forms.TextBox textBoxYslovie_PVV;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_PVV;
        private System.Windows.Forms.DataGridView dataGridViewResult_PVV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PVV;
        private System.Windows.Forms.Button buttonInfo_PVV;
        private System.Windows.Forms.Button buttonDone_PVV;
    }
}

