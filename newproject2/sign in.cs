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
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace newproject2
{
    public partial class Form2 : Form
    {
        Dictionary<string, Person> dicp = new Dictionary<string, Person>();
        Dictionary<string, ClassDriver> dic2 = new Dictionary<string, ClassDriver>();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person(txtName.Text, FullNametxt.Text, phoneTextBox.Text, txtPassword.Text, emailTextBox.Text);
            ClassDriver d = new ClassDriver(txtName.Text, FullNametxt.Text, phoneTextBox.Text, txtPassword.Text, emailTextBox.Text, txtCarModel.Text, txtCarPlate.Text, txtcolor.Text, txtNationalCode.Text);
            if (radioButtonD.Checked == true)
            {
                d.setkarbar("Driver");
            }
            else if (radioButtonM.Checked == true)
            {
                p.setkarbar("Customer");
            }
            else
            {
                MessageBox.Show("لطفا یکی از گزینه ها را انتخاب کنید");
                return;
            }

            //read and tekrari
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
                if (Name == txtName.Text)
                {
                    MessageBox.Show("این نام کاربری قبلا استفاده شده است. لطفا یکی دیگر انتخاب کنید");
                    isDuplicateName = true;
                    break;



                }
                if (password == txtPassword.Text)
                {
                    MessageBox.Show("این پسوورد قبلا استفاده شده است. لطفا یکی دیگر انتخاب کنید ");
                    isDuplicatePassword = true;
                    break;



                }
            }

            sr.Close();
            if (isDuplicateName || isDuplicatePassword)
            {
                txtName.Clear();
                txtPassword.Clear();
                return;
            }

            if (txtName.Text.Length < 3)
            {
                MessageBox.Show("نام کاربری کوتاه است. لطفا یکی دیگر انتخاب کنید");
                txtName.Clear();
                return;
            }

            if (txtPassword.Text.Length < 3)
            {
                MessageBox.Show("رمز کوتاه است. لطفا یکی دیگر انتخاب کنید");
                txtPassword.Clear();
                return;
            }
            if (radioButtonD.Checked == true)
            {
                dic2.Add(txtPassword.Text, d);
                File f = new File();
                f.AddToFile(dic2);
            }
            else if (radioButtonM.Checked == true)
            {
                dicp.Add(txtPassword.Text, p);
                File f = new File();
                f.AddToFile(dicp);
            }
            MessageBox.Show("ثبت نام شما با موفقیت انجام شد");

            Form1.GetInstance().Show();
            this.Hide();
        }










        /*else
        {

            dicp.Add(txtPassword.Text, p);
            dic2.Add(txtPassword.Text, d);


            File f = new File();
            f.AddToFile(dic2);
            f.AddToFile(dicp);
        }*/









        // string fileName = "D:\\fillproject.txt";










        private void radioButtonM_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonM.Checked == true)
            {
                label4.Hide();
                txtCarModel.Hide();
                txtCarPlate.Hide();
                txtcolor.Hide();
                txtNationalCode.Hide();
                labelcar.Hide();
                labelcode.Hide();
                labelcolor.Hide();
                labelpelak.Hide();
                phoneTextBox.Hide();






            }
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonD.Checked == true)
            {
                label4.Show();
                txtCarModel.Show();
                txtCarPlate.Show();
                txtcolor.Show();
                txtNationalCode.Show();
                labelcar.Show();
                labelcode.Show();
                labelcolor.Show();
                labelpelak.Show();
                phoneTextBox.Show();






            }




        }
    }
}





