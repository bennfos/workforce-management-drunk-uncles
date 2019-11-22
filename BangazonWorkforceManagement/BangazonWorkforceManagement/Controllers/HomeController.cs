using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BangazonWorkforceManagement.Models;
using Microsoft.Data.SqlClient;
using BangazonWorkforceManagement.Models.ViewModels;
using Microsoft.Extensions.Configuration;

namespace BangazonWorkforceManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private string _connectionString;
        private SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _connectionString = config.GetConnectionString("DefaultConnection");
        }

        public IActionResult EmployeeTrainingReport()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, Name FROM Department";
                    var reader = cmd.ExecuteReader();

                    var allDepartments = new List<Department>();
                    while (reader.Read())
                    {
                        allDepartments.Add(new Department()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                        });
                    }

                    reader.Close();
                    var viewModel = new EmployeeTrainingProgramsReportViewModel()
                    {
                        Departments = allDepartments
                    };
                    return View(viewModel);
                }
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
