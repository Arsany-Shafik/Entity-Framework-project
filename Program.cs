// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.database;
using Microsoft.EntityFrameworkCore;

var _context = new DbContextapp();

var testSelect = _context.Employees.Where(x => x.Name.StartsWith("m")).ToList();
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

                    //Add records using AddRange
//var employee1 = new Employee
//{
//    Name = "John Doe",
//    EmployeeSurvey = new EmployeeSurvey {Gender=true,Age=22, JobLevel="Intern/Fresher", Experience=0,Dept= "IT",PhysicalActivityHours= 1.6,WorkLoad= 3,Stress= 2,SleepHours= 5.5,CommuteMode= "Car",CommuteDistance= 22,TeamSize= 27,EduLevel= "High School" }
//};

//var employee2 = new Employee
//{
//    Name = "Jane Smith",
//    EmployeeSurvey = new EmployeeSurvey { Gender = true, Age = 32, JobLevel = "Mid", Experience = 7, Dept = "IT", PhysicalActivityHours = 2.5, WorkLoad = 2, Stress = 1, SleepHours = 7.6, CommuteMode = "Car", CommuteDistance = 20, TeamSize = 12, EduLevel = "Bachelor" }
//};

//_context.AddRange(employee1, employee2);
//_context.SaveChanges();


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
_context.SaveChanges();