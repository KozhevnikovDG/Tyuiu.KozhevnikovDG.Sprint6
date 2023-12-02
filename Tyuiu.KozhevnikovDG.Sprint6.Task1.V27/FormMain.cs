using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KozhevnikovDG.Sprint6.Task1.V27.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task1.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_KDG_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KDG.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KDG.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] vallueArray;
                vallueArray = new double[len];

                vallueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KDG.Text = "";
                textBoxResult_KDG.AppendText("+---------+---------+" + Environment.NewLine);
                textBoxResult_KDG.AppendText("|    X    |   f(X)  |" + Environment.NewLine);
                textBoxResult_KDG.AppendText("+---------+---------+" + Environment.NewLine);

                for(int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}   |  {1,5:f2}   | ", startStep, vallueArray[i]);
                    textBoxResult_KDG.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KDG.AppendText("+---------+---------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-1 Кожевников Данил Георгиевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
