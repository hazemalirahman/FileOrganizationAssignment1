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

namespace assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\bahy\Desktop\hazem_code\assignment1\assignment1\hazem.txt");
            string text = File.ReadAllText(@".\hazem.txt");
            string[] arr = text.Split("\r\n");
            label1.Text = "";
            for (int i = 0; i < 5; i++)
            {
                label1.Text = label1.Text + arr[i] + "\r\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string text = System.IO.File.ReadAllText(@"C:\Users\bahy\Desktop\hazem_code\assignment1\assignment1\hazem.txt");
            string text = System.IO.File.ReadAllText(@".\hazem.txt");
            string[] arr = text.Split("\r\n");
            label2.Text = "";
            for (int i = arr.Length-5; i < arr.Length; i++)
            {
                label2.Text += arr[i] + "\r\n";
            }
        }
    }
}
