﻿using System.Data.Entity;
using MunkeyIssues.Core.Data;
using MunkeyIssues.IssueService.Domain;

namespace MunkeyIssues.IssueService.Persistence
{
    public class IssueContext : DbContext, IDbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}