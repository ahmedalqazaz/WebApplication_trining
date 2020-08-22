namespace WebApplication_trining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbl_news : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tbl_news",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        news_name = c.String(nullable: false),
                        title_news = c.String(nullable: false),
                        news_desc = c.String(nullable: false),
                        news_category = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tbl_news");
        }
    }
}
