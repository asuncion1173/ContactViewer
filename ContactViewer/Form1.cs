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

namespace ContactViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            String path = @"C:\Users\ASUNCION\Desktop\Safe Stay\" + textBoxSearch.Text + ".txt";
            if (File.Exists(path))
            {
                String output = File.ReadAllText(path);
                richTextBox.Text = output;
            }
            else
            {
                richTextBox.Text = "The data does not exist";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox.Text = "";
            textBoxSearch.Text = "";
        }
    }
}
