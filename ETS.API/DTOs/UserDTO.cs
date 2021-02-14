using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETS.API.DTOs
{
    public class UserDTO
    {
        //public Guid ID { get; set; }
    
        public string Name { get; set; }
        public string Surname { get; set; }

        public string BloodGroup { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }

    }
}
