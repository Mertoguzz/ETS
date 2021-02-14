using ETS.UI.DTOs;
using ETS.UI.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ETS.UI.Helpers
{
    public class ETSHelpers
    {
        private readonly IConfiguration _config;
        public ETSHelpers(IConfiguration config)
        {
            _config = config; 
        }
        public bool isValidBloodGroup(string bloodGroup)
        {
            Regex rgx = new Regex("(A|B|AB|O)[+-]");
            if (rgx.IsMatch(bloodGroup))
            {

            }

            return true;
        }
        internal bool IsValidUser(UserDTO user)
        {
            bool isValid = true;
            if (user == null)
            {
                return false;
            }
            isValid = CheckMandatoryFields(user);
     
            return isValid;
        }
        private bool CheckMandatoryFields(UserDTO user)
        {
            List<MyKeyValuePair> properties = GetStringPropertiesByObject(user);
            if (properties.Any())
            {
                foreach (MyKeyValuePair item in properties)
                {
                    if (item.Value == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private static List<MyKeyValuePair> GetStringPropertiesByObject(object myObject)
        {
            List<MyKeyValuePair> stringPropertyNamesAndValues = (List<MyKeyValuePair>)myObject.GetType()
                         .GetProperties()
                         .Where(pi => pi.PropertyType == typeof(string) && pi.GetGetMethod() != null)
                         .Select(pi => new MyKeyValuePair
                         {
                             Name = pi.Name,
                             Value = pi.GetGetMethod().Invoke(myObject, null)
                         }).ToList();


            return stringPropertyNamesAndValues;
        }
        internal string ApiGetProcess(string operationName)
        {
            string retVal = "";
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_config.GetValue<string>("APIUri"));

                var responseTask = client.GetAsync(operationName);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    retVal = readTask.Result;
                  
                }

            }
            return retVal;
        }

    }
}
