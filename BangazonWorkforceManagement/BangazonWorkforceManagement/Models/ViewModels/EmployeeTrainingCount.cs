using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforceManagement.Models.ViewModels
{
    public class EmployeeTrainingCount
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }  
        public int TrainingProgramCount { get; set; }
    }
}
