namespace Emp_dep_desg_layout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Name : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Name", c => c.String());
            AlterColumn("dbo.Employees", "Address", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Employees", "Name", c => c.String(nullable: false));
        }
    }
}
