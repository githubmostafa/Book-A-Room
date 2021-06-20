namespace Book_A_Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AvailableRooms", "BeginTime", c => c.DateTime());
            AlterColumn("dbo.AvailableRooms", "EndTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AvailableRooms", "EndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AvailableRooms", "BeginTime", c => c.DateTime(nullable: false));
        }
    }
}
