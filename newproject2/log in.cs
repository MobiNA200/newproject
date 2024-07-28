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
    public partial class Form1 : Form
    {
        private static Form1 instance = null;
        public Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetInstance()
        {
            if (instance == null)
            {
                instance = new Form1();
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fileName = "C:\\Users\\Windows\\files\\fillproject.txt";
            StreamReader sr = new StreamReader(fileName);
            string userType = "";
            string userName = "";
            string password = "";
            string nationalCode = "";
            string carModel = "";
            string carPlate = "";
            string color = "";
            string email = "";
            bool found = false;


            while (!sr.EndOfStream)
            {
                userType = sr.ReadLine();
                userName = sr.ReadLine();
                password = sr.ReadLine();
                nationalCode = sr.ReadLine();
                email = sr.ReadLine();
                if (userType == "Driver")
                {
                    carModel = sr.ReadLine();
                    carPlate = sr.ReadLine();
                    color = sr.ReadLine();
                }

                if (userName == txtUserName.Text && password == txtPassword.Text)
                {
                    found = true;
                    break;
                }
            }
            sr.Close();
            if (found)
            {
                if (userType == "Driver")
                {
                    MessageBox.Show(" خوش آمدید " + userName+ "\n" + "شما به عنوان راننده با موفقیت وارد شدید :)");
                    // Open the driver form
                    driver driverForm = new driver();
                    
                    driverForm.Name = userName;
                    driverForm.NationalCode = nationalCode;
                    driverForm.CarModel = carModel;
                    driverForm.CarPlate = carPlate;
                    driverForm.Email = email;
                    driverForm.ShowDialog();
                }
                else if (userType == "Customer")
                {
                    MessageBox.Show("خوش آمدید " + userName + "\n" + "شما به عنوان مشتری با موفقیت وارد شدید :)");
                    // Open the customer form
                    customer customerForm = new customer();
                    customerForm.Name = userName;
                    customerForm.NationalCode = nationalCode;
                    customerForm.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Invalid user type!");
                }
            }
            else
            {
                MessageBox.Show("نام کاربری یا پسوورد اشتباه وارد شده است");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 RF = new Form2();
            RF.Show();
            this.Hide();
        }
    }
}
