using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ARDC.Admin.Data.Model
{
    public partial class ARDCDataContext : DbContext
    {
        public ARDCDataContext()
        {
        }

        public ARDCDataContext(DbContextOptions<ARDCDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<ELMAH_Error> ELMAH_Error { get; set; }
        public virtual DbSet<__MigrationHistory> __MigrationHistory { get; set; }
        public virtual DbSet<tblAcceptance> tblAcceptance { get; set; }
        public virtual DbSet<tblBookingStatusType> tblBookingStatusType { get; set; }
        public virtual DbSet<tblCar> tblCar { get; set; }
        public virtual DbSet<tblCarClub> tblCarClub { get; set; }
        public virtual DbSet<tblCarType> tblCarType { get; set; }
        public virtual DbSet<tblContactType> tblContactType { get; set; }
        public virtual DbSet<tblEvent> tblEvent { get; set; }
        public virtual DbSet<tblEventCategoryClassType> tblEventCategoryClassType { get; set; }
        public virtual DbSet<tblEventCategoryType> tblEventCategoryType { get; set; }
        public virtual DbSet<tblEventDay> tblEventDay { get; set; }
        public virtual DbSet<tblEventDayPerson> tblEventDayPerson { get; set; }
        public virtual DbSet<tblEventPriceCategoryChart> tblEventPriceCategoryChart { get; set; }
        public virtual DbSet<tblEventType> tblEventType { get; set; }
        public virtual DbSet<tblGarageCarPort> tblGarageCarPort { get; set; }
        public virtual DbSet<tblGarageCarportNonAvailability> tblGarageCarportNonAvailability { get; set; }
        public virtual DbSet<tblLookup> tblLookup { get; set; }
        public virtual DbSet<tblPaymentType> tblPaymentType { get; set; }
        public virtual DbSet<tblPerson> tblPerson { get; set; }
        public virtual DbSet<tblPersonContact> tblPersonContact { get; set; }
        public virtual DbSet<tblPersonRole> tblPersonRole { get; set; }
        public virtual DbSet<tblPersonRoleGradeType> tblPersonRoleGradeType { get; set; }
        public virtual DbSet<tblPersonRoleType> tblPersonRoleType { get; set; }
        public virtual DbSet<tblPriceCategory> tblPriceCategory { get; set; }
        public virtual DbSet<tblPriceList> tblPriceList { get; set; }
        public virtual DbSet<tblRace> tblRace { get; set; }
        public virtual DbSet<tblRaceEvent> tblRaceEvent { get; set; }
        public virtual DbSet<tblSMSPOC> tblSMSPOC { get; set; }
        public virtual DbSet<tblSecurePayResponse> tblSecurePayResponse { get; set; }
        public virtual DbSet<tblSystemConfig> tblSystemConfig { get; set; }
        public virtual DbSet<tblTeam> tblTeam { get; set; }
        public virtual DbSet<tblTeamCar> tblTeamCar { get; set; }
        public virtual DbSet<tblTeamPersonRole> tblTeamPersonRole { get; set; }
        public virtual DbSet<tblTeamRaceEntry> tblTeamRaceEntry { get; set; }
        public virtual DbSet<tblTeamRaceEntryGarageCarPort> tblTeamRaceEntryGarageCarPort { get; set; }
        public virtual DbSet<tblTeamRaceEntryPayment> tblTeamRaceEntryPayment { get; set; }
        public virtual DbSet<tblTeamRaceEntryPriceItem> tblTeamRaceEntryPriceItem { get; set; }
        public virtual DbSet<tblTrack> tblTrack { get; set; }
        public virtual DbSet<tblUserMigration> tblUserMigration { get; set; }
        public virtual DbSet<tbl_LetterTemplate> tbl_LetterTemplate { get; set; }
        public virtual DbSet<tempOfficialsMigration> tempOfficialsMigration { get; set; }
        public virtual DbSet<vwCompetitorCurrentRaceEntries> vwCompetitorCurrentRaceEntries { get; set; }
        public virtual DbSet<vwCompetitorCurrentTeamRaceEntires> vwCompetitorCurrentTeamRaceEntires { get; set; }
        public virtual DbSet<vwOfficialsEventDay> vwOfficialsEventDay { get; set; }
        public virtual DbSet<vwTeamRaceEvent> vwTeamRaceEvent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MD-R90Q8NH0\\LOCALSQL;Database=ARDCData;User Id=sa;Password=sa;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();
            });

            modelBuilder.Entity<ELMAH_Error>(entity =>
            {
                entity.HasIndex(e => new { e.Application, e.TimeUtc, e.Sequence })
                    .HasName("IX_ELMAH_Error_App_Time_Seq");

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Sequence).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<__MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");
            });

            modelBuilder.Entity<tblAcceptance>(entity =>
            {
                entity.Property(e => e.AcceptanceType).IsUnicode(false);

                entity.Property(e => e.AcceptedDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DocumentReference).IsUnicode(false);

                entity.Property(e => e.Role).IsUnicode(false);
            });

            modelBuilder.Entity<tblEventDayPerson>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Updated).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblEventPriceCategoryChart>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EventPriceCategoryChartId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<tblPerson>(entity =>
            {
                entity.Property(e => e.DoYouSmoke).IsUnicode(false);

                entity.Property(e => e.HasCAMSId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<tblPersonRole>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tblSMSPOC>(entity =>
            {
                entity.Property(e => e.CAMS).IsUnicode(false);

                entity.Property(e => e.DOB).IsUnicode(false);

                entity.Property(e => e.EventDateTime).IsUnicode(false);

                entity.Property(e => e.Mobile).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RaceEvent).IsUnicode(false);

                entity.Property(e => e.SMSResponse).IsUnicode(false);

                entity.Property(e => e.SMSResponseLog).IsUnicode(false);

                entity.Property(e => e.SMSSent).IsUnicode(false);

                entity.Property(e => e.SMSSentLog).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<tblSecurePayResponse>(entity =>
            {
                entity.Property(e => e.Created).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TeamRaceEntryId).IsUnicode(false);

                entity.Property(e => e.amount).IsUnicode(false);

                entity.Property(e => e.baseamount).IsUnicode(false);

                entity.Property(e => e.cardtype).IsUnicode(false);

                entity.Property(e => e.currency).IsUnicode(false);

                entity.Property(e => e.expirydate).IsUnicode(false);

                entity.Property(e => e.fingerprint).IsUnicode(false);

                entity.Property(e => e.merchant).IsUnicode(false);

                entity.Property(e => e.pan).IsUnicode(false);

                entity.Property(e => e.refid).IsUnicode(false);

                entity.Property(e => e.rescode).IsUnicode(false);

                entity.Property(e => e.restext).IsUnicode(false);

                entity.Property(e => e.settdate).IsUnicode(false);

                entity.Property(e => e.summarycode).IsUnicode(false);

                entity.Property(e => e.suramount).IsUnicode(false);

                entity.Property(e => e.surfee).IsUnicode(false);

                entity.Property(e => e.surrate).IsUnicode(false);

                entity.Property(e => e.timestamp).IsUnicode(false);

                entity.Property(e => e.txnid).IsUnicode(false);
            });

            modelBuilder.Entity<tblSystemConfig>(entity =>
            {
                entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.FieldName).IsUnicode(false);

                entity.Property(e => e.FieldType).IsUnicode(false);

                entity.Property(e => e.FieldValue).IsUnicode(false);

                entity.Property(e => e.UpdatedDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tblUserMigration>(entity =>
            {
                entity.Property(e => e.CAMS).IsUnicode(false);

                entity.Property(e => e.CreatedDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DriverLicence).IsUnicode(false);

                entity.Property(e => e.EntrantLicence).IsUnicode(false);

                entity.Property(e => e.ErrorMessage).IsUnicode(false);

                entity.Property(e => e.NewPassword).IsUnicode(false);

                entity.Property(e => e.OfficialLicence).IsUnicode(false);

                entity.Property(e => e.PersonName).IsUnicode(false);

                entity.Property(e => e.UpdatedDateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<tempOfficialsMigration>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ASPUserExists).IsUnicode(false);

                entity.Property(e => e.IsCompetitorOrDriver).IsUnicode(false);

                entity.Property(e => e.WillBeMigrated).IsUnicode(false);
            });

            modelBuilder.Entity<vwCompetitorCurrentRaceEntries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCompetitorCurrentRaceEntries");
            });

            modelBuilder.Entity<vwCompetitorCurrentTeamRaceEntires>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwCompetitorCurrentTeamRaceEntires");
            });

            modelBuilder.Entity<vwOfficialsEventDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwOfficialsEventDay");
            });

            modelBuilder.Entity<vwTeamRaceEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vwTeamRaceEvent");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
