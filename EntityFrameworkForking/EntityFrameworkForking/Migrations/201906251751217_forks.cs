namespace EntityFrameworkForking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Forks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        owner = c.String(),
                        prongs = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Forks");
        }
    }
}
