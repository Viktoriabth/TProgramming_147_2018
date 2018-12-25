using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Rabochiy
    {
        private string name;
        private string hireDate;

        public Rabochiy(string hireDate, string name)
        {
            this.hireDate = hireDate;
            this.name = name;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string HireDate
        {
            get => hireDate;
            set => hireDate = value;
        }

        public string GetInfo()
        {
            return $"Имя: {name}  Дата приема: {hireDate} ";
        }
    }
}