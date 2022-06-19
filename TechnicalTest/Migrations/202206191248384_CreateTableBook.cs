namespace TechnicalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblBooks",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        BookName = c.String(),
                        Author = c.String(),
                        ReleaseDate = c.Int(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblBooks");
        }
    }
}
