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

namespace TechtoriumInventory
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DALLASHARVEY-L;Initial Catalog=TECHTORIUM_INVENTORY;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "UPDATE TechTable " + "SET ProductName='" + textBox1.Text + "', Quantity='" + textBox2.Text + "' WHERE ProductName='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated product!");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
