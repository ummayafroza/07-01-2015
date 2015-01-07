using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformationApp
{
   public class Employee
    {
       public string Name { set; get; }
       public string Email { set; get; }
       public string Address { set; get; }

       private Dictionary<string, Employee> employees;

       public Employee(string name, string email, string address): this()
       {
           Name = name;
           Email = email;
           Address = address;

       }

       public Employee()
       {
           employees =new Dictionary<string, Employee>();
       }
       public string AddEmployee(string email, Employee aEmployee)
       {
           if (employees.ContainsKey(email))
               return "Same EmailID";
           else
           {
                  employees.Add(email, aEmployee);
           }
           return "found";
       }

       public Employee[] GetAllEmployees()
       {
           return employees.Values.ToArray();
       }

       
    }
}
