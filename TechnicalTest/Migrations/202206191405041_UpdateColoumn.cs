namespace TechnicalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateColoumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblBooks", "ReleaseYear", c => c.Int(nullable: false));
            DropColumn("dbo.TblBooks", "ReleaseDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblBooks", "ReleaseDate", c => c.Int(nullable: false));
            DropColumn("dbo.TblBooks", "ReleaseYear");
        }
    }
}
