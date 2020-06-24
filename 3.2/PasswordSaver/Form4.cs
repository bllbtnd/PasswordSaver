using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordSaver
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            int d = int.Parse(System.IO.File.ReadLines(@"score.txt").First());
            if (d >= 1)
            {
                pictureBox1.Visible = true;
            }
            if (d >= 2)
            {
                pictureBox2.Visible = true;
            }
            if (d >= 5)
            {
                pictureBox3.Visible = true;
            }
            if (d >= 10)
            {
                pictureBox4.Visible = true;
            }
            if (d>= 25)
            {
                pictureBox5.Visible = true;
            }
            
        }
    }
}
