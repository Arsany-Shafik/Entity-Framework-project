// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Transactions;
using ConsoleApp1;
using ConsoleApp1.database;
using ConsoleApp1.Transactions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

var _context = new DbContextapp();

                  // Retrive all names that begin with letter "M"
var testSelect = _context.Employees.Where(x => x.Name.StartsWith("M")).ToList();
foreach (var item in testSelect)
{
    Console.WriteLine($"Id: {item.Id}   Name: {item.Name}");
}

                                //Update record
//var employee = new Employee
//{
//    Id = 8,
//    Name = "Shafik"
//};
//_context.Employees.Update(employee);


                                //AddRangeTransaction
//var AddRange = new AddRange();
//AddRange.AddRanges();


                                //Add record
//var employee2 = new Employee
//{
//    Name = "Arsany",
//   EmployeeSurvey = new EmployeeSurvey { Gender = true, Age = 31, JobLevel = "Senior", Experience = 6, Dept = "Legal", PhysicalActivityHours = 0.3, WorkLoad = 5, Stress = 3, SleepHours = 7.4, CommuteMode = "Public Transport", CommuteDistance = 7, TeamSize = 21, EduLevel = "Master" },
//};
//_context.Employees.Add(employee2);

                            //Inner join using linq
var ViewJoin = (from b in _context.Employees
               join a in _context.EmployeeSurveys
               on b.Id equals a.EmployeeId
               select new
               {
                   Name = b.Name,
                   Id = b.Id,
                   Gender = a.Gender ? "Male" : "Female",
                   Age = a.Age,
                   JobLevel = a.JobLevel,
                   Dept = a.Dept,
                   CommuteDistance = a.CommuteDistance,
                   CommuteMode = a.CommuteMode,
                   PhysicalActivityHours = a.PhysicalActivityHours,
                   WorkLoad = a.WorkLoad,
                   Stress = a.Stress,
                   TeamSize = a.TeamSize,
                   SleepHours = a.SleepHours,
               }).ToList();
foreach (var item in ViewJoin)
{
    Console.WriteLine($"{item}\n");
}

                // StoredProcedure that restore all Names from Employees table
var employeesName = _context.Employees.FromSqlRaw("SelectAllEmployeeNames").ToList();
foreach (var item in employeesName)
{
                //return names start with letter "M" with case-sensitive from the stored procedure
    if (item.Name.StartsWith("M"))
    {
    Console.WriteLine($"{item.Name}\n");   
    }
}

               // StoredProcedure that restore all data from EmployeeSurveys table
var employeesyrveys = _context.EmployeeSurveys.FromSqlRaw("SelectAllEmployeeSurveys").ToList();
foreach (var item in employeesyrveys)
{
            //return data of department "IT" from the stored procedure
    if (item.Dept.Equals("IT"))
    {
        Console.WriteLine($"EmployeeId: {item.EmployeeId}    Gender: {(item.Gender ? "Male" : "Female")}    Age: {item.Age}   Dept: {item.Dept}     JobLevel: {item.JobLevel}\n");
    }
}

_context.SaveChanges();