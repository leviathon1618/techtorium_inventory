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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DALLASHARVEY-L;Initial Catalog=TECHTORIUM_INVENTORY;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            String query = "INSERT INTO TechTable (ProductName, Quantity) " + "Values" + "('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Product added successfully!");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
