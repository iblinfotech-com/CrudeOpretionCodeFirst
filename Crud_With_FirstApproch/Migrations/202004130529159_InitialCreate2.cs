namespace Crud_With_FirstApproch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "EmpName", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Address", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Employees", "Department", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Department", c => c.String());
            AlterColumn("dbo.Employees", "Address", c => c.String());
            AlterColumn("dbo.Employees", "Phone", c => c.String());
            AlterColumn("dbo.Employees", "Email", c => c.String());
            AlterColumn("dbo.Employees", "EmpName", c => c.String());
        }
    }
}
