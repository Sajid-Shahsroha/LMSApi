using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.Models
{
    [Table("leavetype")]
    public class LeaveType
    {
        public int Id { get; set; }
        public string LeaveTypeName { get; set; }
        [Required(ErrorMessage = "Leave Type is required")]
        [StringLength(20, ErrorMessage = "Leave Type can't be longer than 20 characters")]
        public string Status { get; set; }

        public ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
