﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RemoteWorkProductivityTracker.Areas.Identity.Data;

namespace RemoteWorkProductivityTracker.Areas.Identity.Data;

public class TrackerDbContext : IdentityDbContext<ApplicationUser>
{
    public TrackerDbContext(DbContextOptions<TrackerDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    DbSet<ApplicationUser> Users;
    DbSet<TrackerTask> Tasks;
    DbSet<Sections> Sections;
}
