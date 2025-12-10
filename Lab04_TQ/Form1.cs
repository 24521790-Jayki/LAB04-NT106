using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bai02;
using Bai03;
using Lab04_TQ;

namespace Lab04_TQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02.Bai02 bai02 = new Bai02.Bai02();
            bai02.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03.Bai03 bai03 = new Bai03.Bai03(); 
            bai03.ShowDialog();
        }
    }
}
