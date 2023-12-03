
namespace Tyuiu.KozhevnikovDG.Sprint6.Task3.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_KDG));
            this.groupBoxData_KDG = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_KDG = new System.Windows.Forms.DataGridView();
            this.textBoxData_KDG = new System.Windows.Forms.TextBox();
            this.groupBoxResult_KDG = new System.Windows.Forms.GroupBox();
            this.buttonDone_KDG = new System.Windows.Forms.Button();
            this.buttonHelp_KDG = new System.Windows.Forms.Button();
            this.groupBoxData_KDG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KDG)).BeginInit();
            this.groupBoxResult_KDG.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxData_KDG
            // 
            this.groupBoxData_KDG.Controls.Add(this.textBoxData_KDG);
            this.groupBoxData_KDG.Location = new System.Drawing.Point(13, 13);
            this.groupBoxData_KDG.Name = "groupBoxData_KDG";
            this.groupBoxData_KDG.Size = new System.Drawing.Size(287, 312);
            this.groupBoxData_KDG.TabIndex = 0;
            this.groupBoxData_KDG.TabStop = false;
            this.groupBoxData_KDG.Text = "Условие";
            // 
            // dataGridViewMatrix_KDG
            // 
            this.dataGridViewMatrix_KDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KDG.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KDG.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewMatrix_KDG.Name = "dataGridViewMatrix_KDG";
            this.dataGridViewMatrix_KDG.ReadOnly = true;
            this.dataGridViewMatrix_KDG.RowHeadersVisible = false;
            this.dataGridViewMatrix_KDG.RowHeadersWidth = 51;
            this.dataGridViewMatrix_KDG.RowTemplate.Height = 24;
            this.dataGridViewMatrix_KDG.Size = new System.Drawing.Size(292, 285);
            this.dataGridViewMatrix_KDG.TabIndex = 1;
            // 
            // textBoxData_KDG
            // 
            this.textBoxData_KDG.Location = new System.Drawing.Point(7, 22);
            this.textBoxData_KDG.Multiline = true;
            this.textBoxData_KDG.Name = "textBoxData_KDG";
            this.textBoxData_KDG.ReadOnly = true;
            this.textBoxData_KDG.Size = new System.Drawing.Size(275, 284);
            this.textBoxData_KDG.TabIndex = 0;
            this.textBoxData_KDG.Text = resources.GetString("textBoxData_KDG.Text");
            // 
            // groupBoxResult_KDG
            // 
            this.groupBoxResult_KDG.Controls.Add(this.buttonDone_KDG);
            this.groupBoxResult_KDG.Controls.Add(this.dataGridViewMatrix_KDG);
            this.groupBoxResult_KDG.Controls.Add(this.buttonHelp_KDG);
            this.groupBoxResult_KDG.Location = new System.Drawing.Point(306, 13);
            this.groupBoxResult_KDG.Name = "groupBoxResult_KDG";
            this.groupBoxResult_KDG.Size = new System.Drawing.Size(463, 312);
            this.groupBoxResult_KDG.TabIndex = 1;
            this.groupBoxResult_KDG.TabStop = false;
            this.groupBoxResult_KDG.Text = "Вывод данных";
            // 
            // buttonDone_KDG
            // 
            this.buttonDone_KDG.Location = new System.Drawing.Point(304, 22);
            this.buttonDone_KDG.Name = "buttonDone_KDG";
            this.buttonDone_KDG.Size = new System.Drawing.Size(153, 73);
            this.buttonDone_KDG.TabIndex = 2;
            this.buttonDone_KDG.Text = "Выполнить ";
            this.buttonDone_KDG.UseVisualStyleBackColor = true;
            this.buttonDone_KDG.Click += new System.EventHandler(this.buttonDone_KDG_Click);
            // 
            // buttonHelp_KDG
            // 
            this.buttonHelp_KDG.Location = new System.Drawing.Point(304, 101);
            this.buttonHelp_KDG.Name = "buttonHelp_KDG";
            this.buttonHelp_KDG.Size = new System.Drawing.Size(159, 53);
            this.buttonHelp_KDG.TabIndex = 3;
            this.buttonHelp_KDG.Text = "?";
            this.buttonHelp_KDG.UseVisualStyleBackColor = true;
            this.buttonHelp_KDG.Click += new System.EventHandler(this.buttonHelp_KDG_Click);
            // 
            // FormMain_KDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 337);
            this.Controls.Add(this.groupBoxResult_KDG);
            this.Controls.Add(this.groupBoxData_KDG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_KDG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 11 | Кожевников Д. Г.";
            this.Load += new System.EventHandler(this.FormMain_KDG_Load);
            this.groupBoxData_KDG.ResumeLayout(false);
            this.groupBoxData_KDG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KDG)).EndInit();
            this.groupBoxResult_KDG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData_KDG;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KDG;
        private System.Windows.Forms.TextBox textBoxData_KDG;
        private System.Windows.Forms.GroupBox groupBoxResult_KDG;
        private System.Windows.Forms.Button buttonDone_KDG;
        private System.Windows.Forms.Button buttonHelp_KDG;
    }
}

