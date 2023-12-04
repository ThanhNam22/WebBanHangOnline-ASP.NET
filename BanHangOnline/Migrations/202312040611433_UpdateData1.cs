namespace BanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateData1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_New", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_New", "Title", c => c.String());
        }
    }
}
