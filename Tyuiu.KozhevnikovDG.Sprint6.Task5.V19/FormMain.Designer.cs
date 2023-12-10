
namespace Tyuiu.KozhevnikovDG.Sprint6.Task5.V19
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_KDG = new System.Windows.Forms.Panel();
            this.panelResult_KDG = new System.Windows.Forms.Panel();
            this.panelFunction_KDG = new System.Windows.Forms.Panel();
            this.groupBoxCondition_KDG = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KDG = new System.Windows.Forms.GroupBox();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.buttonOpenFile_KDG = new System.Windows.Forms.Button();
            this.buttonHelp_KDG = new System.Windows.Forms.Button();
            this.chartFunction_KDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult_KDG = new System.Windows.Forms.DataGridView();
            this.panelTask_KDG.SuspendLayout();
            this.panelResult_KDG.SuspendLayout();
            this.panelFunction_KDG.SuspendLayout();
            this.groupBoxCondition_KDG.SuspendLayout();
            this.groupBoxResult_KDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KDG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_KDG
            // 
            this.panelTask_KDG.Controls.Add(this.buttonHelp_KDG);
            this.panelTask_KDG.Controls.Add(this.buttonOpenFile_KDG);
            this.panelTask_KDG.Controls.Add(this.buttonDone_KDG);
            this.panelTask_KDG.Controls.Add(this.groupBoxCondition_KDG);
            this.panelTask_KDG.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_KDG.Location = new System.Drawing.Point(0, 0);
            this.panelTask_KDG.Name = "panelTask_KDG";
            this.panelTask_KDG.Padding = new System.Windows.Forms.Padding(5);
            this.panelTask_KDG.Size = new System.Drawing.Size(801, 100);
            this.panelTask_KDG.TabIndex = 0;
            // 
            // panelResult_KDG
            // 
            this.panelResult_KDG.Controls.Add(this.groupBoxResult_KDG);
            this.panelResult_KDG.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelResult_KDG.Location = new System.Drawing.Point(0, 100);
            this.panelResult_KDG.Name = "panelResult_KDG";
            this.panelResult_KDG.Padding = new System.Windows.Forms.Padding(5);
            this.panelResult_KDG.Size = new System.Drawing.Size(200, 460);
            this.panelResult_KDG.TabIndex = 1;
            // 
            // panelFunction_KDG
            // 
            this.panelFunction_KDG.Controls.Add(this.chartFunction_KDG);
            this.panelFunction_KDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFunction_KDG.Location = new System.Drawing.Point(200, 100);
            this.panelFunction_KDG.Name = "panelFunction_KDG";
            this.panelFunction_KDG.Padding = new System.Windows.Forms.Padding(5);
            this.panelFunction_KDG.Size = new System.Drawing.Size(601, 460);
            this.panelFunction_KDG.TabIndex = 2;
            // 
            // groupBoxCondition_KDG
            // 
            this.groupBoxCondition_KDG.Controls.Add(this.textBoxCondition_KDG);
            this.groupBoxCondition_KDG.Location = new System.Drawing.Point(8, 8);
            this.groupBoxCondition_KDG.Name = "groupBoxCondition_KDG";
            this.groupBoxCondition_KDG.Size = new System.Drawing.Size(479, 86);
            this.groupBoxCondition_KDG.TabIndex = 0;
            this.groupBoxCondition_KDG.TabStop = false;
            this.groupBoxCondition_KDG.Text = "Условие:";
            // 
            // textBoxCondition_KDG
            // 
            this.textBoxCondition_KDG.Location = new System.Drawing.Point(1, 22);
            this.textBoxCondition_KDG.Multiline = true;
            this.textBoxCondition_KDG.Name = "textBoxCondition_KDG";
            this.textBoxCondition_KDG.ReadOnly = true;
            this.textBoxCondition_KDG.Size = new System.Drawing.Size(472, 58);
            this.textBoxCondition_KDG.TabIndex = 0;
            this.textBoxCondition_KDG.Text = "Прочитать данные из файла InPutFileTask5V19.txt. Вывести в dataGridView. \r\nВывест" +
    "и все целые числа. Построить диаграмму по этим значениям.";
            // 
            // groupBoxResult_KDG
            // 
            this.groupBoxResult_KDG.Controls.Add(this.dataGridViewResult_KDG);
            this.groupBoxResult_KDG.Location = new System.Drawing.Point(9, 9);
            this.groupBoxResult_KDG.Name = "groupBoxResult_KDG";
            this.groupBoxResult_KDG.Size = new System.Drawing.Size(183, 443);
            this.groupBoxResult_KDG.TabIndex = 0;
            this.groupBoxResult_KDG.TabStop = false;
            this.groupBoxResult_KDG.Text = "Вывод:";
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_KDG.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_KDG.Location = new System.Drawing.Point(494, 13);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(99, 75);
            this.buttonDone_KDG.TabIndex = 1;
            this.buttonDone_KDG.Text = "Выполнить";
            this.buttonDone_KDG.UseVisualStyleBackColor = false;
            this.buttonDone_KDG.Click += new System.EventHandler(this.buttonDone_KDG_Click);
            // 
            // buttonOpenFile_KDG
            // 
            this.buttonOpenFile_KDG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonOpenFile_KDG.Location = new System.Drawing.Point(599, 13);
            this.buttonOpenFile_KDG.Name = "buttonOpenFile_KDG";
            this.buttonOpenFile_KDG.Size = new System.Drawing.Size(95, 75);
            this.buttonOpenFile_KDG.TabIndex = 1;
            this.buttonOpenFile_KDG.Text = "Открыть файл";
            this.buttonOpenFile_KDG.UseVisualStyleBackColor = false;
            this.buttonOpenFile_KDG.Click += new System.EventHandler(this.buttonOpenFile_KDG_Click);
            // 
            // buttonHelp_KDG
            // 
            this.buttonHelp_KDG.BackColor = System.Drawing.Color.Teal;
            this.buttonHelp_KDG.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp_KDG.Location = new System.Drawing.Point(701, 5);
            this.buttonHelp_KDG.Name = "buttonHelp_KDG";
            this.buttonHelp_KDG.Size = new System.Drawing.Size(95, 90);
            this.buttonHelp_KDG.TabIndex = 1;
            this.buttonHelp_KDG.Text = "Справка";
            this.buttonHelp_KDG.UseVisualStyleBackColor = false;
            this.buttonHelp_KDG.Click += new System.EventHandler(this.buttonHelp_KDG_Click);
            // 
            // chartFunction_KDG
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFunction_KDG.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFunction_KDG.Legends.Add(legend5);
            this.chartFunction_KDG.Location = new System.Drawing.Point(9, 9);
            this.chartFunction_KDG.Name = "chartFunction_KDG";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartFunction_KDG.Series.Add(series5);
            this.chartFunction_KDG.Size = new System.Drawing.Size(584, 443);
            this.chartFunction_KDG.TabIndex = 0;
            this.chartFunction_KDG.Text = "chart1";
            // 
            // dataGridViewResult_KDG
            // 
            this.dataGridViewResult_KDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KDG.ColumnHeadersVisible = false;
            this.dataGridViewResult_KDG.Location = new System.Drawing.Point(-1, 21);
            this.dataGridViewResult_KDG.Name = "dataGridViewResult_KDG";
            this.dataGridViewResult_KDG.RowHeadersVisible = false;
            this.dataGridViewResult_KDG.RowHeadersWidth = 51;
            this.dataGridViewResult_KDG.RowTemplate.Height = 24;
            this.dataGridViewResult_KDG.Size = new System.Drawing.Size(178, 416);
            this.dataGridViewResult_KDG.TabIndex = 0;
            // 
            // FormMain_KDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 560);
            this.Controls.Add(this.panelFunction_KDG);
            this.Controls.Add(this.panelResult_KDG);
            this.Controls.Add(this.panelTask_KDG);
            this.MinimumSize = new System.Drawing.Size(819, 607);
            this.Name = "FormMain_KDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 19 | Кожевников Д. Г.";
            this.panelTask_KDG.ResumeLayout(false);
            this.panelResult_KDG.ResumeLayout(false);
            this.panelFunction_KDG.ResumeLayout(false);
            this.groupBoxCondition_KDG.ResumeLayout(false);
            this.groupBoxCondition_KDG.PerformLayout();
            this.groupBoxResult_KDG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_KDG;
        private System.Windows.Forms.Panel panelResult_KDG;
        private System.Windows.Forms.Panel panelFunction_KDG;
        private System.Windows.Forms.GroupBox groupBoxCondition_KDG;
        private System.Windows.Forms.TextBox textBoxCondition_KDG;
        private System.Windows.Forms.GroupBox groupBoxResult_KDG;
        private System.Windows.Forms.Button buttonHelp_KDG;
        private System.Windows.Forms.Button buttonOpenFile_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDG;
        private System.Windows.Forms.DataGridView dataGridViewResult_KDG;
    }
}

