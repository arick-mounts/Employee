using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch9p4
{


    public partial class Form1 : Form
    {

        /*
         * This program constructs several employee classes and displays them in a table
         * C# @TCC
         * 
         * Arick Mounts
         */
        public Form1()
        {
            InitializeComponent();
            Employee Employee1 = new Employee("Susan Meyers", 47899,"Accounting", "Vice President");
            Employee Employee2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee Employee3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");
            Row1_1.Text = Employee1.Name;
            Row1_2.Text = Employee1.IdNumber.ToString();
            Row1_3.Text = Employee1.Department;
            Row1_4.Text = Employee1.Position;

            Row2_1.Text = Employee2.Name;
            Row2_2.Text = Employee2.IdNumber.ToString();
            Row2_3.Text = Employee2.Department;
            Row2_4.Text = Employee2.Position;

            Row3_1.Text = Employee3.Name;
            Row3_2.Text = Employee3.IdNumber.ToString();
            Row3_3.Text = Employee3.Department;
            Row3_4.Text = Employee3.Position;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    class Employee
    {
        private string _Name;
        private int _IdNumber;
        private string _Position;
        private string _Department;

        //constructor
        public Employee()
        {
            _Name = "";
            _IdNumber = 0;
            _Position = "";
            _Department = "";
        }

        public Employee(string N, int I)
        {
            _Name = N;
            _IdNumber = I;
            _Position = "";
            _Department = "";
        }

        public Employee(string N, int I, string P, string D)
        {
            _Name = N;
            _IdNumber = I;
            _Position = P;
            _Department = D;
        }
        public string Name
        {
            get
            {
                return _Name;
            }

        }
        public int IdNumber
        {
            get
            {
                return _IdNumber;
            }
        }
        public string Position
        {
            get
            {
                return _Position;
            }
        }

        public string Department
        {
            get
            {
                return _Department;
            }
        }

    }
}
