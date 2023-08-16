using FluentMigrator;
using FluentMigrator.SqlServer;


namespace HRMIS.Migration.Tables
{
    [Migration(20230813101037, "Identity")]
    public class _20230813101037_identity : ForwardOnlyMigration
    {
        public override void Up()
        {

            Create.Table("AspNetRoles")
                .WithColumn("Id").AsString(450).NotNullable().PrimaryKey()
                .WithColumn("Name").AsString(256).Nullable()
                .WithColumn("NormalizedName").AsString(256).Nullable()
                .WithColumn("ConcurrencyStamp").AsString().Nullable();

            Create.Table("AspNetUsers")
               .WithColumn("Id").AsString(450).NotNullable().PrimaryKey()
               .WithColumn("UserName").AsString(256).Nullable()
               .WithColumn("NormalizedUserName").AsString(256).Nullable()
               .WithColumn("Email").AsString(256).Nullable()
               .WithColumn("NormalizedEmail").AsString(256).Nullable()
               .WithColumn("EmailConfirmed").AsBoolean().NotNullable()
               .WithColumn("PasswordHash").AsString().Nullable()
               .WithColumn("SecurityStamp").AsString().Nullable()
               .WithColumn("ConcurrencyStamp").AsString().Nullable()
               .WithColumn("PhoneNumber").AsString().Nullable()
               .WithColumn("PhoneNumberConfirmed").AsBoolean().NotNullable()
               .WithColumn("TwoFactorEnabled").AsBoolean().NotNullable()
               .WithColumn("LockoutEnd").AsDateTimeOffset().Nullable()
               .WithColumn("LockoutEnabled").AsBoolean().NotNullable()
               .WithColumn("AccessFailedCount").AsInt32().NotNullable();

            //Create.Table("Profiles")
            //    .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
            //    .WithColumn("Country").AsString().NotNullable()
            //    .WithColumn("Name").AsString().NotNullable()
            //    .WithColumn("Description").AsString().NotNullable()
            //    .WithColumn("Phone").AsString().NotNullable()
            //    .WithColumn("Age").AsString().NotNullable()
            //    .WithColumn("City").AsString().NotNullable();


            Create.Table("AspNetRoleClaims")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("RoleId").AsString(450).NotNullable()
                .WithColumn("ClaimType").AsString().Nullable()
                .WithColumn("ClaimValue").AsString().Nullable();

            Create.ForeignKey()
                .FromTable("AspNetRoleClaims").ForeignColumn("RoleId")
                .ToTable("AspNetRoles").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);


            Create.Table("AspNetUserClaims")
                .WithColumn("Id").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("UserId").AsString(450).NotNullable()
                .WithColumn("ClaimType").AsString().Nullable()
                .WithColumn("ClaimValue").AsString().Nullable();

            Create.ForeignKey()
                .FromTable("AspNetUserClaims").ForeignColumn("UserId")
                .ToTable("AspNetUsers").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);

            Create.Table("AspNetUserLogins")
               .WithColumn("LoginProvider").AsString(128).NotNullable().PrimaryKey()
               .WithColumn("ProviderKey").AsString(128).NotNullable().PrimaryKey()
               .WithColumn("ProviderDisplayName").AsString().Nullable()
               .WithColumn("UserId").AsString(450).NotNullable();

            Create.ForeignKey()
                .FromTable("AspNetUserLogins").ForeignColumn("UserId")
                .ToTable("AspNetUsers").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);

            Create.Table("AspNetUserRoles")
               .WithColumn("UserId").AsString(450).NotNullable()
               .WithColumn("RoleId").AsString(450).NotNullable();

            Create.PrimaryKey().OnTable("AspNetUserRoles").Columns("UserId", "RoleId");

            Create.ForeignKey()
                .FromTable("AspNetUserRoles").ForeignColumn("UserId")
                .ToTable("AspNetUsers").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);

            Create.ForeignKey()
                .FromTable("AspNetUserRoles").ForeignColumn("RoleId")
                .ToTable("AspNetRoles").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);

            Create.Table("AspNetUserTokens")
               .WithColumn("UserId").AsString(450).NotNullable()
               .WithColumn("LoginProvider").AsString(128).NotNullable()
               .WithColumn("Name").AsString(128).NotNullable()
               .WithColumn("Value").AsString().Nullable();

            Create.PrimaryKey().OnTable("AspNetUserTokens").Columns("UserId", "LoginProvider", "Name");

            Create.ForeignKey()
                .FromTable("AspNetUserTokens").ForeignColumn("UserId")
                .ToTable("AspNetUsers").PrimaryColumn("Id")
                .OnDelete(System.Data.Rule.Cascade);


            //Insert.IntoTable("Profiles")
            //.Row(new
            //{
            //    //Id = 1,
            //    Age = "20",
            //    City = "kathmandu",
            //    Country = "Nepal",
            //    Description = "Description",
            //    Name = "Philips",
            //    Phone = "9865231245"
            //})
            //.Row(new
            //{
            //    //Id = 2,
            //    Age = "25",
            //    City = "Pokhara",
            //    Country = "Nepal",
            //    Description = "Description",
            //    Name = "Abhya",
            //    Phone = "98652656565"
            //});

            Insert.IntoTable("AspNetRoles")
            .Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            Insert.IntoTable("AspNetRoles")
            .Row(new
            {
                Id = Guid.NewGuid(),
                Name = "HR",
                NormalizedName = "HR"
            });

            Insert.IntoTable("AspNetRoles")
            .Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Developer",
                NormalizedName = "DEVELOPER"
            });

            Insert.IntoTable("AspNetRoles")
            .Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Interviewer",
                NormalizedName = "INTERVIEWER"
            });
            Insert.IntoTable("AspNetRoles")
            .Row(new
            {
                Id = Guid.NewGuid(),
                Name = "Lead",
                NormalizedName = "LEAD"
            });

            Create.Index("IX_AspNetRoleClaims_RoleId").OnTable("AspNetRoleClaims").OnColumn("RoleId");
            Create.Index("IX_RoleNameIndex").OnTable("AspNetRoles").OnColumn("NormalizedName").Unique().WithOptions().Filter("[NormalizedName] IS NOT NULL");
            Create.Index("IX_AspNetUserClaims_UserId").OnTable("AspNetUserClaims").OnColumn("UserId");
            Create.Index("IX_AspNetUserLogins_UserId").OnTable("AspNetUserLogins").OnColumn("UserId");
            Create.Index("IX_AspNetUserRoles_RoleId").OnTable("AspNetUserRoles").OnColumn("RoleId");
            Create.Index("EmailIndex").OnTable("AspNetUsers").OnColumn("NormalizedEmail");
            Create.Index("UserNameIndex").OnTable("AspNetUsers").OnColumn("NormalizedUserName").Unique().WithOptions().Filter("[NormalizedUserName] IS NOT NULL");

        }
    }
}
