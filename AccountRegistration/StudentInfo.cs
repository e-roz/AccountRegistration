using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{

    public delegate string DelegateText(string text);
    public delegate long DelegateLong(long number);

    internal class StudentInfo
    {
        public static string firstName = "";
        public static string lastName = "";
        public static string middleName = "";
        public static string address = "";
        public static string program = "";

        public static long age = 0;
        public static long studentNo = 0;
        public static long contactNo = 0;

        public static string GetFirstName(string name)
        {
            firstName = name;
            return firstName;
        }

        public static string GetLastName(string name)
        {
            lastName = name;
            return lastName;
        }

        public static string GetMiddleName(string name)
        {
            middleName = name;
            return middleName;
        }

        public static string GetAddress(string add)
        {
            address = add;
            return address;
        }

        public static string GetProgram(string prog)
        {
            program = prog;
            return program;
        }


        public static long GetAge(long EDAD)
        {
            age = EDAD;
            return age;
        }

        public static long GetStudentNo(long sno)
        {
            studentNo = sno;
            return studentNo;
        }
        public static long GetContactNo(long no)
        {
            contactNo = no;
            return contactNo;
        }
    }
}
