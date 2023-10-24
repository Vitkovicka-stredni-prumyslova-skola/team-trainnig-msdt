namespace Corporate{

    class Company{
        public static List<Employee>employees{get;private set;}
        public Company(){
            employees = new List<Employee>();
        }
        public string AddEmployee(employee){
            return employees.Add(employee);
        }

    }
}