namespace Book_A_Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatDate2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AvailableRooms", "BeginTime", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.AvailableRooms", "EndTime", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AvailableRooms", "EndTime", c => c.DateTime());
            AlterColumn("dbo.AvailableRooms", "BeginTime", c => c.DateTime());
        }
    }
}
