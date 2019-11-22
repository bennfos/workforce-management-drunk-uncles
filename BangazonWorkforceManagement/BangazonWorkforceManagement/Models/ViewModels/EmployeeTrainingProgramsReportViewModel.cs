using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonWorkforceManagement.Models.ViewModels
{
    public class EmployeeTrainingProgramsReportViewModel
    {
        public List<Department> Departments { get; set; }
        public List<SelectListItem> DepartmentOptions
        {
            get
            {
                List<SelectListItem> options = new List<SelectListItem>()
                {
                    new SelectListItem("Select a department...", "0")
                };

                if (Departments != null)
                {
                    options.AddRange(
                        Departments.Select(d => new SelectListItem(d.Name, d.Id.ToString()))
                    );
                }

                return options;
            }
        }
    }
}