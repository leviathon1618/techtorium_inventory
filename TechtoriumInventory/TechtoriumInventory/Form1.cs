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

namespace TechtoriumInventory { 
public partial class Form1 : Form { public Form1() { InitializeComponent(); } SqlConnection con = new SqlConnection(@"Data Source=DALLASHARVEY-L;Initial Catalog=DATABASE;Integrated Security=True"); private void button4_Click(object sender, EventArgs e) { Form2 frm2 = new Form2(); frm2.Show(); } private void button3_Click(object sender, EventArgs e) { con.Open(); String query = "DELETE FROM TABLE WHERE ID='" + textBox1.Text + "'"; SqlDataAdapter SDA = new SqlDataAdapter(query, con); SDA.SelectCommand.ExecuteNonQuery(); con.Close(); MessageBox.Show("SQL Record Delete"); } private void button1_Click(object sender, EventArgs e) { con.Open(); String query = "SELECT * FROM TABLE WHERE ID='" + textBox1.Text + "'"; SqlDataAdapter SDA = new SqlDataAdapter(query, con); DataTable dt = new DataTable(); SDA.Fill(dt); dataGridView1.DataSource = dt; con.Close(); } private void button2_Click(object sender, EventArgs e) { Form3 frm1 = new Form3(); frm1.Show(); }private void refreshTable() { con.Open(); String query = "SELECT * FROM TABLE"; SqlDataAdapter SDA = new SqlDataAdapter(query, con); DataTable dt = new DataTable(); SDA.Fill(dt); dataGridView1.DataSource = dt; con.Close(); } private void button5_Click(object sender, EventArgs e) { refreshTable();} }
}





