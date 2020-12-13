using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MyCosmetologist.Models
{
    public class User: IdentityUser
    {
        //public int Id { get; set; }
        public string Name { get; set; }
    }
}
