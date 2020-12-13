using Microsoft.AspNetCore.Identity;

namespace MyCosmetologist.Web.Models
{
    public class User: IdentityUser
    {
        //public int Id { get; set; }
        public string Name { get; set; }
    }
}
