using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace PasswordSaver
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 g = new Form3();
            g.Show();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string p = System.IO.File.ReadAllText(@"pass.txt");
            textBox1.Text = p;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = System.IO.File.ReadAllText(@"pass.txt");


            string[] line ={
            a+textBox2.Text+" --- "+textBox3.Text+" --- "+textBox4.Text
            };
            File.WriteAllLines("pass.txt", line);
            File.WriteAllLines("sos.txt", line);

            textBox3.Text = "Saved!";
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] line ={
            ""
            };
            File.WriteAllLines("pass.txt", line);
            

            textBox3.Text = "Deleted!";
        }
    }
}
