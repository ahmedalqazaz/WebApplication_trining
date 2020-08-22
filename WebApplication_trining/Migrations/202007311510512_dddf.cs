namespace WebApplication_trining.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dddf : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tbl_news", "news_img1", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tbl_news", "news_img1", c => c.String(nullable: false));
        }
    }
}
