using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcTaskManager.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime DateOfStart { get; set; }
        public int TeamSize { get; set; }
    }

    //public class TaskManageDbContext : DbContext
    //{
    //    public DbSet<Project> Projects { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        base.OnConfiguring(optionsBuilder);
    //        optionsBuilder.UseSqlServer("data source=localhost;integrated security=yes;initial catalog=TaskManager");
    //    }
    //}
}
