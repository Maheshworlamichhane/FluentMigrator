using System;
using System.ComponentModel.DataAnnotations;


namespace HRMS.Entity.Entities
{
    public class InterviewDetails : BaseEntity
    {
        #region Instance Properties

        [Display(Name = "Id")]
        [Required]
        public Int64 Id { get; set; }

        [Display(Name = "InterviewStatus")]
        [StringLength(256)]
        public String InterviewStatus { get; set; }

        [Display(Name = "CommentFromInterviewer")]
        [StringLength(255)]
        public String CommentFromInterviewer { get; set; }

        [Display(Name = "InterviewDate")]
        public DateTime? InterviewDate { get; set; }

        [Display(Name = "NthAttempt")]
        public DateTime? NthAttempt { get; set; }

        [Display(Name = "InterviewResult")]
        [StringLength(255)]
        public String InterviewResult { get; set; }

        [Display(Name = "MeetingLink")]
        [StringLength(255)]
        public String MeetingLink { get; set; }

        [Display(Name = "hasMeetingLinkExpired")]
        public Boolean? hasMeetingLinkExpired { get; set; }

        [Display(Name = "InterViewerId")]
        [StringLength(450)]
        public String InterViewerId { get; set; }

        #endregion Instance Properties
    }

}
