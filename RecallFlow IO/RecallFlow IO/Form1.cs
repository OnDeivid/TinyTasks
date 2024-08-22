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
        private string TextPath;
        public Form1()
        {
            InitializeComponent();
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
            reader.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(TextPath);

            writer.WriteLine(textBox1.Text);
            writer.Close();
        }
    }
}
