using ETS.UI.DTOs;
using ETS.UI.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ETS.UI.Controllers
{
    public class UserController : Controller
    {
        ETSHelpers eTSHelpers = null;
        private readonly IConfiguration _config;
        public UserController(IConfiguration config)
        {
            _config = config;
            eTSHelpers = new ETSHelpers(config);

        }

        public IActionResult List()
        {
            IEnumerable<UserDTO> users = null;
            string strObject = eTSHelpers.ApiGetProcess("user/getusers");
            users = JsonConvert.DeserializeObject<List<UserDTO>>(strObject);
            return View(users);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Register(UserDTO user)
        {
            string retVal = "";
            bool isValidUser = eTSHelpers.IsValidUser(user);
            if (isValidUser)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(_config.GetValue<string>("APIUri"));

                    var content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                    var result = client.PostAsync("user/register", content);
                    result.Wait();
                    var ss = result.Result;
                    if (result.IsCompletedSuccessfully)
                    {
                        Task<string> readTask = result.Result.Content.ReadAsStringAsync();
                        readTask.Wait();
                        retVal = readTask.Result;

                    }

                }
            }
            return Json(retVal);
        }
    }
}
