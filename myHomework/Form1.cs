﻿using System;
using System.Windows.Forms;

namespace myHomework
{
    public partial class Homework : Form
    {
        public Homework()
        {
            InitializeButton();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void Button_Click(object sender, EventArgs e) {
            if (tabControl1.SelectedIndex < tabControl1.TabPages.Count)
                tabControl1.SelectedIndex++;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void calculation(object sender, EventArgs e) {
            for (int i = 0; i <= dataGridView1.Rows.Count; i++)
                if (Int32.Parse(dataGridView1[3, i].Value.ToString()) >= 5) 
                    if (dataGridView1[2, i].Value.ToString().Equals("полупроводник"))
                       richTextBox1.Text = richTextBox1.Text + dataGridView1[0, i].Value.ToString() + " " + dataGridView1[2, i].Value.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
