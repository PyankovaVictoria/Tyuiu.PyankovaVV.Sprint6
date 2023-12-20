
namespace Tyuiu.PyankovaVV.Sprint6.Task6.V16
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelTop_PVV = new System.Windows.Forms.Panel();
            this.buttonInfo_PVV = new System.Windows.Forms.Button();
            this.buttonDone_PVV = new System.Windows.Forms.Button();
            this.buttonOpen_PVV = new System.Windows.Forms.Button();
            this.groupBoxYslovie_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxYslovie_PVV = new System.Windows.Forms.TextBox();
            this.panelLeft_PVV = new System.Windows.Forms.Panel();
            this.groupBoxInput_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxInput_PVV = new System.Windows.Forms.TextBox();
            this.splitterLeftRight_PVV = new System.Windows.Forms.Splitter();
            this.panelRight_PVV = new System.Windows.Forms.Panel();
            this.groupBoxOutput_PVV = new System.Windows.Forms.GroupBox();
            this.textBoxOutput_PVV = new System.Windows.Forms.TextBox();
            this.openFileDialogTask_PVV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipInfo_PVV = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_PVV.SuspendLayout();
            this.groupBoxYslovie_PVV.SuspendLayout();
            this.panelLeft_PVV.SuspendLayout();
            this.groupBoxInput_PVV.SuspendLayout();
            this.panelRight_PVV.SuspendLayout();
            this.groupBoxOutput_PVV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop_PVV
            // 
            this.panelTop_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop_PVV.Controls.Add(this.buttonInfo_PVV);
            this.panelTop_PVV.Controls.Add(this.buttonDone_PVV);
            this.panelTop_PVV.Controls.Add(this.buttonOpen_PVV);
            this.panelTop_PVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_PVV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_PVV.Name = "panelTop_PVV";
            this.panelTop_PVV.Size = new System.Drawing.Size(941, 60);
            this.panelTop_PVV.TabIndex = 0;
            // 
            // buttonInfo_PVV
            // 
            this.buttonInfo_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo_PVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfo_PVV.Image")));
            this.buttonInfo_PVV.Location = new System.Drawing.Point(846, 3);
            this.buttonInfo_PVV.Name = "buttonInfo_PVV";
            this.buttonInfo_PVV.Size = new System.Drawing.Size(82, 50);
            this.buttonInfo_PVV.TabIndex = 2;
            this.toolTipInfo_PVV.SetToolTip(this.buttonInfo_PVV, "О программе");
            this.buttonInfo_PVV.UseVisualStyleBackColor = true;
            this.buttonInfo_PVV.Click += new System.EventHandler(this.buttonInfo_PVV_Click);
            // 
            // buttonDone_PVV
            // 
            this.buttonDone_PVV.Enabled = false;
            this.buttonDone_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_PVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_PVV.Image")));
            this.buttonDone_PVV.Location = new System.Drawing.Point(91, 3);
            this.buttonDone_PVV.Name = "buttonDone_PVV";
            this.buttonDone_PVV.Size = new System.Drawing.Size(82, 50);
            this.buttonDone_PVV.TabIndex = 1;
            this.toolTipInfo_PVV.SetToolTip(this.buttonDone_PVV, "Выводит предпоследнее слово каждой строки в\r\nрезультатирующую строку");
            this.buttonDone_PVV.UseVisualStyleBackColor = true;
            this.buttonDone_PVV.Click += new System.EventHandler(this.buttonDone_PVV_Click);
            // 
            // buttonOpen_PVV
            // 
            this.buttonOpen_PVV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpen_PVV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpen_PVV.Image")));
            this.buttonOpen_PVV.Location = new System.Drawing.Point(3, 3);
            this.buttonOpen_PVV.Name = "buttonOpen_PVV";
            this.buttonOpen_PVV.Size = new System.Drawing.Size(82, 50);
            this.buttonOpen_PVV.TabIndex = 0;
            this.toolTipInfo_PVV.SetToolTip(this.buttonOpen_PVV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpen_PVV.UseVisualStyleBackColor = true;
            this.buttonOpen_PVV.Click += new System.EventHandler(this.buttonOpen_PVV_Click);
            // 
            // groupBoxYslovie_PVV
            // 
            this.groupBoxYslovie_PVV.Controls.Add(this.textBoxYslovie_PVV);
            this.groupBoxYslovie_PVV.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxYslovie_PVV.Location = new System.Drawing.Point(0, 60);
            this.groupBoxYslovie_PVV.Name = "groupBoxYslovie_PVV";
            this.groupBoxYslovie_PVV.Size = new System.Drawing.Size(941, 83);
            this.groupBoxYslovie_PVV.TabIndex = 1;
            this.groupBoxYslovie_PVV.TabStop = false;
            this.groupBoxYslovie_PVV.Text = "Условие";
            // 
            // textBoxYslovie_PVV
            // 
            this.textBoxYslovie_PVV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxYslovie_PVV.Location = new System.Drawing.Point(12, 22);
            this.textBoxYslovie_PVV.Multiline = true;
            this.textBoxYslovie_PVV.Name = "textBoxYslovie_PVV";
            this.textBoxYslovie_PVV.ReadOnly = true;
            this.textBoxYslovie_PVV.Size = new System.Drawing.Size(917, 55);
            this.textBoxYslovie_PVV.TabIndex = 0;
            this.textBoxYslovie_PVV.Text = resources.GetString("textBoxYslovie_PVV.Text");
            // 
            // panelLeft_PVV
            // 
            this.panelLeft_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft_PVV.Controls.Add(this.groupBoxInput_PVV);
            this.panelLeft_PVV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_PVV.Location = new System.Drawing.Point(0, 143);
            this.panelLeft_PVV.Name = "panelLeft_PVV";
            this.panelLeft_PVV.Size = new System.Drawing.Size(487, 307);
            this.panelLeft_PVV.TabIndex = 2;
            // 
            // groupBoxInput_PVV
            // 
            this.groupBoxInput_PVV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInput_PVV.Controls.Add(this.textBoxInput_PVV);
            this.groupBoxInput_PVV.Location = new System.Drawing.Point(12, 6);
            this.groupBoxInput_PVV.Name = "groupBoxInput_PVV";
            this.groupBoxInput_PVV.Size = new System.Drawing.Size(468, 296);
            this.groupBoxInput_PVV.TabIndex = 0;
            this.groupBoxInput_PVV.TabStop = false;
            this.groupBoxInput_PVV.Text = "Ввод";
            // 
            // textBoxInput_PVV
            // 
            this.textBoxInput_PVV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput_PVV.Location = new System.Drawing.Point(7, 22);
            this.textBoxInput_PVV.Multiline = true;
            this.textBoxInput_PVV.Name = "textBoxInput_PVV";
            this.textBoxInput_PVV.ReadOnly = true;
            this.textBoxInput_PVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput_PVV.Size = new System.Drawing.Size(455, 266);
            this.textBoxInput_PVV.TabIndex = 0;
            // 
            // splitterLeftRight_PVV
            // 
            this.splitterLeftRight_PVV.Location = new System.Drawing.Point(487, 143);
            this.splitterLeftRight_PVV.Name = "splitterLeftRight_PVV";
            this.splitterLeftRight_PVV.Size = new System.Drawing.Size(3, 307);
            this.splitterLeftRight_PVV.TabIndex = 3;
            this.splitterLeftRight_PVV.TabStop = false;
            // 
            // panelRight_PVV
            // 
            this.panelRight_PVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight_PVV.Controls.Add(this.groupBoxOutput_PVV);
            this.panelRight_PVV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_PVV.Location = new System.Drawing.Point(490, 143);
            this.panelRight_PVV.Name = "panelRight_PVV";
            this.panelRight_PVV.Size = new System.Drawing.Size(451, 307);
            this.panelRight_PVV.TabIndex = 4;
            // 
            // groupBoxOutput_PVV
            // 
            this.groupBoxOutput_PVV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput_PVV.Controls.Add(this.textBoxOutput_PVV);
            this.groupBoxOutput_PVV.Location = new System.Drawing.Point(6, 6);
            this.groupBoxOutput_PVV.Name = "groupBoxOutput_PVV";
            this.groupBoxOutput_PVV.Size = new System.Drawing.Size(432, 288);
            this.groupBoxOutput_PVV.TabIndex = 0;
            this.groupBoxOutput_PVV.TabStop = false;
            this.groupBoxOutput_PVV.Text = "Вывод";
            // 
            // textBoxOutput_PVV
            // 
            this.textBoxOutput_PVV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutput_PVV.Location = new System.Drawing.Point(7, 22);
            this.textBoxOutput_PVV.Multiline = true;
            this.textBoxOutput_PVV.Name = "textBoxOutput_PVV";
            this.textBoxOutput_PVV.ReadOnly = true;
            this.textBoxOutput_PVV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput_PVV.Size = new System.Drawing.Size(419, 260);
            this.textBoxOutput_PVV.TabIndex = 0;
            // 
            // openFileDialogTask_PVV
            // 
            this.openFileDialogTask_PVV.FileName = "openFileDialog1";
            // 
            // toolTipInfo_PVV
            // 
            this.toolTipInfo_PVV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo_PVV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.panelRight_PVV);
            this.Controls.Add(this.splitterLeftRight_PVV);
            this.Controls.Add(this.panelLeft_PVV);
            this.Controls.Add(this.groupBoxYslovie_PVV);
            this.Controls.Add(this.panelTop_PVV);
            this.MinimumSize = new System.Drawing.Size(500, 50);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 16 | Пьянкова В. В.";
            this.panelTop_PVV.ResumeLayout(false);
            this.groupBoxYslovie_PVV.ResumeLayout(false);
            this.groupBoxYslovie_PVV.PerformLayout();
            this.panelLeft_PVV.ResumeLayout(false);
            this.groupBoxInput_PVV.ResumeLayout(false);
            this.groupBoxInput_PVV.PerformLayout();
            this.panelRight_PVV.ResumeLayout(false);
            this.groupBoxOutput_PVV.ResumeLayout(false);
            this.groupBoxOutput_PVV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_PVV;
        private System.Windows.Forms.GroupBox groupBoxYslovie_PVV;
        private System.Windows.Forms.TextBox textBoxYslovie_PVV;
        private System.Windows.Forms.Panel panelLeft_PVV;
        private System.Windows.Forms.Splitter splitterLeftRight_PVV;
        private System.Windows.Forms.Panel panelRight_PVV;
        private System.Windows.Forms.Button buttonInfo_PVV;
        private System.Windows.Forms.Button buttonDone_PVV;
        private System.Windows.Forms.Button buttonOpen_PVV;
        private System.Windows.Forms.GroupBox groupBoxInput_PVV;
        private System.Windows.Forms.TextBox textBoxInput_PVV;
        private System.Windows.Forms.GroupBox groupBoxOutput_PVV;
        private System.Windows.Forms.TextBox textBoxOutput_PVV;
        private System.Windows.Forms.ToolTip toolTipInfo_PVV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_PVV;
    }
}

