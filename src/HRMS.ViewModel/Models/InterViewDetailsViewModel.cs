using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRMS.ViewModel.Models
{
    public class InterViewDetailsViewModel
    {
     
        public Int64 Id { get; set; }

        public String InterviewStatus { get; set; }

        public String CommentFromInterviewer { get; set; }

        public DateTime? InterviewDate { get; set; }

        public DateTime? NthAttempt { get; set; }

        public String InterviewResult { get; set; }

        public String MeetingLink { get; set; }

        public Boolean? hasMeetingLinkExpired { get; set; }
        public String InterViewerId { get; set; }
        public String createdBy { get; set; }
        public String updatedBy { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? updatedDate { get; set; }
    }
}
