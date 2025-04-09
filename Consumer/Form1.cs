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

namespace Consumer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "data source = KING; initial catalog = RDB; integrated security = True; trustservercertificate = True; MultipleActiveResultSets = True; App = EntityFramework";

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            //CONSUMER
            String C_ID = tbC_ID.Text;
            String C_NAME = tbC_NAME.Text;
            String CONSUMER_NO = tbCONSUMER_NO.Text;
            String C_TYPE = tbC_TYPE.Text;
            String PHASE = tbPHASE.Text;
            String MOUNTING_TYPE = tbMOUNTING_TYPE.Text;
            String NEAREST_POLE_ID = tbNEAREST_POLE_ID.Text;
            String C_IMAGE_PATH = tbC_IMAGE_PATH.Text;
            String C_LATITUDE = tbC_LATITUDE.Text;
            String C_LONGITUDE = tbC_LONGITUDE.Text;


            String query = "INSERT INTO CONSUMER (C_ID, C_NAME, CONSUMER_NO, C_TYPE, PHASE, MOUNTING_TYPE, NEAREST_POLE_ID, C_IMAGE_PATH, C_LATITUDE, C_LONGITUDE)VALUES('" + C_ID + "','" + C_NAME + "','" + CONSUMER_NO + "','" + C_TYPE + "','" + PHASE + "','" + MOUNTING_TYPE + "','" + NEAREST_POLE_ID + "','" + C_IMAGE_PATH + "','" + C_LATITUDE + "','" + C_LONGITUDE + "')";


            SqlCommand cmd = new SqlCommand(query, con);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Inserted Successfully");




        }

        private void tbC_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
