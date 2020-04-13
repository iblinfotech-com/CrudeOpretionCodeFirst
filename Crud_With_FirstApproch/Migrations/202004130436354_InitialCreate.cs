namespace Crud_With_FirstApproch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        BirthofDate = c.DateTime(nullable: false),
                        Gender = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Address = c.String(),
                        City = c.String(),
                        Department = c.String(),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
