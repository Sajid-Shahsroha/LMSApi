using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Entities.Models
{
    [Table("leaverequest")]
    public class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public string EmployeeId { get; set; }

        public int? LeaveTypeId { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public string FromDate { get; set; }
        [Required(ErrorMessage = "From date is required")]
        public string ToDate { get; set; }
        [Required(ErrorMessage = "To date is required")]
        public DateTime CreatedDate { get; set; }
        public string LeaveReason { get; set; }
        [Required(ErrorMessage = "Leave reason is required")]
        public bool Approved { get; set; }
        public string DenialReason { get; set; }
        public int Status { get; set; }
        public int ReviewedBy { get; set; }
    }
}
