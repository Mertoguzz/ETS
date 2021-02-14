using ETS.API.DTOs;
using ETS.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;

namespace ETS.API.Services
{
    public partial class UserService : IUserService
    {
        #region DBContext
        //private DatabaseContext _db;


        //public UserService(DatabaseContext context)
        //{
        //    _db = context;

        //} 
        #endregion
        public List<UserDTO> GetUsers()
        {
            #region DBContext
            //List<UserDTO> userDTOs = _db.Users
            //  .Select(x => new UserDTO() { Surname = x.Surname, Name = x.Name, BloodGroup = x.BloodGroup, Phone = x.Phone, Address = x.Address })
            //  .ToList(); 
            #endregion

            List<UserDTO> userDTOs = new List<UserDTO>();
            string file = System.IO.File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json") );
            JArray jArray = JArray.Parse(file);
            if (jArray.Count > 0)
            {
                foreach (var item in jArray)
                {
                    UserDTO userDTO = null;
                    if (item != null)
                    {
                        userDTO = new UserDTO();
                        userDTO.Name = (string)item["Name"];
                        userDTO.Surname = (string)item["Surname"];
                        userDTO.Address = (string)item["Address"];
                        userDTO.Phone = (string)item["Phone"];
                        userDTO.BloodGroup = (string)item["BloodGroup"];
                        userDTOs.Add(userDTO);
                    }
                }

            }
            return userDTOs;
        }

        public bool Register(User user)
        {
            int result = 0;
            #region DBContext
            //_db.Users.Add(user);
            //result = _db.SaveChanges(); 
            #endregion

            UserDTO userDTO = new UserDTO { Address = user.Address, Name = user.Name, Phone = user.Phone, BloodGroup = user.BloodGroup, Surname = user.Surname };
            List<UserDTO> users = new List<UserDTO>();
            try
            {
                users = GetUsers();
                users.Add(userDTO);
                string jsonData = JsonConvert.SerializeObject(users, Formatting.None);
                System.IO.File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.json"), jsonData);
                result = 1;
            }
            catch (Exception)
            {
            }

            return result > 0 ? true : false;
        }
    }
}
