﻿/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GridView
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> Employees
        {
            get
            {
                return EmployeeDataAccessLayer4.GetAllEmployees(this.DepartmentId);
            }
        }
    }

    public class DepartmentDataAccessLayer1
    {
        public static List<Department> GetAllDepartmentsandEmployees()
        {
            List<Department> listDepartments = new List<Department>();

            string CS = ConfigurationManager.ConnectionStrings["SampleConnectionString3"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from tblDepartment1", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Department department = new Department();
                    department.DepartmentId = Convert.ToInt32(rdr["DepartmentId"]);
                    department.DepartmentName = rdr["Name"].ToString();

                    listDepartments.Add(department);
                }
            }

            return listDepartments;
        }
    }
}*/