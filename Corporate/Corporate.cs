
using System;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Corporate{
    class Employee{
        private string name;
        private int salary;
        private string position;
        public string Name {
            get{
                return name;
            }
            private set{
                name = value;
            }
        }
        public int Salary {
            get{
                return salary;
            }
            private set{
                salary = value;
            }
        }
        public string Position { 
            get{
                return position;
            }
            private set{
                position = value;
            }
        }
        public Employee(string name, int salary, string position){
            this.name = name;
            this.salary = salary;
            this.position = position;
        }
        
        public Employee(string name, int salary){
            this.name = name;
            this.salary = salary;
            position = "Unknown";
        }

        public override string ToString(){
            return $"Name: {Name}, Salary: {Salary}, Position: {Position}";
        }

        public virtual int GetBonus(){
            return 0;
        }
    }
    class Manager : Employee
{
    private int teamSize;

    public Manager(string name, int salary, int teamSize) : base(name, salary)
    {
        this.teamSize = teamSize;
    }

    public override string ToString()
    {
        return base.ToString() + $", Team Size: {teamSize}";
    }

    public override int GetBonus()
    {
        return (int)(0.1 * Salary + 100 * teamSize);
    }
}

 class Developer : Employee
{
    private string language;

    public Developer(string name, int salary, string language) : base(name, salary)
    {
        this.language = language;
    }

    public override string ToString()
    {
        return base.ToString() + $", Language: {language}";
    }

    public override int GetBonus()
    {
        if (language == "C#")
            return (int)(0.15 * Salary + 500);
        else
            return (int)(0.15 * Salary + 300);
    }
}

 class Salesperson : Employee
{
    private int sales;

    public Salesperson(string name, int salary, int sales) : base(name, salary)
    {
        this.sales = sales;
    }

    public override string ToString()
    {
        return base.ToString() + $", Sales: {sales}";
    }

    public override int GetBonus()
    {
        return (int)(0.05 * Salary + 50 * sales);
    }
  }
}
