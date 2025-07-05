using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using VPNAppFormS.Models; // 如果你的 StaffProfile 在 Models 資料夾

namespace VPNAppFormS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<StaffProfile> StaffProfiles { get; set; }
    }
}

