using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Employee
    {
        
        private String name;
        private int salary;
        private DateTime dateTime;
        public Employee (String name, int salary, int day, int month, int year) {
            this.name = name;
            this.salary = salary;
            this.dateTime = new DateTime(year, month, day);
        }
        public Employee(String name, int salary)
        {
            this.name = name;
            this.salary = salary;
            this.dateTime = DateTime.Now;
        }
        public String getName()
        {
            return name;
        }

        public string Name{
            set => this.name = value;
            get => this.name;
        }

        public int Salary
        {
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentException("Значение должно быть положительным.");
                }
                else
                {
                    this.salary = value;
                }
            }
            get => this.salary;
        }

        public void upSalary(int p)
        {
            this.salary = this.salary + this.salary / 100 * p;
        }

        public override String ToString()
        {
            return this.name + ", зарплата - " + this.salary;
        }
    }
}
