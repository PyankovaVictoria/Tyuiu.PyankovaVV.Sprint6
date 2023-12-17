
namespace Tyuiu.PyankovaVV.Sprint6.Task0.V16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxYslovie_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxYslovie_PVV = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInput_PVV = new System.Windows.Forms.GroupBox();
            this.groupBoxOutput_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxInput_PVV = new System.Windows.Forms.TextBox();
            this.textBoxOutput_PVV = new System.Windows.Forms.TextBox();
            this.buttonDone_PVV = new System.Windows.Forms.Button();
            this.buttonInfo_PVV = new System.Windows.Forms.Button();
            this.labelInput_PVV = new System.Windows.Forms.Label();
            this.labelOutput_PVV = new System.Windows.Forms.Label();
            this.groupBoxYslovie_PVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInput_PVV.SuspendLayout();
            this.groupBoxOutput_PVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxYslovie_PVV
            // 
            this.groupBoxYslovie_PVV.Controls.Add(this.pictureBox1);
            this.groupBoxYslovie_PVV.Controls.Add(this.textBoxYslovie_PVV);
            this.groupBoxYslovie_PVV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxYslovie_PVV.Name = "groupBoxYslovie_PVV";
            this.groupBoxYslovie_PVV.Size = new System.Drawing.Size(800, 318);
            this.groupBoxYslovie_PVV.TabIndex = 0;
            this.groupBoxYslovie_PVV.TabStop = false;
            this.groupBoxYslovie_PVV.Text = "Условие";
            // 
            // textBoxYslovie_PVV
            // 
            this.textBoxYslovie_PVV.Location = new System.Drawing.Point(6, 18);
            this.textBoxYslovie_PVV.Multiline = true;
            this.textBoxYslovie_PVV.Name = "textBoxYslovie_PVV";
            this.textBoxYslovie_PVV.ReadOnly = true;
            this.textBoxYslovie_PVV.Size = new System.Drawing.Size(635, 294);
            this.textBoxYslovie_PVV.TabIndex = 0;
            this.textBoxYslovie_PVV.Text = "Дано выражение, вычислить его значение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(665, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInput_PVV
            // 
            this.groupBoxInput_PVV.Controls.Add(this.labelInput_PVV);
            this.groupBoxInput_PVV.Controls.Add(this.textBoxInput_PVV);
            this.groupBoxInput_PVV.Location = new System.Drawing.Point(0, 324);
            this.groupBoxInput_PVV.Name = "groupBoxInput_PVV";
            this.groupBoxInput_PVV.Size = new System.Drawing.Size(381, 100);
            this.groupBoxInput_PVV.TabIndex = 1;
            this.groupBoxInput_PVV.TabStop = false;
            this.groupBoxInput_PVV.Text = "Ввод данных";
            // 
            // groupBoxOutput_PVV
            // 
            this.groupBoxOutput_PVV.Controls.Add(this.labelOutput_PVV);
            this.groupBoxOutput_PVV.Controls.Add(this.textBoxOutput_PVV);
            this.groupBoxOutput_PVV.Location = new System.Drawing.Point(387, 324);
            this.groupBoxOutput_PVV.Name = "groupBoxOutput_PVV";
            this.groupBoxOutput_PVV.Size = new System.Drawing.Size(413, 100);
            this.groupBoxOutput_PVV.TabIndex = 2;
            this.groupBoxOutput_PVV.TabStop = false;
            this.groupBoxOutput_PVV.Text = "Вывод данных";
            // 
            // textBoxInput_PVV
            // 
            this.textBoxInput_PVV.Location = new System.Drawing.Point(6, 47);
            this.textBoxInput_PVV.Name = "textBoxInput_PVV";
            this.textBoxInput_PVV.Size = new System.Drawing.Size(186, 22);
            this.textBoxInput_PVV.TabIndex = 0;
            this.textBoxInput_PVV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_PVV_KeyPress);
            // 
            // textBoxOutput_PVV
            // 
            this.textBoxOutput_PVV.Location = new System.Drawing.Point(6, 47);
            this.textBoxOutput_PVV.Name = "textBoxOutput_PVV";
            this.textBoxOutput_PVV.ReadOnly = true;
            this.textBoxOutput_PVV.Size = new System.Drawing.Size(192, 22);
            this.textBoxOutput_PVV.TabIndex = 0;
            // 
            // buttonDone_PVV
            // 
            this.buttonDone_PVV.Location = new System.Drawing.Point(666, 440);
            this.buttonDone_PVV.Name = "buttonDone_PVV";
            this.buttonDone_PVV.Size = new System.Drawing.Size(118, 43);
            this.buttonDone_PVV.TabIndex = 3;
            this.buttonDone_PVV.Text = "Выполнить";
            this.buttonDone_PVV.UseVisualStyleBackColor = true;
            this.buttonDone_PVV.Click += new System.EventHandler(this.buttonDone_PVV_Click);
            // 
            // buttonInfo_PVV
            // 
            this.buttonInfo_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_PVV.Location = new System.Drawing.Point(605, 440);
            this.buttonInfo_PVV.Name = "buttonInfo_PVV";
            this.buttonInfo_PVV.Size = new System.Drawing.Size(48, 43);
            this.buttonInfo_PVV.TabIndex = 4;
            this.buttonInfo_PVV.Text = "?";
            this.buttonInfo_PVV.UseVisualStyleBackColor = true;
            this.buttonInfo_PVV.Click += new System.EventHandler(this.buttonInfo_PVV_Click);
            // 
            // labelInput_PVV
            // 
            this.labelInput_PVV.AutoSize = true;
            this.labelInput_PVV.Location = new System.Drawing.Point(7, 22);
            this.labelInput_PVV.Name = "labelInput_PVV";
            this.labelInput_PVV.Size = new System.Drawing.Size(104, 17);
            this.labelInput_PVV.TabIndex = 1;
            this.labelInput_PVV.Text = "Переменная Х";
            // 
            // labelOutput_PVV
            // 
            this.labelOutput_PVV.AutoSize = true;
            this.labelOutput_PVV.Location = new System.Drawing.Point(6, 22);
            this.labelOutput_PVV.Name = "labelOutput_PVV";
            this.labelOutput_PVV.Size = new System.Drawing.Size(76, 17);
            this.labelOutput_PVV.TabIndex = 5;
            this.labelOutput_PVV.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.buttonInfo_PVV);
            this.Controls.Add(this.buttonDone_PVV);
            this.Controls.Add(this.groupBoxOutput_PVV);
            this.Controls.Add(this.groupBoxInput_PVV);
            this.Controls.Add(this.groupBoxYslovie_PVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 16 | Пьянкова В. В.";
            this.groupBoxYslovie_PVV.ResumeLayout(false);
            this.groupBoxYslovie_PVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInput_PVV.ResumeLayout(false);
            this.groupBoxInput_PVV.PerformLayout();
            this.groupBoxOutput_PVV.ResumeLayout(false);
            this.groupBoxOutput_PVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxYslovie_PVV;
        private System.Windows.Forms.TextBox textBoxYslovie_PVV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInput_PVV;
        private System.Windows.Forms.Label labelInput_PVV;
        private System.Windows.Forms.TextBox textBoxInput_PVV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PVV;
        private System.Windows.Forms.Label labelOutput_PVV;
        private System.Windows.Forms.TextBox textBoxOutput_PVV;
        private System.Windows.Forms.Button buttonDone_PVV;
        private System.Windows.Forms.Button buttonInfo_PVV;
    }
}

