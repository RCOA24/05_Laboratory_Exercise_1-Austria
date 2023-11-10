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

            string[] info = { "StudentNo.:" + getStudentNo, "FullName:" + getFirstName + " " + getMiddleName + " " + getLastName, "Program:" + getList + "Age:" + getAge, "Birthday:" + getBirthday, "ContactNo.:" + getContactNo };
            Console.WriteLine(getStudentNo);
            foreach(string i in info)
            outputFile.WriteLine(i);
            outputFile.Close();
            Close();

        }
    }
}
