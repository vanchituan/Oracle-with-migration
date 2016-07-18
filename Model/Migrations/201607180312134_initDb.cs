namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "VANCHITUAN.About",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        MetaTitle = c.String(maxLength: 300),
                        Description = c.String(),
                        Image = c.String(maxLength: 300),
                        Detail = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 300),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 300),
                        MetaKeywords = c.String(maxLength: 300),
                        MetaDescriptions = c.String(maxLength: 300),
                        Status = c.Decimal(precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.Category",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        MetaTitle = c.String(maxLength: 300),
                        ParentID = c.Decimal(precision: 10, scale: 0),
                        DisplayOrder = c.Decimal(precision: 10, scale: 0),
                        SeoTitle = c.String(maxLength: 300),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 300),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 300),
                        MetaKeywords = c.String(maxLength: 300),
                        MetaDescriptions = c.String(maxLength: 300),
                        Status = c.Decimal(precision: 1, scale: 0),
                        ShowOnHome = c.Decimal(precision: 1, scale: 0),
                        Language = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.Contact",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Content = c.String(),
                        Status = c.Decimal(precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.Content",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(),
                        MetaTitle = c.String(maxLength: 300),
                        Description = c.String(),
                        Image = c.String(maxLength: 300),
                        CategoryId = c.Decimal(precision: 10, scale: 0),
                        Detail = c.String(),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 300),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 300),
                        MetaKeywords = c.String(maxLength: 300),
                        MetaDescriptions = c.String(maxLength: 300),
                        Status = c.Decimal(nullable: false, precision: 1, scale: 0),
                        TopHot = c.DateTime(),
                        ViewCount = c.Decimal(precision: 10, scale: 0),
                        Tags = c.String(maxLength: 300),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.ContentTag",
                c => new
                    {
                        ContentId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        TagId = c.String(nullable: false, maxLength: 300),
                    })
                .PrimaryKey(t => new { t.ContentId, t.TagId });
            
            CreateTable(
                "VANCHITUAN.Credential",
                c => new
                    {
                        UserGroupId = c.String(nullable: false, maxLength: 20),
                        RoleId = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => new { t.UserGroupId, t.RoleId });
            
            CreateTable(
                "VANCHITUAN.Feedback",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Content = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        Status = c.Decimal(precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.Footer",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Content = c.String(),
                        Status = c.Decimal(precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.InvoiceDetail",
                c => new
                    {
                        InvoiceId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        ProductId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Quantity = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.InvoiceId, t.ProductId });
            
            CreateTable(
                "VANCHITUAN.Invoice",
                c => new
                    {
                        InvoiceId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        CreatedDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        CustomerId = c.Decimal(precision: 10, scale: 0),
                        ShipName = c.String(maxLength: 250),
                        ShipMobile = c.String(maxLength: 250),
                        ShipAddress = c.String(maxLength: 250),
                        ShipEmail = c.String(maxLength: 250),
                        Total = c.Decimal(precision: 18, scale: 2),
                        Profit = c.Decimal(precision: 18, scale: 2),
                        PromotionId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        OrderId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        ProvinceId = c.Decimal(precision: 10, scale: 0),
                        DistrictId = c.Decimal(precision: 10, scale: 0),
                        PrecinctId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.InvoiceId);
            
            CreateTable(
                "VANCHITUAN.Menu",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Text = c.String(maxLength: 50),
                        Link = c.String(maxLength: 250),
                        DisplayOrder = c.Decimal(precision: 10, scale: 0),
                        Target = c.String(maxLength: 50),
                        Status = c.Decimal(precision: 1, scale: 0),
                        TypeID = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.MenuType",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.OrderDetail",
                c => new
                    {
                        OrderId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        ProductId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Quantity = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => new { t.OrderId, t.ProductId });
            
            CreateTable(
                "VANCHITUAN.Order",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        CreatedDate = c.DateTime(),
                        OrderDate = c.DateTime(),
                        CustomerId = c.Decimal(precision: 10, scale: 0),
                        ShipName = c.String(maxLength: 50),
                        ShipMobile = c.String(maxLength: 50),
                        ShipAddress = c.String(maxLength: 50),
                        ShipEmail = c.String(maxLength: 50),
                        Total = c.Decimal(precision: 18, scale: 2),
                        PromotionId = c.Decimal(nullable: false, precision: 10, scale: 0),
                        Status = c.Decimal(nullable: false, precision: 10, scale: 0),
                        ProvinceId = c.Decimal(precision: 10, scale: 0),
                        DistrictId = c.Decimal(precision: 10, scale: 0),
                        PrecinctId = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.OrderStatus",
                c => new
                    {
                        OrderStatusId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.OrderStatusId);
            
            CreateTable(
                "VANCHITUAN.ProductCategory",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 250),
                        MetaTitle = c.String(maxLength: 250),
                        ParentId = c.Decimal(precision: 19, scale: 0),
                        DisplayOrder = c.Decimal(precision: 10, scale: 0),
                        SeoTitle = c.String(maxLength: 250),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Decimal(precision: 1, scale: 0),
                        ShowOnHome = c.Decimal(precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.Product",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Name = c.String(maxLength: 250),
                        CategoryId = c.Decimal(precision: 10, scale: 0),
                        Code = c.String(maxLength: 10),
                        MetaTitle = c.String(maxLength: 250),
                        Description = c.String(maxLength: 500),
                        Detail = c.String(),
                        Image = c.String(maxLength: 250),
                        MoreImages = c.String(maxLength: 300),
                        Price = c.Decimal(precision: 18, scale: 2),
                        PriceImport = c.Decimal(precision: 18, scale: 2),
                        IncludedVAT = c.Decimal(precision: 1, scale: 0),
                        Quantity = c.Decimal(precision: 10, scale: 0),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        MetaKeywords = c.String(maxLength: 250),
                        MetaDescriptions = c.String(maxLength: 250),
                        Status = c.Decimal(precision: 1, scale: 0),
                        TopHot = c.DateTime(),
                        ViewCount = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.Promotion",
                c => new
                    {
                        PromotionId = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        PromotionName = c.String(maxLength: 250),
                        Value = c.Decimal(precision: 18, scale: 2),
                        Discount = c.Decimal(precision: 10, scale: 0),
                    })
                .PrimaryKey(t => t.PromotionId);
            
            CreateTable(
                "VANCHITUAN.Role",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.Slide",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        Image = c.String(maxLength: 250),
                        DisplayOrder = c.Decimal(precision: 10, scale: 0),
                        Link = c.String(maxLength: 250),
                        Description = c.String(maxLength: 50),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                        Status = c.Decimal(precision: 1, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.Tag",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 50),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "VANCHITUAN.UserGroup",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 20),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "VANCHITUAN.User",
                c => new
                    {
                        Id = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        UserName = c.String(maxLength: 50),
                        Password = c.String(maxLength: 32),
                        GroupId = c.String(maxLength: 20),
                        Name = c.String(maxLength: 50),
                        Address = c.String(maxLength: 50),
                        Email = c.String(maxLength: 50),
                        Phone = c.String(maxLength: 50),
                        Point = c.Decimal(precision: 18, scale: 2),
                        Image = c.String(maxLength: 300),
                        PromotionId = c.Decimal(precision: 10, scale: 0),
                        Status = c.Decimal(nullable: false, precision: 1, scale: 0),
                        ProvinceId = c.Decimal(precision: 10, scale: 0),
                        DistrictId = c.Decimal(precision: 10, scale: 0),
                        PrecinctId = c.Decimal(precision: 10, scale: 0),
                        CreatedDate = c.DateTime(),
                        CreatedBy = c.String(maxLength: 50),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("VANCHITUAN.User");
            DropTable("VANCHITUAN.UserGroup");
            DropTable("VANCHITUAN.Tag");
            DropTable("VANCHITUAN.Slide");
            DropTable("VANCHITUAN.Role");
            DropTable("VANCHITUAN.Promotion");
            DropTable("VANCHITUAN.Product");
            DropTable("VANCHITUAN.ProductCategory");
            DropTable("VANCHITUAN.OrderStatus");
            DropTable("VANCHITUAN.Order");
            DropTable("VANCHITUAN.OrderDetail");
            DropTable("VANCHITUAN.MenuType");
            DropTable("VANCHITUAN.Menu");
            DropTable("VANCHITUAN.Invoice");
            DropTable("VANCHITUAN.InvoiceDetail");
            DropTable("VANCHITUAN.Footer");
            DropTable("VANCHITUAN.Feedback");
            DropTable("VANCHITUAN.Credential");
            DropTable("VANCHITUAN.ContentTag");
            DropTable("VANCHITUAN.Content");
            DropTable("VANCHITUAN.Contact");
            DropTable("VANCHITUAN.Category");
            DropTable("VANCHITUAN.About");
        }
    }
}
