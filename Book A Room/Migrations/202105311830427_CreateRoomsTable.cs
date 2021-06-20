namespace Book_A_Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRoomsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomName = c.String(nullable: false),
                        AttendeesCapacity = c.Int(nullable: false),
                        Floor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rooms");
        }
    }
}
