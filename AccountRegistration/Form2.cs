using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AccountRegistration
{

    public partial class Form2 : Form
    {
        DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        DelegateLong DelAge, DelStudentNo, DelContactNo;



        public Form2()
        {

            InitializeComponent();
            

        }

        private void display()
        {
            FNlbl.Text = DelFirstName(StudentInfo.firstName);
            LNlbl.Text = DelLastName(StudentInfo.lastName);
            MNlbl.Text = DelMiddleName(StudentInfo.middleName);
            ADDlbl.Text = DelAddress(StudentInfo.address);
            progLbl.Text = DelProgram(StudentInfo.program);
            AGElbl.Text = DelAge(StudentInfo.age).ToString();
            SNlbl.Text = DelStudentNo(StudentInfo.studentNo).ToString();
            CNlbl.Text = DelContactNo(StudentInfo.contactNo).ToString();

        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            DelFirstName = new DelegateText(StudentInfo.GetFirstName);
            DelLastName = new DelegateText(StudentInfo.GetLastName);
            DelMiddleName = new DelegateText(StudentInfo.GetMiddleName);
            DelAddress = new DelegateText(StudentInfo.GetAddress);
            DelProgram = new DelegateText(StudentInfo.GetProgram);
            DelAge = new DelegateLong(StudentInfo.GetAge);
            DelStudentNo = new DelegateLong(StudentInfo.GetStudentNo);
            DelContactNo = new DelegateLong(StudentInfo.GetContactNo);


            display();
        }
    }
}
