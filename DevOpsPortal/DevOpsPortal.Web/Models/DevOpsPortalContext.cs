using System;
using DevOpsPortal.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.DependencyInjection;

namespace DevOpsPortal.Data
{
    public class DevOpsPortalContext : IdentityDbContext<ApplicationUser> //DbContext
    {
        public IdentityManager identityManager;
        public DevOpsPortalContext(IdentityManager identity)
        {
            identityManager = identity;
        }

        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DevOpsPortalContext(DbContextOptions<DevOpsPortalContext> options) : base(options)
        {
            //  Database.SetInitializer<DevOpsPortalContext>(new CreateDatabaseIfNotExists<DevOpsPortalContext>());
            //  AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.GetData("DataDirectory").ToString());
            // AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());


            // AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\adminAzure\Source\Workspaces\DevOpsPortal\DevOpsPortalDev\featurevorchestratorintegrn\DevOpsPortal\DevOpsPortal.Data\DataDirectory");
            // C:\DataDirectoryAppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\adminAzure\Source\Workspaces\DevOpsPortal\DevOpsPortalDev\featurevorchestratorintegrn\DevOpsPortal\DevOpsPortal.Data\DataDirectory");
            //AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\DataDirectory");
            // AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\New folder\FeatureKubernetesDeploy\DevOpsPortal.WebAPI\App_Data");


            //  this.Database.= s => System.Diagnostics.Debug.WriteLine(s);
        }

        #region DBTables
         public virtual DbSet<DevOpsPortal.Data.ApplicationRole> Roles { get; set; }
        public DbSet<DevOpsPortal.Data.Group> Groups { get; set; }

        // public DbSet<DevOpsPortal.Data.DevOpsFacets> DevOpsFacets { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.KPIAreas> KPIAreas { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.MaturityLevels> MaturityLevels { get; set; }
        //
        //
        // public DbSet<DevOpsPortal.Data.KPITenets> KPITenets { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.MaturityAssessQuestions> MaturityAssessQuestions { get; set; }
        //
        // // publty.DbSet<DevOpsPortal.Data.MaturityAssessAnswer> MaturityAssessAnswer { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.MaturityAssessAnswerOptions> MaturityAssessAnswerOptions { get; set; }
        // public DbSet<DevOpsPortal.Data.MaturityAssessKPIAreaCurrentStates> MaturityAssessKPIAreaCurrentStates { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.MaturityAssessKPIAreaDesiredStates> MaturityAssessKPIAreaDesiredStates { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.MaturityAssessmentSurveys> MaturityAssessmentSurveys { get; set; }
        //
        // // publty.DbSet<DevOpsAssessment.Models.MaturityAssessmentResult_kpiCurrentState> MaturityAssessmentResult_kpiCurrentState { get; set; }
        //
        // // publty.DbSet<DevOpsAssessment.Models.MaturityAssessmentResult_kpiDesiredState> MaturityAssessmentResult_kpiDesiredState { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.MaturityAssessmentResults> MaturityAssessmentResults { get; set; }
        // public DbSet<DevOpsPortal.Data.AppToolChains> AppToolChains { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.ToolTypes> ToolTypes { get; set; }
        // public DbSet<DevOpsPortal.Data.ToolTypeOptions> ToolTypeOptions { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.ToolChainActions> ToolChainActions { get; set; }
        // public DbSet<DevOpsPortal.Data.ToolChainAudits> ToolChainAudits { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.AssessPrelims> AssessPrelims { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.PrelimAssessQuestions> PrelimAssessQuestions { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.PrelimQtnCtrgs> PrelimQtnCtrgs { get; set; }
        //
        // //publiy.DbSet<DevOpsPortal.Data.AssessmentViews> assessmentstatusviews { get; set; }
        // public DbSet<DevOpsPortal.Data.ProjectDetails> ProjectDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.AssessmentTypes> AssessmentTypes { get; set; }
        // public DbSet<DevOpsPortal.Data.ReadinessAssessments> ReadinessAssessments { get; set; }
        // public DbSet<DevOpsPortal.Data.ReadinessAssessAnswers> ReadinessAssessAnswers { get; set; }
        // //publiy.DbSet<DevOpsPortal.Data.ReadinessAssessmentResults> ReadinessAssessmentResults { get; set; }
        // //publiy.DbSet<DevOpsPortal.Data.ReadinessAssessQuestions> ReadinessAssessQuestions { get; set; }
        // //publiy.DbSet<DevOpsPortal.Data.ReadinessAssessQusAnsOptions> ReadinessAssessQusAnsOptions { get; set; }
        // //publiy.DbSet<DevOpsPortal.Data.ReadinessAssessAnswerOptions> ReadinessAssessAnswerOpt { get; set; }
        // public DbSet<DevOpsPortal.Data.AssessStatusViews> assessstatusviews { get; set; }
        public DbSet<DevOpsPortal.Data.Organizations> Organizations { get; set; }
        public DbSet<DevOpsPortal.Data.OrgLevelTypes> OrgLevelTypes { get; set; }
        public DbSet<DevOpsPortal.Data.OrgLevels> OrgLevels { get; set; }

        public DbSet<DevOpsPortal.Data.OrgHierarchyLevelsUsers> OrgHierarchyLevelsUsers { get; set; }
        // public DbSet<DevOpsPortal.Data.ApplicationDetails> ApplicationDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.InfraHosts> InfraHosts { get; set; }
        // public DbSet<DevOpsPortal.Data.InfraProvisionAuditLogs> InfraProvisionAuditLogs { get; set; }
        // public DbSet<DevOpsPortal.Data.SubscriptionDetails> SubscriptionDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.SshkeypairDetails> SshkeypairDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.Environments> Environments { get; set; }
        // public DbSet<DevOpsPortal.Data.InfraHostsMasters> InfraHostsMasters { get; set; }
        // public DbSet<DevOpsPortal.Data.InfraHostsDetails> InfraHostsDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.InfraHostLogs> InfraHostLogs { get; set; }
        // public DbSet<DevOpsPortal.Data.SecurityGroups> SecurityGroups { get; set; }
        // public DbSet<DevOpsPortal.Data.Mt_Components> Mt_Components { get; set; }
        // public DbSet<DevOpsPortal.Data.Dt_StrategyInputs> Dt_StrategyInputs { get; set; }
        // public DbSet<DevOpsPortal.Data.ExcelDetails> ExcelDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.TemplateDetails> TemplateDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.InventoryMasters> InventoryMasters { get; set; }
        // public DbSet<DevOpsPortal.Data.InventoryDetails> InventoryDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.NamespaceDetails> NamespaceDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.ReadinessCategories> ReadinessCategories { get; set; }
        // public DbSet<DevOpsPortal.Data.ReadinessRecommendations> ReadinessRecommendations { get; set; }
        // public DbSet<DevOpsPortal.Data.PrelimRecommendations> PrelimRecommendations { get; set; }
        // public DbSet<DevOpsPortal.Data.SREAssessments> SREAssessments { get; set; }
        // public DbSet<DevOpsPortal.Data.SREAssessAnswers> SREAssessAnswers { get; set; }
        // public DbSet<DevOpsPortal.Data.SRECategories> SRECategories { get; set; }
        // public DbSet<DevOpsPortal.Data.SRERecommendations> SRERecommendations { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.FullStackAssessments> FullStackAssessments { get; set; }
        // public DbSet<DevOpsPortal.Data.FullStackAdditionalQuesAssessments> FullStackAdditionalQuesAssessments { get; set; }
        // public DbSet<DevOpsPortal.Data.FullStackCategories> FullStackCategories { get; set; }
        // public DbSet<DevOpsPortal.Data.FullStackQuestionnaires> FullStackQuestionnaires { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.ReviewStatuses> ReviewStatuses { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.AssetStatusHistories> AssetStatusHistories { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.AssessWorkflowStatuses> AssessWorkflowStatuses { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.ManageKuberneteClusterJobs> ManageKuberneteClusterJobs { get; set; }
        // public DbSet<DevOpsPortal.Data.ArtefactsRepositoryDetails> ArtefactsRepositoryDetails { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.DockerRepositoryDetails> DockerRepositoryDetails { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.KubernetesClusterDetails> KubernetesClusterDetails { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.KubeToolchainInventoryMasters> KubeToolchainInventoryMasters { get; set; }
        // public DbSet<DevOpsPortal.Data.KubeToolImageAuditLogs> KubeToolImageAuditLogs { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.KubeToolImageInventoryDetails> KubeToolImageInventoryDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.KubeToolImageInventoryMasters> KubeToolImageInventoryMasters { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.KubeToolListMasters> KubeToolListMasters { get; set; }
        // public DbSet<DevOpsPortal.Data.KubeToolNamespaceDetails> KubeToolNamespaceDetails { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.K8ToolchainDetails> K8ToolchainDetails { get; set; }
        //
        // public DbSet<DevOpsPortal.Data.KubeToolchainAuditLogs> KubeToolchainAuditLogs { get; set; }
        // public DbSet<DevOpsPortal.Data.KubeCategoryMasters> KubeCategoryMasters { get; set; }
        // public DbSet<DevOpsPortal.Data.K8ClusterDetails> K8ClusterDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.K8ClusterAuditLogs> K8ClusterAuditLogs { get; set; }
        // public DbSet<DevOpsPortal.Data.RancherDetails> RancherDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.PipelineFlowTypes> PipelineFlowTypes { get; set; }
        // public DbSet<DevOpsPortal.Data.PipelineStages> PipelineStages { get; set; }
        // public DbSet<DevOpsPortal.Data.PipelineStageTools> PipelineStageTools { get; set; }
        // public DbSet<DevOpsPortal.Data.PipelineProvisionDetails> PipelineProvisionDetails { get; set; }
        // public DbSet<DevOpsPortal.Data.PipelineProvisionAuditLogs> PipelineProvisionAuditLogs { get; set; }
        // public DbSet<DevOpsPortal.Data.KubeToolStageMappings> KubeToolStageMappings { get; set; }
        // public DbSet<DevOpsPortal.Data.K8ToolchainStageMappings> K8ToolchainStageMappings { get; set; }
        // public DbSet<DevOpsPortal.Data.DeleteAuditLogMasters> DeleteAuditLogMasters { get; set; }
        // public DbSet<DevOpsPortal.Data.CloudProviders> CloudProviders { get; set; }

        #endregion

        #region Commenting for now
       // overriding the asp.net tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ApplicationUser>().ToTable("AspNetUsers").Property(p => p.UserName).IsRequired(); ;
            modelBuilder.Entity<ApplicationUser>().HasMany<ApplicationUserGroup>((ApplicationUser u) => u.Groups);
            modelBuilder.Entity<ApplicationUserGroup>().ToTable("ApplicationUserGroups").HasKey((ApplicationUserGroup r) => new { UserId = r.UserId, GroupId = r.GroupId });
            modelBuilder.Entity<Group>().HasMany<ApplicationRoleGroup>((Group g) => g.Roles);
            modelBuilder.Entity<ApplicationRoleGroup>().ToTable("ApplicationRoleGroups").HasKey((ApplicationRoleGroup gr) => new { RoleId = gr.RoleId, GroupId = gr.GroupId });
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.Entity<IdentityRole>().ToTable("AspNetRoles").Property(r=> r.Name).IsRequired();
            modelBuilder.Entity<IdentityUserLogin<string>>().ToTable("AspNetUserLogins").HasKey((IdentityUserLogin<string> l) =>
                    new { UserId = l.UserId, LoginProvider = l.LoginProvider, ProviderKey = l.ProviderKey });
            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("AspNetUserRoles").HasKey((IdentityUserRole<string> r) =>
                new { UserId = r.UserId, RoleId = r.RoleId });
            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<IdentityUserClaim<string>>(b =>
            {
                b.Property(r => r.UserId).IsRequired();
            });
            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.Property(r => r.Name).IsRequired();
            });
            modelBuilder.Seed();
        }
        #endregion
      
    }
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {

                    UserName = "PlainVanillaUser",
                    FirstName = "PlainVanillaFirstName",
                    LastName = "PlainVanillaLastName",
                    Email = "Plainvanilla@test.com",
                    EmailConfirmed = true,
                    OrgId = 1,
                    OrgLevelTypeId = 1,
                    OrgLevelid = 1,
                    User_Active = true
                }
            );
        }

    }
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("AspNetUsers");
            // compound PK
            builder.Property(p => p.UserName).IsRequired();
        }
    }
    public class ApplicationUserGroupConfiguration : IEntityTypeConfiguration<ApplicationUserGroup>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserGroup> builder)
        {
            // compound PK
            builder.ToTable("ApplicationUserGroups").HasKey(p => new {p.UserId, p.GroupId });
        }
    }
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            // compound PK
            builder.ToTable("Groups").Property(p => p.Name).IsRequired();
        }
    }
    public class AspNetUserLogins : IdentityUserLogin<string>
    {
        public virtual ApplicationUser User { get; set; }
    }
   
}
