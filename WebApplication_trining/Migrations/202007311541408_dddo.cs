namespace WebApplication_trining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dddo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbl_news", "news_img2", c => c.String());
            AlterColumn("dbo.tbl_news", "news_img3", c => c.String());
            AlterColumn("dbo.tbl_news", "news_img4", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_news", "news_img4", c => c.String(nullable: false));
            AlterColumn("dbo.tbl_news", "news_img3", c => c.String(nullable: false));
            AlterColumn("dbo.tbl_news", "news_img2", c => c.String(nullable: false));
        }
    }
}
