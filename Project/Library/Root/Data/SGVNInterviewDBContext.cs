using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Root.Migrations;
using Root.Models;
using Root.Models.Mapping;

namespace Root.Data
{
	public partial class SGVNInterviewDBContext : IdentityDbContext<User>
	{
		//static SGTSVNDBContext()
		//{
		//	//Database.SetInitializer<SGTSVNDBContext>(null);
		//}

		public SGVNInterviewDBContext()
			: base("Name=SGVNInterviewDBContext", false) // false: giam 2 giay
		{
		}

        public DbSet<Employee_M> Employee_M { get; set; }
        public DbSet<Driver_M> Driver_M { get; set; }
        public DbSet<Basic_S> Basic_S { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<RoleFeatures> RoleFeatures { get; set; }
        public DbSet<Feature_M> Feature_M { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
            modelBuilder.Configurations.Add(new Employee_MMap());
            modelBuilder.Configurations.Add(new Driver_MMap());
            modelBuilder.Configurations.Add(new Basic_SMap());
            modelBuilder.Configurations.Add(new Client_Map());
            modelBuilder.Configurations.Add(new RefreshToken_Map());
            modelBuilder.Configurations.Add(new Feature_MMap());
            modelBuilder.Configurations.Add(new RoleFeatures_Map());

            base.OnModelCreating(modelBuilder); // This needs to go before the other rules!
                                                //authentication db
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles");
        }

		public virtual void Commit()
		{
			base.SaveChanges();
		}
	}
}
