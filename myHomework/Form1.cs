using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //new Task522.Task();
        } 
    }
}
