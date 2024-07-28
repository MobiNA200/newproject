using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace newproject2
{
    public partial class customer : Form
    {
        List<string> ltravel = new List<string>();
        List<string> LD = new List<string>();

        public customer()
        {
            InitializeComponent();
        }


        public string username { get; set; }
        public string Fullname { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }


        public string NationalCode { get; internal set; }

        private void radioButtonstop_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButtonmaghsad2_CheckedChanged(object sender, EventArgs e)
        {

        }

        //private void checkBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (Chstop.Checked)
        //    {
        //        txttimestop.Visible = true;

        //    }

        //}

        //private void checkBox2_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (Chdis.Checked)
        //    {
        //        txtmaghsad2.Visible = true;

        //    }
        //}

        private void button2_Click(object sender, EventArgs e)
        {


            Random rnd = new Random();
            int s = rnd.Next(15000, 100000);
            if (txtmabda != null && txtmaghsad != null)
            {

                if (Chstop.Checked == true)
                {
                    s = s + 10000;

                }
                if (Chdis.Checked == true)
                {
                    s = s + s / 2;


                }
                if (checkBox3.Checked == true)
                {
                    s = s * 2;

                }
                else
                {
                    s = s;
                }









            }
            txtprice.Text = Convert.ToString(s);




        }

        private void txtmabda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("C:\\Users\\Windows\\files\\fillproject.txt");
            string userType = "";
            string Name = "";
            string password = "";
            string nationalCode = "";
            string carModel = "";
            string carPlate = "";
            string color = "";
            string email = "";
            bool isDuplicateName = false;
            bool isDuplicatePassword = false;

            while (!sr.EndOfStream)
            {
                userType = sr.ReadLine();
                Name = sr.ReadLine();
                password = sr.ReadLine();
                nationalCode = sr.ReadLine();
                email = sr.ReadLine();
                if (userType == "Driver")
                {
                    carModel = sr.ReadLine();
                    carPlate = sr.ReadLine();
                    color = sr.ReadLine();
                }
                if (userType == "Driver")
                {
                    LD.Add(Name);
                }


            }


            sr.Close();
            Random rd = new Random();
            int s = rd.Next(0, LD.Count);


            //MessageBox.Show("your driver is="+LD[s]);
            StreamReader sre = new StreamReader("C:\\Users\\Windows\\files\\fillproject.txt");
            while (!sre.EndOfStream)
            {
                userType = sre.ReadLine();
                Name = sre.ReadLine();
                password = sre.ReadLine();
                nationalCode = sre.ReadLine();
                email = sre.ReadLine();
                if (userType == "Driver")
                {
                    carModel = sre.ReadLine();
                    carPlate = sre.ReadLine();
                    color = sre.ReadLine();
                }


                /*while (!sre.EndOfStream)
                {
                    userType = sre.ReadLine();
                    Name = sre.ReadLine();
                    password = sre.ReadLine();
                    nationalCode = sre.ReadLine();
                    if (userType == "Driver")
                    {
                        carModel = sre.ReadLine();
                        carPlate = sre.ReadLine();
                    }*/
                if (Name == LD[s])
                {
                    MessageBox.Show("the driver name is : " + LD[s] + "\n" + " your car model is : " + carModel + "\n" + "plate of car : " + carPlate + "\n");
                }
               // txtmabda.Clear();
               // txtmaghsad.Clear();
                txtprice.Clear();




            }
            sre.Close();
            ltravel.Add(txtmabda.Text);
            ltravel.Add(txtmaghsad.Text);
            ltravel.Add(LD[s]);
            File f = new File();
            f.AddToFile(ltravel);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < LD.Count; i++)
            {
                s += LD[i] + "\n";

            }
            MessageBox.Show(s);
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void Chdis_CheckedChanged(object sender, EventArgs e)
        {
            if (Chdis.Checked)
            {
                txtmaghsad2.Visible = true;


            }
        }

        private void Chstop_CheckedChanged(object sender, EventArgs e)
        {

            if (Chstop.Checked)
            {
                txttimestop.Visible = true;

            }
        }
    }
}
