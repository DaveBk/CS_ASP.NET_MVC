namespace DOT_Ksiega_gosci.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Gender : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registrations", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Registrations", "Gender");
        }
    }
}
