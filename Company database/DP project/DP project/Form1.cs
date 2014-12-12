using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_project
{
    public partial class Form1 : Form
    {
        private InsertForm insert;
        private updateForm update;
        private deleteForm delete;
        private searchForm search;
        private analysisForm analysis;
        private functionForm function;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert=new InsertForm();
            insert.BringToFront();
            insert.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update = new updateForm();
            update.BringToFront();
            update.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete = new deleteForm();
            delete.BringToFront();
            delete.Show();
        }
       
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            search = new searchForm();
            search.BringToFront();
            search.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            function = new functionForm();
            function.BringToFront();
            function.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            analysis = new analysisForm();
            analysis.BringToFront();
            analysis.Show();
        }
    }
}
