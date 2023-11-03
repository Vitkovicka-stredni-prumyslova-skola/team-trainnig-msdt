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

        public virtual int GetBonus(){
            return 0;
        }
    }
    //Zde Ondra dá svůj kód
    class Company{
        /// <summary>
        /// List zaměstanců
        /// </summary>
        public static List<Employee>employees{get;private set;}
        /// <summary>
        /// Vytváří list zaměstanců
        /// </summary>
        public Company(){
            employees = new List<Employee>();
        }
        /// <summary>
        /// Metoda AddEmployee slouží k přídání zaměstnance do listu. Uživatel zadá údaje zaměstnance.
        /// </summary>
        /// <param name="employee">Údaje zaměstnance</param>
        public void AddEmployee(Employee employee){
            employees.Add(employee);
        }

        /// <summary>
        /// Metoda RemoveEmplolyee slouží k odstranění změstnance. Funguje tak, že user zadá jméno, metoda najde v listu zaměstnanců jeho index a ten odstraní
        /// </summary>
        /// <param name="name">Jméno zaměstnance</param>
        public void RemoveEmployee(Employee name){
            if (name != null){
                int index = employees.IndexOf(name);
                employees.RemoveAt(index);
            }
        }
        /// <summary>
        /// Metoda PrintEmployees vytiskne údaje zaměstnanců v listu
        /// </summary>
        public void PrintEmployees(){
            foreach(var employee in employees){
                Console.WriteLine($"Name: {employee.Name}\nPosition: {employee.Position}\nSalary: {employee.Salary}");
            }
        }
        /// <summary>
        /// Metoda PayBonuses zaplatí bonusy všech zaměstnanců. Funguje tak, že projde každého zaměstnance v listu, a pomocí metody GetBonus() zaplatí bonus
        /// </summary>
        /// <returns> Vrací Bonus </returns>
        public int PayBonuses(){
            int summ = 0;
            for (int i = 0; i < employees.Count(); i++){
                
                summ += employees[i].GetBonus();
            }
            return summ;
        }
    }

}