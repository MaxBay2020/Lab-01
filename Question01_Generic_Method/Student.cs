using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01_Generic_Method
{
    /*Student class implements the interface IComparable*/
    class Student:IComparable<string>
    {
        private string studentNumber;
        private string studentName;

        public string StudentNumber { get; set; }
        public string StudentName { get; set; }

        public Student(string studentNumber, string studentName)
        {
            this.StudentNumber = studentNumber;
            this.StudentName = studentName;
        }

        /// <summary>
        /// implemented method of IComparable interface, using to compare two objects based on the conditions logic inside
        /// </summary>
        /// <param name="other">compared objct</param>
        /// <returns>compared result</returns>
        public int CompareTo(string other) => this.studentNumber.Equals(other)? 1 : -1;

        /// <summary>
        /// override ToString method to display appropriately
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"{StudentNumber}  {StudentName}";
    }
}
