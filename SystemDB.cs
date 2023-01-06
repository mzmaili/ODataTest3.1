using AdminLog.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataTest
{
    public class SystemDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=AdminLogDB;User Id=postgres;Password=0000");


        // Users Tables:
        public DbSet<User> Users { get; set; }
        public DbSet<UserExtension> UserExtension { get; set; }
        public DbSet<UserAssignedLicense> UserAssignedLicenses { get; set; }
        public DbSet<UserAssignedPlan> UserAssignedPlans { get; set; }
        public DbSet<UserDeviceKey> UserDeviceKeys { get; set; }
        public DbSet<UserIdentity> UserIdentities { get; set; }
        public DbSet<UserOnPremisesProvisioningError> UserOnPremisesProvisioningError { get; set; }
        public DbSet<UserProvisionedPlan> UserProvisionedPlans { get; set; }
        public DbSet<UsersCredentialUserRegistrationDetails> UsersCredentialUserRegistrationDetails { get; set; }
        public DbSet<DirectoryRole> DirectoryRoles { get; set; }
        public DbSet<DirectoryRoleMember> DirectoryRoleMembers { get; set; }
    }
}
