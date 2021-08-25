using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class spGetLeaveTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            string procedure = @"CREATE PROCEDURE spGetLeaveTypes
                                AS
                                  SELECT
                                    leavetype.Id,
                                    leavetype.LeaveTypeName,
                                    leavetype.Status
                                  FROM leavetype";
            migrationBuilder.Sql(procedure);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            string procedure = @"DROP PROCEDURE spGetLeaveTypes";
            migrationBuilder.Sql(procedure);

        }
    }
}
