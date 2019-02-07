using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ProCoding.Demos.ASPNetCore.Configuration.Models;

namespace ProCoding.Demos.ASPNetCore.Configuration.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _config;

        public HomeController(IConfiguration config)
        {
            _config = config;
        }

        public IActionResult Index()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(_config.GetValue<string>("RootLevelKey"));

            // result.AppendLine("section0:key0 - " + _config.GetValue<string>("section0:key0"));

            // result.AppendLine("section2:subsection0:key1 - " + _config.GetValue<string>("section2:subsection0:key1"));

            // IConfigurationSection configSection = _config.GetSection("section2:subsection0");
            // // foreach(var item in configSection.AsEnumerable())
            // foreach(var item in configSection.GetChildren())
            // {
            //     result.AppendLine($"{item.Key} - {item.Value}");
            // }
            
            // result.AppendLine($"section2 exists? - {_config.GetSection("section2").Exists()}");
            // result.AppendLine($"section3 exists? - {_config.GetSection("section3").Exists()}");

            // var inexistent = _config.GetValue<string>("InexistentKey", "Not Found");
            // result.AppendLine(inexistent);

            // IConfigurationSection employeesSection = _config.GetSection("employees");
            // foreach(var item in employeesSection.AsEnumerable())
            // {
            //     result.AppendLine($"{item.Key} - {item.Value}");
            // }

            // var specificEmployee = _config.GetSection("employees:0").Get<Employee>();
            // result.AppendLine($"{nameof(specificEmployee.FirstName)} - {specificEmployee.FirstName}");
            // result.AppendLine($"{nameof(specificEmployee.LastName)} - {specificEmployee.LastName}");
            // result.AppendLine($"{nameof(specificEmployee.Age)} - {specificEmployee.Age}");
            // result.AppendLine($"{nameof(specificEmployee.EMail)} - {specificEmployee.EMail}");

            // var employees = _config.GetSection("employees").Get<List<Employee>>();
            // foreach(var employee in employees)
            // {
            //     result.AppendLine($"{nameof(employee.FirstName)} - {employee.FirstName}");
            //     result.AppendLine($"{nameof(employee.LastName)} - {employee.LastName}");
            //     result.AppendLine($"{nameof(employee.Age)} - {employee.Age}");
            //     result.AppendLine($"{nameof(employee.EMail)} - {employee.EMail}");
            // }

            // result.AppendLine($"ConnectionStrings:Database - {_config.GetConnectionString("Database")}");

            ViewData["Result"] = result.ToString();
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
