namespace MovieStore.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class checking : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Movies", "Tax");
            DropColumn("dbo.Movies", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Total", c => c.Int(nullable: false));
            AddColumn("dbo.Movies", "Tax", c => c.Int(nullable: false));
        }
    }
}
