using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssign
{
    internal class DataInput
    {
        Model1 ob = new Model1();

        public void Insertdata()
        {
            try
            {

                while (true)
                {
                    Console.WriteLine("Enter the Employee ID: ");
                    string empid = Console.ReadLine();
                    Console.WriteLine("Enter the name of the Employee: ");
                    string empName = Console.ReadLine();
                    Console.WriteLine("Enter dept id: ");
                    int deptId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Salary amount: ");
                    int salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the DOB of Employee(yyyy-mm-dd): ");
                    DateTime dob = DateTime.Parse(Console.ReadLine());


                    Employee emp = new Employee()
                    {
                        DeptID = deptId,
                        Salary = salary,
                        EmpName = empName,
                        DateofBirth = dob,
                        EmpID = empid

                    };

                    ob.Employees.Add(emp);

                    int i = ob.SaveChanges();
                    Console.WriteLine(i + " Effected");
                }

            }
            catch (Exception e)
            {
                var res = ob.GetValidationErrors();
                foreach (var error in res)
                {
                    foreach (var item in error.ValidationErrors)
                    {
                        Console.WriteLine(item.ErrorMessage);
                    }
                }
            }
              
            
        }


        
        public void InsertDept()
        {
                Console.WriteLine("Enter the Department ID: ");
                int deptid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Department Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Manager Name: ");
                string mname = Console.ReadLine();
                Department dt = new Department()
                {
                   DeptID = deptid,
                   Manager = mname,
                   DepartmentName = name
                };


                ob.Departments.Add(dt);
                try
                {
                    int i = ob.SaveChanges();
                    Console.WriteLine(i + "Effected");
                }
                catch (Exception e)
                {
                    var res = ob.GetValidationErrors();
                    foreach(var error in res)
                    {
                        foreach(var item in error.ValidationErrors)
                        {
                            Console.WriteLine(item.ErrorMessage);
                        }
                    }
                }
             
            
          
        }
    }
}
