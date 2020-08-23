using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261004_w06
{
    class Person
    {
        private string name;
        private string lastname;
        private double salary;
        private string position;

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { this.lastname = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { this.salary = value; }
        }
        public string Position
        {
            get { return position; }
            set { this.position = value; }
        }

        public Person() { }
        public Person(string Name, string Lastname, double Salary, string Position)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.Salary = Salary;
            this.Position = Position;

        }
        public override string ToString()
        {
            return this.Name + " " + this.Lastname + " salary : " + this.Salary + " Tax : " + Tax.getTax(this.Salary * 12);
        }
    }
}