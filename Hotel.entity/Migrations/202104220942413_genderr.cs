namespace Hotel.entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genderr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(nullable: false),
                        ServiceCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceQuantity = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ServicesId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .ForeignKey("dbo.AdditionalServices", t => t.ServicesId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.ServicesId)
                .Index(t => t.ReservationId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Img = c.String(),
                        Gender = c.String(),
                        PhoneNumber = c.String(),
                        FIN = c.String(nullable: false, maxLength: 7),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        ZipCode = c.String(),
                        CustomerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CheckInDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomNo = c.String(),
                        NumberOfBeds = c.Int(),
                        NumberOfChildBeds = c.Int(),
                        RoomPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Int(),
                        FloorNumber = c.Int(),
                        Img = c.String(),
                        RoomTypesId = c.Int(nullable: false),
                        RoomStatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RoomStatus", t => t.RoomStatusId, cascadeDelete: true)
                .ForeignKey("dbo.RoomTypes", t => t.RoomTypesId, cascadeDelete: true)
                .Index(t => t.RoomTypesId)
                .Index(t => t.RoomStatusId);
            
            CreateTable(
                "dbo.RoomImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Img = c.String(),
                        RoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.RoomStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StatusName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PaymentTime = c.DateTime(nullable: false),
                        PaymentTypesId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ReservationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentTypes", t => t.PaymentTypesId, cascadeDelete: true)
                .ForeignKey("dbo.Reservations", t => t.ReservationId, cascadeDelete: true)
                .Index(t => t.PaymentTypesId)
                .Index(t => t.CustomerId)
                .Index(t => t.ReservationId);
            
            CreateTable(
                "dbo.PaymentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Satisfactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SatisfactionLevel = c.Int(),
                        TransactionsId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Transactions", t => t.TransactionsId, cascadeDelete: true)
                .Index(t => t.TransactionsId);
            
            CreateTable(
                "dbo.AppUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Email = c.String(),
                        FIN = c.String(nullable: false, maxLength: 7),
                        Password = c.String(),
                        PhoneNumber = c.String(),
                        rolesId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.rolesId, cascadeDelete: true)
                .Index(t => t.rolesId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppUsers", "rolesId", "dbo.Roles");
            DropForeignKey("dbo.CustomerServices", "ServicesId", "dbo.AdditionalServices");
            DropForeignKey("dbo.Reservations", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Satisfactions", "TransactionsId", "dbo.Transactions");
            DropForeignKey("dbo.Transactions", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.Transactions", "PaymentTypesId", "dbo.PaymentTypes");
            DropForeignKey("dbo.Transactions", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Rooms", "RoomTypesId", "dbo.RoomTypes");
            DropForeignKey("dbo.Rooms", "RoomStatusId", "dbo.RoomStatus");
            DropForeignKey("dbo.RoomImages", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.CustomerServices", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.CustomerServices", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.Customers");
            DropIndex("dbo.AppUsers", new[] { "rolesId" });
            DropIndex("dbo.Satisfactions", new[] { "TransactionsId" });
            DropIndex("dbo.Transactions", new[] { "ReservationId" });
            DropIndex("dbo.Transactions", new[] { "CustomerId" });
            DropIndex("dbo.Transactions", new[] { "PaymentTypesId" });
            DropIndex("dbo.RoomImages", new[] { "RoomId" });
            DropIndex("dbo.Rooms", new[] { "RoomStatusId" });
            DropIndex("dbo.Rooms", new[] { "RoomTypesId" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropIndex("dbo.Reservations", new[] { "CustomerId" });
            DropIndex("dbo.Addresses", new[] { "CustomerId" });
            DropIndex("dbo.CustomerServices", new[] { "ReservationId" });
            DropIndex("dbo.CustomerServices", new[] { "ServicesId" });
            DropIndex("dbo.CustomerServices", new[] { "CustomerId" });
            DropTable("dbo.Roles");
            DropTable("dbo.AppUsers");
            DropTable("dbo.Satisfactions");
            DropTable("dbo.PaymentTypes");
            DropTable("dbo.Transactions");
            DropTable("dbo.RoomTypes");
            DropTable("dbo.RoomStatus");
            DropTable("dbo.RoomImages");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Addresses");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerServices");
            DropTable("dbo.AdditionalServices");
        }
    }
}
