﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kcsara.Training.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration.Conventions;
    
    public partial class AuthDatabaseEntities : DbContext
    {
        public AuthDatabaseEntities()
            : base("name=AuthDatabaseEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<MemberEmergencyContact> MemberEmergencyContacts { get; set; }
        public virtual DbSet<MemberMedical> MemberMedicals { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberUnitDocument> MemberUnitDocuments { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonContact> PersonContacts { get; set; }
        public virtual DbSet<TrainingAward> TrainingAwards { get; set; }
        public virtual DbSet<TrainingCours> TrainingCourses { get; set; }
        public virtual DbSet<TrainingRoster> TrainingRosters { get; set; }
        public virtual DbSet<TrainingRule> TrainingRules { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
    }
}
