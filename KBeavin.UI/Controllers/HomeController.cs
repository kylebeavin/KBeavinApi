using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using KBeavin.UI.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace KBeavin.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            List<Test> test = new List<Test>();
            try
            {
                using (var httpClient = new HttpClient())
                {
                    //using (var response = await httpClient.GetAsync("https://localhost:44331/api/Test"))
                    using (var response = await httpClient.GetAsync("https://kbeavinapi.azurewebsites.net/api/Test"))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        test = JsonConvert.DeserializeObject<List<Test>>(apiResponse);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return View(test);
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
