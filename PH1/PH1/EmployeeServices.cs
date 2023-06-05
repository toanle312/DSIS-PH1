using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH1
{
    internal class EmployeeServices
    {
        public static Employee GetEmployeeInfo(DataRow employeeRow)
        {
            var employee = new Employee()
            {
                Id = employeeRow["MANV"].ToString() ?? "",
                Name = employeeRow["TENNV"].ToString() ?? "",
                Gender = employeeRow["PHAI"].ToString() ?? "",
                Birthday = employeeRow["NGAYSINH"].ToString() ?? "",
                Address = employeeRow["DIACHI"].ToString() ?? "",
                PhoneNumber = employeeRow["SODT"].ToString() ?? "",
                Salary = employeeRow["LUONG"].ToString() ?? "",
                Allowance = employeeRow["PHUCAP"].ToString() ?? "",
                Role = employeeRow["VAITRO"].ToString() ?? "",
                ManagerId = employeeRow["MANQL"].ToString() ?? "",
                Department = employeeRow["PHG"].ToString() ?? ""
            };
            return employee;
        }

        public static DataRow SetEmployeeInfo(Employee employee, DataTable table)
        {
            var employeeRow = table.NewRow();
            employeeRow["MANV"] = employee.Id;
            employeeRow["TENNV"] = employee.Name;
            employeeRow["PHAI"] = employee.Gender;
            employeeRow["NGAYSINH"] = employee.Birthday;
            employeeRow["DIACHI"] = employee.Address;
            employeeRow["SODT"] = employee.PhoneNumber;
            employeeRow["LUONG"] = employee.Salary;
            employeeRow["PHUCAP"] = employee.Allowance;
            employeeRow["VAITRO"] = employee.Role;
            employeeRow["MANQL"] = employee.ManagerId;
            employeeRow["PHG"] = employee.Department;
            return employeeRow;
        }
    }
}