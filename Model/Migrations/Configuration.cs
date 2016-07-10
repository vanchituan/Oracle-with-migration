namespace DataLayer.Migrations
{
    using Framework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataLayer.Framework.OnlineShopDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataLayer.Framework.OnlineShopDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            context.Products.AddOrUpdate(p=>p.Id, SeedProduct());

            context.ProductCategories.AddOrUpdate(p => p.Id, SeedProductCategory());

            context.Users.AddOrUpdate(p => p.Id, SeedUser());

            context.UserGroups.AddOrUpdate(p => p.Id, SeedUserGroup());

            context.Roles.AddOrUpdate(p => p.Id, SeedRole());

            context.Credentials.AddOrUpdate(SeedCredential());

            context.Promotions.AddOrUpdate(p => p.PromotionId, SeedPromotion());

            context.OrderStatuses.AddOrUpdate(p => p.OrderStatusId, SeedOrderStatus());

            context.MenuTypes.AddOrUpdate(SeedMenuType());

            context.Menus.AddOrUpdate(SeedMenu());

            context.Slides.AddOrUpdate(SeedSlide());
        }

        private Product[] SeedProduct()
        {
            Product[] productArr = new Product[]
                {
                    new Product
                    {
                        Id = 1,
                        Name = "SRM khoáng chất ngừa mụn sâu",
                        CategoryId = 1,
                        Code = "A21",
                        MetaTitle = "srm-khoang-chat-ngua-mun-sau",
                        Description = "Dành cho mọi loại da có trang điểm, tối ưu cho da mụn. Kết hợp tác dụng làm sạch của bùn khoáng giúp sạch cặn trang điểm khó trôi + ngừa mụn hiệu quả + dưỡng da sáng mịn. Hiệu quả như chăm sóc da với mặt nạ bùn",
                        Detail = "Các hạt khoáng chất với tác dụng làm sạch của bùn khoáng giúp làm sạch cả cặn trang điểm khó trôi bám trong lỗ chân lông. Cho da sạch và sáng mịn, hiệu quả như chăm sóc da với mặt nạ bùn. Tinh chất vỏ cây Mộc Lan (Magnolia Officinalis Bark Extract) giúp ngừa khuẩn gây mụn, đem lại hiệu quả ngừa mụn gấp 10 lần. Hoạt chất L-Cartinine và chiết xuất trà trắng giúp giảm nhờn nhanh chóng và chăm sóc dịu nhẹ cho da. Công thức không bổ sung AHA/BHA gây mỏng da, dịu nhẹ để sử dụng hàng ngày ngay cả những lúc không trang điểm",
                        Image = "/Assets/Client/images/1.png",
                        Price = 3000,
                        PriceImport = 100000,
                        Quantity = 400,
                        Status = false,
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "SRM khoáng chất trắng da",
                        CategoryId = 1,
                        Code = "A02",
                        MetaTitle = "srm-khoang-chat-trang-da",
                        Description = "Dành cho mọi loại da có trang điểm. Công thức kết hợp bùn khoáng giúp làm sạch bụi bẩn và cặn trang điểm khó trôi + dưỡng da trắng mịn. Hiệu quả như chăm sóc da với mặt nạ bùn",
                        Detail = "Khoáng chất từ bùn khoáng giúp làm sạch cả cặn trang điểm khó trôi bám trong lỗ chân lông. Cho da sạch và trắng mịn, hiệu quả như chăm sóc da với mặt nạ bùn. Tinh chất dưỡng trắng Pearly White giúp dưỡng trắng da gấp 10 lần so với Vitamin C. Công thức không bổ sung AHA/BHA gây mỏng da, dịu nhẹ để sử dụng hàng ngày ngay cả những lúc không trang điểm",
                        Image = "/Assets/Client/images/2.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = false,
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Tinh chất serum dưỡng lót ngày",
                        CategoryId = 1,
                        Code = "A03",
                        MetaTitle = "tinh-chat-serum-duong-lot-ngay",
                        Description = "Dưỡng trắng + Dưỡng ẩm + Chống nắng - bảo vệ da trước khi trang điểm",
                        Detail = "Là sản phẩm chăm sóc da trang điểm chuyên biệt, Tinh chất Serum NIVEA giúp đem đến làn da trắng mượt như nước, để bạn thỏa sức trang điểm đẹp mỗi ngày. Tinh chất tảo nâu kết hợp thành phần kem lót tạo thành lớp dưỡng chất bảo vệ da trước khi trang điểm, giúp hạn chế phấn trang điểm thấm vào lỗ chân lông, từ đó ngăn ngừa các vấn đề da hư tổn. Công nghệ dưỡng trắng Sensilight™ kết hợp dẫn xuất vitamin C trong công thức Serum dưới dạng phân tử nhỏ, nhanh chóng thấm sâu, giúp dưỡng trắng da và làm mờ vết thâm nám từ sâu bên trong, đồng thời làm giảm sự hình thành hắc tố melanin là nguyên nhân khiến da sạm đen. Công nghệ dưỡng ẩm Hydra IQ™- được lấy cảm hứng dựa trên nghiên cứu đoạt giải Nobel – giúp kích thích sự hình thành đường dẫn nước trong tế bào da, cho hiệu quả dưỡng ẩm suốt cả ngày. Làn da được bổ sung đủ độ ẩm sẽ giúp lớp trang điểm mịn màng và bền lâu hơn. SPF33 và PA+++ giúp chống nắng và bảo vệ da khỏi tác hại của tia UVA và UVB.",
                        Image = "/Assets/Client/images/3.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = false,
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Tinh chất serum dưỡng trắng đêm",
                        CategoryId = 1,
                        Code = "A02",
                        MetaTitle = "tinh-chat-serum-duong-trang-dem",
                        Description = "Dưỡng trắng + Dưỡng ẩm + Cung cấp dưỡng chất - giúp phục hồi da trang điểm",
                        Detail = "Là sản phẩm giúp phục hồi da trang điểm chuyên biệt, Tinh chất Serum ban đêm NIVEA giúp đem đến làn da trắng mượt như nước, để bạn thỏa sức trang điểm đẹp mỗi ngày. Tinh chất nhân sâm trong công thức serum hoạt động như mặt nạ dưỡng chất, nhanh chóng thấm sâu vào da, giúp phục hồi da trang điểm bị hư tổn. Công nghệ dưỡng trắng Sensilight™ kết hợp dẫn xuất vitamin C trong công thức Serum dưới dạng phân tử nhỏ, nhanh chóng thấm sâu, giúp dưỡng trắng da và làm mờ vết thâm nám từ sâu bên trong, đồng thời làm giảm sự hình thành hắc tố melanin là nguyên nhân khiến da sạm đen. Công nghệ dưỡng ẩm Hydra IQ™- được lấy cảm hứng dựa trên nghiên cứu đoạt giải Nobel – giúp kích thích sự hình thành đường dẫn nước trong tế bào da, giúp dưỡng ẩm và phục hồi vùng da khô, mất nước trong khi ngủ, đem đến làn da tươi khoẻ và mịn màng vào buổi sáng.",
                        Image = "/Assets/Client/images/4.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Lăn ngăn mùi kháng khuẩn",
                        CategoryId = 2,
                        Code = "A02",
                        MetaTitle = "lan-ngan-mui-khang-khuan",
                        Description = "Khô thoáng",
                        Detail = "Công thức chứa tinh chất muối nhôm*, giúp giảm tiết mồ hôi và ngăn mùi hiệu quả đến 48 giờ**, cho cảm giác khô thoáng tức thì với mùi hương nam tính. Không bổ sung cồn, chất tạo màu, chất bảo quản",
                        Image = "/Assets/Client/images/5.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Lăn ngăn mùi phân tử bạc",
                        CategoryId = 2,
                        Code = "A02",
                        MetaTitle = "lan-ngan-mui-phan-tu-bac",
                        Description = "Phân tử bạc - Ngăn khuẩn gây mùi",
                        Detail = "Công thức chứa phân tử bạc giúp giảm hình thành vi khuẩn gây mùi đến 99.9% *, đồng thời giúp làm giảm tiết mồ hôi và ngăn mùi hiệu quả đến 48 giờ** , cho cảm giác khô thoáng tức thì với mùi hương nam tính. Không bổ sung cồn, chất tạo màu, chất bảo quản",
                        Image = "/Assets/Client/images/6.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 7,
                        Name = "Serum dưỡng sáng da mặt men",
                        CategoryId = 2,
                        Code = "A02",
                        MetaTitle = "serum-duong-sang-da-mat-men",
                        Description = "Dành cho da nam giới bị hư tổn sạm đen và xuất hiện nhiều vết thâm do ánh nắng mặt trời.",
                        Detail = "Đột phá mới từ Nivea Men! Tinh chất SERUM - HẠT DƯỠNG CHẤT SIÊU NHỎ giúp THẤM NHANH và SÂU*, giúp phục hồi và dưỡng da từ sâu bên trong*, hơn nữa không gây nhờn rít. Đặc biệt sản phẩm chứa hạt dưỡng sáng Whitinat** giúp làm mờ vết thâm và sáng da hiệu quả gấp 10 lần***, SPF 30 giúp chống nắng lâu hơn 30 lần**** (đối với tia UVB). KHÔNG CHỨA AHA/BHA NÊN KHÔNG GÂY MỎNG DA, KHÔNG GÂY KÍCH ỨNG VÀ BẮT NẮNG.",
                        Image = "/Assets/Client/images/7.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 8,
                        Name = "Ngăn mùi diệt khuẩn Invisible",
                        CategoryId = 2,
                        Code = "A02",
                        MetaTitle = "ngan-mui-diet-khuan-invisible",
                        Description = "Giảm vệt ố vàng",
                        Detail = "Công thức tiên tiến giúp giảm hình thành vệt ố vàng trên áo*, đồng thời giúp giảm tiết mồ hôi và ngăn mùi hiệu quả đến 48**, cùng với mùi hương nam tính. Không bổ sung cồn, chất tạo màu, chất bảo quản.",
                        Image = "/Assets/Client/images/8.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 9,
                        Name = "Dưỡng thể dưỡng ẩm sâu",
                        CategoryId = 3,
                        Code = "A02",
                        MetaTitle = "duong-the-duong-am-sau",
                        Description = "Công thức Serum với Vitamin E và tinh dầu nho dưỡng ẩm chuyên sâu cùng màn chống nắng SPF 25 bảo vệ da gấp 25 lần",
                        Detail = "Được tăng cường hàm lượng Vitamin E gấp 100 lần và chiết xuất tinh dầu hạt nho cho hiệu quả dưỡng ẩm chuyên sâu. SPF 25 và PA++ tạo 1 lớp màng bảo vệ trên da, giúp da hạn chế mất độ ẩm dưới sức nóng mặt trời và bảo vệ da khỏi tác hại của ánh nắng hiệu quả gấp 25 lần. Cấu trúc phân tử siêu nhỏ và kết cấu dịu nhẹ không gây nhờn dính giúp Serum có khả năng thấm nhanh và sâu vào da. Serum dưỡng ẩm chuyên sâu NIVEA bảo vệ hiệu quả và phục hồi da hiệu quả, cho làn  da khỏe đẹp  và mềm mịn lên trông thấy.",
                        Image = "/Assets/Client/images/9.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 10,
                        Name = "Dưỡng thể trắng da chuyên sâu",
                        CategoryId = 3,
                        Code = "A02",
                        MetaTitle = "duong-the-trang-da-chuyen-sau",
                        Description = "Kem xả dưỡng thể trắng da NIVEA trong khi tắm giúp bổ sung các dưỡng chất thiết yếu bị mất đi do nắng. Bạn sẽ cảm nhận ngay một làn da sáng mịn, mềm mượt khi bước ra khỏi phòng tắm.",
                        Detail = "<p>C&ocirc;ng thức đặc biệt gi&uacute;p c&aacute;c dưỡng chất thấm nhanh v&agrave; s&acirc;u ngay khi da c&ograve;n ướt . Tăng cường 50x vitamin C, chiết xuất anh đ&agrave;o c&ugrave;ng kho&aacute;ng chất biển gi&uacute;p bổ sung dưỡng chất, phục hồi da kh&ocirc; sạm đen, dưỡng da s&aacute;ng mịn tăng cường khả năng tự bảo vệ của da trước c&aacute;c t&aacute;c động của &aacute;nh nắng v&agrave; m&ocirc;i trường.</p>",
                        Image = "/Assets/Client/images/10.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 11,
                        Name = "Sữa dưỡng thể dưỡng ẩm sâu",
                        CategoryId = 3,
                        Code = "A02",
                        MetaTitle = "sua-duong-the-duong-am-sau",
                        Description = "Sữa dưỡng thể dưỡng ẩm chuyên sâu: chiết xuất từ tinh dầu nho, dầu trái bơ và 50x vitamin E, cho làn da cơ thể mịn màng, mềm mượt như nước suốt 24h.",
                        Detail = "Cải tiến với công nghệ giúp cải thiện và duy trì mức độ ẩm tối ưu trên bề mặt da. Tăng cường tinh dầu nho, dầu trái bơ và vitamin E, dưỡng ẩm và nuôi dưỡng da khô, hư tồn. Cho làn da cơ thể mềm mượt như nước và giảm thiểu 10 dấu hiệu của da khô.",
                        Image = "/Assets/Client/images/11.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 12,
                        Name = "Dưỡng thể chống tia cực tím",
                        CategoryId = 3,
                        Code = "A02",
                        MetaTitle = "duong-the-chong-tia-cuc-tim",
                        Description = "Gấp 10 lần vitamin C thiên nhiên từ siêu quả Camu Camu, Acelora Cherry được biết đến với khả năng giúp nuôi dưỡng và làm trắng da hiệu quả cũng như nuôi dưỡng da khỏe từ sâu bên trong.Màng lọc tia UVA/UVB giúp bảo vệ da khỏi ánh nắng & không gây nhờn dính",
                        Detail = "Gấp 10 lần vitamin C thiên nhiên từ siêu quả Camu Camu, Acelora Cherry được biết đến với khả năng giúp nuôi dưỡng và làm trắng lớp da bên ngoài hiệu quả cũng như nuôi dưỡng da khỏe từ sâu bên trong. Màng lọc tia UVA/UVB giúp bảo vệ da khỏi ánh nắng và sức nóng mặt trời.Công thức dịu nhẹ, không gây nhờn dính nên dễ dàng thấm sâu vào da. Mang đến 10 lợi ích, cho làn da trắng mịn rạng ngời.",
                        Image = "/Assets/Client/images/12.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 13,
                        Name = "Lăn ngăn mùi khô thoáng",
                        CategoryId = 4,
                        Code = "A02",
                        MetaTitle = "lan-ngan-mui-kho-thoang",
                        Description = "Giúp ngăn mùi và khô thoáng đến 48 giờ, dưỡng vùng da dưới cánh tay sáng mịn và giảm sần hiệu quả.",
                        Detail = "Với công thức chứa tinh chất muối nhôm. Không chỉ giúp ngăn mùi mà còn mang lại cảm giác khô thoáng đến 48 giờ. Dưỡng cho vùng da dưới cánh tay sáng mịn và giảm sần hiệu quả. Mang lại hương thơm dễ chịu suốt ngày.",
                        Image = "/Assets/Client/images/13.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 14,
                        Name = "Ngăn mùi mờ vết thâm",
                        CategoryId = 4,
                        Code = "A02",
                        MetaTitle = "lan-ngan-mui-mo-ve-tham",
                        Description = "Dưỡng vùng da dưới cánh tay trắng mịn và giúp giảm sần, mờ vết thâm hiệu quả với chiết xuất ngọc trai. Phù hợp cho da dùng nhíp hoặc dao cạo.",
                        Detail = "Công thức với các hạt phân tử siêu nhỏ chứa 10 loại Vitamin, cùng chiết xuất ngọc trai. Không chỉ dưỡng vùng da dưới cánh tay trắng mịn mà còn giúp mờ vết thâm, giảm sần hiệu quả. Mang lại hương thơm dễ chịu đến 48 giờ. Phù hợp cho da dùng nhíp hoặc dao cạo",
                        Image = "/Assets/Client/images/14.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 15,
                        Name = "Ngăn mùi kháng khuẩn ngọc trai",
                        CategoryId = 4,
                        Code = "A02",
                        MetaTitle = "ngan-mui-khang-khuan-ngoc-trai",
                        Description = "Dưỡng vùng da dưới cánh tay mềm mượt, trắng mịn và giúp giảm sần hiệu quả với chiết xuất ngọc trai",
                        Detail = "Công thức chứa dưỡng chất và chiết xuất ngọc trai. Không chỉ dưỡng cho vùng da dưới cánh tay mềm mượt, trắng mịn mà còn giúp giảm sần hiệu quả. Mang lại hương thơm quyến rũ đến 48 giờ.",
                        Image = "/Assets/Client/images/15.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 16,
                        Name = "Ngăn mùi kháng khuẩn Q10 săn da",
                        CategoryId = 4,
                        Code = "A02",
                        MetaTitle = "ngan-mui-khang-khuan-q10-san-da",
                        Description = "Công thức chứa hợp chất Q10 dưỡng vùng da dưới cánh tay trắng mịn, săn chắc & giảm thâm sần. Phù hợp cho da bị kém săn chắc do sử dụng nhíp thường xuyên dẫn đến thâm & nổi sần.",
                        Detail = "Hợp chất Q10* tinh khiết đến 98% giúp tăng tính đàn hồi cho da, dưỡng da săn chắc & giảm thâm sần. Tinh chất rễ cây cam thảo & dầu trái bơ dưỡng da trắng mịn. Ngăn mùi hiệu quả đến 48 giờ với hương thơm dễ chịu. Tinh chất Q10 là một hợp chất tự nhiên được da tự tổng hợp chỉ với một lượng nhỏ, có tác dụng dưỡng da săn chắc và tăng tính đàn hồi cho da.",
                        Image = "/Assets/Client/images/16.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 17,
                        Name = "Son dưỡng Essential chuyên sâu",
                        CategoryId = 5,
                        Code = "A02",
                        MetaTitle = "son-duong-chuyen-sau-essential",
                        Description = "Nuôi dưỡng và cân bằng độ ẩm cho môi với tinh dầu Jojoba và Tinh chất bơ Shea Butter.",
                        Detail = "Bạn muốn đôi môi luôn được dưỡng ẩm mềm mượt và mịn màng ngay cả khi thời tiết hanh khô hay trong môi trường máy lạnh. Son dưỡng ẩm chuyên sâu với công thức chứa tinh dầu Jojoba và Shea Butter thiên nhiên giúp: Dưỡng và cân bằng độ ẩm cho đôi môi luôn mềm mại. Ngăn chặn sự mất nước của môi. Phục hồi môi khô, hư tổn, bong tróc do thiếu độ ẩm. Giữ sắc hồng tự nhiên của môi. Có thể dùng làm son dưỡng chuyên sâu hoặc lót trước lớp son màu",
                        Image = "/Assets/Client/images/17.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 18,
                        Name = "Dưỡng đỏ dâu dây mùa đông",
                        CategoryId = 5,
                        Code = "A02",
                        MetaTitle = "duong-do-dau-tay-mua-dong",
                        Description = "Cung cấp độ ẩm thiết yếu cho môi. Môi xinh thêm quyết rũ với mùi dâu tây ngọt ngào và ánh hồng tự nhiên.",
                        Detail = "Bạn có biết một số loại son màu có thể chứa chì và hoá chất khiến môi bị thâm và sạm màu. Đột phá mới! Fruity Shine Strawberry, son dưỡng ẩm với chiết xuất dâu tây giúp dưỡng môi mềm mại và bảo vệ an toàn cho môi. Không bổ sung chì và hoá chất làm hại môi. Hương dâu tây cho môi thêm quyến rũ. Giữ ẩm cho môi luôn mềm mượt và mịn màng. Giúp bảo vệ môi khỏi ánh nắng mặt trời. Có thể dùng làm son lót trước lớp son màu để bảo vệ môi hoặc dùng riêng với sắc đỏ dâu tây tươi tắn",
                        Image = "/Assets/Client/images/18.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 19,
                        Name = "Dưỡng và giữ ẩm hồng tươi",
                        CategoryId = 5,
                        Code = "A02",
                        MetaTitle = "duong-va-giu-am-hong-tuoi",
                        Description = "Son dưỡng môi sắc hồng tươi trẻ tự nhiên",
                        Detail = "Bạn có muốn đôi môi mình có sắc màu bóng đẹp đầy gợi cảm nhưng cũng đồng thời được dưỡng ẩm lâu dài? Công thức cải tiến mới của son dưỡng môi Nivea Lovely Lips sắc hồng tươi trẻ tự nhiên với chiết xuất tinh dầu Jojoba và Shea Butter, kết hợp hương trái cây ngọt ngào cho môi bạn đầy gợi cảm cùng sắc màu bóng đẹp. Dưỡng ẩm môi liên tục suốt 8h. Môi luôn mềm mại, mịn màng với màu song bóng đẹp. Không chứa lượng chì và hóa chất làm thâm môi",
                        Image = "/Assets/Client/images/19.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    },
                    new Product
                    {
                        Id = 20,
                        Name = "Dưỡng lót thanh khiết",
                        CategoryId = 4,
                        Code = "A02",
                        MetaTitle = "son-lot-duong-am-thanh-khiet",
                        Description = "Son dưỡng ẩm và bảo vệ an toàn cho đôi môi",
                        Detail = "Bạn có biết một số loại son màu có thể chứa nhiều chì và hoá chất khiến môi bị thâm và sạm màu. Do đó, đôi môi cần một lớp son lót bảo vệ và chăm sóc trước khi thoa son màu. Đột phá mới!  Son Nivea Pure & Natural với chiết xuất từ hoa cúc Chamomile & Calendula  là lớp lót bảo vệ hoàn hảo cho đôi môi khỏi chì và hoá chất gây hại từ son màu, đồng thời duy trì độ ẩm cho môi, giúp môi luôn mềm mịn tươi trẻ. Lớp lót dưỡng an toàn, bảo vệ môi trước khi thoa son màu. Dưỡng ẩm dịu nhẹ & giúp giữ sắc hồng tự nhiên của môi",
                        Image = "/Assets/Client/images/20.png",
                        Price = 3000,
                        PriceImport = 500000,
                        Quantity = 400,
                        Status = true,
                    }
                };
            return productArr;
        }

        private ProductCategory[] SeedProductCategory()
        {
            ProductCategory[] categoryArr = new ProductCategory[]
                {
                    new ProductCategory
                    {
                        Id =1 ,
                        Name = "Chăm sóc da mặt",
                        MetaTitle = "cham-soc-da-mat",
                        Status = true
                    },
                    new ProductCategory
                    {
                        Id =2 ,
                        Name = "Dành cho nam",
                        MetaTitle = "danh-cho-nam",
                        Status = true
                    },
                    new ProductCategory
                    {
                        Id =3 ,
                        Name = "Dưỡng thể",
                        MetaTitle = "duong-the",
                        Status = true
                    },
                    new ProductCategory
                    {
                        Id =4 ,
                        Name = "Ngăn mùi",
                        MetaTitle = "ngan-mui",
                        Status = true
                    },
                    new ProductCategory
                    {
                        Id =5 ,
                        Name = "Son dưỡng môi",
                        MetaTitle = "son-duong-moi",
                        Status = true
                    },
                };

            return categoryArr;

        }

        private User[] SeedUser()
        {
            User[] userArr = new User[]
                {
                    new User
                    {
                        Name = "khachle",
                        GroupId = "MEMBER",
                        Point = 0,
                        PromotionId = 0,
                        Status = true
                    },
                    new User
                    {
                        Name = "van nguyen",
                        Password = "123",
                        GroupId = "ADMIN",
                        UserName = "vannguyen",
                        Point = 13999000,
                        Address = "16 phan huy on",
                        Email = "vanvan@gmail.com",
                        Phone = "0126 54 35 231",
                        ProvinceId = 701,
                        DistrictId = 70101,
                        PrecinctId = 7010113,
                        PromotionId = 1,
                        Status = true
                    },
                    new User
                    {
                        Name = "trucnguyen",
                        Password = "123",
                        GroupId = "MOD",
                        UserName = "trucnguyen",
                        Point = 13999000,
                        Address = "187 ton dan",
                        Email = "trucnguyen@gmail.com",
                        Phone = "0126 54 35 231",
                        ProvinceId = 701,
                        DistrictId = 70101,
                        PrecinctId = 7010109,
                        PromotionId = 1,
                        Status = true
                    },
                    new User
                    {
                        Name = "ha huy long",
                        Password = "123",
                        GroupId = "MEMBER",
                        UserName = "longha",
                        Point = 41751500,
                        Address = "1976 CMt8",
                        Email = "longha@gmail.com",
                        Phone = "0455 15 15 151",
                        ProvinceId = 701,
                        DistrictId = 70101,
                        PrecinctId = 7010113,
                        PromotionId = 2,
                        Status = true
                    },
                    new User
                    {
                        Name = "nguyen minh minh",
                        Password = "123",
                        GroupId = "MOD",
                        UserName = "minhminh",
                        Point = 11017500,
                        Address = "341 ba thang",
                        Email = "minhminh@gmai.com",
                        Phone = "3423 89 47 293",
                        ProvinceId = 701,
                        DistrictId = 70101,
                        PrecinctId = 7010109,
                        PromotionId = 2,
                        Status = true
                    },
                };
            return userArr;
        }

        private UserGroup[] SeedUserGroup()
        {
            UserGroup[] userGroupArr = new UserGroup[]
                {
                    new UserGroup
                    {
                        Id = "ADMIN",
                        Name = "Quản trị"
                    },
                    new UserGroup
                    {
                        Id = "MEMBER",
                        Name = "Thành viên"
                    },
                    new UserGroup
                    {
                        Id = "MOD",
                        Name = "Moderatior"
                    },
                };
            return userGroupArr;
        }

        private Role[] SeedRole()
        {
            Role[] roleArr = new Role[]
                {
                    new Role
                    {
                        Id = "custom_order",
                        Name = "xxx"
                    },
                    new Role
                    {
                        Id = "view_user",
                        Name = "Xem người dùng"
                    },
                    new Role
                    {
                        Id = "view_role",
                        Name = "Xem vai trò"
                    },
                    new Role
                    {
                        Id = "view_productcategory",
                        Name = "Xem loại sản phẩm"
                    },
                    new Role
                    {
                        Id = "view_product",
                        Name = "Xem sản phẩm"
                    },
                    new Role
                    {
                        Id = "view_order",
                        Name = "Xem hóa đơn"
                    },
                    new Role
                    {
                        Id = "view_feedback",
                        Name = "Xem phản hồi"
                    },

                };
            return roleArr;
        }

        private Credential[] SeedCredential()
        {
            Credential[] credentialArr = new Credential[]
                {
                    new Credential
                    {
                        RoleId = "MOD",
                        UserGroupId = "view_user"
                    },
                    new Credential
                    {
                        RoleId = "MOD",
                        UserGroupId = "view_feedback"
                    },
                    new Credential
                    {
                        RoleId = "ADMIN",
                        UserGroupId = "view_user"
                    },
                    new Credential
                    {
                        RoleId = "ADMIN",
                        UserGroupId = "view_role"
                    },
                };
            return credentialArr;
        }

        private Promotion[] SeedPromotion()
        {
            Promotion[] promotionArr = new Promotion[]
                {
                    new Promotion
                    {
                        PromotionId = 0,
                        PromotionName = "Khách lẽ",
                        Value = 0,
                        Discount = 0 
                    },
                    new Promotion
                    {
                        PromotionId = 1,
                        PromotionName = "Thành viên",
                        Value = 2000000,
                        Discount = 5
                    },
                    new Promotion
                    {
                        PromotionId = 2,
                        PromotionName = "Khách hàng thân thiết",
                        Value = 20000000,
                        Discount = 10
                    },
                    new Promotion
                    {
                        PromotionId = 3,
                        PromotionName = "Thẻ bạc",
                        Value = 50000000,
                        Discount = 15
                    },
                    new Promotion
                    {
                        PromotionId = 4,
                        PromotionName = "Thẻ vàng",
                        Value = 100000000,
                        Discount = 20
                    },
                };
            return promotionArr;
        }

        private OrderStatus [] SeedOrderStatus()
        {
            OrderStatus[] arr = new OrderStatus[]
                {
                    new OrderStatus
                    {
                        Name = "Đang chờ xử lý",
                        Description = "đã nhận được đơn hàng của bạn và sẽ được nhân viên xử lý trong thời gian sớm nhất."
                    },
                    new OrderStatus
                    {
                        Name = "Đã xử lý",
                        Description = "Nhân viên đã gọi hoặc nhắn tin cho bạn để xác nhận ngày giờ giao hàng. Khi nhân viên gọi, bạn có thể thay đổi sản phẩm và thông tin giao hàng."
                    },
                    new OrderStatus
                    {
                        Name = "Đã giao hàng",
                        Description = "Gói hàng của bạn đã rời kho và đã được chuyển qua bộ phận giao hàng. Bạn không thể tự thay đổi sản phẩm hay thông tin giao hàng với tình trạng đơn hàng này."
                    },
                    new OrderStatus
                    {
                        Name = "Đơn hàng tự hủy",
                        Description = "Trong trường hợp nhân viên không thể liên lạc được với khách hàng trong nhiều ngày và không nhận được thông báo gì từ khách hàng, nhân viên có quyền hủy đơn hàng của bạn mà không cần phải thông báo."
                    },
                    new OrderStatus
                    {
                        Name = "Giao hàng thành công",
                        Description = "Xác nhận giao hàng thành công"
                    },
                };
            return arr;
        }

        private MenuType[] SeedMenuType()
        {
            MenuType[] menuTypeArr = new MenuType[]
                {
                    new MenuType
                    {
                        ID = 1,
                        Name = "Menu chính"
                    },
                    new MenuType
                    {
                        ID = 2,
                        Name = "Menu top"
                    },
                };
            return menuTypeArr;
        }

        private Menu[] SeedMenu()
        {
            Menu[] menuArr = new Menu[]
                {
                    new Menu
                    {
                        ID = 1,
                        Text = "Trang chủ",
                        Link = "/",
                        DisplayOrder = 1,
                        Target = "_blank",
                        TypeID = 1,
                        Status = true
                    },
                    new Menu
                    {
                        ID = 2,
                        Text = "Giới thiệu",
                        Link = "/gioi-thieu",
                        DisplayOrder = 2,
                        Target = "_self",
                        TypeID = 1,
                        Status = true
                    },
                    new Menu
                    {
                        ID = 3,
                        Text = "Sản phẩm",
                        Link = "/san-pham",
                        DisplayOrder = 4,
                        Target = "_self",
                        TypeID = 1,
                        Status = true
                    },
                    new Menu
                    {
                        ID = 4,
                        Text = "Liên hệ",
                        Link = "/lien-he",
                        DisplayOrder = 4,
                        Target = "_self",
                        TypeID = 1,
                        Status = true
                    },
                    new Menu
                    {
                        ID = 5,
                        Text = "Đăng nhập",
                        Link = "/dang-nhap",
                        DisplayOrder = 1,
                        Target = "_self",
                        TypeID = 2,
                        Status = true
                    },
                    new Menu
                    {
                        ID = 6,
                        Text = "Đăng ký",
                        Link = "/dang-ky",
                        DisplayOrder = 2,
                        Target = "_self",
                        TypeID = 2,
                        Status = true
                    },
                    new Menu
                    {
                        ID = 7,
                        Text = "Hệ thống",
                        Link = "/Admin/Login",
                        DisplayOrder = 3,
                        Target = "_self",
                        TypeID = 2,
                        Status = true
                    }
                };
            return menuArr;
        }

        private Slide[] SeedSlide()
        {
            Slide[] slideArr = new Slide[]
                {
                    new Slide
                    {
                        ID = 1,
                        Image = "/Assets/Client/Images/slide1.jpg",
                        DisplayOrder = 1,
                        Link = "/",
                        Status = true
                    },
                    new Slide
                    {
                        ID = 2,
                        Image = "/Assets/Client/Images/slide2.jpg",
                        DisplayOrder = 2,
                        Link = "/",
                        Status = true
                    }
                };
            return slideArr;
        }

    }
}
