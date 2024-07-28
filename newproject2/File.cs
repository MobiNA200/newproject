using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace newproject2
{
    internal class File
    {


        public void AddToFile(Dictionary<string, Person> dp)
        {
            try
            {



                FileStream fs = new FileStream("C:\\Users\\Windows\\files\\fillproject.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                foreach (var x in dp)
                {

                    if (x.Value.getkarbar() == "Customer")
                    {
                        Person p = x.Value;
                        sw.WriteLine(p.getkarbar() + "\n" + p.getname() + "\n" + p.getpass() + "\n" + p.getfullName() + "\n" + p.getEmail());
                    }
                }

                sw.Close();
                fs.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("File not found");
            }
        }

        public void AddToFile(Dictionary<string, ClassDriver> dv)
        {
            try
            {



                FileStream fs = new FileStream("C:\\Users\\Windows\\files\\fillproject.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                foreach (var x in dv)
                {

                    if (x.Value.getkarbar() == "Driver")
                    {
                        ClassDriver d = x.Value;
                        sw.WriteLine(d.getkarbar() + "\n" + d.getname() + "\n" + d.getpass() + "\n" + d.codemeli + "\n" +d.getEmail()+"\n"+ d.getcar() + "\n" + d.getplak() + "\n" + d.color);
                    }
                }

                sw.Close();
                fs.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("File not found");
            }
        }


        public void AddToFile(List<string> ltravel)
        {
            try
            {



                FileStream fs = new FileStream("C:\\Users\\Windows\\files\\travel.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);

                for(int i = 0;i<ltravel.Count;i++)

                {
                    sw.WriteLine(ltravel[i]);

                }
                

                sw.Close();
                fs.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("File not found");
            }



        }
    }
}

