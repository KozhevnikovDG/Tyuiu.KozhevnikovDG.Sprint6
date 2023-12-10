using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KozhevnikovDG.Sprint6.Task6.V10.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint6.Task6.V10
{
    public partial class FormMain_KDG : Form
    {
        public FormMain_KDG()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();
        private void buttonLoadFile_KDG_Click(object sender, EventArgs e)
        {
            openFileDialog_KDG.ShowDialog();
            openFilePath = openFileDialog_KDG.FileName;
            textBoxInPut_KDG.Text = File.ReadAllText(openFilePath);
            groupBoxOutPut_KDG.Text = groupBoxOutPut_KDG.Text + " " + openFileDialog_KDG.FileName;
            buttonOutPut_KDG.Enabled = true;
        }

        private void buttonOutPut_KDG_Click(object sender, EventArgs e)
        {
            textBoxOutPut_KDG.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonInfo_KDG_Click(object sender, EventArgs e)
        {
             FormAbout_KDG formAbout = new FormAbout_KDG();
             formAbout.ShowDialog();
        }
    }
}
