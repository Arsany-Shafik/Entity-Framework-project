using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using ConsoleApp1.database;

namespace ConsoleApp1.Transactions
{
    public class AddRange

    {
       public void AddRanges() {
            var _context = new DbContextapp();

            using var AddRangeTransaction = _context.Database.BeginTransaction();
            try
            {
                //Add records using AddRange
                var employee1 = new Employee
                {
                    Name = "Christina jad",
                    EmployeeSurvey = new EmployeeSurvey { Gender = false, Age = 29, JobLevel = "Junior", Experience = 7, Dept = "Marketing", PhysicalActivityHours = 1.6, WorkLoad = 1, Stress = 1, SleepHours = 8.2, CommuteMode = "Car", CommuteDistance = 13, TeamSize = 8, EduLevel = "Bachelor" }
                };

                var employee2 = new Employee
                {
                    Name = "Mirna mario",
                    EmployeeSurvey = new EmployeeSurvey { Gender = false, Age = 58, JobLevel = "Lead", Experience = 25, Dept = "Customer Service", PhysicalActivityHours = 3.7, WorkLoad = 3, Stress = 3, SleepHours = 6.7, CommuteMode = "Public Transport", CommuteDistance = 25, TeamSize = 28, EduLevel = "Bachelor" }
                };

                _context.AddRange(employee1, employee2);
                _context.SaveChanges();
                AddRangeTransaction.Commit();
            }
                catch (System.Exception) {
                AddRangeTransaction.Rollback();
                }
            _context.SaveChanges();
        }
    }
}
