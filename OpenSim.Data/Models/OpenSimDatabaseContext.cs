using System;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OpenSim.Data.Models
{
    public partial class OpenSimDatabaseContext : DbContext
    {
        public OpenSimDatabaseContext()
        {
        }

        public OpenSimDatabaseContext(DbContextOptions<OpenSimDatabaseContext> options)
            : base(options)
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     var connectionString = ConfigurationManager.ConnectionStrings["OpenSimDatabase"].ConnectionString;
        //     optionsBuilder.UseMySQL(connectionString);
        // }

        public virtual DbSet<Agentpref> Agentprefs { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<Avatar> Avatars { get; set; }
        public virtual DbSet<Bakedterrain> Bakedterrains { get; set; }
        public virtual DbSet<Classified> Classifieds { get; set; }
        public virtual DbSet<EstateGroup> EstateGroups { get; set; }
        public virtual DbSet<EstateManager> EstateManagers { get; set; }
        public virtual DbSet<EstateMap> EstateMaps { get; set; }
        public virtual DbSet<EstateSetting> EstateSettings { get; set; }
        public virtual DbSet<EstateUser> EstateUsers { get; set; }
        public virtual DbSet<Estateban> Estatebans { get; set; }
        public virtual DbSet<Friend> Friends { get; set; }
        public virtual DbSet<Fsasset> Fsassets { get; set; }
        public virtual DbSet<Gloebitsubscription> Gloebitsubscriptions { get; set; }
        public virtual DbSet<Gloebittransaction> Gloebittransactions { get; set; }
        public virtual DbSet<Gloebituser> Gloebitusers { get; set; }
        public virtual DbSet<Griduser> Gridusers { get; set; }
        public virtual DbSet<HgTravelingDatum> HgTravelingData { get; set; }
        public virtual DbSet<ImOffline> ImOfflines { get; set; }
        public virtual DbSet<Inventoryfolder> Inventoryfolders { get; set; }
        public virtual DbSet<Inventoryitem> Inventoryitems { get; set; }
        public virtual DbSet<Land> Lands { get; set; }
        public virtual DbSet<Landaccesslist> Landaccesslists { get; set; }
        public virtual DbSet<Migration> Migrations { get; set; }
        public virtual DbSet<Mutelist> Mutelists { get; set; }
        public virtual DbSet<OsGroupsGroup> OsGroupsGroups { get; set; }
        public virtual DbSet<OsGroupsInvite> OsGroupsInvites { get; set; }
        public virtual DbSet<OsGroupsMembership> OsGroupsMemberships { get; set; }
        public virtual DbSet<OsGroupsNotice> OsGroupsNotices { get; set; }
        public virtual DbSet<OsGroupsPrincipal> OsGroupsPrincipals { get; set; }
        public virtual DbSet<OsGroupsRole> OsGroupsRoles { get; set; }
        public virtual DbSet<OsGroupsRolemembership> OsGroupsRolememberships { get; set; }
        public virtual DbSet<Presence> Presences { get; set; }
        public virtual DbSet<Prim> Prims { get; set; }
        public virtual DbSet<Primitem> Primitems { get; set; }
        public virtual DbSet<Primshape> Primshapes { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Regionban> Regionbans { get; set; }
        public virtual DbSet<Regionenvironment> Regionenvironments { get; set; }
        public virtual DbSet<Regionextra> Regionextras { get; set; }
        public virtual DbSet<Regionsetting> Regionsettings { get; set; }
        public virtual DbSet<Regionwindlight> Regionwindlights { get; set; }
        public virtual DbSet<SpawnPoint> SpawnPoints { get; set; }
        public virtual DbSet<Terrain> Terrains { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<Useraccount> Useraccounts { get; set; }
        public virtual DbSet<Userdatum> Userdata { get; set; }
        public virtual DbSet<Usernote> Usernotes { get; set; }
        public virtual DbSet<Userpick> Userpicks { get; set; }
        public virtual DbSet<Userprofile> Userprofiles { get; set; }
        public virtual DbSet<Usersetting> Usersettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agentpref>(entity =>
            {
                entity.HasKey(e => e.PrincipalId)
                    .HasName("PRIMARY");

                entity.ToTable("agentprefs");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID")
                    .IsUnique();

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(36)
                    .HasColumnName("PrincipalID")
                    .IsFixedLength(true);

                entity.Property(e => e.AccessPrefs)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasDefaultValueSql("'M'")
                    .IsFixedLength(true);

                entity.Property(e => e.HoverHeight).HasColumnType("double(30,27)");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("'en-us'")
                    .IsFixedLength(true);

                entity.Property(e => e.LanguageIsPublic)
                    .IsRequired()
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PermNextOwner).HasDefaultValueSql("'532480'");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("assets");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.AccessTime)
                    .HasColumnName("access_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AssetFlags).HasColumnName("asset_flags");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("CreatorID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnType("longblob")
                    .HasColumnName("data");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("description");

                entity.Property(e => e.Local).HasColumnName("local");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Temporary).HasColumnName("temporary");
            });

            modelBuilder.Entity<Auth>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PRIMARY");

                entity.ToTable("auth");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(36)
                    .HasColumnName("UUID")
                    .IsFixedLength(true);

                entity.Property(e => e.AccountType)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("accountType")
                    .HasDefaultValueSql("'UserAccount'");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("passwordHash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("passwordSalt")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.WebLoginKey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("webLoginKey")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Avatar>(entity =>
            {
                entity.HasKey(e => new { e.PrincipalId, e.Name })
                    .HasName("PRIMARY");

                entity.ToTable("avatars");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(36)
                    .HasColumnName("PrincipalID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(32);
            });

            modelBuilder.Entity<Bakedterrain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bakedterrain");

                entity.Property(e => e.Heightfield).HasColumnType("longblob");

                entity.Property(e => e.RegionUuid)
                    .HasMaxLength(255)
                    .HasColumnName("RegionUUID");
            });

            modelBuilder.Entity<Classified>(entity =>
            {
                entity.HasKey(e => e.Classifieduuid)
                    .HasName("PRIMARY");

                entity.ToTable("classifieds");

                entity.Property(e => e.Classifieduuid)
                    .HasMaxLength(36)
                    .HasColumnName("classifieduuid")
                    .IsFixedLength(true);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("category");

                entity.Property(e => e.Classifiedflags).HasColumnName("classifiedflags");

                entity.Property(e => e.Creationdate).HasColumnName("creationdate");

                entity.Property(e => e.Creatoruuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("creatoruuid")
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Expirationdate).HasColumnName("expirationdate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Parcelname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("parcelname");

                entity.Property(e => e.Parceluuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("parceluuid")
                    .IsFixedLength(true);

                entity.Property(e => e.Parentestate).HasColumnName("parentestate");

                entity.Property(e => e.Posglobal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("posglobal");

                entity.Property(e => e.Priceforlisting).HasColumnName("priceforlisting");

                entity.Property(e => e.Simname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("simname");

                entity.Property(e => e.Snapshotuuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("snapshotuuid")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EstateGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("estate_groups");

                entity.HasIndex(e => e.EstateId, "EstateID");

                entity.Property(e => e.EstateId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("EstateID");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("uuid")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EstateManager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("estate_managers");

                entity.HasIndex(e => e.EstateId, "EstateID");

                entity.Property(e => e.EstateId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("EstateID");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("uuid")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<EstateMap>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PRIMARY");

                entity.ToTable("estate_map");

                entity.HasIndex(e => e.EstateId, "EstateID");

                entity.Property(e => e.RegionId)
                    .HasMaxLength(36)
                    .HasColumnName("RegionID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.EstateId).HasColumnName("EstateID");
            });

            modelBuilder.Entity<EstateSetting>(entity =>
            {
                entity.HasKey(e => e.EstateId)
                    .HasName("PRIMARY");

                entity.ToTable("estate_settings");

                entity.Property(e => e.EstateId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("EstateID");

                entity.Property(e => e.AbuseEmail)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AllowLandmark).HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowParcelChanges).HasDefaultValueSql("'1'");

                entity.Property(e => e.AllowSetHome).HasDefaultValueSql("'1'");

                entity.Property(e => e.EstateName).HasMaxLength(64);

                entity.Property(e => e.EstateOwner)
                    .IsRequired()
                    .HasMaxLength(36);

                entity.Property(e => e.ParentEstateId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("ParentEstateID");
            });

            modelBuilder.Entity<EstateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("estate_users");

                entity.HasIndex(e => e.EstateId, "EstateID");

                entity.Property(e => e.EstateId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("EstateID");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("uuid")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Estateban>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("estateban");

                entity.HasIndex(e => e.EstateId, "estateban_EstateID");

                entity.Property(e => e.BanTime).HasColumnName("banTime");

                entity.Property(e => e.BannedIp)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("bannedIp");

                entity.Property(e => e.BannedIpHostMask)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("bannedIpHostMask");

                entity.Property(e => e.BannedNameMask)
                    .HasMaxLength(64)
                    .HasColumnName("bannedNameMask");

                entity.Property(e => e.BannedUuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("bannedUUID");

                entity.Property(e => e.BanningUuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("banningUUID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.EstateId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("EstateID");
            });

            modelBuilder.Entity<Friend>(entity =>
            {
                entity.HasKey(e => new { e.PrincipalId, e.Friend1 })
                    .HasName("PRIMARY");

                entity.ToTable("friends");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(255)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.Friend1)
                    .HasMaxLength(255)
                    .HasColumnName("Friend");

                entity.Property(e => e.Flags)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Offered)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Fsasset>(entity =>
            {
                entity.ToTable("fsassets");

                entity.Property(e => e.Id)
                    .HasMaxLength(36)
                    .HasColumnName("id")
                    .IsFixedLength(true);

                entity.Property(e => e.AccessTime).HasColumnName("access_time");

                entity.Property(e => e.AssetFlags).HasColumnName("asset_flags");

                entity.Property(e => e.CreateTime).HasColumnName("create_time");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Hash)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("hash")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Gloebitsubscription>(entity =>
            {
                entity.HasKey(e => new { e.ObjectId, e.AppKey, e.GlbApiUrl })
                    .HasName("PRIMARY");

                entity.ToTable("gloebitsubscriptions");

                entity.HasIndex(e => e.ObjectId, "ix_oid");

                entity.HasIndex(e => e.SubscriptionId, "ix_sid");

                entity.HasIndex(e => new { e.SubscriptionId, e.GlbApiUrl }, "k_sub_api")
                    .IsUnique();

                entity.Property(e => e.ObjectId)
                    .HasMaxLength(36)
                    .HasColumnName("ObjectID")
                    .IsFixedLength(true);

                entity.Property(e => e.AppKey).HasMaxLength(64);

                entity.Property(e => e.GlbApiUrl).HasMaxLength(100);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Enabled).HasColumnName("enabled");

                entity.Property(e => e.ObjectName).HasMaxLength(64);

                entity.Property(e => e.SubscriptionId)
                    .HasMaxLength(36)
                    .HasColumnName("SubscriptionID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Gloebittransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("gloebittransactions");

                entity.HasIndex(e => e.PayeeId, "ix_payeeid");

                entity.HasIndex(e => e.PayerId, "ix_payerid");

                entity.HasIndex(e => e.PartId, "ix_pid");

                entity.HasIndex(e => e.SubscriptionId, "ix_sid");

                entity.HasIndex(e => e.TransactionType, "ix_tt");

                entity.Property(e => e.TransactionId)
                    .HasMaxLength(36)
                    .HasColumnName("TransactionID")
                    .IsFixedLength(true);

                entity.Property(e => e.Canceled).HasColumnName("canceled");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(36)
                    .HasColumnName("CategoryID")
                    .IsFixedLength(true);

                entity.Property(e => e.Consumed).HasColumnName("consumed");

                entity.Property(e => e.Enacted).HasColumnName("enacted");

                entity.Property(e => e.PartDescription).HasMaxLength(128);

                entity.Property(e => e.PartId)
                    .HasMaxLength(36)
                    .HasColumnName("PartID")
                    .IsFixedLength(true);

                entity.Property(e => e.PartName).HasMaxLength(64);

                entity.Property(e => e.PayeeId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("PayeeID")
                    .IsFixedLength(true);

                entity.Property(e => e.PayeeName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PayerId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("PayerID")
                    .IsFixedLength(true);

                entity.Property(e => e.PayerName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ResponseReason)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ResponseStatus)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.SubscriptionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("SubscriptionID")
                    .IsFixedLength(true);

                entity.Property(e => e.TransactionTypeString)
                    .IsRequired()
                    .HasMaxLength(64);
            });

            modelBuilder.Entity<Gloebituser>(entity =>
            {
                entity.HasKey(e => new { e.AppKey, e.PrincipalId })
                    .HasName("PRIMARY");

                entity.ToTable("gloebitusers");

                entity.HasIndex(e => e.PrincipalId, "ix_gu_pid");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(36)
                    .IsFixedLength(true);

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(36)
                    .HasColumnName("PrincipalID")
                    .IsFixedLength(true);

                entity.Property(e => e.GloebitId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("GloebitID")
                    .IsFixedLength(true);

                entity.Property(e => e.GloebitToken)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsFixedLength(true);

                entity.Property(e => e.LastSessionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("LastSessionID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Griduser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("griduser");

                entity.Property(e => e.UserId)
                    .HasMaxLength(255)
                    .HasColumnName("UserID");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(31)
                    .IsFixedLength(true);

                entity.Property(e => e.HomeLookAt)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("'<0,0,0>'")
                    .IsFixedLength(true);

                entity.Property(e => e.HomePosition)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("'<0,0,0>'")
                    .IsFixedLength(true);

                entity.Property(e => e.HomeRegionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("HomeRegionID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.LastLookAt)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("'<0,0,0>'")
                    .IsFixedLength(true);

                entity.Property(e => e.LastPosition)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("'<0,0,0>'")
                    .IsFixedLength(true);

                entity.Property(e => e.LastRegionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("LastRegionID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.Login)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength(true);

                entity.Property(e => e.Logout)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength(true);

                entity.Property(e => e.NameCached)
                    .HasMaxLength(16)
                    .IsFixedLength(true);

                entity.Property(e => e.Online)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasDefaultValueSql("'false'")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<HgTravelingDatum>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("hg_traveling_data");

                entity.HasIndex(e => e.UserId, "UserID");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(36)
                    .HasColumnName("SessionID");

                entity.Property(e => e.ClientIpaddress)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("ClientIPAddress")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GridExternalName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MyIpaddress)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("MyIPAddress")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServiceToken)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ImOffline>(entity =>
            {
                entity.ToTable("im_offline");

                entity.HasIndex(e => e.FromId, "FromID");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint")
                    .HasColumnName("ID");

                entity.Property(e => e.FromId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("FromID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.PrincipalId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Inventoryfolder>(entity =>
            {
                entity.HasKey(e => e.FolderId)
                    .HasName("PRIMARY");

                entity.ToTable("inventoryfolders");

                entity.HasIndex(e => e.AgentId, "inventoryfolders_agentid");

                entity.HasIndex(e => e.ParentFolderId, "inventoryfolders_parentFolderid");

                entity.Property(e => e.FolderId)
                    .HasMaxLength(36)
                    .HasColumnName("folderID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.AgentId)
                    .HasMaxLength(36)
                    .HasColumnName("agentID")
                    .IsFixedLength(true);

                entity.Property(e => e.FolderName)
                    .HasMaxLength(64)
                    .HasColumnName("folderName");

                entity.Property(e => e.ParentFolderId)
                    .HasMaxLength(36)
                    .HasColumnName("parentFolderID")
                    .IsFixedLength(true);

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Inventoryitem>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PRIMARY");

                entity.ToTable("inventoryitems");

                entity.HasIndex(e => e.AvatarId, "inventoryitems_avatarid");

                entity.HasIndex(e => e.ParentFolderId, "inventoryitems_parentFolderid");

                entity.Property(e => e.InventoryId)
                    .HasMaxLength(36)
                    .HasColumnName("inventoryID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.AssetId)
                    .HasMaxLength(36)
                    .HasColumnName("assetID");

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.AvatarId)
                    .HasMaxLength(36)
                    .HasColumnName("avatarID")
                    .IsFixedLength(true);

                entity.Property(e => e.CreationDate).HasColumnName("creationDate");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("creatorID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.Flags)
                    .HasColumnType("int unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("groupID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.GroupOwned).HasColumnName("groupOwned");

                entity.Property(e => e.InvType).HasColumnName("invType");

                entity.Property(e => e.InventoryBasePermissions)
                    .HasColumnType("int unsigned")
                    .HasColumnName("inventoryBasePermissions");

                entity.Property(e => e.InventoryCurrentPermissions)
                    .HasColumnType("int unsigned")
                    .HasColumnName("inventoryCurrentPermissions");

                entity.Property(e => e.InventoryDescription)
                    .HasMaxLength(128)
                    .HasColumnName("inventoryDescription");

                entity.Property(e => e.InventoryEveryOnePermissions)
                    .HasColumnType("int unsigned")
                    .HasColumnName("inventoryEveryOnePermissions");

                entity.Property(e => e.InventoryGroupPermissions)
                    .HasColumnType("int unsigned")
                    .HasColumnName("inventoryGroupPermissions");

                entity.Property(e => e.InventoryName)
                    .HasMaxLength(64)
                    .HasColumnName("inventoryName");

                entity.Property(e => e.InventoryNextPermissions)
                    .HasColumnType("int unsigned")
                    .HasColumnName("inventoryNextPermissions");

                entity.Property(e => e.ParentFolderId)
                    .HasMaxLength(36)
                    .HasColumnName("parentFolderID")
                    .IsFixedLength(true);

                entity.Property(e => e.SalePrice).HasColumnName("salePrice");

                entity.Property(e => e.SaleType).HasColumnName("saleType");
            });

            modelBuilder.Entity<Land>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PRIMARY");

                entity.ToTable("land");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(255)
                    .HasColumnName("UUID");

                entity.Property(e => e.AnyAvsounds)
                    .HasColumnName("AnyAVSounds")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.AuctionId).HasColumnName("AuctionID");

                entity.Property(e => e.AuthbuyerId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("AuthbuyerID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.Bitmap).HasColumnType("longblob");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Environment)
                    .HasColumnType("mediumtext")
                    .HasColumnName("environment");

                entity.Property(e => e.GroupAvsounds)
                    .HasColumnName("GroupAVSounds")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.GroupUuid)
                    .HasMaxLength(255)
                    .HasColumnName("GroupUUID");

                entity.Property(e => e.LandFlags).HasColumnType("int unsigned");

                entity.Property(e => e.LocalLandId).HasColumnName("LocalLandID");

                entity.Property(e => e.MediaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MediaSize)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasDefaultValueSql("'0,0'");

                entity.Property(e => e.MediaTextureUuid)
                    .HasMaxLength(255)
                    .HasColumnName("MediaTextureUUID");

                entity.Property(e => e.MediaType)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasDefaultValueSql("'none/none'");

                entity.Property(e => e.MediaUrl)
                    .HasMaxLength(255)
                    .HasColumnName("MediaURL");

                entity.Property(e => e.MusicUrl)
                    .HasMaxLength(255)
                    .HasColumnName("MusicURL");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OwnerUuid)
                    .HasMaxLength(255)
                    .HasColumnName("OwnerUUID");

                entity.Property(e => e.RegionUuid)
                    .HasMaxLength(255)
                    .HasColumnName("RegionUUID");

                entity.Property(e => e.SeeAvs)
                    .HasColumnName("SeeAVs")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SnapshotUuid)
                    .HasMaxLength(255)
                    .HasColumnName("SnapshotUUID");
            });

            modelBuilder.Entity<Landaccesslist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("landaccesslist");

                entity.Property(e => e.AccessUuid)
                    .HasMaxLength(255)
                    .HasColumnName("AccessUUID");

                entity.Property(e => e.LandUuid)
                    .HasMaxLength(255)
                    .HasColumnName("LandUUID");
            });

            modelBuilder.Entity<Migration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("migrations");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<Mutelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mutelist");

                entity.HasIndex(e => e.AgentId, "AgentID");

                entity.HasIndex(e => new { e.AgentId, e.MuteId, e.MuteName }, "AgentID_2")
                    .IsUnique();

                entity.Property(e => e.AgentId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("AgentID")
                    .IsFixedLength(true);

                entity.Property(e => e.MuteId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("MuteID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.MuteName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MuteType).HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OsGroupsGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_groups");

                entity.HasIndex(e => e.Name, "Name")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "Name_2");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.Charter).IsRequired();

                entity.Property(e => e.FounderId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("FounderID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.InsigniaId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("InsigniaID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpenEnrollment)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OwnerRoleId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("OwnerRoleID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OsGroupsInvite>(entity =>
            {
                entity.HasKey(e => e.InviteId)
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_invites");

                entity.HasIndex(e => new { e.GroupId, e.PrincipalId }, "PrincipalGroup")
                    .IsUnique();

                entity.Property(e => e.InviteId)
                    .HasMaxLength(36)
                    .HasColumnName("InviteID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.PrincipalId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OsGroupsMembership>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.PrincipalId })
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_membership");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(255)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AcceptNotices).HasDefaultValueSql("'1'");

                entity.Property(e => e.AccessToken)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.ListInProfile).HasDefaultValueSql("'1'");

                entity.Property(e => e.SelectedRoleId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("SelectedRoleID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OsGroupsNotice>(entity =>
            {
                entity.HasKey(e => e.NoticeId)
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_notices");

                entity.HasIndex(e => e.GroupId, "GroupID");

                entity.HasIndex(e => e.Tmstamp, "TMStamp");

                entity.Property(e => e.NoticeId)
                    .HasMaxLength(36)
                    .HasColumnName("NoticeID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.AttachmentItemId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("AttachmentItemID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.AttachmentName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AttachmentOwnerId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("AttachmentOwnerID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GroupId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tmstamp)
                    .HasColumnType("int unsigned")
                    .HasColumnName("TMStamp");
            });

            modelBuilder.Entity<OsGroupsPrincipal>(entity =>
            {
                entity.HasKey(e => e.PrincipalId)
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_principals");

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(255)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ActiveGroupId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("ActiveGroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<OsGroupsRole>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RoleId })
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_roles");

                entity.HasIndex(e => e.GroupId, "GroupID");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Powers).HasColumnType("bigint unsigned");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OsGroupsRolemembership>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.RoleId, e.PrincipalId })
                    .HasName("PRIMARY");

                entity.ToTable("os_groups_rolemembership");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.RoleId)
                    .HasMaxLength(36)
                    .HasColumnName("RoleID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.PrincipalId)
                    .HasMaxLength(255)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Presence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("presence");

                entity.HasIndex(e => e.RegionId, "RegionID");

                entity.HasIndex(e => e.SessionId, "SessionID")
                    .IsUnique();

                entity.HasIndex(e => e.UserId, "UserID");

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("RegionID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.SecureSessionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("SecureSessionID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("SessionID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<Prim>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PRIMARY");

                entity.ToTable("prims");

                entity.HasIndex(e => e.RegionUuid, "prims_regionuuid");

                entity.HasIndex(e => e.SceneGroupId, "prims_scenegroupid");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(36)
                    .HasColumnName("UUID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.AccelerationX).HasDefaultValueSql("'0'");

                entity.Property(e => e.AccelerationY).HasDefaultValueSql("'0'");

                entity.Property(e => e.AccelerationZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.AngularVelocityX).HasDefaultValueSql("'0'");

                entity.Property(e => e.AngularVelocityY).HasDefaultValueSql("'0'");

                entity.Property(e => e.AngularVelocityZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.AttachedPosX).HasDefaultValueSql("'0'");

                entity.Property(e => e.AttachedPosY).HasDefaultValueSql("'0'");

                entity.Property(e => e.AttachedPosZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.CameraAtOffsetX).HasDefaultValueSql("'0'");

                entity.Property(e => e.CameraAtOffsetY).HasDefaultValueSql("'0'");

                entity.Property(e => e.CameraAtOffsetZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.CameraEyeOffsetX).HasDefaultValueSql("'0'");

                entity.Property(e => e.CameraEyeOffsetY).HasDefaultValueSql("'0'");

                entity.Property(e => e.CameraEyeOffsetZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.CollisionSound)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CreatorID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Density).HasDefaultValueSql("'1000'");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Friction).HasDefaultValueSql("'0.6'");

                entity.Property(e => e.GravityModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("GroupID")
                    .IsFixedLength(true);

                entity.Property(e => e.GroupPositionX).HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupPositionY).HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupPositionZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.KeyframeMotion).HasColumnType("blob");

                entity.Property(e => e.LastOwnerId)
                    .HasMaxLength(36)
                    .HasColumnName("LastOwnerID")
                    .IsFixedLength(true);

                entity.Property(e => e.LoopedSound)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.LoopedSoundGain).HasDefaultValueSql("'0'");

                entity.Property(e => e.Material).HasDefaultValueSql("'3'");

                entity.Property(e => e.MediaUrl)
                    .HasMaxLength(255)
                    .HasColumnName("MediaURL");

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OmegaX).HasDefaultValueSql("'0'");

                entity.Property(e => e.OmegaY).HasDefaultValueSql("'0'");

                entity.Property(e => e.OmegaZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(36)
                    .HasColumnName("OwnerID")
                    .IsFixedLength(true);

                entity.Property(e => e.ParticleSystem).HasColumnType("blob");

                entity.Property(e => e.PositionX).HasDefaultValueSql("'0'");

                entity.Property(e => e.PositionY).HasDefaultValueSql("'0'");

                entity.Property(e => e.PositionZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.Pseudocrc)
                    .HasColumnName("pseudocrc")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RegionUuid)
                    .HasMaxLength(36)
                    .HasColumnName("RegionUUID")
                    .IsFixedLength(true);

                entity.Property(e => e.Restitution).HasDefaultValueSql("'0.5'");

                entity.Property(e => e.RezzerId)
                    .HasMaxLength(36)
                    .HasColumnName("RezzerID")
                    .IsFixedLength(true);

                entity.Property(e => e.RotationW).HasDefaultValueSql("'0'");

                entity.Property(e => e.RotationX).HasDefaultValueSql("'0'");

                entity.Property(e => e.RotationY).HasDefaultValueSql("'0'");

                entity.Property(e => e.RotationZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.SalePrice).HasDefaultValueSql("'10'");

                entity.Property(e => e.SceneGroupId)
                    .HasMaxLength(36)
                    .HasColumnName("SceneGroupID")
                    .IsFixedLength(true);

                entity.Property(e => e.SitName).HasMaxLength(255);

                entity.Property(e => e.SitTargetOffsetX).HasDefaultValueSql("'0'");

                entity.Property(e => e.SitTargetOffsetY).HasDefaultValueSql("'0'");

                entity.Property(e => e.SitTargetOffsetZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.SitTargetOrientW).HasDefaultValueSql("'0'");

                entity.Property(e => e.SitTargetOrientX).HasDefaultValueSql("'0'");

                entity.Property(e => e.SitTargetOrientY).HasDefaultValueSql("'0'");

                entity.Property(e => e.SitTargetOrientZ).HasDefaultValueSql("'0'");

                entity.Property(e => e.Sitactrange)
                    .HasColumnName("sitactrange")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sopanims)
                    .HasColumnType("blob")
                    .HasColumnName("sopanims");

                entity.Property(e => e.Standtargetx)
                    .HasColumnName("standtargetx")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Standtargety)
                    .HasColumnName("standtargety")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Standtargetz)
                    .HasColumnName("standtargetz")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text).HasMaxLength(255);

                entity.Property(e => e.TextureAnimation).HasColumnType("blob");

                entity.Property(e => e.TouchName).HasMaxLength(255);

                entity.Property(e => e.VelocityX).HasDefaultValueSql("'0'");

                entity.Property(e => e.VelocityY).HasDefaultValueSql("'0'");

                entity.Property(e => e.VelocityZ).HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<Primitem>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PRIMARY");

                entity.ToTable("primitems");

                entity.HasIndex(e => e.PrimId, "primitems_primid");

                entity.Property(e => e.ItemId)
                    .HasMaxLength(36)
                    .HasColumnName("itemID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.AssetId)
                    .HasMaxLength(36)
                    .HasColumnName("assetID")
                    .IsFixedLength(true);

                entity.Property(e => e.AssetType).HasColumnName("assetType");

                entity.Property(e => e.BasePermissions).HasColumnName("basePermissions");

                entity.Property(e => e.CreationDate).HasColumnName("creationDate");

                entity.Property(e => e.CreatorId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("CreatorID")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CurrentPermissions).HasColumnName("currentPermissions");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.EveryonePermissions).HasColumnName("everyonePermissions");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(36)
                    .HasColumnName("groupID")
                    .IsFixedLength(true);

                entity.Property(e => e.GroupPermissions).HasColumnName("groupPermissions");

                entity.Property(e => e.InvType).HasColumnName("invType");

                entity.Property(e => e.LastOwnerId)
                    .HasMaxLength(36)
                    .HasColumnName("lastOwnerID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NextPermissions).HasColumnName("nextPermissions");

                entity.Property(e => e.OwnerId)
                    .HasMaxLength(36)
                    .HasColumnName("ownerID")
                    .IsFixedLength(true);

                entity.Property(e => e.ParentFolderId)
                    .HasMaxLength(36)
                    .HasColumnName("parentFolderID")
                    .IsFixedLength(true);

                entity.Property(e => e.PrimId)
                    .HasMaxLength(36)
                    .HasColumnName("primID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Primshape>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PRIMARY");

                entity.ToTable("primshapes");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(36)
                    .HasColumnName("UUID")
                    .HasDefaultValueSql("''")
                    .IsFixedLength(true);

                entity.Property(e => e.ExtraParams).HasColumnType("longblob");

                entity.Property(e => e.Pcode).HasColumnName("PCode");

                entity.Property(e => e.Texture).HasColumnType("longblob");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasKey(e => e.Uuid)
                    .HasName("PRIMARY");

                entity.ToTable("regions");

                entity.HasIndex(e => e.ScopeId, "ScopeID");

                entity.HasIndex(e => e.Flags, "flags");

                entity.HasIndex(e => new { e.EastOverrideHandle, e.WestOverrideHandle, e.SouthOverrideHandle, e.NorthOverrideHandle }, "overrideHandles");

                entity.HasIndex(e => e.RegionHandle, "regionHandle");

                entity.HasIndex(e => e.RegionName, "regionName");

                entity.Property(e => e.Uuid)
                    .HasMaxLength(36)
                    .HasColumnName("uuid");

                entity.Property(e => e.Access)
                    .HasColumnType("int unsigned")
                    .HasColumnName("access")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.EastOverrideHandle)
                    .HasColumnType("bigint unsigned")
                    .HasColumnName("eastOverrideHandle");

                entity.Property(e => e.Flags).HasColumnName("flags");

                entity.Property(e => e.LastSeen).HasColumnName("last_seen");

                entity.Property(e => e.LocX)
                    .HasColumnType("int unsigned")
                    .HasColumnName("locX");

                entity.Property(e => e.LocY)
                    .HasColumnType("int unsigned")
                    .HasColumnName("locY");

                entity.Property(e => e.LocZ)
                    .HasColumnType("int unsigned")
                    .HasColumnName("locZ");

                entity.Property(e => e.NorthOverrideHandle)
                    .HasColumnType("bigint unsigned")
                    .HasColumnName("northOverrideHandle");

                entity.Property(e => e.OriginUuid)
                    .HasMaxLength(36)
                    .HasColumnName("originUUID");

                entity.Property(e => e.OwnerUuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("owner_uuid")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.ParcelMapTexture)
                    .HasMaxLength(36)
                    .HasColumnName("parcelMapTexture");

                entity.Property(e => e.PrincipalId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("PrincipalID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.RegionAssetRecvKey)
                    .HasMaxLength(128)
                    .HasColumnName("regionAssetRecvKey");

                entity.Property(e => e.RegionAssetSendKey)
                    .HasMaxLength(128)
                    .HasColumnName("regionAssetSendKey");

                entity.Property(e => e.RegionAssetUri)
                    .HasMaxLength(255)
                    .HasColumnName("regionAssetURI");

                entity.Property(e => e.RegionDataUri)
                    .HasMaxLength(255)
                    .HasColumnName("regionDataURI");

                entity.Property(e => e.RegionHandle)
                    .HasColumnType("bigint unsigned")
                    .HasColumnName("regionHandle");

                entity.Property(e => e.RegionMapTexture)
                    .HasMaxLength(36)
                    .HasColumnName("regionMapTexture");

                entity.Property(e => e.RegionName)
                    .HasMaxLength(128)
                    .HasColumnName("regionName");

                entity.Property(e => e.RegionRecvKey)
                    .HasMaxLength(128)
                    .HasColumnName("regionRecvKey");

                entity.Property(e => e.RegionSecret)
                    .HasMaxLength(128)
                    .HasColumnName("regionSecret");

                entity.Property(e => e.RegionSendKey)
                    .HasMaxLength(128)
                    .HasColumnName("regionSendKey");

                entity.Property(e => e.RegionUserRecvKey)
                    .HasMaxLength(128)
                    .HasColumnName("regionUserRecvKey");

                entity.Property(e => e.RegionUserSendKey)
                    .HasMaxLength(128)
                    .HasColumnName("regionUserSendKey");

                entity.Property(e => e.RegionUserUri)
                    .HasMaxLength(255)
                    .HasColumnName("regionUserURI");

                entity.Property(e => e.ScopeId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("ScopeID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.ServerHttpPort).HasColumnName("serverHttpPort");

                entity.Property(e => e.ServerIp)
                    .HasMaxLength(64)
                    .HasColumnName("serverIP");

                entity.Property(e => e.ServerPort)
                    .HasColumnType("int unsigned")
                    .HasColumnName("serverPort");

                entity.Property(e => e.ServerRemotingPort).HasColumnName("serverRemotingPort");

                entity.Property(e => e.ServerUri)
                    .HasMaxLength(255)
                    .HasColumnName("serverURI");

                entity.Property(e => e.SizeX).HasColumnName("sizeX");

                entity.Property(e => e.SizeY).HasColumnName("sizeY");

                entity.Property(e => e.SouthOverrideHandle)
                    .HasColumnType("bigint unsigned")
                    .HasColumnName("southOverrideHandle");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.WestOverrideHandle)
                    .HasColumnType("bigint unsigned")
                    .HasColumnName("westOverrideHandle");
            });

            modelBuilder.Entity<Regionban>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("regionban");

                entity.Property(e => e.BannedIp)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("bannedIp");

                entity.Property(e => e.BannedIpHostMask)
                    .IsRequired()
                    .HasMaxLength(16)
                    .HasColumnName("bannedIpHostMask");

                entity.Property(e => e.BannedUuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("bannedUUID");

                entity.Property(e => e.RegionUuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("regionUUID");
            });

            modelBuilder.Entity<Regionenvironment>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PRIMARY");

                entity.ToTable("regionenvironment");

                entity.Property(e => e.RegionId)
                    .HasMaxLength(36)
                    .HasColumnName("region_id");

                entity.Property(e => e.LlsdSettings)
                    .HasColumnType("mediumtext")
                    .HasColumnName("llsd_settings");
            });

            modelBuilder.Entity<Regionextra>(entity =>
            {
                entity.HasKey(e => new { e.RegionId, e.Name })
                    .HasName("PRIMARY");

                entity.ToTable("regionextra");

                entity.Property(e => e.RegionId)
                    .HasMaxLength(36)
                    .HasColumnName("RegionID")
                    .IsFixedLength(true);

                entity.Property(e => e.Name).HasMaxLength(32);

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<Regionsetting>(entity =>
            {
                entity.HasKey(e => e.RegionUuid)
                    .HasName("PRIMARY");

                entity.ToTable("regionsettings");

                entity.Property(e => e.RegionUuid)
                    .HasMaxLength(36)
                    .HasColumnName("regionUUID")
                    .IsFixedLength(true);

                entity.Property(e => e.AgentLimit).HasColumnName("agent_limit");

                entity.Property(e => e.AllowDamage).HasColumnName("allow_damage");

                entity.Property(e => e.AllowLandJoinDivide).HasColumnName("allow_land_join_divide");

                entity.Property(e => e.AllowLandResell).HasColumnName("allow_land_resell");

                entity.Property(e => e.BlockFly).HasColumnName("block_fly");

                entity.Property(e => e.BlockSearch).HasColumnName("block_search");

                entity.Property(e => e.BlockShowInSearch).HasColumnName("block_show_in_search");

                entity.Property(e => e.BlockTerraform).HasColumnName("block_terraform");

                entity.Property(e => e.CacheId)
                    .HasMaxLength(36)
                    .HasColumnName("cacheID")
                    .IsFixedLength(true);

                entity.Property(e => e.Casino).HasColumnName("casino");

                entity.Property(e => e.Covenant)
                    .HasMaxLength(36)
                    .HasColumnName("covenant")
                    .IsFixedLength(true);

                entity.Property(e => e.CovenantDatetime)
                    .HasColumnType("int unsigned")
                    .HasColumnName("covenant_datetime");

                entity.Property(e => e.DisableCollisions).HasColumnName("disable_collisions");

                entity.Property(e => e.DisablePhysics).HasColumnName("disable_physics");

                entity.Property(e => e.DisableScripts).HasColumnName("disable_scripts");

                entity.Property(e => e.Elevation1Ne).HasColumnName("elevation_1_ne");

                entity.Property(e => e.Elevation1Nw).HasColumnName("elevation_1_nw");

                entity.Property(e => e.Elevation1Se).HasColumnName("elevation_1_se");

                entity.Property(e => e.Elevation1Sw).HasColumnName("elevation_1_sw");

                entity.Property(e => e.Elevation2Ne).HasColumnName("elevation_2_ne");

                entity.Property(e => e.Elevation2Nw).HasColumnName("elevation_2_nw");

                entity.Property(e => e.Elevation2Se).HasColumnName("elevation_2_se");

                entity.Property(e => e.Elevation2Sw).HasColumnName("elevation_2_sw");

                entity.Property(e => e.FixedSun).HasColumnName("fixed_sun");

                entity.Property(e => e.LoadedCreationDatetime)
                    .HasColumnType("int unsigned")
                    .HasColumnName("loaded_creation_datetime");

                entity.Property(e => e.LoadedCreationId)
                    .HasMaxLength(64)
                    .HasColumnName("loaded_creation_id");

                entity.Property(e => e.MapTileId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("map_tile_ID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.Maturity).HasColumnName("maturity");

                entity.Property(e => e.ObjectBonus).HasColumnName("object_bonus");

                entity.Property(e => e.ParcelTileId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("parcel_tile_ID")
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'")
                    .IsFixedLength(true);

                entity.Property(e => e.RestrictPushing).HasColumnName("restrict_pushing");

                entity.Property(e => e.SunPosition).HasColumnName("sun_position");

                entity.Property(e => e.Sunvectorx).HasColumnName("sunvectorx");

                entity.Property(e => e.Sunvectory).HasColumnName("sunvectory");

                entity.Property(e => e.Sunvectorz).HasColumnName("sunvectorz");

                entity.Property(e => e.TelehubObject)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasDefaultValueSql("'00000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.TerrainLowerLimit).HasColumnName("terrain_lower_limit");

                entity.Property(e => e.TerrainRaiseLimit).HasColumnName("terrain_raise_limit");

                entity.Property(e => e.TerrainTexture1)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("terrain_texture_1")
                    .IsFixedLength(true);

                entity.Property(e => e.TerrainTexture2)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("terrain_texture_2")
                    .IsFixedLength(true);

                entity.Property(e => e.TerrainTexture3)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("terrain_texture_3")
                    .IsFixedLength(true);

                entity.Property(e => e.TerrainTexture4)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("terrain_texture_4")
                    .IsFixedLength(true);

                entity.Property(e => e.UseEstateSun).HasColumnName("use_estate_sun");

                entity.Property(e => e.WaterHeight).HasColumnName("water_height");
            });

            modelBuilder.Entity<Regionwindlight>(entity =>
            {
                entity.HasKey(e => e.RegionId)
                    .HasName("PRIMARY");

                entity.ToTable("regionwindlight");

                entity.Property(e => e.RegionId)
                    .HasMaxLength(36)
                    .HasColumnName("region_id")
                    .HasDefaultValueSql("'000000-0000-0000-0000-000000000000'");

                entity.Property(e => e.BigWaveDirectionX)
                    .HasColumnType("float(9,8)")
                    .HasColumnName("big_wave_direction_x")
                    .HasDefaultValueSql("'1.04999995'");

                entity.Property(e => e.BigWaveDirectionY)
                    .HasColumnType("float(9,8)")
                    .HasColumnName("big_wave_direction_y")
                    .HasDefaultValueSql("'-0.41999999'");

                entity.Property(e => e.CloudScrollX)
                    .HasColumnType("float(9,7)")
                    .HasColumnName("cloud_scroll_x")
                    .HasDefaultValueSql("'0.2000000'");

                entity.Property(e => e.CloudScrollXLock)
                    .HasColumnType("tinyint unsigned")
                    .HasColumnName("cloud_scroll_x_lock");

                entity.Property(e => e.CloudScrollY)
                    .HasColumnType("float(9,7)")
                    .HasColumnName("cloud_scroll_y")
                    .HasDefaultValueSql("'0.0100000'");

                entity.Property(e => e.CloudScrollYLock)
                    .HasColumnType("tinyint unsigned")
                    .HasColumnName("cloud_scroll_y_lock");

                entity.Property(e => e.DrawClassicClouds)
                    .HasColumnType("tinyint unsigned")
                    .HasColumnName("draw_classic_clouds")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LittleWaveDirectionX)
                    .HasColumnType("float(9,8)")
                    .HasColumnName("little_wave_direction_x")
                    .HasDefaultValueSql("'1.11000001'");

                entity.Property(e => e.LittleWaveDirectionY)
                    .HasColumnType("float(9,8)")
                    .HasColumnName("little_wave_direction_y")
                    .HasDefaultValueSql("'-1.15999997'");

                entity.Property(e => e.MaxAltitude)
                    .HasColumnType("int unsigned")
                    .HasColumnName("max_altitude")
                    .HasDefaultValueSql("'1605'");

                entity.Property(e => e.NormalMapTexture)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("normal_map_texture")
                    .HasDefaultValueSql("'822ded49-9a6c-f61c-cb89-6df54f42cdf4'");
            });

            modelBuilder.Entity<SpawnPoint>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spawn_points");

                entity.HasIndex(e => e.RegionId, "RegionID");

                entity.Property(e => e.RegionId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("RegionID");
            });

            modelBuilder.Entity<Terrain>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("terrain");

                entity.Property(e => e.Heightfield).HasColumnType("longblob");

                entity.Property(e => e.RegionUuid)
                    .HasMaxLength(255)
                    .HasColumnName("RegionUUID");
            });

            modelBuilder.Entity<Token>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tokens");

                entity.HasIndex(e => e.Uuid, "UUID");

                entity.HasIndex(e => e.Token1, "token");

                entity.HasIndex(e => new { e.Uuid, e.Token1 }, "uuid_token")
                    .IsUnique();

                entity.Property(e => e.Token1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("token");

                entity.Property(e => e.Uuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("UUID")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Useraccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("useraccounts");

                entity.HasIndex(e => e.Email, "Email");

                entity.HasIndex(e => e.FirstName, "FirstName");

                entity.HasIndex(e => e.LastName, "LastName");

                entity.HasIndex(e => new { e.FirstName, e.LastName }, "Name");

                entity.HasIndex(e => e.PrincipalId, "PrincipalID")
                    .IsUnique();

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(31)
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasMaxLength(64);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.NameChanged).HasColumnType("int unsigned");

                entity.Property(e => e.PrincipalId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("PrincipalID")
                    .IsFixedLength(true);

                entity.Property(e => e.ScopeId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("ScopeID")
                    .IsFixedLength(true);

                entity.Property(e => e.ServiceUrls).HasColumnName("ServiceURLs");

                entity.Property(e => e.UserTitle)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Userdatum>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.TagId })
                    .HasName("PRIMARY");

                entity.ToTable("userdata");

                entity.Property(e => e.UserId)
                    .HasMaxLength(36)
                    .IsFixedLength(true);

                entity.Property(e => e.TagId).HasMaxLength(64);

                entity.Property(e => e.DataKey).HasMaxLength(255);

                entity.Property(e => e.DataVal).HasMaxLength(255);
            });

            modelBuilder.Entity<Usernote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usernotes");

                entity.HasIndex(e => new { e.Useruuid, e.Targetuuid }, "useruuid")
                    .IsUnique();

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasColumnName("notes");

                entity.Property(e => e.Targetuuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("targetuuid");

                entity.Property(e => e.Useruuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("useruuid");
            });

            modelBuilder.Entity<Userpick>(entity =>
            {
                entity.HasKey(e => e.Pickuuid)
                    .HasName("PRIMARY");

                entity.ToTable("userpicks");

                entity.Property(e => e.Pickuuid)
                    .HasMaxLength(36)
                    .HasColumnName("pickuuid");

                entity.Property(e => e.Creatoruuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("creatoruuid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Enabled)
                    .IsRequired()
                    .HasColumnType("enum('true','false')")
                    .HasColumnName("enabled");

                entity.Property(e => e.Gatekeeper)
                    .HasMaxLength(255)
                    .HasColumnName("gatekeeper");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Originalname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("originalname");

                entity.Property(e => e.Parceluuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("parceluuid");

                entity.Property(e => e.Posglobal)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("posglobal");

                entity.Property(e => e.Simname)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("simname");

                entity.Property(e => e.Snapshotuuid)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("snapshotuuid");

                entity.Property(e => e.Sortorder).HasColumnName("sortorder");

                entity.Property(e => e.Toppick)
                    .IsRequired()
                    .HasColumnType("enum('true','false')")
                    .HasColumnName("toppick");

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user");
            });

            modelBuilder.Entity<Userprofile>(entity =>
            {
                entity.HasKey(e => e.Useruuid)
                    .HasName("PRIMARY");

                entity.ToTable("userprofile");

                entity.Property(e => e.Useruuid)
                    .HasMaxLength(36)
                    .HasColumnName("useruuid");

                entity.Property(e => e.ProfileAboutText)
                    .IsRequired()
                    .HasColumnName("profileAboutText");

                entity.Property(e => e.ProfileAllowPublish)
                    .IsRequired()
                    .HasColumnType("binary(1)")
                    .HasColumnName("profileAllowPublish");

                entity.Property(e => e.ProfileFirstImage)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("profileFirstImage");

                entity.Property(e => e.ProfileFirstText)
                    .IsRequired()
                    .HasColumnName("profileFirstText");

                entity.Property(e => e.ProfileImage)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("profileImage");

                entity.Property(e => e.ProfileLanguages)
                    .IsRequired()
                    .HasColumnName("profileLanguages");

                entity.Property(e => e.ProfileMaturePublish)
                    .IsRequired()
                    .HasColumnType("binary(1)")
                    .HasColumnName("profileMaturePublish");

                entity.Property(e => e.ProfilePartner)
                    .IsRequired()
                    .HasMaxLength(36)
                    .HasColumnName("profilePartner");

                entity.Property(e => e.ProfileSkillsMask).HasColumnName("profileSkillsMask");

                entity.Property(e => e.ProfileSkillsText)
                    .IsRequired()
                    .HasColumnName("profileSkillsText");

                entity.Property(e => e.ProfileUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("profileURL");

                entity.Property(e => e.ProfileWantToMask).HasColumnName("profileWantToMask");

                entity.Property(e => e.ProfileWantToText)
                    .IsRequired()
                    .HasColumnName("profileWantToText");
            });

            modelBuilder.Entity<Usersetting>(entity =>
            {
                entity.HasKey(e => e.Useruuid)
                    .HasName("PRIMARY");

                entity.ToTable("usersettings");

                entity.Property(e => e.Useruuid)
                    .HasMaxLength(36)
                    .HasColumnName("useruuid");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(254)
                    .HasColumnName("email");

                entity.Property(e => e.Imviaemail)
                    .IsRequired()
                    .HasColumnType("enum('true','false')")
                    .HasColumnName("imviaemail");

                entity.Property(e => e.Visible)
                    .IsRequired()
                    .HasColumnType("enum('true','false')")
                    .HasColumnName("visible");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
