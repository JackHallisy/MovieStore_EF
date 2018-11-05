namespace MovieStore.Db.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Final : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GenreTables", newName: "Genres");
            DropForeignKey("dbo.MoviesTables", "GenreTable_Id", "dbo.GenreTables");
            DropIndex("dbo.MoviesTables", new[] { "GenreTable_Id" });
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        YearReleased = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        Tax = c.Int(nullable: false),
                        Total = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            DropTable("dbo.MoviesTables");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.MoviesTables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        YearReleased = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        GenreId = c.Int(nullable: false),
                        GenreTable_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            DropIndex("dbo.Movies", new[] { "GenreId" });
            DropTable("dbo.Movies");
            CreateIndex("dbo.MoviesTables", "GenreTable_Id");
            AddForeignKey("dbo.MoviesTables", "GenreTable_Id", "dbo.GenreTables", "Id");
            RenameTable(name: "dbo.Genres", newName: "GenreTables");
        }
    }
}
