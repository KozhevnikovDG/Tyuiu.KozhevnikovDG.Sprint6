
namespace Tyuiu.KozhevnikovDG.Sprint6.Task7.V25
{
    partial class FormAbout_KDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KDG));
            this.labelInfo_KDG = new System.Windows.Forms.Label();
            this.buttonInfo_KDG = new System.Windows.Forms.Button();
            this.pictureBoxInfo_KDG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KDG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KDG
            // 
            this.labelInfo_KDG.AutoSize = true;
            this.labelInfo_KDG.Location = new System.Drawing.Point(322, 32);
            this.labelInfo_KDG.Name = "labelInfo_KDG";
            this.labelInfo_KDG.Size = new System.Drawing.Size(385, 153);
            this.labelInfo_KDG.TabIndex = 1;
            this.labelInfo_KDG.Text = resources.GetString("labelInfo_KDG.Text");
            // 
            // buttonInfo_KDG
            // 
            this.buttonInfo_KDG.Location = new System.Drawing.Point(713, 307);
            this.buttonInfo_KDG.Name = "buttonInfo_KDG";
            this.buttonInfo_KDG.Size = new System.Drawing.Size(75, 44);
            this.buttonInfo_KDG.TabIndex = 2;
            this.buttonInfo_KDG.Text = "OK";
            this.buttonInfo_KDG.UseVisualStyleBackColor = true;
            this.buttonInfo_KDG.Click += new System.EventHandler(this.buttonInfo_KDG_Click);
            // 
            // pictureBoxInfo_KDG
            // 
            this.pictureBoxInfo_KDG.Image = global::Tyuiu.KozhevnikovDG.Sprint6.Task7.V25.Properties.Resources.VfZH0Ksf2Is;
            this.pictureBoxInfo_KDG.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxInfo_KDG.Name = "pictureBoxInfo_KDG";
            this.pictureBoxInfo_KDG.Size = new System.Drawing.Size(303, 338);
            this.pictureBoxInfo_KDG.TabIndex = 0;
            this.pictureBoxInfo_KDG.TabStop = false;
            // 
            // FormAbout_KDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.Controls.Add(this.buttonInfo_KDG);
            this.Controls.Add(this.labelInfo_KDG);
            this.Controls.Add(this.pictureBoxInfo_KDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_KDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo_KDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxInfo_KDG;
        private System.Windows.Forms.Label labelInfo_KDG;
        private System.Windows.Forms.Button buttonInfo_KDG;
    }
}