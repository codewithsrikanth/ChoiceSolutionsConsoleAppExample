using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CADatabase
{
    class EmployeeCRUD
    {
        private SqlConnection _con;
        private SqlDataAdapter _adapter;
        private DataSet _ds;
        private SqlCommandBuilder _commandBuilder;
        public EmployeeCRUD()
        {
            _con = new SqlConnection(ConfigurationManager.ConnectionStrings["ChoiceConn"].ConnectionString);
            _ds = new DataSet();
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            _adapter = new SqlDataAdapter("select * from Employee", _con);
            _commandBuilder = new SqlCommandBuilder(_adapter);
            _adapter.Fill(_ds, "Employee");
            foreach (DataRow item in _ds.Tables["Employee"].Rows)
            {
                Employee emp = new Employee();
                emp.Eno =Convert.ToInt32(item["Eno"]);
                emp.Ename =Convert.ToString(item["Ename"]);
                emp.Job =Convert.ToString(item["Job"]);
                emp.Salary =Convert.ToDouble(item["Salary"]);
                emp.Dname =Convert.ToString(item["Dname"]);
                employees.Add(emp);
            }
            return employees;
        }
        public Employee GetEmployee(int id)
        {
            List<Employee> employees = GetEmployees();
            foreach(Employee employee in employees)
            {
                if(employee.Eno == id)
                {
                    Employee emp = new Employee()
                    {
                        Eno = employee.Eno, Ename = employee.Ename, Job = employee.Job,Salary = employee.Salary,Dname = employee.Dname
                    };
                    return emp;
                }
            }
            return new Employee();
        }
        public string InsertEmployee(Employee emp)
        {
            DataRow rec = _ds.Tables["Employee"].NewRow();
            rec["Eno"] = emp.Eno;
            rec["Ename"] = emp.Ename;
            rec["Job"] = emp.Job;
            rec["Salary"] = emp.Salary;
            rec["Dname"] = emp.Dname;
            _ds.Tables["Employee"].Rows.Add(rec);
            if (_ds.HasChanges())
            {
                _adapter.Update(_ds);
            }
            return emp.Eno+" - Employee Record Inserted ";
        }
        public string UpdateEmployee(Employee emp)
        {
            DataRow rec = _ds.Tables["Employee"].Rows.Find(emp.Eno);
            if(rec != null)
            {
                rec["Ename"] = emp.Ename;
                rec["Job"] = emp.Job;
                rec["Salary"] = emp.Salary;
                rec["Dname"] = emp.Dname;
                if (_ds.HasChanges())
                {
                    _adapter.Update(_ds);
                }
                return "Record Updated";
            }
            else
            {
                return "Record Not Found";
            }
        }
        public string DeleteEmployee(int eno)
        {
            DataRow rec = _ds.Tables["Employee"].Rows.Find(eno);
            if(rec != null)
            {
                _ds.Tables["Employee"].Rows.Remove(rec);
                if (_ds.HasChanges())
                {
                    _adapter.Update(_ds);
                }
                return "Employee Deleted";
            }
            return "Record Not Found";
        }
    }
    class Example9
    {
        
        static void Main(string[] args)
        {
            EmployeeCRUD employeeCRUD = new EmployeeCRUD();
            foreach (var emp in employeeCRUD.GetEmployees())
            {
                Console.WriteLine($"{emp.Eno}   -   {emp.Ename}     -   {emp.Job}   -   {emp.Salary}    -   {emp.Dname}");
            }

            Console.Read();
        }
    }
}
