﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIO
{
    public partial class myBD : Form
    {
        public myBD()
        {
            InitializeComponent();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f1 = new About();
            f1.ShowDialog();
        }

        private void калькуляторToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Calculator f1 = new Calculator();
            f1.ShowDialog();
        }
    }
}
