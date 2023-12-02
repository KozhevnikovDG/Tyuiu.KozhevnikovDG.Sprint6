
namespace Tyuiu.KozhevnikovDG.Sprint6.Task0.V1
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
            this.pictureBoxFormula_KDG = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_KDG = new System.Windows.Forms.GroupBox();
            this.labelVarX_KDG = new System.Windows.Forms.Label();
            this.textBoxVarX_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_KDG = new System.Windows.Forms.GroupBox();
            this.labelResult_KDG = new System.Windows.Forms.Label();
            this.textBoxResult_KDG = new System.Windows.Forms.TextBox();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.textBoxTask_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KDG = new System.Windows.Forms.GroupBox();
            this.buttonHelp_KDG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDG)).BeginInit();
            this.groupBoxInputData_KDG.SuspendLayout();
            this.groupBoxOutPutData_KDG.SuspendLayout();
            this.groupBoxTask_KDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFormula_KDG
            // 
            this.pictureBoxFormula_KDG.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula_KDG.Image")));
            this.pictureBoxFormula_KDG.Location = new System.Drawing.Point(567, 21);
            this.pictureBoxFormula_KDG.Name = "pictureBoxFormula_KDG";
            this.pictureBoxFormula_KDG.Size = new System.Drawing.Size(189, 105);
            this.pictureBoxFormula_KDG.TabIndex = 0;
            this.pictureBoxFormula_KDG.TabStop = false;
            // 
            // groupBoxInputData_KDG
            // 
            this.groupBoxInputData_KDG.Controls.Add(this.labelVarX_KDG);
            this.groupBoxInputData_KDG.Controls.Add(this.textBoxVarX_KDG);
            this.groupBoxInputData_KDG.Location = new System.Drawing.Point(25, 223);
            this.groupBoxInputData_KDG.Name = "groupBoxInputData_KDG";
            this.groupBoxInputData_KDG.Size = new System.Drawing.Size(440, 163);
            this.groupBoxInputData_KDG.TabIndex = 1;
            this.groupBoxInputData_KDG.TabStop = false;
            this.groupBoxInputData_KDG.Text = "Ввод данных :";
            // 
            // labelVarX_KDG
            // 
            this.labelVarX_KDG.AutoSize = true;
            this.labelVarX_KDG.Location = new System.Drawing.Point(9, 35);
            this.labelVarX_KDG.Name = "labelVarX_KDG";
            this.labelVarX_KDG.Size = new System.Drawing.Size(21, 17);
            this.labelVarX_KDG.TabIndex = 1;
            this.labelVarX_KDG.Text = "X:";
            // 
            // textBoxVarX_KDG
            // 
            this.textBoxVarX_KDG.Location = new System.Drawing.Point(6, 55);
            this.textBoxVarX_KDG.Name = "textBoxVarX_KDG";
            this.textBoxVarX_KDG.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarX_KDG.TabIndex = 0;
            this.textBoxVarX_KDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KDG_KeyPress);
            // 
            // groupBoxOutPutData_KDG
            // 
            this.groupBoxOutPutData_KDG.Controls.Add(this.labelResult_KDG);
            this.groupBoxOutPutData_KDG.Controls.Add(this.textBoxResult_KDG);
            this.groupBoxOutPutData_KDG.Location = new System.Drawing.Point(480, 223);
            this.groupBoxOutPutData_KDG.Name = "groupBoxOutPutData_KDG";
            this.groupBoxOutPutData_KDG.Size = new System.Drawing.Size(308, 163);
            this.groupBoxOutPutData_KDG.TabIndex = 2;
            this.groupBoxOutPutData_KDG.TabStop = false;
            this.groupBoxOutPutData_KDG.Text = "Вывод данных :";
            // 
            // labelResult_KDG
            // 
            this.labelResult_KDG.AutoSize = true;
            this.labelResult_KDG.Location = new System.Drawing.Point(7, 32);
            this.labelResult_KDG.Name = "labelResult_KDG";
            this.labelResult_KDG.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KDG.TabIndex = 1;
            this.labelResult_KDG.Text = "Результат:";
            // 
            // textBoxResult_KDG
            // 
            this.textBoxResult_KDG.Location = new System.Drawing.Point(6, 55);
            this.textBoxResult_KDG.Name = "textBoxResult_KDG";
            this.textBoxResult_KDG.ReadOnly = true;
            this.textBoxResult_KDG.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_KDG.TabIndex = 0;
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.Location = new System.Drawing.Point(658, 392);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(130, 52);
            this.buttonDone_KDG.TabIndex = 2;
            this.buttonDone_KDG.Text = "Выполнить";
            this.buttonDone_KDG.UseVisualStyleBackColor = true;
            this.buttonDone_KDG.Click += new System.EventHandler(this.buttonDone_KDG_Click);
            // 
            // textBoxTask_KDG
            // 
            this.textBoxTask_KDG.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_KDG.Multiline = true;
            this.textBoxTask_KDG.Name = "textBoxTask_KDG";
            this.textBoxTask_KDG.Size = new System.Drawing.Size(555, 177);
            this.textBoxTask_KDG.TabIndex = 3;
            this.textBoxTask_KDG.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxTask_KDG
            // 
            this.groupBoxTask_KDG.Controls.Add(this.textBoxTask_KDG);
            this.groupBoxTask_KDG.Controls.Add(this.pictureBoxFormula_KDG);
            this.groupBoxTask_KDG.Location = new System.Drawing.Point(25, 4);
            this.groupBoxTask_KDG.Name = "groupBoxTask_KDG";
            this.groupBoxTask_KDG.Size = new System.Drawing.Size(763, 220);
            this.groupBoxTask_KDG.TabIndex = 4;
            this.groupBoxTask_KDG.TabStop = false;
            this.groupBoxTask_KDG.Text = "Условие";
            // 
            // buttonHelp_KDG
            // 
            this.buttonHelp_KDG.Location = new System.Drawing.Point(592, 392);
            this.buttonHelp_KDG.Name = "buttonHelp_KDG";
            this.buttonHelp_KDG.Size = new System.Drawing.Size(60, 52);
            this.buttonHelp_KDG.TabIndex = 5;
            this.buttonHelp_KDG.Text = "?";
            this.buttonHelp_KDG.UseVisualStyleBackColor = true;
            this.buttonHelp_KDG.Click += new System.EventHandler(this.buttonHelp_KDG_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp_KDG);
            this.Controls.Add(this.groupBoxTask_KDG);
            this.Controls.Add(this.buttonDone_KDG);
            this.Controls.Add(this.groupBoxOutPutData_KDG);
            this.Controls.Add(this.groupBoxInputData_KDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 1 | Кожевников Д. Г.";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KDG)).EndInit();
            this.groupBoxInputData_KDG.ResumeLayout(false);
            this.groupBoxInputData_KDG.PerformLayout();
            this.groupBoxOutPutData_KDG.ResumeLayout(false);
            this.groupBoxOutPutData_KDG.PerformLayout();
            this.groupBoxTask_KDG.ResumeLayout(false);
            this.groupBoxTask_KDG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxFormula_KDG;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDG;
        private System.Windows.Forms.TextBox textBoxVarX_KDG;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KDG;
        private System.Windows.Forms.Label labelVarX_KDG;
        private System.Windows.Forms.TextBox textBoxResult_KDG;
        private System.Windows.Forms.Label labelResult_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.TextBox textBoxTask_KDG;
        private System.Windows.Forms.GroupBox groupBoxTask_KDG;
        private System.Windows.Forms.Button buttonHelp_KDG;
    }
}

