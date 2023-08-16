using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRMS.Entity.Entities
{
    public abstract class BaseEntity
    {
        [Display(Name = "createdBy")]
        [StringLength(255)]
        public String createdBy { get; set; }

        [Display(Name = "updatedBy")]
        [StringLength(255)]
        public String updatedBy { get; set; }

        [Display(Name = "createdDate")]
        [StringLength(255)]
        public DateTime? createdDate { get; set; }

        [Display(Name = "updatedDate")]
        [StringLength(255)]
        public DateTime? updatedDate { get; set; }

    }
}
