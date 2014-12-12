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
    public partial class deleteForm : Form
    {
        public deleteForm()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection("Data Source=omar-PC\\SQLEXPRESS;Initial Catalog=DropBox;Integrated Security=True");
            //con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand cmd = new SqlCommand("Delete_User ", con);
            //cmd.CommandType = CommandType.StoredProcedure;
        }
    }
}
