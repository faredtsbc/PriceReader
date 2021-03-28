namespace PriceReader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BARCODE",
                c => new
                    {
                        BAR_ID = c.Int(nullable: false, identity: true),
                        ITEM_ID = c.Int(nullable: false),
                        UNIT_ID = c.Int(nullable: false),
                        BARCODE = c.String(),
                        PRICE1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UNIT_QTY = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BAR_ID);
            
            CreateTable(
                "dbo.ITEMS",
                c => new
                    {
                        ITEM_ID = c.Int(nullable: false, identity: true),
                        ITEM_NAME = c.String(),
                    })
                .PrimaryKey(t => t.ITEM_ID);
            
            CreateTable(
                "dbo.UNITS",
                c => new
                    {
                        UNIT_ID = c.Int(nullable: false, identity: true),
                        UNIT_DISC = c.String(),
                    })
                .PrimaryKey(t => t.UNIT_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UNITS");
            DropTable("dbo.ITEMS");
            DropTable("dbo.BARCODE");
        }
    }
}
