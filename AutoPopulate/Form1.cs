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

namespace AutoPopulate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //String conString = "Server=localhost;Database=PersonDB;Integrated Security=True;";
                String conString = txtConString.Text;
                SqlConnection con = new SqlConnection(conString);
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM " + txtTblName.Text + ";",con);
                int rowCount = (int)cmd.ExecuteScalar();
                if (rowCount < 100000)
                {
                    cmd = new SqlCommand("DELETE FROM " + txtTblName.Text + ";", con);
                    cmd.ExecuteNonQuery();

                    //Random SSN
                    Random r = new Random();
                    int rInt;

                    //RandomFirstName
                    int rNum;
                    String rFName;

                    //RandomLastName
                    String rLName;

                    //RandomAddress
                    String rAddress;

                    //Random Date
                    DateTime start;
                    int range;
                    DateTime rDate;

                    for (int j = 0; j < 10000; j++)
                    {
                        cmd = new SqlCommand();
                        cmd.Connection = con;

                        rInt = r.Next(11111111, 99999999);
                        rNum = r.Next(12, 456789);
                        rFName = "FirstName" + rNum;
                        rLName = "LastName" + rNum;
                        rAddress = "Address" + rNum;

                        start = new DateTime(1995, 1, 1);
                        range = (DateTime.Today - start).Days;
                        rDate = start.AddDays(r.Next(range));

                        cmd.CommandText = "INSERT INTO " + txtTblName.Text + "(ssn,FirstName,LastName,pAddress,StartDate) VALUES(" + rInt + ",'" + rFName + "','" + rLName + "','" + rAddress + "',@StartDate)";
                        cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = rDate.Date;
                        cmd.ExecuteNonQuery();

                        for (int i = 0; i <= 8; i++)
                        {
                            rNum = r.Next(12, 456789);
                            rAddress = "Address" + rNum;
                            rDate = start.AddDays(r.Next(range));

                            cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandText = "INSERT INTO " + txtTblName.Text + "(ssn,FirstName,LastName,pAddress,StartDate) VALUES(" + rInt + ",'" + rFName + "','" + rLName + "','" + rAddress + "',@StartDate)";
                            cmd.Parameters.Add("@StartDate", SqlDbType.Date).Value = rDate.Date;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                cmd = new SqlCommand("SELECT * FROM " + txtTblName.Text, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable("AddressTable");
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtConString.Text = "Server=localhost;Database=PersonDB;Integrated Security=True;";
            txtTblName.Text = "personAddresses";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
