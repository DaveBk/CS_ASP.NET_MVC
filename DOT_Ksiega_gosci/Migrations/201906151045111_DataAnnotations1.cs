namespace DOT_Ksiega_gosci.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Gender", c => c.String(maxLength: 6));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "Gender", c => c.String(nullable: false, maxLength: 6));
        }
    }
}
