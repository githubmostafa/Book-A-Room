namespace Book_A_Room.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedingItems : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Items Values('VGA Cable')");
            Sql("Insert into Items Values('HDMI Cable')");
            Sql("Insert into Items Values('Y/C Cable')");
            Sql("Insert into Items Values('DisplayPort Cable')");
            Sql("Insert into Items Values('DVI Cable')");
            Sql("Insert into Items Values('Ethernet Cable')");
            Sql("Insert into Items Values('Pen(Red)')");
            Sql("Insert into Items Values('Pen(Blue)')");
            Sql("Insert into Items Values('Pen(Green)')");
            Sql("Insert into Items Values('Pen(Black)')");
            Sql("Insert into Items Values('Chairs')");
            Sql("Insert into Items Values('Desks')");
            Sql("Insert into Items Values('Projector')");
            Sql("Insert into Items Values('Scanner')");
            Sql("Insert into Items Values('Printer')");
            Sql("Insert into Items Values('USB-A Type')");
            Sql("Insert into Items Values('USB-B Type')");
            Sql("Insert into Items Values('USB-C Type')");
            Sql("Insert into Items Values('QR-Code Scanner')");
            Sql("Insert into Items Values('Bar Code Scanner')");
            Sql("Insert into Items Values('Handheld Scanner')"); 

        }
        
        public override void Down()
        {
        }
    }
}
