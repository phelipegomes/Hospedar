using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedar.All_User_Control
{
    public partial class UC_AddQuarto : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddQuarto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddQuarto_Load(object sender, EventArgs e)
        {
            query = "select * from quartos";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
    }
}
