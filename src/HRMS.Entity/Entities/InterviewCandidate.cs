

using System.ComponentModel.DataAnnotations;

namespace HRMS.Entity.Entities
{

    public class InterviewCandidate:BaseEntity
    {
        #region Instance Properties

        [Display(Name = "Id")]
        [Required]
        public Int64 Id { get; set; }

        [Display(Name = "CandidateName")]
        [StringLength(405)]
        public String CandidateName { get; set; }

        [Display(Name = "CandidateEmail")]
        [StringLength(255)]
        public String CandidateEmail { get; set; }

        [Display(Name = "PhoneNumber")]
        [StringLength(255)]
        public String PhoneNumber { get; set; }

        [Display(Name = "Resume")]
        [StringLength(255)]
        public String Resume { get; set; }

        [Display(Name = "CoverLetter")]
        [StringLength(255)]
        public String CoverLetter { get; set; }
        #endregion Instance Properties
    }

}
