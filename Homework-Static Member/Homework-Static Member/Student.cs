using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_Static_Member
{
    internal class Student
    {
        private string _fullName;
        private string _groupNo;
        public int Age;
        public string GroupNo 
        {
            get
            {
                return _groupNo;
            }
            set
            {
                if(CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }
        public string FullName 
        {
            get
            {
                return _fullName;
            }

            set
            {
                if (CheckFullName(value)) 
                {
                    _fullName = value;
                }
            }
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length != 4) return false;
            if (string.IsNullOrWhiteSpace(groupNo)) return false;
            if (!char.IsLetter(groupNo[0])) return false;
            if (!char.IsUpper(groupNo[0])) return false;
            for (int i = 1; i < groupNo.Length; i++)
            {
                if (!char.IsNumber(groupNo[i])) return false;
            }
            return true;
        }
        public static bool CheckFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))  return false;
            var text1 = fullName.Trim();
            var text2 = text1.Substring(text1.IndexOf(" ") + 1);
            if (!text1.Contains(" ")) return false;
            if (!char.IsUpper(text1[0])) return false;
            if (!char.IsUpper(text2[0])) return false;

            return true;
        }
    }
}
