using FluentMigrator;
using FluentMigrator.SqlServer;
using System.Security.Policy;

namespace HRMS.Migration.Tables
{
    [Migration(20230814121037, "Login")]
    public class _20230814121037_login : ForwardOnlyMigration
    {
        public override void Up()
        {

          //  Create.Table("Users")
          //       .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
          //       .WithColumn("FirstName").AsString(256).Nullable()
          //       .WithColumn("LastName").AsString(256).Nullable()
          //       .WithColumn("Email").AsString().Nullable()
          //       .WithColumn("HashPassword").AsString().Nullable()
          //       .WithColumn("Salt").AsString().Nullable()
          //       .WithColumn("isActive").AsBoolean().Nullable()
          //       .WithColumn("isDeleted").AsBoolean().Nullable()
          //       .WithColumn("isValidated").AsBoolean().Nullable()
          //       .WithColumn("createdBy").AsString().Nullable()
          //       .WithColumn("updatedBy").AsString().Nullable()
          //       .WithColumn("createdDate").AsDateTime().Nullable()
          //       .WithColumn("updatedDate").AsDateTime().Nullable();

          //  Create.Table("Role")
          //    .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
          //    .WithColumn("Label").AsString(256).Nullable()
          //    .WithColumn("createdBy").AsString().Nullable()
          //    .WithColumn("updatedBy").AsString().Nullable()
          //    .WithColumn("createdDate").AsString().Nullable()
          //    .WithColumn("updatedDate").AsString().Nullable();
          //  Create.Table("UserRole")
          //    .WithColumn("Id").AsGuid().NotNullable().PrimaryKey()
          //    .WithColumn("RoleId").AsGuid().Nullable()
          //    .WithColumn("UserId").AsGuid().Nullable();
          //  Create.ForeignKey("fk_User_Role_Role_Id")
          //      .FromTable("UserRole").ForeignColumn("RoleId")
          //      .ToTable("Role").PrimaryColumn("Id");
          //  Create.ForeignKey("fk_User_Role_User_Id")
          //     .FromTable("UserRole").ForeignColumn("UserId")
          //     .ToTable("Users").PrimaryColumn("Id");

          //  Create.Index("IX_UserRole_RoleId").OnTable("UserRole").OnColumn("RoleId");
          //  Create.Index("RoleNameIndex").OnTable("Role").OnColumn("Label").Unique().WithOptions().Filter("[Label] IS NOT NULL");
          //  Create.Index("IX_UserRole_UserId").OnTable("UserRole").OnColumn("UserId");
          //  Create.Index("EmailIndex").OnTable("Users").OnColumn("Email");
          //  Insert.IntoTable("Role")
          //  .Row(new
          //  {
          //      Id = Guid.NewGuid(),
          //      Label = "Admin",
          //      createdBy = "admin",
          //      updatedBy = "admin",
          //      createdDate = DateTime.UtcNow,
          //      updatedDate = DateTime.UtcNow
          //  });
          //  Insert.IntoTable("Role")
          // .Row(new
          // {
          //     Id = Guid.NewGuid(),
          //     Label = "HR",
          //     createdBy = "admin",
          //     updatedBy = "admin",
          //     createdDate = DateTime.UtcNow,
          //     updatedDate = DateTime.UtcNow
          // });
          //  Insert.IntoTable("Role")
          // .Row(new
          // {
          //     Id = Guid.NewGuid(),
          //     Label = "Developer",
          //     createdBy = "admin",
          //     updatedBy = "admin",
          //     createdDate = DateTime.UtcNow,
          //     updatedDate = DateTime.UtcNow
          // });
          //  Insert.IntoTable("Role")
          //.Row(new
          //{
          //    Id = Guid.NewGuid(),
          //    Label = "Interviewer",
          //    createdBy = "admin",
          //    updatedBy = "admin",
          //    createdDate = DateTime.UtcNow,
          //    updatedDate = DateTime.UtcNow
          //});
          //  Insert.IntoTable("Role")
          //.Row(new
          //{
          //    Id = Guid.NewGuid(),
          //    Label = "Lead",
          //    createdBy = "admin",
          //    updatedBy = "admin",
          //    createdDate = DateTime.UtcNow,
          //    updatedDate = DateTime.UtcNow
          //});



        }
    }
}
