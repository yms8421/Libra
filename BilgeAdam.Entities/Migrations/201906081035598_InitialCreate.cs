namespace BilgeAdam.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PageCount = c.Int(nullable: false),
                        ISBNNumber = c.String(maxLength: 20),
                        Category = c.Int(nullable: false),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shelves",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 5),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HireDate = c.DateTime(nullable: false),
                        FullName = c.String(),
                        Created = c.DateTime(nullable: false),
                        Modified = c.DateTime(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
            DropTable("dbo.Shelves");
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}
