using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.database
{
    public class EmployeeSurvey
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Required, MaxLength(50)]
        public bool  Gender { get; set; }         // true = male, false = female
        public int Age { get; set; }
        [Required, MaxLength(100)]
        public string JobLevel { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required, MaxLength(1000)]
        public string Dept { get; set; }
        public double PhysicalActivityHours { get; set; }
        public int WorkLoad { get; set; }
        public int Stress { get; set; }
        public double SleepHours { get; set; }
        [MaxLength(1000)]
        public string CommuteMode { get; set; }
        public int CommuteDistance { get; set; }
        public int TeamSize { get; set; }
        [Required, MaxLength(1000)]
        public string EduLevel { get; set; }
    public Employee Employee { get; set; }
    }
}
