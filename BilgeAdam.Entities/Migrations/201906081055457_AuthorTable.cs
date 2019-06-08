namespace BilgeAdam.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(maxLength: 50),
                        BirthDate = c.DateTime(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Books", "AuthorId", c => c.Int());
            CreateIndex("dbo.Books", "AuthorId");
            AddForeignKey("dbo.Books", "AuthorId", "dbo.Authors", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorId", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorId" });
            DropColumn("dbo.Books", "AuthorId");
            DropTable("dbo.Authors");
        }
    }
}
