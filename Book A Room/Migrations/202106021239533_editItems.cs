namespace Book_A_Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editItems : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "ItemName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Items", "ItemName", c => c.String());
        }
    }
}
