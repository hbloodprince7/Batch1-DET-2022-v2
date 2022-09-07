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
    internal class DatabaseFirstApproach
    {
        public static void Main()
        {
            GetAllEmpDetails();
            //GetEmpDetailsByID();
            //AddNewEmployee();
            //RemoveNewEmployee();
            //UpdateNewEmployee();

            //WithoutParameterSp();
            //WithParameterSp();
            //DeleteEmpUsingID();
            //CallStoredProcwithSQLParamater_insert();

        }

        private static void WithoutParameterSp()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw("GetAllEmps").ToList();



            foreach (var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }




        private static void WithParameterSp()
        {
            var ctx = new TrainingContext();
            var employees = ctx.Emps.FromSqlRaw("AcceptEmpNo @p0", 7369).ToList();



            foreach (var e in employees)
            {
                Console.WriteLine(e.Ename);
            }
        }



        private static void DeleteEmpUsingID()
        {
            var ctx = new TrainingContext();
            var eno = 7934;
            int rowsAffected = ctx.Database.ExecuteSqlRaw($"RemoveEmpNo {eno}");
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
                            Value = 7725
                        },
                        new SqlParameter() {
                            ParameterName = "@empname",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "JACK"},





                        new SqlParameter() {
                            ParameterName = "@job",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "EMPLOYEE"},




                         new SqlParameter() {
                            ParameterName = "@MGR",
                            SqlDbType =  System.Data.
                            SqlDbType.VarChar,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = "7839"},

                         new SqlParameter() {
                            ParameterName = "@HIREDATE",
                            SqlDbType =  System.Data.
                            SqlDbType.DateTime,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = DateTime.Now},




                         new SqlParameter() {
                            ParameterName = "@SAL",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 85000},


                         new SqlParameter() {
                            ParameterName = "@COMM",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 850},



                        new SqlParameter() {
                            ParameterName = "@DEPTNO",
                            SqlDbType =  System.Data.
                            SqlDbType.Int,
                            Size = 100,
                            Direction = System.Data.
                            ParameterDirection.Input,
                            Value = 30}
                      };



            try
            {
                var result = ctx.Database.ExecuteSqlRaw("AcceptDetails @empno,  @empname, @job, @MGR, @HIREDATE, @SAL, @COMM, @DEPTNO", param);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {
                throw;
            }
            Console.WriteLine("update successful");
        }






        private static void UpdateNewEmployee()
        {
            var ctx = new TrainingContext();
            try
            {
                var employee = ctx.Emps.Where(e => e.Empno == 6969).SingleOrDefault();
                employee.Empno = 2979;
                employee.Ename = "Dhanush";
                ctx.Update(employee);
                ctx.SaveChanges();
                Console.WriteLine("Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }


        private static void RemoveNewEmployee()
        {

            var ctx = new TrainingContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 6969;
                employee.Ename = "Rahul";
                employee.Sal = 10000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Remove(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);

                throw;
            }


        }

        private static void AddNewEmployee()
        {
            var ctx = new TrainingContext();
            try
            {
                Emp employee = new Emp();
                employee.Empno = 6969;
                employee.Ename = "Rahul";
                employee.Sal = 10000;
                employee.Deptno = 30;
                employee.Job = "Trainer";
                ctx.Add(employee);
                ctx.SaveChanges();
                Console.WriteLine("New employee added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);

                throw;
            }
        }

        private static void GetEmpDetailsByID()
        {
            var ctx = new TrainingContext();
            var emp = ctx.Emps.Where(e => e.Empno == 7369).SingleOrDefault();
            Console.WriteLine(emp.Ename + "  " + emp.Sal + "  " + emp.Job);

        }

        private static void GetAllEmpDetails()
        {
            var ctx = new TrainingContext();
            var emp = ctx.Emps;

            foreach (var employee in emp)
            {
                Console.WriteLine(employee.Ename + " " + employee.Sal);
            }
        }
    }
}