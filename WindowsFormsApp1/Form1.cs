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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void POS_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Orders());
        }
        private void ShowScreen(UserControl newScreen)
        {

            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}