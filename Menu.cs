﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Escolar1.src.vistas;

namespace Sistema_Escolar1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Students().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Teachers().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RegisterStudent().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new TeacherSubject().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Subjects().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Score().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Curse().Show();
        }
    }
}