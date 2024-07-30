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

namespace STUDENT_DB_SYSTEM
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-168VT5JN\\SQLEXPRESS;Initial Catalog=\"student system\";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_systemDataSet.Table_studentdb' table. You can move, or remove it, as needed.
            this.table_studentdbTableAdapter.Fill(this.student_systemDataSet.Table_studentdb);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [Table_studentdb] (id,[first name],[last name],email,[date of birth],[enrolled date]) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox5.Text+"','"+textBox4.Text+"','"+textBox6.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            display_data();
            MessageBox.Show("succefully iserted!");
        }
        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table_studentdb]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display_data();
        }
    }
}
