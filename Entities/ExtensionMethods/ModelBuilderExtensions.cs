using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ExtensionMethods
{
   public static class ModelBuilderExtensions
    {
       public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LeaveType>().HasData(
                  new LeaveType
                  {
                      Id = 1,
                      LeaveTypeName = "Annual Leave",
                      Status = "Active"
                  }, new LeaveType
                  {
                      Id = 2,
                      LeaveTypeName = "Sick Leave",
                      Status = "Active"
                  });
        }
    }
}
