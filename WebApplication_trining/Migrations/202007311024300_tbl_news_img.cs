namespace WebApplication_trining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tbl_news_img : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_news", "news_img1", c => c.String(nullable: false));
            AddColumn("dbo.tbl_news", "news_img2", c => c.String(nullable: false));
            AddColumn("dbo.tbl_news", "news_img3", c => c.String(nullable: false));
            AddColumn("dbo.tbl_news", "news_img4", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_news", "news_img4");
            DropColumn("dbo.tbl_news", "news_img3");
            DropColumn("dbo.tbl_news", "news_img2");
            DropColumn("dbo.tbl_news", "news_img1");
        }
    }
}
