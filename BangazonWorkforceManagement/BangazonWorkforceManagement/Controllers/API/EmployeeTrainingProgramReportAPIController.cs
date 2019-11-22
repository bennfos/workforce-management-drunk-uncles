
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using BangazonWorkforceManagement.Models;
using BangazonWorkforceManagement.Models.ViewModels;

namespace BangazonWorkforceManagement.Controllers.API
    {
        [Route("api/[controller]")]
        [ApiController]
        public class EmployeeTrainingProgramReportAPIController : ControllerBase
        {
            private string _connectionString;
            private SqlConnection Connection
            {
                get
                {
                    return new SqlConnection(_connectionString);
                }
            }

            public EmployeeTrainingProgramReportAPIController(IConfiguration config)
            {
                _connectionString = config.GetConnectionString("DefaultConnection");
            }

            [HttpGet("{id:int}")]
            public async Task<IActionResult> Get(int id)
            {
                using (SqlConnection conn = Connection)
                {
                    conn.Open();
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"SELECT e.id, e.FirstName, e.LastName, e.DepartmentId, e.IsSupervisor,
                                               COUNT(et.id) AS TrainingProgramCount
                                          FROM Employee e
                                               LEFT JOIN EmployeeTraining et on et.EmployeeId = e.Id
                                         WHERE e.departmentId = @id
                                      GROUP BY e.id, e.FirstName, e.LastName, e.DepartmentId, e.IsSupervisor";
                        cmd.Parameters.Add(new SqlParameter("@id", id));
                        var reader = cmd.ExecuteReader();

                        var employees = new List<EmployeeTrainingCount>();
                        while (reader.Read())
                        {
                            employees.Add(
                                new EmployeeTrainingCount
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                                    FirstName = reader.GetString(reader.GetOrdinal("firstname")),
                                    LastName = reader.GetString(reader.GetOrdinal("lastname")),
                                    TrainingProgramCount = reader.GetInt32(reader.GetOrdinal("TrainingProgramCount")),
                                });
                        }

                        reader.Close();
                        return Ok(employees);
                    }
                }
            }
        }
    }
