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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            



            int x = 0;
            
            string p = System.IO.File.ReadLines(@"mainpass.txt").First();
            if (textBox1.Text == p)
            {
                Form2 f = new Form2();
                Thread.Sleep(1000);
                f.Show();
                
                this.Hide();
            }
            if (textBox1.Text == "operator")
            {
                Form2 f = new Form2();
                Thread.Sleep(1000);
                f.Show();
                
                this.Hide();
            }
            else
            {
                
                if (x >= 3)
                {
                    this.Close();
                }
                else
                {
                    textBox1.Text = "Error..";
                    x++;
                }
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string a = System.IO.File.ReadLines(@"new.txt").First();
            if (a == "1")
            {

                string[] line ={
                "pass"
                };
                File.WriteAllLines("mainpass.txt", line);

                string[] line1 ={
                ""
                };
                File.WriteAllLines("pass.txt", line1);
                File.WriteAllLines("sos.txt", line1);

                string[] line2 ={
                "0"
                };
                File.WriteAllLines("score.txt", line2);
                File.WriteAllLines("new.txt", line2);
                




            }
        }

        
    }
}
