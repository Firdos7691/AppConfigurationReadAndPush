using Azure.Data.AppConfiguration;
using DemoForAppConfiguration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DemoForAppConfiguration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Push(AppConfigurationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var client = new ConfigurationClient(_configuration.GetConnectionString("AppConnectionString"));
            var settingToCreate = new ConfigurationSetting(model.Key, model.Value);
            client.SetConfigurationSetting(settingToCreate);
            ViewBag.Message = "Values pushed successfully....!";
            return View("Index");
        }

        [HttpPost]
        public ActionResult Read(AppConfigurationModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            ViewBag.ReadMessage = $"Value of for {model.Key} is :" + _configuration[model.Key];
            return View("Privacy");
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
