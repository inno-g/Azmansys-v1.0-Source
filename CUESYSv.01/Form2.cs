using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public partial class Form2 : Form
    {
        dbConn mysqlConn = new dbConn();
        public Form2()
        {
            InitializeComponent();
            dbConfig();
            mysqlConn.connect();
        }
        public bool dbConfig()
        {
            try
            {
                mysqlConn.varConfigServer = "airemionkp.cucstudents.org";
                mysqlConn.varConfigDatabase = "airemionkp_";
                mysqlConn.varConfigUser = "airemionkp";
                mysqlConn.varConfigPass = "coventry01";
                return true;
            }
            catch { return false; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConn.connOpen();
            string date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string varPaid;
            if (checkBox1.Checked == true) { varPaid = "Y"; }
            else { varPaid = "N"; }
            mysqlConn.insertBooking(custContact.Text, Flyingfrom.Text, Destination.Text, Time.Text, date, Price.Text, varPaid);
            MessageBox.Show("Booking Finished Successfully");
        }

        

        
    }
}
