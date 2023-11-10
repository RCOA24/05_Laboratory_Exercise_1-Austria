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

namespace _05_Laboratory_Exercise_1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text;
            string getLastName = txtLastName.Text;
            string getAge = txtAge.Text;
            string getBirthday = dateTimePicker1.Text;
            string getList = comboProgram.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleName = txtMiddleName.Text;
            string getGender = comboGender.Text;
            string getContactNo = txtContactNo.Text;
            string setFileName = String.Concat(getStudentNo, ".txt");

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, setFileName));

            string[] info = { "StudentNo.:" + getStudentNo, "FullName:" + getFirstName + " " + getMiddleName + " " + getLastName, "Program:" + getList + "Age:" + getAge, "Birthday:" + getBirthday, "ContactNo.:" + getContactNo, "Gender: " + getGender, };
            Console.WriteLine(getStudentNo);
            foreach (string i in info)
            {
                outputFile.WriteLine(i);
            }
            outputFile.Close();
            MessageBox.Show("Successfully saved!!!");
            Close();
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[] { "BS Information Technology",
                                                    "BS Computer Science",
                                                    "BS Information Systems",
                                                    "BS in Accountancy",
                                                    "BS in Hospitality Management",
                                                    "BS in Tourism Management" };
            for (int i = 0; i < 6; i++)
            {
                comboProgram.Items.Add(ListOfProgram[i].ToString());
            }

            string[] listGender = new string[] { "Male", "Female" };

            for (int i = 0; i < 2; i++)
            {
                comboGender.Items.Add(listGender[i].ToString());
            }
        }
    }
}