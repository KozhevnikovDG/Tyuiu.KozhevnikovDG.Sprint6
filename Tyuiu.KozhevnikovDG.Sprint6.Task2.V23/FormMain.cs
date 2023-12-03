using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KozhevnikovDG.Sprint6.Task2.V23.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task2.V23
{
    public partial class FormMain_KDG : Form
    {
        public FormMain_KDG()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_KDG_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxVarStartStep_KDG.Text);
                int stopStep = Convert.ToInt32(textBoxVarStopStep_KDG.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                
                this.chartFunction_KDG.Titles.Add("График функции ");

                this.chartFunction_KDG.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KDG.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KDG.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KDG.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDG_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИИПБ-23-1 Кожевников Данил Георгиевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDone_KDG_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KDG.BackColor = Color.Red;
        }

        private void buttonDone_KDG_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KDG.BackColor = Color.Green;
        }

        private void buttonDone_KDG_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KDG.BackColor = Color.Blue;
        }
    }
}
