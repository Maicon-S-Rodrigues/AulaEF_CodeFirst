namespace AulaEF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonMobileMail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Mobile", c => c.String());
            AddColumn("dbo.People", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Mail");
            DropColumn("dbo.People", "Mobile");
        }
    }
}
