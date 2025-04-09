using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transformer

{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source = KING; initial catalog = RDB; integrated security = True; trustservercertificate = True; MultipleActiveResultSets = True; App = EntityFramework";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            String ID = tbID.Text;
            String NAME = tbNAME.Text;
            String TYPE = tbTYPE.Text;
            String CAPACITY = tbCAPACITY.Text;
            String AREA = tbAREA.Text;
            String IMAGE_PATH = tbIMAGE_PATH.Text;
            String LATITUDE = tbLATITUDE.Text;
            String LONGITUDE = tbLONGITUDE.Text;



            String query = "INSERT INTO TRANSFORMER (NAME, TYPE, CAPACITY, AREA, IMAGE_PATH, LATITUDE, LONGITUDE) VALUES('" + NAME + "','" + TYPE + "','" + CAPACITY + "','" + AREA + "','" + IMAGE_PATH + "','" + LATITUDE + "','" + LONGITUDE + "')";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Inserted Successfully");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCAPACITY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAREA_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIMAGE_PATH_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLATITUDE_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLONGITUDE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
