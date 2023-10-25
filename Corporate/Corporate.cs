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

        public int GetBonus(){
            return 0;
        }
    }
    //Zde Ondra mrdne svůj kód
    class Company{
        public static List<Employee>employees{get;private set;}
        public Company(){
            employees = new List<Employee>();
        }
        public string AddEmployee(employee){
            return employees.Add(employee);
        }
        public string RemoveEmployee(string Name){
            if (Name != null){
                int index = employees.IndexOf(Name);
                return employees.RemoveAt(index);
            }
        }
    }
}