using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KozhevnikovDG.Sprint6.Task5.V19.Lib;
using System.IO;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task5.V19
{
    public partial class FormMain_KDG : Form
    {
        public FormMain_KDG()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\f1zog\source\repos\Tyuiu.KozhevnikovDG.Sprint6\Tyuiu.KozhevnikovDG.Sprint6.Task5.V19\bin\Debug\InPutFileTask5V19.txt";

        private void buttonDone_KDG_Click(object sender, EventArgs e)
        {
            dataGridViewResult_KDG.ColumnCount = 2;
            dataGridViewResult_KDG.Columns[0].Width = 20;
            dataGridViewResult_KDG.Columns[1].Width = 50;

            this.chartFunction_KDG.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartFunction_KDG.ChartAreas[0].AxisY.Title = " Ось Y";

            chartFunction_KDG.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_KDG.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_KDG.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonHelp_KDG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИИПБ-23-1 Кожевников Данил Георгиевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpenFile_KDG_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
