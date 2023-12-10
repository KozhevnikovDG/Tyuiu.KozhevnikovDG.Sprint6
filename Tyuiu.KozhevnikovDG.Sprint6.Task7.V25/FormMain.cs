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

using Tyuiu.KozhevnikovDG.Sprint6.Task7.V25.Lib;



namespace Tyuiu.KozhevnikovDG.Sprint6.Task7.V25
{
    public partial class FormMain_KDG : Form
    {
        public FormMain_KDG()
        {
            InitializeComponent();
            openFileDialog_KDG.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
            saveFileDialog_KDG.Filter = "Значения, разделённые запятыми(*.csv)|*csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;


        }

        private void buttonInPutFile_KDG_Click(object sender, EventArgs e)
        {
            openFileDialog_KDG.ShowDialog();
            openFilePath = openFileDialog_KDG.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPutFile_KDG.ColumnCount = columns;
            dataGridViewInPutFile_KDG.RowCount = rows;
            dataGridViewOutPutFile_KDG.ColumnCount = columns;
            dataGridViewOutPutFile_KDG.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutFile_KDG.Columns[i].Width = 25;
                dataGridViewOutPutFile_KDG.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutFile_KDG.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonOutPutFile_KDG.Enabled = true;
        }

        private void buttonHelp_KDG_Click(object sender, EventArgs e)
        {
            FormAbout_KDG formAbout = new FormAbout_KDG();
            formAbout.ShowDialog();
        }

        private void buttonOutPutFile_KDG_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutFile_KDG.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KDG.Enabled = true;
        }

        private void buttonSave_KDG_Click(object sender, EventArgs e)
        {
            saveFileDialog_KDG.FileName = "OutPutFileTask7.csv";
            saveFileDialog_KDG.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_KDG.ShowDialog();

            string path = saveFileDialog_KDG.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutFile_KDG.RowCount;
            int columns = dataGridViewOutPutFile_KDG.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPutFile_KDG.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPutFile_KDG.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInPutFile_KDG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDG.ToolTipTitle = "Открыть файл";
        }

        private void buttonOutPutFile_KDG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDG.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_KDG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDG.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_KDG_MouseEnter(object sender, EventArgs e)
        {
            toolTip_KDG.ToolTipTitle = "Справка";
        }
    }
    
}
