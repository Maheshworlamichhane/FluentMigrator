using FluentMigrator;
using FluentMigrator.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Policy;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HRMS.Migration.Tables
{
    [Migration(20230814142437, "Interview")]
    public class _20230814142437_interview : ForwardOnlyMigration
    {
        public override void Up()
        {

            Create.Table("InterviewCandidate")
                 .WithColumn("Id").AsInt64().NotNullable().PrimaryKey()
                 .WithColumn("CandidateName").AsString(405).Nullable()
                 .WithColumn("CandidateEmail").AsString().Nullable()
                 .WithColumn("PhoneNumber").AsString().Nullable()
                 .WithColumn("Resume").AsString().Nullable()
                 .WithColumn("CoverLetter").AsString().Nullable()
                 .WithColumn("createdBy").AsString().Nullable()
                 .WithColumn("updatedBy").AsString().Nullable()
                 .WithColumn("createdDate").AsDateTime().Nullable()
                 .WithColumn("updatedDate").AsDateTime().Nullable();

            Create.Table("InterviewDetails")
              .WithColumn("Id").AsInt64().NotNullable().PrimaryKey()
              .WithColumn("InterviewStatus").AsString(256).Nullable()
              .WithColumn("CommentFromInterviewer").AsString().Nullable()
              .WithColumn("InterviewDate").AsDateTime().Nullable()
              .WithColumn("NthAttempt").AsDateTime().Nullable()
              .WithColumn("InterviewResult").AsString().Nullable()
              .WithColumn("MeetingLink").AsString().Nullable()
              .WithColumn("hasMeetingLinkExpired").AsBoolean().Nullable()
              .WithColumn("createdBy").AsString().Nullable()
              .WithColumn("updatedBy").AsString().Nullable()
              .WithColumn("createdDate").AsString().Nullable()
              .WithColumn("updatedDate").AsString().Nullable()
              .WithColumn("InterViewerId").AsString(450).Nullable();

            Create.ForeignKey("fk_Interview_details_User_Id")
      .FromTable("InterviewDetails").ForeignColumn("InterViewerId")
      .ToTable("AspNetUsers").PrimaryColumn("Id");

            Create.Index("IX_InterviewDetails_InterViewerId").OnTable("InterviewDetails").OnColumn("InterViewerId");
            Create.Index("CandidateEmail").OnTable("InterviewCandidate").OnColumn("CandidateEmail");
       
        }
    }
}
