namespace Book_A_Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createAvalableRoomsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AvailableRooms",
                c => new
                    {
                        AvailableRoomId = c.Int(nullable: false, identity: true),
                        BeginTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AvailableRoomId)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AvailableRooms", "RoomId", "dbo.Rooms");
            DropIndex("dbo.AvailableRooms", new[] { "RoomId" });
            DropTable("dbo.AvailableRooms");
        }
    }
}
