using Building_Managementsystem.Controllers;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Building_Managementsystem.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<admin_login> admin_login { get; set; }
        public virtual DbSet<maintenance_req> maintenance_req { get; set; }

        public virtual DbSet<user_reg> user_reg { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
