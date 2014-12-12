using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DP_project
{
    public partial class InsertForm : Form
    {
        private SqlConnection con;
        public InsertForm()
        {
            InitializeComponent();
            con = new SqlConnection("Data Source=omar-PC\\SQLEXPRESS;Initial Catalog=DropBox;Integrated Security=True");
            con.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            SqlCommand cmd = new SqlCommand("Insert_User", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@userName", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@email", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@password ", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@fullName", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Payment",float.Parse(textBox1.Text)));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Insertion done successfully"); 
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
