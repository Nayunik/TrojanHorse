using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TrojanHorse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор программы\r\nКорюкин Данил\r\nгр. ИТ-30919.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad");
        }

        /// <summary>
        /// Данный метод выполняет копирование информации из одного текствого файла в другой
        /// Метод является асинхронным
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Form1_Load(object sender, EventArgs e)
        {
            string pathSource = @"D:\ВУЗ\3_курс\5_семестр\Теоретические_основы_компьютерной_безопасности\Лаба_8\SEC\secret.txt";
            string pathDestination = @"D:\ВУЗ\3_курс\5_семестр\Теоретические_основы_компьютерной_безопасности\Лаба_8\NONSEC\nonsecret.txt";
            string content = "";

            await Task.Run(() =>
            {
                if (File.Exists(pathSource))//Проверка на наличие файла
                {
                    using (StreamReader reader = new StreamReader(pathSource))
                    {
                        using (StreamWriter writer = new StreamWriter(pathDestination))
                        {
                            do
                            {
                                content = reader.ReadLine();
                                writer.WriteLine(content);
                            }
                            while (content != null);
                        }
                    }
                }
            });
        }
    }
}
