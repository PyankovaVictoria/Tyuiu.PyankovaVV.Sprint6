
namespace Tyuiu.PyankovaVV.Sprint6.Task6.V16
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAutor_PVV = new System.Windows.Forms.PictureBox();
            this.labelInfo_PVV = new System.Windows.Forms.Label();
            this.buttonOK_PVV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_PVV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAutor_PVV
            // 
            this.pictureBoxAutor_PVV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAutor_PVV.Image")));
            this.pictureBoxAutor_PVV.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxAutor_PVV.Name = "pictureBoxAutor_PVV";
            this.pictureBoxAutor_PVV.Size = new System.Drawing.Size(137, 198);
            this.pictureBoxAutor_PVV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAutor_PVV.TabIndex = 0;
            this.pictureBoxAutor_PVV.TabStop = false;
            // 
            // labelInfo_PVV
            // 
            this.labelInfo_PVV.AutoSize = true;
            this.labelInfo_PVV.Location = new System.Drawing.Point(157, 13);
            this.labelInfo_PVV.Name = "labelInfo_PVV";
            this.labelInfo_PVV.Size = new System.Drawing.Size(364, 153);
            this.labelInfo_PVV.TabIndex = 1;
            this.labelInfo_PVV.Text = resources.GetString("labelInfo_PVV.Text");
            // 
            // buttonOK_PVV
            // 
            this.buttonOK_PVV.Location = new System.Drawing.Point(441, 183);
            this.buttonOK_PVV.Name = "buttonOK_PVV";
            this.buttonOK_PVV.Size = new System.Drawing.Size(79, 27);
            this.buttonOK_PVV.TabIndex = 2;
            this.buttonOK_PVV.Text = "ОК";
            this.buttonOK_PVV.UseVisualStyleBackColor = true;
            this.buttonOK_PVV.Click += new System.EventHandler(this.buttonOK_PVV_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 223);
            this.Controls.Add(this.buttonOK_PVV);
            this.Controls.Add(this.labelInfo_PVV);
            this.Controls.Add(this.pictureBoxAutor_PVV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 270);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutor_PVV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAutor_PVV;
        private System.Windows.Forms.Label labelInfo_PVV;
        private System.Windows.Forms.Button buttonOK_PVV;
    }
}