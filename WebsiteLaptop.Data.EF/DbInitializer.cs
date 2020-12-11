using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebsiteLaptop.Data.Entities;
using WebsiteLaptop.Data.Enums;
using WebsiteLaptop.Utilities.Constants;

namespace WebsiteLaptop.Data.EF
{
    public class DbInitializer
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        private RoleManager<AppRole> _roleManager;
        public DbInitializer(AppDbContext context, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task Seed()
        {
            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Description = "Top manager"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Nhân Viên Bán Hàng",
                    NormalizedName = "Nhân Viên Bán Hàng",
                    Description = "Nhân Viên Bán Hàng"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Quản Lí",
                    NormalizedName = "Quản Lí",
                    Description = "Quản Lí"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Nhân Viên Giao Hàng",
                    NormalizedName = "Nhân Viên Giao Hàng",
                    Description = "Nhân Viên Giao Hàng"
                });
                await _roleManager.CreateAsync(new AppRole()
                {
                    Name = "Khách Hàng",
                    NormalizedName = "Khách Hàng",
                    Description = "Khách hàng"
                });
            }
            if (!_userManager.Users.Any())
            {
                await _userManager.CreateAsync(new AppUser()
                {
                    UserName = "admin",
                    FullName = "Administrator",
                    Email = "admin@gmail.com",
                    Balance = 0,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now,
                    Status = Status.Active,
                    Avatar= "/admin-side/images/admin-avatar.jpg"
                }, "123456");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (_context.Functions.Count() == 0)
            {
                _context.Functions.AddRange(new List<Function>()
                {
                    new Function() {Id = "SYSTEM", Name = "Hệ thống",ParentId = null,SortOrder = 1,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "ROLE", Name = "Role",ParentId = "SYSTEM",SortOrder = 1,Status = Status.Active,URL = "/admin/role/index",IconCss = "fa-home"  },
                    new Function() {Id = "FUNCTION", Name = "Chức năng",ParentId = "SYSTEM",SortOrder = 2,Status = Status.Active,URL = "/admin/function/index",IconCss = "fa-home"  },
                    new Function() {Id = "USER", Name = "Người dùng",ParentId = "SYSTEM",SortOrder =3,Status = Status.Active,URL = "/admin/user/index",IconCss = "fa-home"  },
                    new Function() {Id = "ERROR", Name = "Lỗi",ParentId = "SYSTEM",SortOrder = 5,Status = Status.Active,URL = "/admin/error/index",IconCss = "fa-home"  },
                    new Function() {Id = "PRODUCT",Name = "Sản phẩm",ParentId = null,SortOrder = 2,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CATEGORY",Name = "Danh mục",ParentId = "PRODUCT",SortOrder =1,Status = Status.Active,URL = "/admin/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_LIST",Name = "Sản phẩm",ParentId = "PRODUCT",SortOrder = 2,Status = Status.Active,URL = "/admin/product/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "ORDER",Name = "Đơn hàng",ParentId = "PRODUCT",SortOrder = 3,Status = Status.Active,URL = "/admin/order/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "UTILITY",Name = "Tiện ích",ParentId = null,SortOrder = 4,Status = Status.Active,URL = "/",IconCss = "fa-clone"  },
                    new Function() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",SortOrder = 1,Status = Status.Active,URL = "/admin/footer/index",IconCss = "fa-clone"  },
                    new Function() {Id = "FEEDBACK",Name = "Phản hồi",ParentId = "UTILITY",SortOrder = 2,Status = Status.Active,URL = "/admin/feedback/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ANNOUNCEMENT",Name = "Thông báo",ParentId = "UTILITY",SortOrder = 3,Status = Status.Active,URL = "/admin/announcement/index",IconCss = "fa-clone"  },
                    new Function() {Id = "CONTACT",Name = "Liên hệ",ParentId = "UTILITY",SortOrder = 4,Status = Status.Active,URL = "/admin/contact/index",IconCss = "fa-clone"  },
                    new Function() {Id = "SLIDE",Name = "Slide",ParentId = "UTILITY",SortOrder = 5,Status = Status.Active,URL = "/admin/slide/index",IconCss = "fa-clone"  },

                    new Function() {Id = "REPORT",Name = "Báo cáo",ParentId = null,SortOrder = 5,Status = Status.Active,URL = "/",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "REVENUES",Name = "Báo cáo doanh thu",ParentId = "REPORT",SortOrder = 1,Status = Status.Active,URL = "/admin/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "ACCESS",Name = "Báo cáo truy cập",ParentId = "REPORT",SortOrder = 2,Status = Status.Active,URL = "/admin/report/visitor",IconCss = "fa-bar-chart-o"  },
                });
            }

            if (_context.Footers.Count(x => x.Id == CommonConstants.DefaultFooterId) == 0)
            {
                string content = "Footer";
                _context.Footers.Add(new Footer()
                {
                    Id = CommonConstants.DefaultFooterId,
                    Content = content
                });
            }

            if (_context.ProductConditions.Count() == 0)
            {
                List<ProductCondition> listSize = new List<ProductCondition>()
                {
                    new ProductCondition() { Condition="Mới" },
                    new ProductCondition() { Condition="Like new"},
                    new ProductCondition() { Condition="90%" },
                    new ProductCondition() { Condition="50%" },
                    new ProductCondition() { Condition="Cũ" }
                };
                _context.ProductConditions.AddRange(listSize);
            }

            if (_context.Slides.Count() == 0)
            {
                List<Slide> slides = new List<Slide>()
                {
                    new Slide() {Name="Slide 1",Image="/client-side/images/slider/asus-ad-1.png",Url="#",DisplayOrder = 0,GroupAlias = "top",Status = true },
                    new Slide() {Name="Slide 2",Image="/client-side/images/slider/msi-ad-1.png",Url="#",DisplayOrder = 1,GroupAlias = "top",Status = true },
                    new Slide() {Name="Slide 3",Image="/client-side/images/slider/intel-ad-1.png",Url="#",DisplayOrder = 2,GroupAlias = "top",Status = true },

                    new Slide() {Name="Slide 1",Image="/client-side/images/brand1.png",Url="#",DisplayOrder = 1,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 2",Image="/client-side/images/brand2.png",Url="#",DisplayOrder = 2,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 3",Image="/client-side/images/brand3.png",Url="#",DisplayOrder = 3,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 4",Image="/client-side/images/brand4.png",Url="#",DisplayOrder = 4,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 5",Image="/client-side/images/brand5.png",Url="#",DisplayOrder = 5,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 6",Image="/client-side/images/brand6.png",Url="#",DisplayOrder = 6,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 7",Image="/client-side/images/brand7.png",Url="#",DisplayOrder = 7,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 8",Image="/client-side/images/brand8.png",Url="#",DisplayOrder = 8,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 9",Image="/client-side/images/brand9.png",Url="#",DisplayOrder = 9,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 10",Image="/client-side/images/brand10.png",Url="#",DisplayOrder = 10,GroupAlias = "brand",Status = true },
                    new Slide() {Name="Slide 11",Image="/client-side/images/brand11.png",Url="#",DisplayOrder = 11,GroupAlias = "brand",Status = true },
                };
                _context.Slides.AddRange(slides);
            }

            if (!_context.Contacts.Any())
            {
                _context.Contacts.Add(new Contact()
                {
                    Id = CommonConstants.DefaultContactId,
                    Address = "63, ngõ 117, Trần Cung, Bắc Từ Liêm",
                    Email = "minhcrazy99@gmail.com",
                    Name = "Website Laptop",
                    Phone = "0942 324 543",
                    Status = Status.Active,
                    Website = "http://websitelaptop.com",
                    Lat = 21.0521435,
                    Lng = 105.7861743
                });
            }

            if (_context.ProductCategories.Count() == 0)
            {
                List<ProductCategory> listProductCategory = new List<ProductCategory>()
                {
                    new ProductCategory() { Name="Laptop", Alias="laptop", ParentId = null,Status=Status.Active,SortOrder=1,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "HP 15s fq1111TU",DateCreated=DateTime.Now,Image="/client-side/images/products/3b4e068e920628459e0613013259636d.jpg",Alias="hp-15s-fq1111tu" ,Price = 10000000,Status = Status.Active,OriginalPrice = 11390000,
                            CPU="Intel Core i3 Ice Lake, 1005G1, 1.20 GHz", RAM="4 GB, DDR4 (2 khe), 2666 MHz", HardDrive="SSD 256GB NVMe PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 3.0, HDMI, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 18 mm, 1.69 kg", YearLaunch="2020", Brand="HP"},
                            new Product(){Name = "HP 348 G7",DateCreated=DateTime.Now,Image="/client-side/images/products/181802.png",Alias="hp-348-g7" ,Price = 9800000,Status = Status.Active,OriginalPrice = 12190000,
                            CPU="Intel Core i3 Coffee Lake, 8130U, 2.20 GHz", RAM="4 GB, DDR4 (2 khe), 2666 MHz", HardDrive="SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA", Screen="14 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel® UHD Graphics 620", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="3 x USB 3.1, HDMI, LAN (RJ45), USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa", Size="Dài 324 mm - Rộng 225.9 mm - Dày 19.9 mm, 1.5 kg", YearLaunch="2020", Brand="HP"},
                            new Product(){Name = "Asus VivoBook A515EA",DateCreated=DateTime.Now,Image="/client-side/images/products/41062_vivobook_a515_black_ha7.jpg",Alias="asus-vivobook-a515ea" ,Price = 8690000,Status = Status.Active,OriginalPrice = 14690000,
                            CPU="Intel Core i3 Tiger Lake, 1115G4, 3.00 GHz", RAM="8 GB, DDR4 (On board +1 khe), 3200 MHz", HardDrive="SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="1 x USB 3.2, 2 x USB 2.0, HDMI, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ kim loại, PIN liền", Size="Dày 17.9 mm, 1.8 kg", YearLaunch="2020", Brand="Asus"},
                            new Product(){Name = "Asus VivoBook X509MA N5030",DateCreated=DateTime.Now,Image="/client-side/images/products/unnamed.jpg",Alias="asus-vivobook-x509ma-n5030" ,Price = 6700000,Status = Status.Active,OriginalPrice = 8890000,
                            CPU="Intel Pentium, N5030, 1.10 GHz", RAM="4 GB, DDR4 (1 khe), 2666 MHz", HardDrive="SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel® UHD Graphics 605", Pin="Pin liền, Li-Ion 2 cell", ConnectPort="2 x USB 2.0, HDMI, USB 3.0, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 22.9 mm, 1.9 kg", YearLaunch="2020", Brand="Asus"},
                            new Product(){Name = "Dell Vostro 3590",DateCreated=DateTime.Now,Image="/client-side/images/products/unnamed-1.jpg",Alias="dell-vostro-3590" ,Price = 15700000,Status = Status.Active,OriginalPrice = 20990000,
                            CPU="Intel Core i7 Comet Lake, 10510U, 1.80 GHz", RAM="8 GB, DDR4 (On board +1 khe), 2666 MHz", HardDrive="SSD 256GB NVMe PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa rời, AMD Radeon 610R5, 2GB", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 3.1, HDMI, LAN (RJ45), USB 2.0, VGA (D-Sub)", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 19.8 mm, 1.99 kg", YearLaunch="2019", Brand="Dell"},
                            new Product(){Name = "Lenovo IdeaPad S145 15IIL",DateCreated=DateTime.Now,Image="/client-side/images/products/s145-1-1200x1200.jpg",Alias="lenovo-ideapad-s145-15iil" ,Price = 10990000,Status = Status.Active,OriginalPrice = 10990000,
                            CPU="Intel Core i3 Ice Lake, 1005G1, 1.20 GHz", RAM="4 GB, DDR4 (On board +1 khe), 2666 MHz", HardDrive="SSD 256GB NVMe PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 2 cell", ConnectPort="2 x USB 3.0, HDMI, USB 2.0", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 17.9 mm, 1.79kg", YearLaunch="2019", Brand="Lenovo"},
                            new Product(){Name = "Asus VivoBook X509JA",DateCreated=DateTime.Now,Image="/client-side/images/products/17902-laptop-asus-15-x509ja-ej427t.jpg",Alias="asus-vivobook-x509ja" ,Price = 7900000,Status = Status.Active,OriginalPrice = 10890000,
                            CPU="Intel Core i3 Ice Lake, 1005G1, 1.20 GHz", RAM="4 GB, DDR4 (On board +1 khe), 2666 MHz", HardDrive="SSD 256GB NVMe PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 2 cell", ConnectPort="2 x USB 2.0, USB 3.1, HDMI, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 22.9 mm, 1.73 kg", YearLaunch="2020", Brand="Asus"},
                            new Product(){Name = "Lenovo IdeaPad C340 14IML",DateCreated=DateTime.Now,Image="/client-side/images/products/32123_02_131_283_1.jpg",Alias="lenovo-ideapad-c340-14iml" ,Price = 12000000,Status = Status.Active,OriginalPrice = 16290000,
                            CPU="Intel Core i3 Comet Lake, 10110U, 2.10 GHz", RAM="8 GB, DDR4 (On board 4GB +1 khe 4GB), 2666 MHz", HardDrive="SSD 512 GB M.2 PCIe, Không hỗ trợ khe cắm HDD", Screen="14 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 3.1, HDMI, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 17.9 mm, 1.59 kg", YearLaunch="2019", Brand="Lenovo"},
                            new Product(){Name = "Asus VivoBook A415EA",DateCreated=DateTime.Now,Image="/client-side/images/products/35198_7176_asus_a415ea_4.jpg",Alias="asus-vivobook-a415ea" ,Price = 10500000,Status = Status.Active,OriginalPrice = 13690000,
                            CPU="Intel Core i3 Tiger Lake, 1115G4, 3.00 GHz", RAM="4 GB, DDR4 (On board), 3200 MHz", HardDrive="SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm SSD M.2 PCIe", Screen="14 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 2.0, USB 3.1, HDMI, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa - nắp lưng bằng kim loại, PIN liền", Size="Dày 17.9 mm, 1.4 kg", YearLaunch="2020", Brand="Asus"},
                            new Product(){Name = "HP 15s du1076TX",DateCreated=DateTime.Now,Image="/client-side/images/products/thumb650_Laptop_HP_15s-du1076tx_1R8E2PA_3.jpg",Alias="hp-15s-du1076tx" ,Price = 15100000,Status = Status.Active,OriginalPrice = 17490000,
                            CPU="Intel Core i5 Comet Lake, 10210U, 1.60 GHz", RAM="8 GB, DDR4 (2 khe), 2666 MHz", HardDrive="SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm HDD SATA", Screen="15.6 inch, Full HD (1920 x 1080)", GPU="Card đồ họa rời, NVIDIA Geforce MX130, 2GB", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 3.1, HDMI, LAN (RJ45), USB Type-C", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 19.9 mm, 1.751 kg", YearLaunch="2020", Brand="HP"},
                            new Product(){Name = "Dell Inspiron 3493",DateCreated=DateTime.Now,Image="/client-side/images/products/33177_ins_3493_1.jpg",Alias="dell-inspiron-3493" ,Price = 14600000,Status = Status.Active,OriginalPrice = 15290000,
                            CPU="Intel Core i5 Ice Lake, 1035G1, 1.00 GHz", RAM="8 GB, DDR4 (2 khe), 2666 MHz", HardDrive="SSD 256GB NVMe PCIe, Hỗ trợ khe cắm HDD SATA", Screen="14 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 3.1, HDMI, LAN (RJ45), USB 2.0", OS="Windows 10 Home SL", Design="Vỏ nhựa, PIN liền", Size="Dày 21 mm, 1.79kg", YearLaunch="2019", Brand="Dell"},
                            new Product(){Name = "Asus VivoBook A415EA",DateCreated=DateTime.Now,Image="/client-side/images/products/41059_vivobook_a415_gold_ha1.jpg",Alias="asus-vivobook-a415ea" ,Price = 13500000,Status = Status.Active,OriginalPrice = 14190000,
                            CPU="Intel Core i3 Tiger Lake, 1115G4, 3.00 GHz", RAM="4 GB, DDR4 (On board), 3200 MHz", HardDrive="Intel Optane 32GB (H10), SSD 512 GB M.2 PCIe, Hỗ trợ khe cắm SSD M.2 PCIe", Screen="14 inch, Full HD (1920 x 1080)", GPU="Card đồ họa tích hợp, Intel UHD Graphics", Pin="Pin liền, Li-Ion 3 cell", ConnectPort="2 x USB 2.0, USB 3.1, HDMI, USB Type-C", OS="Windows 10 Home SL", Design="Vỏ kim loại, PIN liền", Size="Dày 17.9 mm, 1.4 kg", YearLaunch="2020", Brand="Asus"},
                        }
                    },
                    new ProductCategory() { Name="PC văn phòng",Alias="pc-van-phong",ParentId = null,Status=Status.Active ,SortOrder=2,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "PC Acer Aspire XC-830",DateCreated=DateTime.Now,Image="/client-side/images/products/51932_acer_aspire_xc_830_s__2_.jpg",Alias="pc-acer-aspire-xc-830" ,Price = 5490000,Status = Status.Active,OriginalPrice = 6499000,
                            CPU="Intel Celeron J4005", RAM="4GB SODIMM", HardDrive="500GB HDD", GPU="Intel® UHD Graphics 600", ConnectPort="2 x USB 3.1, 1 x Card reader, 1 x Audio jack, 4 x USB 2.0, 1 x RJ-45, 1 x HDMI 1.4, 1 x VGA, 1 x Line-out", OS="Endless", Size="100 x 330 x 295 (mm)", YearLaunch="2018", Brand="Acer"},
                            new Product(){Name = "PC Asus S340MC",DateCreated=DateTime.Now,Image="/client-side/images/products/47741_pc_asus_s340mc___2_.jpg",Alias="pc-asus-s340mc" ,Price = 6990000,Status = Status.Active,OriginalPrice = 7890000,
                            CPU="Intel Pentium G5400", RAM="4GB DDR4", HardDrive="1TB HDD", GPU="Intel Graphics", ConnectPort="1 x Headphone, 1 x Microphone, 4 x USB 2.0, 4 x USB 3.1 Gen 1, 2 x PS/2(Keyboard & Mouse), 1 x DVI-D, 1 x HDMI, 1 x VGA-Out, 1 x RJ45 LAN, 1 x COM Port (Serial Port), 3 x Audio Jack(s)", OS="Windows 10", Size="96 x 410 x 357 mm", YearLaunch="2019", Brand="Asus"},
                            new Product(){Name = "PC Lenovo V530S-07ICB",DateCreated=DateTime.Now,Image="/client-side/images/products/44477_lenovo_v530s_023.jpg",Alias="pc-lenovo-v530s-07icb" ,Price = 8999000,Status = Status.Active,OriginalPrice = 9690000,
                            CPU="Intel Core i3 8100 3.6Ghz", RAM="4GB DDR4", HardDrive="1TB HDD", GPU="Intel UHD Graphics", ConnectPort="4 x USB 3.0, 4 x USB 3.1 Gen 2, Microphone Combo audio/mic jack, 7 in-1 card reader, 2 x USB 2.0, 1 x Serial, 1 x Parallel (optional), 1 x Ethernet (RJ45), 1 x VGA, 1 x DisplayPort, 1 x HDMI, Additional VGA and HDMI on optional graphics card on some models", OS="DOS", Size="100 x 304.4 x 274.8 mm", YearLaunch="2020", Brand="Lenovo"},
                            new Product(){Name = "PC HP 280 G3 SFF",DateCreated=DateTime.Now,Image="/client-side/images/products/51086_pc_hp_280_g3_sff_a__2_.jpg",Alias="pc-hp-280-g3-sff" ,Price = 8990000,Status = Status.Active,OriginalPrice = 9450000,
                            CPU="Intel Core i3-9100", RAM="4GB DDR4 2666Mhz", HardDrive="1TB HDD", GPU="Intel UHD Graphics 630", ConnectPort="1 x headphone/microphone port, 4 x USB 3.1 Gen 1, 1 x HDMI, 1 x Microphone in, 1 x Line in, 1 x Line out, 1 x RJ-45, 1 x Serial port, 1 x VGA, 4 x USB 2.0", OS="DOS", Size="(9.5 x 29.6 x 27) cm", YearLaunch="2019", Brand="HP"},
                            new Product(){Name = "PC Dell OptiPlex 3070",DateCreated=DateTime.Now,Image="/client-side/images/products/48226_dell_optiplex_3070_mt_021.png",Alias="pc-dell-optiplex-3070" ,Price = 11890000,Status = Status.Active,OriginalPrice = 12990000,
                            CPU="Intel Core™ i5-9500T", RAM="4GB", HardDrive="500GB HDD", GPU="Integrated Intel HD Graphics", ConnectPort="6 External USB: 4 x 3.1 (2 front/2 rear) and 2 x 2.0 (2 rear) 1 RJ-45 1 HDMI 1.4 1 DisplayPort 1.2 1 Universal Audio Jack (front) 1 Line-out (front) 1 Optional Port (Serial/Serial+PS2/DisplayPort/HDMI 2.0/VGA) 1 Power Button 1 Padlock Loop 1 Power Connection", OS="DOS", YearLaunch="2020", Brand="Dell"},
                        }},
                    new ProductCategory() { Name="Bàn Phím & Chuột",Alias="ban-phim-chuot", ParentId = null,Status=Status.Active ,SortOrder=3,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Bàn phím Asus TUF K5",DateCreated=DateTime.Now,Image="/client-side/images/products/55028_ban_phim_choi_game_asus_tuf_k5_usb_rgb_den_0004_5.jpg",Alias="ban-phim-asus-tuf-k5" ,Price = 989000,Status = Status.Active,OriginalPrice = 1299000, ConnectPort="USB 2.0", Size="100,6 mm x 60,6 mm x 33,5 mm", YearLaunch="2019", Brand="Asus"},
                            new Product(){Name = "Chuột Asus ROG Gladius II Core",DateCreated=DateTime.Now,Image="/client-side/images/products/53593_asus_rog_gladius_ii_core__p507_.jpg",Alias="chuot-asus-rog-gladius-ii-core" ,Price = 1089000,Status = Status.Active,OriginalPrice = 1299999, ConnectPort="USB-Wireless", Size="100,6 mm x 60,6 mm x 33,5 mm", YearLaunch="2019", Brand="Asus"},
                            new Product(){Name = "Chuột Logitech M325 Wireless",DateCreated=DateTime.Now,Image="/client-side/images/products/6075_chuot_logitech_m325_wireless_0001_2.jpg",Alias="chuot-logitech-m325-wireless" ,Price = 379000,Status = Status.Active,OriginalPrice = 799000, ConnectPort="USB-Wireless", Size="100,6 mm x 60,6 mm x 33,5 mm", YearLaunch="2019", Brand="Logitech"},
                            new Product(){Name = "Bàn phím Logitech K120",DateCreated=DateTime.Now,Image="/client-side/images/products/6044_ban_phim_logitech_k120_0002_1.jpg",Alias="ban-phim-logitech-k120" ,Price = 150000,Status = Status.Active,OriginalPrice = 229000, ConnectPort="USB-Wireless", Size="100,6 mm x 60,6 mm x 33,5 mm", YearLaunch="2020", Brand="Logitech"},
                            new Product(){Name = "Chuột Logitech M185 Wireless",DateCreated=DateTime.Now,Image="/client-side/images/43622_mouse_logitech_m105_optica_usb_blackl_0001_2.jpg",Alias="chuot-logitech-m185-wireless" ,Price = 249000,Status = Status.Active,OriginalPrice = 249000, ConnectPort="USB-Wireless", Size="100,6 mm x 60,6 mm x 33,5 mm", YearLaunch="2020", Brand="Logitech"},
                        }},
                    new ProductCategory() { Name="Màn Hình",Alias="man-hinh", ParentId = null,Status=Status.Active,SortOrder=4,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Màn hình Asus VA24DQLB",DateCreated=DateTime.Now,Image="/client-side/images/products/54655_vg24dqlb__9_.png",Alias="man-hinh-asus-va24dqlb" ,Price = 3689000,Status = Status.Active,OriginalPrice = 42779000, Screen="23.8 inch, IPS, Full HD (1920x1080)", Size="540 x 325 x 55 mm", ConnectPort="HDMI, D-Sub, DisplayPort", YearLaunch="2019", Brand="Asus"},
                            new Product(){Name = "Màn hình Samsung C27F390FH",DateCreated=DateTime.Now,Image="/client-side/images/products/33517_samsung_c27f390fh__4_.png",Alias="man-hinh-samsung-c27f390fh" ,Price = 4489000,Status = Status.Active,OriginalPrice = 4999000, Screen="27 inch, VA, Full HD (1920x1080)", Size="27 inch", ConnectPort="D-Sub, HDMI", YearLaunch="2020", Brand="Samsung"},
                            new Product(){Name = "Màn hình Acer HA220QA",DateCreated=DateTime.Now,Image="/client-side/images/products/49378__ha220q__1_.jpg",Alias="man-hinh-acer-ha220qa" ,Price = 3069000,Status = Status.Active,OriginalPrice = 3430000, Screen="21.5 inch, IPS, Full HD", Size="21.5 inch", ConnectPort="HDMI, VGA", YearLaunch="2019", Brand="Acer"},
                            new Product(){Name = "Màn hình Dell E2020H",DateCreated=DateTime.Now,Image="/client-side/images/products/52974_e2020h__7_.jpg",Alias="man-hinh-dell-e2020h" ,Price = 2189000,Status = Status.Active,OriginalPrice = 2499000, Screen="19,5 inch, TN, HD", Size="368.96 x 471.52 x 171.0 mm", ConnectPort="DP, VGA", YearLaunch="2016", Brand="Dell"},
                        }},
                    new ProductCategory() { Name="Thiết Bị Văn Phòng",Alias="thiet-bi-van-phong", ParentId = null,Status=Status.Active,SortOrder=5 },
                    new ProductCategory() { Name="Linh Kiện Máy Tính",Alias="linh-kien-may-tinh", ParentId = null,Status=Status.Active,SortOrder=6 },
                    new ProductCategory() { Name="Camera An Ninh",Alias="camera-an-ninh", ParentId = null,Status=Status.Active,SortOrder=7 },
                    new ProductCategory() { Name="Thiết Bị Mạng",Alias="thiet-bi-mang", ParentId = null,Status=Status.Active,SortOrder=8 },
                    new ProductCategory() { Name="USB,Thẻ Nhớ",Alias="usb-the-nho", ParentId = null,Status=Status.Active,SortOrder=9 },
                    new ProductCategory() { Name="Phụ Kiện Khác",Alias="khac", ParentId = null,Status=Status.Active,SortOrder=10 },
                };
                _context.ProductCategories.AddRange(listProductCategory);
            }
            await _context.SaveChangesAsync();
        }
    }
}
