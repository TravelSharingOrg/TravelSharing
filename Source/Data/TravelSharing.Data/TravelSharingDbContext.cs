using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelSharing.Data.Models;

namespace TravelSharing.Data
{
    public class TravelSharingDbContext : IdentityDbContext<ApplicationUser>
    {
        public TravelSharingDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static TravelSharingDbContext Create()
        {
            return new TravelSharingDbContext();
        }
    }
}
