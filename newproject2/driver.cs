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

namespace newproject2
{
    public partial class driver : Form
    {
        List<string> lll = new List<string>();
        List<string> ll2=new List<string>();
        int i = 1;
        public driver()
        {
            InitializeComponent();
           
            
        }

        public string Name { get; set; }
        public string NationalCode { get; set; }
        public string CarModel { get; set; }
        public string CarPlate { get; set; }
        public string Email { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            



            string m ="";
            string mag="";
            string s = "";


            StreamReader sr = new StreamReader("C:\\Users\\Windows\\files\\travel.txt");
            string mabda = "";
            string maghsad = "";
            string driver = "";
            
            while (!sr.EndOfStream)
            {
                mabda = sr.ReadLine();
                maghsad = sr.ReadLine();
                driver = sr.ReadLine();
                
                if (driver == Name)
                {
                    m = mabda;
                    mag = maghsad;
                    lll.Add(m);
                    ll2.Add(mag);    
                }
                
               

            }


            sr.Close();

           
            for (int j=0;j<lll.Count;j++)
            {
                s = s + "سفر شماره" + i + "از مبدا " + lll[j] + " به مقصد " + ll2[j] + " انجام شد. " + "\n";
                i++;
            }

            txttravels.Text = s;           
        }

        private void lblName_Click(object sender, EventArgs e)
        {
           

        }

        private void lblNationalCode_Click(object sender, EventArgs e)
        {
            
        }

        private void lblCarModel_Click(object sender, EventArgs e)
        {
         

        }

        private void lblCarPlate_Click(object sender, EventArgs e)
        {

            


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void driver_Load(object sender, EventArgs e)
        {
            txtName.Text = Name;
            txtcodemeli.Text = NationalCode;
            txtcarmodel.Text = CarModel;
            txtpelak.Text = CarPlate;
            txtemail.Text = Email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maliClass ml = new maliClass();
            int a = ml.hoghogh(i);
            MessageBox.Show(" درامد شما تا به این لحظه : "+ a );
        }
    }
}
