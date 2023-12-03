
namespace Tyuiu.KozhevnikovDG.Sprint6.Task2.V23
{
    partial class FormMain_KDG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxInpuData_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxVarStartStep_KDG = new System.Windows.Forms.TextBox();
            this.labelVarStartStep_KDG = new System.Windows.Forms.Label();
            this.labelVarStopStep_KDG = new System.Windows.Forms.Label();
            this.textBoxVarStopStep_KDG = new System.Windows.Forms.TextBox();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.buttonHelp_KDG = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_KDG = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_KDG = new System.Windows.Forms.DataGridView();
            this.labelOutPutData_KDG = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colums_KDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_KDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_KDG.SuspendLayout();
            this.groupBoxInpuData_KDG.SuspendLayout();
            this.groupBoxOutPutData_KDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDG)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_KDG
            // 
            this.groupBoxTask_KDG.Controls.Add(this.textBoxTask_KDG);
            this.groupBoxTask_KDG.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_KDG.Name = "groupBoxTask_KDG";
            this.groupBoxTask_KDG.Size = new System.Drawing.Size(521, 306);
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
            this.textBoxTask_KDG.Size = new System.Drawing.Size(508, 276);
            this.textBoxTask_KDG.TabIndex = 0;
            this.textBoxTask_KDG.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView " +
    "и построить график функции.";
            // 
            // groupBoxInpuData_KDG
            // 
            this.groupBoxInpuData_KDG.Controls.Add(this.textBoxVarStopStep_KDG);
            this.groupBoxInpuData_KDG.Controls.Add(this.labelVarStopStep_KDG);
            this.groupBoxInpuData_KDG.Controls.Add(this.labelVarStartStep_KDG);
            this.groupBoxInpuData_KDG.Controls.Add(this.textBoxVarStartStep_KDG);
            this.groupBoxInpuData_KDG.Location = new System.Drawing.Point(13, 343);
            this.groupBoxInpuData_KDG.Name = "groupBoxInpuData_KDG";
            this.groupBoxInpuData_KDG.Size = new System.Drawing.Size(317, 95);
            this.groupBoxInpuData_KDG.TabIndex = 1;
            this.groupBoxInpuData_KDG.TabStop = false;
            this.groupBoxInpuData_KDG.Text = "Ввод данных";
            // 
            // textBoxVarStartStep_KDG
            // 
            this.textBoxVarStartStep_KDG.Location = new System.Drawing.Point(7, 55);
            this.textBoxVarStartStep_KDG.Multiline = true;
            this.textBoxVarStartStep_KDG.Name = "textBoxVarStartStep_KDG";
            this.textBoxVarStartStep_KDG.Size = new System.Drawing.Size(145, 39);
            this.textBoxVarStartStep_KDG.TabIndex = 0;
            // 
            // labelVarStartStep_KDG
            // 
            this.labelVarStartStep_KDG.AutoSize = true;
            this.labelVarStartStep_KDG.Location = new System.Drawing.Point(6, 32);
            this.labelVarStartStep_KDG.Name = "labelVarStartStep_KDG";
            this.labelVarStartStep_KDG.Size = new System.Drawing.Size(87, 17);
            this.labelVarStartStep_KDG.TabIndex = 1;
            this.labelVarStartStep_KDG.Text = "Старт шага:";
            // 
            // labelVarStopStep_KDG
            // 
            this.labelVarStopStep_KDG.AutoSize = true;
            this.labelVarStopStep_KDG.Location = new System.Drawing.Point(155, 35);
            this.labelVarStopStep_KDG.Name = "labelVarStopStep_KDG";
            this.labelVarStopStep_KDG.Size = new System.Drawing.Size(89, 17);
            this.labelVarStopStep_KDG.TabIndex = 2;
            this.labelVarStopStep_KDG.Text = "Конец шага:";
            // 
            // textBoxVarStopStep_KDG
            // 
            this.textBoxVarStopStep_KDG.Location = new System.Drawing.Point(158, 55);
            this.textBoxVarStopStep_KDG.Multiline = true;
            this.textBoxVarStopStep_KDG.Name = "textBoxVarStopStep_KDG";
            this.textBoxVarStopStep_KDG.Size = new System.Drawing.Size(153, 39);
            this.textBoxVarStopStep_KDG.TabIndex = 3;
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KDG.Location = new System.Drawing.Point(434, 348);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(100, 90);
            this.buttonDone_KDG.TabIndex = 2;
            this.buttonDone_KDG.Text = "Выполнить ";
            this.buttonDone_KDG.UseVisualStyleBackColor = false;
            this.buttonDone_KDG.Click += new System.EventHandler(this.buttonDone_KDG_Click);
            this.buttonDone_KDG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KDG_MouseDown);
            this.buttonDone_KDG.MouseEnter += new System.EventHandler(this.buttonDone_KDG_MouseEnter);
            this.buttonDone_KDG.MouseLeave += new System.EventHandler(this.buttonDone_KDG_MouseLeave);
            // 
            // buttonHelp_KDG
            // 
            this.buttonHelp_KDG.BackColor = System.Drawing.Color.Aqua;
            this.buttonHelp_KDG.Location = new System.Drawing.Point(336, 348);
            this.buttonHelp_KDG.Name = "buttonHelp_KDG";
            this.buttonHelp_KDG.Size = new System.Drawing.Size(92, 89);
            this.buttonHelp_KDG.TabIndex = 3;
            this.buttonHelp_KDG.Text = "Справка";
            this.buttonHelp_KDG.UseVisualStyleBackColor = false;
            this.buttonHelp_KDG.Click += new System.EventHandler(this.buttonHelp_KDG_Click);
            // 
            // groupBoxOutPutData_KDG
            // 
            this.groupBoxOutPutData_KDG.Controls.Add(this.chartFunction_KDG);
            this.groupBoxOutPutData_KDG.Controls.Add(this.labelOutPutData_KDG);
            this.groupBoxOutPutData_KDG.Controls.Add(this.dataGridViewFunction_KDG);
            this.groupBoxOutPutData_KDG.Location = new System.Drawing.Point(541, 13);
            this.groupBoxOutPutData_KDG.Name = "groupBoxOutPutData_KDG";
            this.groupBoxOutPutData_KDG.Size = new System.Drawing.Size(716, 424);
            this.groupBoxOutPutData_KDG.TabIndex = 4;
            this.groupBoxOutPutData_KDG.TabStop = false;
            this.groupBoxOutPutData_KDG.Text = "Вывод данных ";
            // 
            // dataGridViewFunction_KDG
            // 
            this.dataGridViewFunction_KDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Colums_KDG});
            this.dataGridViewFunction_KDG.Location = new System.Drawing.Point(9, 53);
            this.dataGridViewFunction_KDG.Name = "dataGridViewFunction_KDG";
            this.dataGridViewFunction_KDG.RowHeadersVisible = false;
            this.dataGridViewFunction_KDG.RowHeadersWidth = 51;
            this.dataGridViewFunction_KDG.RowTemplate.Height = 24;
            this.dataGridViewFunction_KDG.Size = new System.Drawing.Size(153, 365);
            this.dataGridViewFunction_KDG.TabIndex = 0;
            // 
            // labelOutPutData_KDG
            // 
            this.labelOutPutData_KDG.AutoSize = true;
            this.labelOutPutData_KDG.Location = new System.Drawing.Point(6, 33);
            this.labelOutPutData_KDG.Name = "labelOutPutData_KDG";
            this.labelOutPutData_KDG.Size = new System.Drawing.Size(80, 17);
            this.labelOutPutData_KDG.TabIndex = 1;
            this.labelOutPutData_KDG.Text = "Результат:";
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Colums_KDG
            // 
            this.Colums_KDG.HeaderText = "F(X)";
            this.Colums_KDG.MinimumWidth = 6;
            this.Colums_KDG.Name = "Colums_KDG";
            this.Colums_KDG.ReadOnly = true;
            this.Colums_KDG.Width = 50;
            // 
            // chartFunction_KDG
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction_KDG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_KDG.Legends.Add(legend2);
            this.chartFunction_KDG.Location = new System.Drawing.Point(168, 53);
            this.chartFunction_KDG.Name = "chartFunction_KDG";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_KDG.Series.Add(series2);
            this.chartFunction_KDG.Size = new System.Drawing.Size(542, 365);
            this.chartFunction_KDG.TabIndex = 2;
            this.chartFunction_KDG.Text = "chart1";
            // 
            // FormMain_KDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 450);
            this.Controls.Add(this.groupBoxOutPutData_KDG);
            this.Controls.Add(this.buttonHelp_KDG);
            this.Controls.Add(this.buttonDone_KDG);
            this.Controls.Add(this.groupBoxInpuData_KDG);
            this.Controls.Add(this.groupBoxTask_KDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_KDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 23 | Кожевников Д. Г.";
            this.groupBoxTask_KDG.ResumeLayout(false);
            this.groupBoxTask_KDG.PerformLayout();
            this.groupBoxInpuData_KDG.ResumeLayout(false);
            this.groupBoxInpuData_KDG.PerformLayout();
            this.groupBoxOutPutData_KDG.ResumeLayout(false);
            this.groupBoxOutPutData_KDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KDG;
        private System.Windows.Forms.TextBox textBoxTask_KDG;
        private System.Windows.Forms.GroupBox groupBoxInpuData_KDG;
        private System.Windows.Forms.TextBox textBoxVarStopStep_KDG;
        private System.Windows.Forms.Label labelVarStopStep_KDG;
        private System.Windows.Forms.Label labelVarStartStep_KDG;
        private System.Windows.Forms.TextBox textBoxVarStartStep_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.Button buttonHelp_KDG;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_KDG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDG;
        private System.Windows.Forms.Label labelOutPutData_KDG;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colums_KDG;
    }
}

