﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3target
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new odnomer();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new dvymer();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
