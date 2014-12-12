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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
            SqlConnection con=new SqlConnection("Data Source=omar-PC\\SQLEXPRESS;Initial Catalog=DropBox;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select ID,User_Name,Full_Name,Email from User",con);
            cmd.CommandType = CommandType.Text;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
