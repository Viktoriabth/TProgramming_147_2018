using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Rabochiy
    {
        private string name;
        private DateTime employee;

        public Rabochiy(DateTime employee, string name)
        {
            this.employee = employee;
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public DateTime Employee
        {
            get => employee;
            set => employee = value;
        }

        public string GetInfo()
        {
            return $"Имя: {name}  Дата приема: {employee} ";
        }
    }
}