namespace QLKTX.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InvoiceId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedDateTS = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDateTS = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Invoices", t => t.InvoiceId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.InvoiceId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IssueDate = c.DateTime(nullable: false),
                        TotalAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                        RoomId = c.Int(nullable: false),
                        CreatedDateTS = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDateTS = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(),
                        Capacity = c.Int(nullable: false),
                        CreatedDateTS = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDateTS = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MSSV = c.String(),
                        Name = c.String(),
                        DateOfBirth = c.String(),
                        Gender = c.Int(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                        Avatar = c.String(),
                        RoomId = c.Int(nullable: false),
                        CreatedDateTS = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDateTS = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                        Unit = c.String(),
                        CreatedDateTS = c.Double(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        UpdatedDateTS = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvoiceDetails", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Invoices", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Students", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.InvoiceDetails", "InvoiceId", "dbo.Invoices");
            DropIndex("dbo.Students", new[] { "RoomId" });
            DropIndex("dbo.Invoices", new[] { "RoomId" });
            DropIndex("dbo.InvoiceDetails", new[] { "ServiceId" });
            DropIndex("dbo.InvoiceDetails", new[] { "InvoiceId" });
            DropTable("dbo.Services");
            DropTable("dbo.Students");
            DropTable("dbo.Rooms");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceDetails");
        }
    }
}
