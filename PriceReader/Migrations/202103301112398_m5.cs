namespace PriceReader.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BARCODE", "PRICE1", c => c.Double(nullable: false));
            AlterColumn("dbo.BARCODE", "UNIT_QTY", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.BARCODE", "UNIT_QTY", c => c.Int(nullable: false));
            AlterColumn("dbo.BARCODE", "PRICE1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
