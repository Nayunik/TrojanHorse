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
    }
}
