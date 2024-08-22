using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecallFlow_IO
{
    public partial class Form1 : Form
    {
        private List<string> lines;
        private string TextPath;
        int count = -1;
        bool lineByline = true;
        public Form1()
        {
            InitializeComponent();
            lines = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();

            openfile.Filter = "Text Files (*.txt)|*.txt";
            openfile.Title = "Select text file";

            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TextPath = openfile.FileName;
            }

            StreamReader reader = new StreamReader(TextPath);

               textBox1.Text = reader.ReadToEnd();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            lineByline = true;
        }

    }
}
