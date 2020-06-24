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
using System.Threading;

namespace PasswordSaver
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Type something!";
            }
            else
            {
                string[] line ={
            textBox1.Text
            };
                File.WriteAllLines("mainpass.txt", line);
                textBox1.Text = "";

                Thread.Sleep(2000);
                this.Hide();
            }

        }

        
    }
}
