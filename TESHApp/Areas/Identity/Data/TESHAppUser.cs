using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TESHApp.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the TESHAppUser class
    public class TESHAppUser : IdentityUser
    {
        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
