namespace WinFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    using System.Windows.Forms;
    using System.Data.SqlClient; // Uncomment this line if you need to use SqlClient
    /// <summary>
    /// Form1 class
    /// </summary>
    /// 

    namespace WinFormsApp1
    {
        using System;
        using System.Windows.Forms;

        static class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }

    public partial class Form1 : Form
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
            //POLE
            String P_ID = tbP_ID.Text;
            String P_NAME = tbP_NAME.Text;
            String P_TYPE = tbP_TYPE.Text;
            String POLE_NO = tbPOLE_NO.Text;
            String lIGHT_COUNT = tbLIGHT_COUNT.Text;
            String HEIGHT = tbHEIGHT.Text;
            String lANDMARK = tbLANDMARK.Text;
            String P_IMAGE_PATH = tbP_IMAGE_PATH.Text;
            String P_LATITUDE = label30.Text;
            String P_LONGITUDE = table31.Text;

            String query = "INSERT INTO TRANSFORMER (NAME, TYPE, CAPACITY, AREA, IMAGE_PATH, LATITUDE, LONGITUDE) VALUES('" + NAME + "','" + TYPE + "','" + CAPACITY + "','" + AREA + "','" + IMAGE_PATH + "','" + LATITUDE + "','" + LONGITUDE + "')";
            String query1 = "INSERT INTO CONSUMER (C_ID, C_NAME, CONSUMER_NO, C_TYPE, PHASE, MOUNTING_TYPE, NEAREST_POLE_ID, C_IMAGE_PATH, C_LATITUDE, C_LONGITUDE)VALUES('" + C_ID + "','" + C_NAME + "','" + CONSUMER_NO + "','" + C_TYPE + "','" + PHASE + "','" + MOUNTING_TYPE + "','" + NEAREST_POLE_ID + "','" + C_IMAGE_PATH + "','" + C_LATITUDE + "','" + C_LONGITUDE + "')";
            String query2 = "INSERT INTO POLE (P_ID, P_NAME, P_TYPE, POLE_NO, LIGHT_COUNT, HEIGHT, LANDMARK, P_IMAGE_PATH, P_LATITUDE, P_LONGITUDE) VALUES (@P_ID, @P_NAME, @P_TYPE, @POLE_NO, @LIGHT_COUNT, @HEIGHT, @LANDMARK, @P_IMAGE_PATH, @P_LATITUDE, @P_LONGITUDE)";


            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@P_ID", P_ID);
            cmd2.Parameters.AddWithValue("@P_NAME", P_NAME);
            cmd2.Parameters.AddWithValue("@P_TYPE", P_TYPE);
            cmd2.Parameters.AddWithValue("@POLE_NO", POLE_NO);
            cmd2.Parameters.AddWithValue("@LIGHT_COUNT", lIGHT_COUNT);
            cmd2.Parameters.AddWithValue("@HEIGHT", HEIGHT);
            cmd2.Parameters.AddWithValue("@LANDMARK", lANDMARK);
            cmd2.Parameters.AddWithValue("@P_IMAGE_PATH", P_IMAGE_PATH);
            cmd2.Parameters.AddWithValue( "@P_LATITUDE", double.TryParse(P_LATITUDE, NumberStyles.Any, CultureInfo.InvariantCulture, out var lat) ? lat : (object)DBNull.Value);
            cmd2.Parameters.AddWithValue("@P_LONGITUDE", double.TryParse(P_LONGITUDE, NumberStyles.Any, CultureInfo.InvariantCulture, out var lon) ? lon : (object)DBNull.Value);

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            

            con.Close();

            MessageBox.Show("Data Inserted Successfully");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNAME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

