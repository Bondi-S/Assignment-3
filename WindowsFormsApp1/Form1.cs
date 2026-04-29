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
        List<string> emoji = new List<string>();
        public Form1()
        {
            InitializeComponent();
            using (StreamReader sr = new StreamReader("C:/Users/0871316/Downloads/emoji.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) !=null)
                {
                    emoji.Add(line);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int value = rand.Next(emoji.Count());
            label1.Text = emoji[value];
            label1.ForeColor = Color.FromArgb(30,150,200);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
