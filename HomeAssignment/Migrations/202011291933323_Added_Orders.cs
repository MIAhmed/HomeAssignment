namespace HomeAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Orders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderName = c.String(),
                        OrderStatus = c.String(),
                        DateOfOrder = c.DateTime(nullable: false),
                        TotalWight = c.Single(nullable: false),
                        EstimatedSupplingDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
