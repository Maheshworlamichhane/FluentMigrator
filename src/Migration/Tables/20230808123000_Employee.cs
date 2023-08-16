using FluentMigrator;

namespace HRMS.Migration.Tables
{
    [Migration(20230808123000, "Employee")]
    public class Employee : ForwardOnlyMigration
    {
        public override void Up()
        {

            //Create.Table("Employee")
            //    .WithColumn("Id").AsString(450).NotNullable().PrimaryKey()
            //    .WithColumn("Name").AsString(256).Nullable()
            //    .WithColumn("NormalizedName").AsString(256).Nullable()
            //    .WithColumn("ConcurrencyStamp").AsString().Nullable();

        }
       
    }
}
