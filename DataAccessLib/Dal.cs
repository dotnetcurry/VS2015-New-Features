using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLib
{
    public class EmployeeTax
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public decimal Tax { get; set; }
    }
    public interface IDataAccess
    {
        List<EmployeeInfo> GetData();
        EmployeeInfo GetData(int id);
        EmployeeInfo Create(EmployeeInfo emp);
        bool Update(int id, EmployeeInfo emp);
        bool Delete(int id);

    }
    public class DataAccess : IDataAccess
    {
        CompanyEntities ctx;

        public DataAccess()
        {
            ctx = new CompanyEntities(); 
        }

        public EmployeeInfo Create(EmployeeInfo emp)
        {
            ctx.EmployeeInfoes.Add(emp);
            ctx.SaveChanges();
            return emp;
        }

        /// <summary>
        /// the empToDelete will be the searched Employee
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            var empData = new EmployeeInfo();
            var empToDelete = ctx.EmployeeInfoes.Find(id);
            if (empToDelete != null)
            {
                ctx.EmployeeInfoes.Remove(empToDelete);
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<EmployeeInfo> GetData()
        {
            var emps = ctx.EmployeeInfoes.ToList();
            return emps;
        }

        public EmployeeInfo GetData(int id)
        {
            return ctx.EmployeeInfoes.Find(id);
        }

        public bool Update(int id, EmployeeInfo emp)
        {
            var empToUpdate = ctx.EmployeeInfoes.Find(id);
            if (empToUpdate != null)
            {
                empToUpdate.EmpName = emp.EmpName;
                empToUpdate.Salary = emp.Salary;
                empToUpdate.DeptName = emp.DeptName;
                empToUpdate.Designation = emp.Designation;
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<EmployeeInfo> GetData(string dname)
        {
            var Res = ctx.EmployeeInfoes.Where(d => d.DeptName == dname);
            return Res.ToList();
        }


        public List<EmployeeTax> GetEmpTax()
        {
           
            List<EmployeeTax> EmpTax = new List<EmployeeTax>(); 
            var Emps = ctx.EmployeeInfoes.ToArray();
            foreach (var item in Emps)
            {
                var emp = new EmployeeTax();
                emp.EmpNo = item.EmpNo;
                emp.EmpName = item.EmpName;
                emp.Salary = item.Salary;
                emp.Tax = item.Salary * Convert.ToDecimal(0.2);
                EmpTax.Add(emp);       
              
            }
            return EmpTax;
        }

    }
}
