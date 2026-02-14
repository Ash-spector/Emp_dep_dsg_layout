namespace Emp_dep_desg_layout.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDsgDeptoModel : DbMigration
    {
        public override void Up()
        {
         Sql("INSERT INTO Departments (name) VALUES ('Accounts')");
            Sql("INSERT INTO Departments (name) VALUES ('Sales')");
            Sql("INSERT INTO Departments (name) VALUES ('Mrk')");
            Sql("INSERT INTO Departments (name) VALUES ('Computers')");
            //designation table me data insert krne k liye
            Sql("INSERT INTO Designations (name) VALUES ('PM')");
            Sql("INSERT INTO Designations (name) VALUES ('TL')");
            Sql("INSERT INTO Designations (name) VALUES ('Programmer')");
        }
        
        public override void Down()
        {
        }
    }
}
