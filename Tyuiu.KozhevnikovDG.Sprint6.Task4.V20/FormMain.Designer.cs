
namespace Tyuiu.KozhevnikovDG.Sprint6.Task4.V20
{
    partial class FormMaim_KDG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_KDG = new System.Windows.Forms.Panel();
            this.buttonHelp_KDG = new System.Windows.Forms.Button();
            this.buttonSave_KDG = new System.Windows.Forms.Button();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.groupBoxInPutData_KDG = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KDG = new System.Windows.Forms.Label();
            this.labelStartStep_KDG = new System.Windows.Forms.Label();
            this.textBoxStopStep_KDG = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KDG = new System.Windows.Forms.TextBox();
            this.panelResult_KDG = new System.Windows.Forms.Panel();
            this.groupBoxResult_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxResult_KDG = new System.Windows.Forms.TextBox();
            this.panelFunction_KDG = new System.Windows.Forms.Panel();
            this.chartFunction_KDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTask_KDG.SuspendLayout();
            this.groupBoxInPutData_KDG.SuspendLayout();
            this.groupBoxCondition_KDG.SuspendLayout();
            this.panelResult_KDG.SuspendLayout();
            this.groupBoxResult_KDG.SuspendLayout();
            this.panelFunction_KDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_KDG
            // 
            this.panelTask_KDG.BackColor = System.Drawing.Color.White;
            this.panelTask_KDG.Controls.Add(this.buttonHelp_KDG);
            this.panelTask_KDG.Controls.Add(this.buttonSave_KDG);
            this.panelTask_KDG.Controls.Add(this.buttonDone_KDG);
            this.panelTask_KDG.Controls.Add(this.groupBoxInPutData_KDG);
            this.panelTask_KDG.Controls.Add(this.groupBoxCondition_KDG);
            this.panelTask_KDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_KDG.Location = new System.Drawing.Point(0, 0);
            this.panelTask_KDG.Name = "panelTask_KDG";
            this.panelTask_KDG.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_KDG.Size = new System.Drawing.Size(1051, 111);
            this.panelTask_KDG.TabIndex = 0;
            // 
            // buttonHelp_KDG
            // 
            this.buttonHelp_KDG.BackColor = System.Drawing.Color.Blue;
            this.buttonHelp_KDG.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_KDG.Location = new System.Drawing.Point(954, 5);
            this.buttonHelp_KDG.Name = "buttonHelp_KDG";
            this.buttonHelp_KDG.Size = new System.Drawing.Size(92, 101);
            this.buttonHelp_KDG.TabIndex = 4;
            this.buttonHelp_KDG.Text = "Справка";
            this.buttonHelp_KDG.UseVisualStyleBackColor = false;
            this.buttonHelp_KDG.Click += new System.EventHandler(this.buttonHelp_KDG_Click);
            // 
            // buttonSave_KDG
            // 
            this.buttonSave_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSave_KDG.Location = new System.Drawing.Point(856, 12);
            this.buttonSave_KDG.Name = "buttonSave_KDG";
            this.buttonSave_KDG.Size = new System.Drawing.Size(92, 92);
            this.buttonSave_KDG.TabIndex = 3;
            this.buttonSave_KDG.Text = "Сохранить ";
            this.buttonSave_KDG.UseVisualStyleBackColor = false;
            this.buttonSave_KDG.Click += new System.EventHandler(this.buttonSave_KDG_Click);
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KDG.Location = new System.Drawing.Point(752, 12);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(98, 92);
            this.buttonDone_KDG.TabIndex = 2;
            this.buttonDone_KDG.Text = "Выполнить ";
            this.buttonDone_KDG.UseVisualStyleBackColor = false;
            this.buttonDone_KDG.Click += new System.EventHandler(this.buttonDone_KDG_Click);
            // 
            // groupBoxInPutData_KDG
            // 
            this.groupBoxInPutData_KDG.Controls.Add(this.labelStopStep_KDG);
            this.groupBoxInPutData_KDG.Controls.Add(this.labelStartStep_KDG);
            this.groupBoxInPutData_KDG.Controls.Add(this.textBoxStopStep_KDG);
            this.groupBoxInPutData_KDG.Controls.Add(this.textBoxStartStep_KDG);
            this.groupBoxInPutData_KDG.Location = new System.Drawing.Point(477, 4);
            this.groupBoxInPutData_KDG.Name = "groupBoxInPutData_KDG";
            this.groupBoxInPutData_KDG.Size = new System.Drawing.Size(265, 101);
            this.groupBoxInPutData_KDG.TabIndex = 1;
            this.groupBoxInPutData_KDG.TabStop = false;
            this.groupBoxInPutData_KDG.Text = "Ввод данных:";
            // 
            // labelStopStep_KDG
            // 
            this.labelStopStep_KDG.AutoSize = true;
            this.labelStopStep_KDG.Location = new System.Drawing.Point(127, 22);
            this.labelStopStep_KDG.Name = "labelStopStep_KDG";
            this.labelStopStep_KDG.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_KDG.TabIndex = 3;
            this.labelStopStep_KDG.Text = "Конец шага:";
            // 
            // labelStartStep_KDG
            // 
            this.labelStartStep_KDG.AutoSize = true;
            this.labelStartStep_KDG.Location = new System.Drawing.Point(6, 22);
            this.labelStartStep_KDG.Name = "labelStartStep_KDG";
            this.labelStartStep_KDG.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_KDG.TabIndex = 2;
            this.labelStartStep_KDG.Text = "Старт шага:";
            // 
            // textBoxStopStep_KDG
            // 
            this.textBoxStopStep_KDG.Location = new System.Drawing.Point(130, 46);
            this.textBoxStopStep_KDG.Multiline = true;
            this.textBoxStopStep_KDG.Name = "textBoxStopStep_KDG";
            this.textBoxStopStep_KDG.Size = new System.Drawing.Size(129, 37);
            this.textBoxStopStep_KDG.TabIndex = 1;
            // 
            // textBoxStartStep_KDG
            // 
            this.textBoxStartStep_KDG.Location = new System.Drawing.Point(6, 46);
            this.textBoxStartStep_KDG.Multiline = true;
            this.textBoxStartStep_KDG.Name = "textBoxStartStep_KDG";
            this.textBoxStartStep_KDG.Size = new System.Drawing.Size(117, 37);
            this.textBoxStartStep_KDG.TabIndex = 0;
            // 
            // groupBoxCondition_KDG
            // 
            this.groupBoxCondition_KDG.Controls.Add(this.textBoxCondition_KDG);
            this.groupBoxCondition_KDG.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition_KDG.Name = "groupBoxCondition_KDG";
            this.groupBoxCondition_KDG.Size = new System.Drawing.Size(467, 101);
            this.groupBoxCondition_KDG.TabIndex = 0;
            this.groupBoxCondition_KDG.TabStop = false;
            this.groupBoxCondition_KDG.Text = "Условие:";
            // 
            // textBoxCondition_KDG
            // 
            this.textBoxCondition_KDG.Location = new System.Drawing.Point(4, 22);
            this.textBoxCondition_KDG.Multiline = true;
            this.textBoxCondition_KDG.Name = "textBoxCondition_KDG";
            this.textBoxCondition_KDG.ReadOnly = true;
            this.textBoxCondition_KDG.Size = new System.Drawing.Size(457, 73);
            this.textBoxCondition_KDG.TabIndex = 0;
            this.textBoxCondition_KDG.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox, построить график функции и сохранить в файл\r\nOutPutFileTask.txt по нажати" +
    "ю кнопки.";
            // 
            // panelResult_KDG
            // 
            this.panelResult_KDG.BackColor = System.Drawing.Color.White;
            this.panelResult_KDG.Controls.Add(this.groupBoxResult_KDG);
            this.panelResult_KDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_KDG.Location = new System.Drawing.Point(0, 111);
            this.panelResult_KDG.Name = "panelResult_KDG";
            this.panelResult_KDG.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_KDG.Size = new System.Drawing.Size(218, 449);
            this.panelResult_KDG.TabIndex = 0;
            // 
            // groupBoxResult_KDG
            // 
            this.groupBoxResult_KDG.BackColor = System.Drawing.Color.White;
            this.groupBoxResult_KDG.Controls.Add(this.textBoxResult_KDG);
            this.groupBoxResult_KDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_KDG.Location = new System.Drawing.Point(5, 5);
            this.groupBoxResult_KDG.Name = "groupBoxResult_KDG";
            this.groupBoxResult_KDG.Size = new System.Drawing.Size(208, 439);
            this.groupBoxResult_KDG.TabIndex = 0;
            this.groupBoxResult_KDG.TabStop = false;
            this.groupBoxResult_KDG.Text = "Вывод:";
            // 
            // textBoxResult_KDG
            // 
            this.textBoxResult_KDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KDG.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_KDG.Multiline = true;
            this.textBoxResult_KDG.Name = "textBoxResult_KDG";
            this.textBoxResult_KDG.ReadOnly = true;
            this.textBoxResult_KDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KDG.Size = new System.Drawing.Size(202, 418);
            this.textBoxResult_KDG.TabIndex = 0;
            // 
            // panelFunction_KDG
            // 
            this.panelFunction_KDG.BackColor = System.Drawing.Color.White;
            this.panelFunction_KDG.Controls.Add(this.chartFunction_KDG);
            this.panelFunction_KDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_KDG.Location = new System.Drawing.Point(218, 111);
            this.panelFunction_KDG.Name = "panelFunction_KDG";
            this.panelFunction_KDG.Size = new System.Drawing.Size(833, 449);
            this.panelFunction_KDG.TabIndex = 0;
            // 
            // chartFunction_KDG
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_KDG.ChartAreas.Add(chartArea1);
            this.chartFunction_KDG.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFunction_KDG.Legends.Add(legend1);
            this.chartFunction_KDG.Location = new System.Drawing.Point(0, 0);
            this.chartFunction_KDG.Name = "chartFunction_KDG";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_KDG.Series.Add(series1);
            this.chartFunction_KDG.Size = new System.Drawing.Size(833, 449);
            this.chartFunction_KDG.TabIndex = 0;
            this.chartFunction_KDG.Text = "chart1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(218, 111);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 449);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // FormMaim_KDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 560);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelFunction_KDG);
            this.Controls.Add(this.panelResult_KDG);
            this.Controls.Add(this.panelTask_KDG);
            this.MinimumSize = new System.Drawing.Size(1060, 607);
            this.Name = "FormMaim_KDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 20 | Кожевников Д. Г.";
            this.panelTask_KDG.ResumeLayout(false);
            this.groupBoxInPutData_KDG.ResumeLayout(false);
            this.groupBoxInPutData_KDG.PerformLayout();
            this.groupBoxCondition_KDG.ResumeLayout(false);
            this.groupBoxCondition_KDG.PerformLayout();
            this.panelResult_KDG.ResumeLayout(false);
            this.groupBoxResult_KDG.ResumeLayout(false);
            this.groupBoxResult_KDG.PerformLayout();
            this.panelFunction_KDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_KDG;
        private System.Windows.Forms.Panel panelResult_KDG;
        private System.Windows.Forms.Panel panelFunction_KDG;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxInPutData_KDG;
        private System.Windows.Forms.GroupBox groupBoxCondition_KDG;
        private System.Windows.Forms.GroupBox groupBoxResult_KDG;
        private System.Windows.Forms.TextBox textBoxResult_KDG;
        private System.Windows.Forms.TextBox textBoxStopStep_KDG;
        private System.Windows.Forms.TextBox textBoxStartStep_KDG;
        private System.Windows.Forms.TextBox textBoxCondition_KDG;
        private System.Windows.Forms.Button buttonHelp_KDG;
        private System.Windows.Forms.Button buttonSave_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.Label labelStopStep_KDG;
        private System.Windows.Forms.Label labelStartStep_KDG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDG;
    }
}

