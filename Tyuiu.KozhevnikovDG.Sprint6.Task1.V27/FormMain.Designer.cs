
namespace Tyuiu.KozhevnikovDG.Sprint6.Task1.V27
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
            this.groupBoxTask_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KDG = new System.Windows.Forms.TextBox();
            this.labelResult_KDG = new System.Windows.Forms.Label();
            this.groupBoxInputData_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxStartStep_KDG = new System.Windows.Forms.TextBox();
            this.labelStartStep_KDG = new System.Windows.Forms.Label();
            this.textBoxStopStep_KDG = new System.Windows.Forms.TextBox();
            this.labelStopStep_KDG = new System.Windows.Forms.Label();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTask_KDG.SuspendLayout();
            this.groupBoxResult_KDG.SuspendLayout();
            this.groupBoxInputData_KDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KDG
            // 
            this.groupBoxTask_KDG.Controls.Add(this.textBoxTask_KDG);
            this.groupBoxTask_KDG.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KDG.Name = "groupBoxTask_KDG";
            this.groupBoxTask_KDG.Size = new System.Drawing.Size(461, 330);
            this.groupBoxTask_KDG.TabIndex = 0;
            this.groupBoxTask_KDG.TabStop = false;
            this.groupBoxTask_KDG.Text = "Условие";
            // 
            // textBoxTask_KDG
            // 
            this.textBoxTask_KDG.Location = new System.Drawing.Point(7, 22);
            this.textBoxTask_KDG.Multiline = true;
            this.textBoxTask_KDG.Name = "textBoxTask_KDG";
            this.textBoxTask_KDG.ReadOnly = true;
            this.textBoxTask_KDG.Size = new System.Drawing.Size(448, 302);
            this.textBoxTask_KDG.TabIndex = 0;
            this.textBoxTask_KDG.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы." +
    "";
            // 
            // groupBoxResult_KDG
            // 
            this.groupBoxResult_KDG.Controls.Add(this.labelResult_KDG);
            this.groupBoxResult_KDG.Controls.Add(this.textBoxResult_KDG);
            this.groupBoxResult_KDG.Location = new System.Drawing.Point(480, 13);
            this.groupBoxResult_KDG.Name = "groupBoxResult_KDG";
            this.groupBoxResult_KDG.Size = new System.Drawing.Size(295, 425);
            this.groupBoxResult_KDG.TabIndex = 1;
            this.groupBoxResult_KDG.TabStop = false;
            this.groupBoxResult_KDG.Text = "Вывод данных";
            // 
            // textBoxResult_KDG
            // 
            this.textBoxResult_KDG.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KDG.Location = new System.Drawing.Point(6, 42);
            this.textBoxResult_KDG.Multiline = true;
            this.textBoxResult_KDG.Name = "textBoxResult_KDG";
            this.textBoxResult_KDG.ReadOnly = true;
            this.textBoxResult_KDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KDG.Size = new System.Drawing.Size(283, 375);
            this.textBoxResult_KDG.TabIndex = 0;
            // 
            // labelResult_KDG
            // 
            this.labelResult_KDG.AutoSize = true;
            this.labelResult_KDG.Location = new System.Drawing.Point(7, 22);
            this.labelResult_KDG.Name = "labelResult_KDG";
            this.labelResult_KDG.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KDG.TabIndex = 1;
            this.labelResult_KDG.Text = "Результат:";
            // 
            // groupBoxInputData_KDG
            // 
            this.groupBoxInputData_KDG.Controls.Add(this.labelStopStep_KDG);
            this.groupBoxInputData_KDG.Controls.Add(this.textBoxStopStep_KDG);
            this.groupBoxInputData_KDG.Controls.Add(this.labelStartStep_KDG);
            this.groupBoxInputData_KDG.Controls.Add(this.textBoxStartStep_KDG);
            this.groupBoxInputData_KDG.Location = new System.Drawing.Point(13, 349);
            this.groupBoxInputData_KDG.Name = "groupBoxInputData_KDG";
            this.groupBoxInputData_KDG.Size = new System.Drawing.Size(274, 89);
            this.groupBoxInputData_KDG.TabIndex = 2;
            this.groupBoxInputData_KDG.TabStop = false;
            this.groupBoxInputData_KDG.Text = "Ввод данных";
            // 
            // textBoxStartStep_KDG
            // 
            this.textBoxStartStep_KDG.Location = new System.Drawing.Point(6, 41);
            this.textBoxStartStep_KDG.Multiline = true;
            this.textBoxStartStep_KDG.Name = "textBoxStartStep_KDG";
            this.textBoxStartStep_KDG.Size = new System.Drawing.Size(130, 42);
            this.textBoxStartStep_KDG.TabIndex = 0;
            // 
            // labelStartStep_KDG
            // 
            this.labelStartStep_KDG.AutoSize = true;
            this.labelStartStep_KDG.Location = new System.Drawing.Point(6, 18);
            this.labelStartStep_KDG.Name = "labelStartStep_KDG";
            this.labelStartStep_KDG.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_KDG.TabIndex = 1;
            this.labelStartStep_KDG.Text = "Старт шага:";
            // 
            // textBoxStopStep_KDG
            // 
            this.textBoxStopStep_KDG.Location = new System.Drawing.Point(142, 41);
            this.textBoxStopStep_KDG.Multiline = true;
            this.textBoxStopStep_KDG.Name = "textBoxStopStep_KDG";
            this.textBoxStopStep_KDG.Size = new System.Drawing.Size(126, 42);
            this.textBoxStopStep_KDG.TabIndex = 2;
            // 
            // labelStopStep_KDG
            // 
            this.labelStopStep_KDG.AutoSize = true;
            this.labelStopStep_KDG.Location = new System.Drawing.Point(139, 18);
            this.labelStopStep_KDG.Name = "labelStopStep_KDG";
            this.labelStopStep_KDG.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_KDG.TabIndex = 3;
            this.labelStopStep_KDG.Text = "Конец шага:";
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDone_KDG.Location = new System.Drawing.Point(382, 355);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(92, 83);
            this.buttonDone_KDG.TabIndex = 3;
            this.buttonDone_KDG.Text = "Выполнить";
            this.buttonDone_KDG.UseVisualStyleBackColor = false;
            this.buttonDone_KDG.Click += new System.EventHandler(this.buttonDone_KDG_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonHelp.Location = new System.Drawing.Point(293, 355);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(83, 83);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonDone_KDG);
            this.Controls.Add(this.groupBoxInputData_KDG);
            this.Controls.Add(this.groupBoxResult_KDG);
            this.Controls.Add(this.groupBoxTask_KDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 27 | Кожевников Д. Г.";
            this.groupBoxTask_KDG.ResumeLayout(false);
            this.groupBoxTask_KDG.PerformLayout();
            this.groupBoxResult_KDG.ResumeLayout(false);
            this.groupBoxResult_KDG.PerformLayout();
            this.groupBoxInputData_KDG.ResumeLayout(false);
            this.groupBoxInputData_KDG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KDG;
        private System.Windows.Forms.TextBox textBoxTask_KDG;
        private System.Windows.Forms.GroupBox groupBoxResult_KDG;
        private System.Windows.Forms.Label labelResult_KDG;
        private System.Windows.Forms.TextBox textBoxResult_KDG;
        private System.Windows.Forms.GroupBox groupBoxInputData_KDG;
        private System.Windows.Forms.Label labelStartStep_KDG;
        private System.Windows.Forms.TextBox textBoxStartStep_KDG;
        private System.Windows.Forms.Label labelStopStep_KDG;
        private System.Windows.Forms.TextBox textBoxStopStep_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.Button buttonHelp;
    }
}

