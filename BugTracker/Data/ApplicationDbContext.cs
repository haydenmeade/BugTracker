using System;
using System.Collections.Generic;
using System.Text;
using BugTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Sprint> Sprints { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProjectAccess>()
                .HasKey(pa => new { pa.ProjectId, pa.UserId });

            builder.Entity<ProjectAccess>()
                .HasOne(pa => pa.Project)
                .WithMany(p => p.ProjectAccesses)
                .HasForeignKey(pa => pa.ProjectId);

            builder.Entity<ProjectAccess>()
                .HasOne(pa => pa.User)
                .WithMany(u => u.ProjectAccesses)
                .HasForeignKey(pa => pa.UserId);
        }
    }
}
