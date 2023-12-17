
namespace Tyuiu.PyankovaVV.Sprint6.Task1.V22
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
            this.groupBoxOutput_PVV = new System.Windows.Forms.GroupBox();
            this.groupBoxInput_PVV = new System.Windows.Forms.GroupBox();
            this.buttonInfo_PVV = new System.Windows.Forms.Button();
            this.buttonDone_PVV = new System.Windows.Forms.Button();
            this.textBoxYslovie_PVV = new System.Windows.Forms.TextBox();
            this.labelResult_PVV = new System.Windows.Forms.Label();
            this.textBoxResult_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStart_PVV = new System.Windows.Forms.TextBox();
            this.textBoxStop_PVV = new System.Windows.Forms.TextBox();
            this.labelStart_PVV = new System.Windows.Forms.Label();
            this.labelStop_PVV = new System.Windows.Forms.Label();
            this.groupBoxYslovie_PVV.SuspendLayout();
            this.groupBoxOutput_PVV.SuspendLayout();
            this.groupBoxInput_PVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxYslovie_PVV
            // 
            this.groupBoxYslovie_PVV.Controls.Add(this.textBoxYslovie_PVV);
            this.groupBoxYslovie_PVV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxYslovie_PVV.Name = "groupBoxYslovie_PVV";
            this.groupBoxYslovie_PVV.Size = new System.Drawing.Size(445, 234);
            this.groupBoxYslovie_PVV.TabIndex = 0;
            this.groupBoxYslovie_PVV.TabStop = false;
            this.groupBoxYslovie_PVV.Text = "Условие";
            // 
            // groupBoxOutput_PVV
            // 
            this.groupBoxOutput_PVV.Controls.Add(this.textBoxResult_PVV);
            this.groupBoxOutput_PVV.Controls.Add(this.labelResult_PVV);
            this.groupBoxOutput_PVV.Location = new System.Drawing.Point(463, 12);
            this.groupBoxOutput_PVV.Name = "groupBoxOutput_PVV";
            this.groupBoxOutput_PVV.Size = new System.Drawing.Size(332, 308);
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
            this.groupBoxInput_PVV.Location = new System.Drawing.Point(12, 252);
            this.groupBoxInput_PVV.Name = "groupBoxInput_PVV";
            this.groupBoxInput_PVV.Size = new System.Drawing.Size(250, 68);
            this.groupBoxInput_PVV.TabIndex = 2;
            this.groupBoxInput_PVV.TabStop = false;
            this.groupBoxInput_PVV.Text = "Ввод данных";
            // 
            // buttonInfo_PVV
            // 
            this.buttonInfo_PVV.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonInfo_PVV.Location = new System.Drawing.Point(268, 252);
            this.buttonInfo_PVV.Name = "buttonInfo_PVV";
            this.buttonInfo_PVV.Size = new System.Drawing.Size(85, 68);
            this.buttonInfo_PVV.TabIndex = 3;
            this.buttonInfo_PVV.Text = "Справка";
            this.buttonInfo_PVV.UseVisualStyleBackColor = false;
            this.buttonInfo_PVV.Click += new System.EventHandler(this.buttonInfo_PVV_Click);
            // 
            // buttonDone_PVV
            // 
            this.buttonDone_PVV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_PVV.Location = new System.Drawing.Point(359, 252);
            this.buttonDone_PVV.Name = "buttonDone_PVV";
            this.buttonDone_PVV.Size = new System.Drawing.Size(98, 68);
            this.buttonDone_PVV.TabIndex = 4;
            this.buttonDone_PVV.Text = "Выполнить";
            this.buttonDone_PVV.UseVisualStyleBackColor = false;
            this.buttonDone_PVV.Click += new System.EventHandler(this.buttonDone_PVV_Click);
            // 
            // textBoxYslovie_PVV
            // 
            this.textBoxYslovie_PVV.Location = new System.Drawing.Point(6, 21);
            this.textBoxYslovie_PVV.Multiline = true;
            this.textBoxYslovie_PVV.Name = "textBoxYslovie_PVV";
            this.textBoxYslovie_PVV.ReadOnly = true;
            this.textBoxYslovie_PVV.Size = new System.Drawing.Size(433, 207);
            this.textBoxYslovie_PVV.TabIndex = 5;
            this.textBoxYslovie_PVV.Text = "Протабулировать функцию: 3x+2-(2х-х/cos(x)+1).\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // labelResult_PVV
            // 
            this.labelResult_PVV.AutoSize = true;
            this.labelResult_PVV.Location = new System.Drawing.Point(7, 21);
            this.labelResult_PVV.Name = "labelResult_PVV";
            this.labelResult_PVV.Size = new System.Drawing.Size(76, 17);
            this.labelResult_PVV.TabIndex = 0;
            this.labelResult_PVV.Text = "Результат";
            // 
            // textBoxResult_PVV
            // 
            this.textBoxResult_PVV.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_PVV.Location = new System.Drawing.Point(6, 41);
            this.textBoxResult_PVV.Multiline = true;
            this.textBoxResult_PVV.Name = "textBoxResult_PVV";
            this.textBoxResult_PVV.ReadOnly = true;
            this.textBoxResult_PVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_PVV.Size = new System.Drawing.Size(320, 261);
            this.textBoxResult_PVV.TabIndex = 1;
            // 
            // textBoxStart_PVV
            // 
            this.textBoxStart_PVV.Location = new System.Drawing.Point(6, 40);
            this.textBoxStart_PVV.Name = "textBoxStart_PVV";
            this.textBoxStart_PVV.Size = new System.Drawing.Size(100, 22);
            this.textBoxStart_PVV.TabIndex = 0;
            // 
            // textBoxStop_PVV
            // 
            this.textBoxStop_PVV.Location = new System.Drawing.Point(140, 40);
            this.textBoxStop_PVV.Name = "textBoxStop_PVV";
            this.textBoxStop_PVV.Size = new System.Drawing.Size(100, 22);
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
            this.labelStop_PVV.Location = new System.Drawing.Point(137, 18);
            this.labelStop_PVV.Name = "labelStop_PVV";
            this.labelStop_PVV.Size = new System.Drawing.Size(89, 17);
            this.labelStop_PVV.TabIndex = 3;
            this.labelStop_PVV.Text = "Конец шага:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 332);
            this.Controls.Add(this.buttonDone_PVV);
            this.Controls.Add(this.buttonInfo_PVV);
            this.Controls.Add(this.groupBoxInput_PVV);
            this.Controls.Add(this.groupBoxOutput_PVV);
            this.Controls.Add(this.groupBoxYslovie_PVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Спринт 6 | Таск 1 | Вариант 22 | Пьянкова В. В.";
            this.groupBoxYslovie_PVV.ResumeLayout(false);
            this.groupBoxYslovie_PVV.PerformLayout();
            this.groupBoxOutput_PVV.ResumeLayout(false);
            this.groupBoxOutput_PVV.PerformLayout();
            this.groupBoxInput_PVV.ResumeLayout(false);
            this.groupBoxInput_PVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxYslovie_PVV;
        private System.Windows.Forms.TextBox textBoxYslovie_PVV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PVV;
        private System.Windows.Forms.TextBox textBoxResult_PVV;
        private System.Windows.Forms.Label labelResult_PVV;
        private System.Windows.Forms.GroupBox groupBoxInput_PVV;
        private System.Windows.Forms.Label labelStop_PVV;
        private System.Windows.Forms.Label labelStart_PVV;
        private System.Windows.Forms.TextBox textBoxStop_PVV;
        private System.Windows.Forms.TextBox textBoxStart_PVV;
        private System.Windows.Forms.Button buttonInfo_PVV;
        private System.Windows.Forms.Button buttonDone_PVV;
    }
}

