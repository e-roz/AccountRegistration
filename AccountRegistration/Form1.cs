using System.Collections;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {

        public FrmRegistration()
        {
            InitializeComponent();
            foreach (string item in program)
            {
                programComboBox.Items.Add(item);
            }
        }


        ArrayList program = new ArrayList() { "BSIT", "BSTM", "BSBA", "BSHM", "BSED" };

        private string getInputTextBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text.ToString()))
            {
                return string.Empty;
            }
            else
            {
               return textBox.Text.ToString();
            }
        }

        private long getNumInput(TextBox textbox)
        {
            if (long.TryParse(textbox.Text, out long result))
            {
                return result;
            }
            else
            {
                return 0;
            }
        }

        private string getProgramInput(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                return string.Empty;
            }
            else
            {
                return comboBox.SelectedItem.ToString();
            }
        }
        private bool checkInput(string fn, string ln, string mn, string add, string prog, long age, long no, long sNum)
        {

            if(string.IsNullOrWhiteSpace(fn) ||
               string.IsNullOrWhiteSpace(ln) ||
               string.IsNullOrWhiteSpace(mn) ||
               string.IsNullOrWhiteSpace(add) ||
               string.IsNullOrWhiteSpace(prog) ||
               age <= 0 ||
               no <= 0 ||
               sNum <= 0)
            {
                MessageBox.Show("Please fill in all fields correctly.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }
        

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            string firstName = getInputTextBox(firstNameTxtBox);
            string lastName = getInputTextBox(lastNameTxtBox);
            string middleName = getInputTextBox(middleNameTxtBox);
            string address = getInputTextBox(addressTxtBox);
            string program = getProgramInput(programComboBox);
            long age = getNumInput(ageTxtBox);
            long studentNo = getNumInput(studentNumTxtBox);
            long contactNo = getNumInput(contactNumberTxtBox);

         


            if (!checkInput(firstName, lastName, middleName, address, program, age, studentNo, contactNo))
            {
                return;
            }


            // :>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            StudentInfo.GetFirstName(firstName);
            StudentInfo.GetLastName(lastName);
            StudentInfo.GetMiddleName(middleName);
            StudentInfo.GetAddress(address);
            StudentInfo.GetProgram(program);
            StudentInfo.GetAge(age);
            StudentInfo.GetStudentNo(studentNo);
            StudentInfo.GetContactNo(contactNo);





            if (form2.ShowDialog() == DialogResult.OK)
            {
                firstNameTxtBox.Clear();
                lastNameTxtBox.Clear();
                middleNameTxtBox.Clear();
                addressTxtBox.Clear();
                programComboBox.SelectedIndex = -1;
                ageTxtBox.Clear();
                studentNumTxtBox.Clear();
                contactNumberTxtBox.Clear();
            }

        }
    }
}
