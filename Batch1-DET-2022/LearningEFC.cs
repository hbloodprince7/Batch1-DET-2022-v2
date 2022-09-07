using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class LearningEFC
    {
        public static void Main(string[] args)
        {
            //GetAllEmpData();
            //GetAllEmpDataByID();
            //AddNewEmployee();
            //DeleteEmployee();
            //UpdateEmployee();
            //GetEmployeesSP();
            GetEmployeesFromDept();
            //RemoveEmpUsingID();
            //CallStoredProcwithSQLParamater_insert();

        }

        public static void GetAllEmpData()
        {
            var ctx = new TrainingContext();
            var emps = ctx.Emps;

            foreach (var emp in emps)
            {
                Console.WriteLine(emp.Ename + "---" + emp.Sal);
            }
        }

        public static void GetAllEmpDataByID()
        {
            var ctx = new TrainingContext();
            var emps = ctx.Emps.Where(e => e.Empno == 7844).SingleOrDefault();
            Console.WriteLine(emps.Ename + ":" + emps.Sal);

        }

        public static void AddNewEmployee()
        {
            var ctx = new TrainingContext();
            Emp employee = new Emp();
            try
            {
                employee.Empno = 7499;
                employee.Ename = "MURDOCK";
                employee.Deptno = 30;
                employee.Comm = 1500;
                employee.Sal = 75000;
                employee.Job = "INTERN";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New Employee Added");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
        private static void DeleteEmployee()
        {
            var ctx = new TrainingContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 7499;
                employee.Ename = "MURDOCK";
                employee.Deptno = 30;
                employee.Comm = 1500;
                employee.Sal = 75000;
                employee.Job = "INTERN";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private static void UpdateEmployee()
        {
            var ctx = new TrainingContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 2999;
                employee.Ename = "PARKER";
                employee.Deptno = 30;
                employee.Comm = 76;
                employee.Sal = 15000;
                employee.Job = "INTERN";
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("Employee Info Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
        private static void GetEmployeesSP()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw($"GetAllEmps").ToList();

            foreach(var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }
        private static void GetEmployeesFromDept()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw($"GetEmpDetailsFromDept @P0",30).ToList();

            foreach (var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }
        private static void RemoveEmpUsingID()
        {
            var ctx = new TrainingContext();
            var eno = 2999;
            int rowsAffected = ctx.Database.ExecuteSqlRaw($"RemoveEmployee {eno}");
            Console.WriteLine($"No Of Rows Affected {rowsAffected}");
        }
        private static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new TrainingContext();
            var param = new SqlParameter[] {
                        new SqlParameter() {
                            ParameterName = "@empno",
                            SqlDbType =  System.Data.SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 7734
                        },
                        new SqlParameter() {
                            ParameterName = "@ename",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "HARRY"},



                         new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "INTERN"},


                         new SqlParameter() {
                            ParameterName = "@mgr",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "7839"},


                         new SqlParameter() {
                            ParameterName = "@hiredate",
                            SqlDbType =  System.Data.
                            SqlDbType.DateTime,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = DateTime.Now},


                         new SqlParameter() {
                            ParameterName = "@sal",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 75000},
                        
                         
                         new SqlParameter() {
                            ParameterName = "@comm",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 750},

                         new SqlParameter() {
                            ParameterName = "@deptno",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30}
                      };

            try
            {
                var result = ctx.Database.ExecuteSqlRaw("InsertEmployee @empno,  @ename, @job, @mgr, @hiredate, @sal, @comm, @deptno", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {
                throw;
            }
            Console.WriteLine("update successful");
       }

    }
}
