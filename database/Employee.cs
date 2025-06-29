using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.database
{
    public class Employee
    {

            public int Id { get; set; }
        [Required , MaxLength(1000)]
            public string Name { get; set; }
        public EmployeeSurvey EmployeeSurvey { get; set; }
    }
}
