namespace DOT_Ksiega_gosci.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "FirstName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Registrations", "LastName", c => c.String(nullable: false, maxLength: 25));
            AlterColumn("dbo.Registrations", "Gender", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Registrations", "Contents", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "Contents", c => c.String());
            AlterColumn("dbo.Registrations", "Gender", c => c.String());
            AlterColumn("dbo.Registrations", "LastName", c => c.String());
            AlterColumn("dbo.Registrations", "FirstName", c => c.String());
        }
    }
}
