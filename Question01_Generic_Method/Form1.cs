using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question01_Generic_Method
{
    public partial class Form1 : Form
    {
        //prepare categories fo the combo box
        string[] selectCategory = new string[2] { "Integer", "Student" };
        //prepare student list data
        static List<Student> studentDataList = new List<Student>()
            {
                new Student("100001", "Sam"),
                new Student("100002", "Dean"),
                new Student("100003", "Pheobe"),
                new Student("100004", "Monica"),
                new Student("100005", "Ross"),
                new Student("100006", "Rachel"),
                new Student("100007", "Joey"),
                new Student("100008", "Chandler"),
                new Student("100009", "Max"),
                new Student("100010", "Lucy"),
            };
        //list of student
        static List<Student> studentList = new List<Student>();
        //list of int
        static List<int> numberList = new List<int>();
        //store the current category selected
        static string selectedItem;

        public Form1()
        {
            InitializeComponent();

            //Prepare the category of the combo box and set the default display value
            selectComboBox.Items.AddRange(selectCategory);
            selectComboBox.SelectedItem = selectCategory[0];
        }

        /// <summary>
        /// Based on different category selected, display different data in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (selectComboBox.SelectedItem)
            {
                //if "integer"selected, display integer data in the list box
                case "Integer":
                    selectedItem = "Integer";
                    dataListBox.Items.Clear();
                    dataListBox.Items.AddRange(GenerateNumbers().ToArray());
                    break;
                case "Student":
                    selectedItem = "Student";
                    dataListBox.Items.Clear();
                    dataListBox.Items.AddRange(GenerateStudents().ToArray());
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// generate the random size (10 to 20) of random numbers list
        /// </summary>
        /// <returns></returns>
        private static List<string> GenerateNumbers()
        {
            //clear numberList before generating new list
            numberList.Clear();
            //prepare data
            Random rd = new Random();
            int count = rd.Next(10, 20);
            List<string> numberStringList = new List<string>();
            for (int i = 0; i < count; i++)
            {
                //generate a random number
                int number = rd.Next(-100, 100);
                if (numberStringList.Contains(number.ToString()))
                {
                    //if numberStringList contains this number
                    i--;
                    continue;
                }
                //otherwise, add to the list
                numberList.Add(number);
                numberStringList.Add(number.ToString());
                
            }
            return numberStringList;
        }

        /// <summary>
        /// generate the random size (10 to 20) of random student list
        /// </summary>
        /// <returns></returns>
        private static List<String> GenerateStudents()
        {
            //clear student list before generating new list
            studentList.Clear();
            //prepare data
            Random rd = new Random();
            int count = rd.Next(3, 10);
            List<String> studentStringList = new List<String>();
            for (int i = 0; i < count; i++)
            {
                //randomly select a student from the studentDataList
                Student student = studentDataList[rd.Next(0, studentDataList.Count)];
                if (studentStringList.Contains(student.ToString()))
                {
                    //studentList has the random generated student
                    i--;
                    continue;
                }
                //otherwise, add to the studentList
                studentList.Add(student);
                studentStringList.Add(student.ToString());
            }

            return studentStringList;
        }

        /// <summary>
        /// click search button to search and display the result
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //get the value of user input, and try to turn it into integer
            //using Linear Search Algorithm to search desired element
            if (selectComboBox.SelectedItem == "Integer")
            {
                int numberInput = 0;
                try
                {
                    numberInput = Convert.ToInt32(inputTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a number");
                    inputTextBox.Text = "";
                    displayTextBox.Text = "";
                    inputTextBox.Focus();
                    return;
                }
                //if integer selected
                foreach (var number in numberList)
                {
                    int result = Search(inputTextBox.Text, number.ToString());
                    if (result == 0)
                    {
                        displayTextBox.Text = $"index：{numberList.IndexOf(numberInput)} \t item：{numberInput}";
                        return;
                    }
                }
                MessageBox.Show($"Unfortunately, the collection does not have number: {numberInput}");
                inputTextBox.Text = "";
                displayTextBox.Text = "";
                inputTextBox.Focus();
            }
            else if (selectComboBox.SelectedItem == "Student")
            {
                //if student selected
                foreach (Student student in studentList)
                {
                    int result = Search(inputTextBox.Text, student.StudentNumber);
                    if (result == 0)
                    {
                        displayTextBox.Text = $"index：{studentList.IndexOf(student)} \t item：{student}";
                        return;
                    }
                }
                MessageBox.Show($"Unfortunately, the collection does not have the student with the student number: {inputTextBox.Text}");
                inputTextBox.Text = "";
                displayTextBox.Text = "";
                inputTextBox.Focus();
            }
        }
        /// <summary>
        /// compare two elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj1">compared element1</param>
        /// <param name="obj2">compared element2</param>
        private static int Search<T> (T obj1, T obj2) where T : IComparable
        {
            return obj1.CompareTo(obj2);

        }
    }
}
