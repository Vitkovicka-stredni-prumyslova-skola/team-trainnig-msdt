using System;
using System.Data.Common;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

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
    //Zde Ondra dá svůj kód
    class Company{
        public static List<Employee>employees{get;private set;}
        public Company(){
            employees = new List<Employee>();
        }
        public void AddEmployee(Employee employee){
            employees.Add(employee);
        }
        public void RemoveEmployee(Employee name){
            if (name != null){
                int index = employees.IndexOf(name);
                employees.RemoveAt(index);
            }
        }
        public void PrintEmployees(){
            foreach(var employee in employees){
                Console.WriteLine($"Name: {employee.Name}\nPosition: {employee.Position}\nSalary: {employee.Salary}");
            }
        }
        public string PayBonuses(){
            for (int i = 0; i < employees.Count(); i++){
               switch(employees[i].Position){
                case "Manager":

               }
            }
            
            //Pokud je pozice Manager tak dostává 10 % navíc ze svého platu + 100,- za každého člena týmů
            //Pokud je pozice Developer tak dostává 15 % navíc ze svého platu + 500,- za C# a 300,- za jiný
            //Pokud je pozice Salesperson tak dostává 5 % navíc ze svého platu + 50,- za každý prodej 
        }
    }

}