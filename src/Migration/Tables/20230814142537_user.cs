using FluentMigrator;
using FluentMigrator.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRMS.Migration.Tables
{
    [Migration(20230814142537, "User")]
    public class _20230814142537_user : ForwardOnlyMigration
    {
        public override void Up()
        {
            Alter.Table("AspNetUsers")
             .AddColumn("FirstName")
             .AsString(450)
             .Nullable();
            Alter.Table("AspNetUsers")
             .AddColumn("LastName")
             .AsString(450)
             .Nullable();

        }
    }
}
