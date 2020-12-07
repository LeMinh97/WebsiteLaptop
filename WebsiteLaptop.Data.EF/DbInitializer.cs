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
                    Status = Status.Active
                }, "123456");
                var user = await _userManager.FindByNameAsync("admin");
                await _userManager.AddToRoleAsync(user, "Admin");
            }
            if (_context.Functions.Count() == 0)
            {
                _context.Functions.AddRange(new List<Function>()
                {
                    new Function() {Id = "SYSTEM", Name = "Hệ thống",ParentId = null,SortOrder = 1,Status = Status.Active,URL = "/",IconCss = "fa-desktop"  },
                    new Function() {Id = "ROLE", Name = "Nhóm",ParentId = "SYSTEM",SortOrder = 1,Status = Status.Active,URL = "/admin/role/index",IconCss = "fa-home"  },
                    new Function() {Id = "FUNCTION", Name = "Chức năng",ParentId = "SYSTEM",SortOrder = 2,Status = Status.Active,URL = "/admin/function/index",IconCss = "fa-home"  },
                    new Function() {Id = "USER", Name = "Người dùng",ParentId = "SYSTEM",SortOrder =3,Status = Status.Active,URL = "/admin/user/index",IconCss = "fa-home"  },
                    new Function() {Id = "ACTIVITY", Name = "Nhật ký",ParentId = "SYSTEM",SortOrder = 4,Status = Status.Active,URL = "/admin/activity/index",IconCss = "fa-home"  },
                    new Function() {Id = "ERROR", Name = "Lỗi",ParentId = "SYSTEM",SortOrder = 5,Status = Status.Active,URL = "/admin/error/index",IconCss = "fa-home"  },
                    new Function() {Id = "SETTING", Name = "Cấu hình",ParentId = "SYSTEM",SortOrder = 6,Status = Status.Active,URL = "/admin/setting/index",IconCss = "fa-home"  },
                    new Function() {Id = "PRODUCT",Name = "Sản phẩm",ParentId = null,SortOrder = 2,Status = Status.Active,URL = "/",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_CATEGORY",Name = "Danh mục",ParentId = "PRODUCT",SortOrder =1,Status = Status.Active,URL = "/admin/productcategory/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "PRODUCT_LIST",Name = "Sản phẩm",ParentId = "PRODUCT",SortOrder = 2,Status = Status.Active,URL = "/admin/product/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "ORDER",Name = "Đơn hàng",ParentId = "PRODUCT",SortOrder = 3,Status = Status.Active,URL = "/admin/order/index",IconCss = "fa-chevron-down"  },
                    new Function() {Id = "CONTENT",Name = "Nội dung",ParentId = null,SortOrder = 3,Status = Status.Active,URL = "/",IconCss = "fa-table"  },
                    new Function() {Id = "BLOG",Name = "Bài viết",ParentId = "CONTENT",SortOrder = 1,Status = Status.Active,URL = "/admin/blog/index",IconCss = "fa-table"  },
                    new Function() {Id = "UTILITY",Name = "Tiện ích",ParentId = null,SortOrder = 4,Status = Status.Active,URL = "/",IconCss = "fa-clone"  },
                    new Function() {Id = "FOOTER",Name = "Footer",ParentId = "UTILITY",SortOrder = 1,Status = Status.Active,URL = "/admin/footer/index",IconCss = "fa-clone"  },
                    new Function() {Id = "FEEDBACK",Name = "Phản hồi",ParentId = "UTILITY",SortOrder = 2,Status = Status.Active,URL = "/admin/feedback/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ANNOUNCEMENT",Name = "Thông báo",ParentId = "UTILITY",SortOrder = 3,Status = Status.Active,URL = "/admin/announcement/index",IconCss = "fa-clone"  },
                    new Function() {Id = "CONTACT",Name = "Liên hệ",ParentId = "UTILITY",SortOrder = 4,Status = Status.Active,URL = "/admin/contact/index",IconCss = "fa-clone"  },
                    new Function() {Id = "SLIDE",Name = "Slide",ParentId = "UTILITY",SortOrder = 5,Status = Status.Active,URL = "/admin/slide/index",IconCss = "fa-clone"  },
                    new Function() {Id = "ADVERTISMENT",Name = "Quảng cáo",ParentId = "UTILITY",SortOrder = 6,Status = Status.Active,URL = "/admin/advertistment/index",IconCss = "fa-clone"  },

                    new Function() {Id = "REPORT",Name = "Báo cáo",ParentId = null,SortOrder = 5,Status = Status.Active,URL = "/",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "REVENUES",Name = "Báo cáo doanh thu",ParentId = "REPORT",SortOrder = 1,Status = Status.Active,URL = "/admin/report/revenues",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "ACCESS",Name = "Báo cáo truy cập",ParentId = "REPORT",SortOrder = 2,Status = Status.Active,URL = "/admin/report/visitor",IconCss = "fa-bar-chart-o"  },
                    new Function() {Id = "READER",Name = "Báo cáo độc giả",ParentId = "REPORT",SortOrder = 3,Status = Status.Active,URL = "/admin/report/reader",IconCss = "fa-bar-chart-o"  },
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
                    new Slide() {Name="Slide 2",Image="/client-side/images/slider/microsoft-mouse.jpg",Url="#",DisplayOrder = 1,GroupAlias = "top",Status = true },
                    new Slide() {Name="Slide 3",Image="/client-side/images/slider/msi-ad-1.jpg",Url="#",DisplayOrder = 2,GroupAlias = "top",Status = true },

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
                            new Product(){Name = "HP 15s fq1111TU",DateCreated=DateTime.Now,Image="/client-side/images/products/hp-15s-fq1111tu-i3-193r0pa-224012-224012-600x600.jpg",Alias="hp-15s-fq1111tu" ,Price = 10000000,Status = Status.Active,OriginalPrice = 11390000},
                            new Product(){Name = "HP 348 G7",DateCreated=DateTime.Now,Image="/client-side/images/products/hp-348-g7-i3-1a0z1pa-1-225549-600x600.jpg",Alias="hp-348-g7" ,Price = 9800000,Status = Status.Active,OriginalPrice = 12190000},
                            new Product(){Name = "Asus VivoBook A515EA",DateCreated=DateTime.Now,Image="/client-side/images/products/asus-vivobook-a515ea-i3-bq497t-062220-092221-600x600.jpg",Alias="asus-vivobook-a515ea" ,Price = 8690000,Status = Status.Active,OriginalPrice = 14690000},
                            new Product(){Name = "Asus VivoBook X509MA N5030",DateCreated=DateTime.Now,Image="/client-side/images/products/asus-vivobook-x509ma-n5030-ej256t-171120-051158-600x600.jpg",Alias="asus-vivobook-x509ma-n5030" ,Price = 6700000,Status = Status.Active,OriginalPrice = 8890000},
                            new Product(){Name = "Dell Vostro 3590",DateCreated=DateTime.Now,Image="/client-side/images/products/dell-vostro-3590-i7-grmgk2-220718-220718-600x600.jpg",Alias="dell-vostro-3590" ,Price = 15700000,Status = Status.Active,OriginalPrice = 20990000},
                            new Product(){Name = "Lenovo IdeaPad S145 15IIL",DateCreated=DateTime.Now,Image="/client-side/images/products/lenovo-ideapad-s145-81w8001xvn-a4-216292-600x600.jpg",Alias="lenovo-ideapad-s145-15iil" ,Price = 10990000,Status = Status.Active,OriginalPrice = 10990000},
                            new Product(){Name = "Asus VivoBook X509JA",DateCreated=DateTime.Now,Image="/client-side/images/products/asus-vivobook-x509ja-i3-ej480t-225608-600x600.jpg",Alias="asus-vivobook-x509ja" ,Price = 7900000,Status = Status.Active,OriginalPrice = 10890000},
                            new Product(){Name = "Lenovo IdeaPad C340 14IML",DateCreated=DateTime.Now,Image="/client-side/images/products/lenovo-ideapad-c340-14iml-i3-10110u-8gb-512gb-touc-5-213524-600x600.jpg",Alias="lenovo-ideapad-c340-14iml" ,Price = 12000000,Status = Status.Active,OriginalPrice = 16290000},
                            new Product(){Name = "Asus VivoBook A415EA",DateCreated=DateTime.Now,Image="/client-side/images/products/asus-vivobook-a415ea-i3-eb317t-062420-092402-600x600.jpg",Alias="asus-vivobook-a415ea" ,Price = 10500000,Status = Status.Active,OriginalPrice = 13690000},
                            new Product(){Name = "HP 15s du1076TX",DateCreated=DateTime.Now,Image="/client-side/images/products/hp-15s-du1076tx-i5-8gb-10210u-512gb-2gb-mx130-win1-600x600.jpg",Alias="hp-15s-du1076tx" ,Price = 15100000,Status = Status.Active,OriginalPrice = 17490000},
                            new Product(){Name = "Dell Inspiron 3493",DateCreated=DateTime.Now,Image="/client-side/images/products/dell-inspiron-3493-i5-n4i5122w-222088-600x600.jpg",Alias="dell-inspiron-3493" ,Price = 14600000,Status = Status.Active,OriginalPrice = 15290000},
                            new Product(){Name = "Asus VivoBook A415EA",DateCreated=DateTime.Now,Image="/client-side/images/products/asus-vivobook-a415ea-i3-eb353t-062320-092323-600x600.jpg",Alias="asus-vivobook-a415ea" ,Price = 13500000,Status = Status.Active,OriginalPrice = 14190000},
                        }
                    },
                    new ProductCategory() { Name="PC văn phòng",Alias="pc-van-phong",ParentId = null,Status=Status.Active ,SortOrder=2,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "PC Acer Aspire XC-830",DateCreated=DateTime.Now,Image="/client-side/images/products/51932_acer_aspire_xc_830_s__2_.jpg",Alias="pc-acer-aspire-xc-830" ,Price = 5490000,Status = Status.Active,OriginalPrice = 6499000},
                            new Product(){Name = "PC Asus S340MC",DateCreated=DateTime.Now,Image="/client-side/images/products/47741_pc_asus_s340mc___2_.jpg",Alias="pc-asus-s340mc" ,Price = 6990000,Status = Status.Active,OriginalPrice = 7890000},
                            new Product(){Name = "PC Lenovo V530S-07ICB",DateCreated=DateTime.Now,Image="/client-side/images/products/44477_lenovo_v530s_023.png",Alias="pc-lenovo-v530s-07icb" ,Price = 8999000,Status = Status.Active,OriginalPrice = 9690000},
                            new Product(){Name = "PC HP 280 G3 SFF",DateCreated=DateTime.Now,Image="/client-side/images/products/51086_pc_hp_280_g3_sff_a__2_.jpg",Alias="pc-hp-280-g3-sff" ,Price = 8990000,Status = Status.Active,OriginalPrice = 9450000},
                            new Product(){Name = "PC Dell OptiPlex 3070",DateCreated=DateTime.Now,Image="/client-side/images/products/48226_dell_optiplex_3070_mt_021.png",Alias="pc-dell-optiplex-3070" ,Price = 11890000,Status = Status.Active,OriginalPrice = 12990000},
                        }},
                    new ProductCategory() { Name="Bàn Phím & Chuột",Alias="ban-phim-chuot", ParentId = null,Status=Status.Active ,SortOrder=3,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Bàn phím Asus TUF K5",DateCreated=DateTime.Now,Image="/client-side/images/products/55028_ban_phim_choi_game_asus_tuf_k5_usb_rgb_den_0004_5.jpg",Alias="ban-phim-asus-tuf-k5" ,Price = 989000,Status = Status.Active,OriginalPrice = 1299000},
                            new Product(){Name = "Chuột Asus ROG Gladius II Core",DateCreated=DateTime.Now,Image="/client-side/images/products/53593_asus_rog_gladius_ii_core__p507_.jpg",Alias="chuot-asus-rog-gladius-ii-core" ,Price = 1089000,Status = Status.Active,OriginalPrice = 1299999},
                            new Product(){Name = "Chuột Logitech M325 Wireless",DateCreated=DateTime.Now,Image="/client-side/images/products/6075_chuot_logitech_m325_wireless_0001_2.jpg",Alias="chuot-logitech-m325-wireless" ,Price = 379000,Status = Status.Active,OriginalPrice = 799000},
                            new Product(){Name = "Bàn phím Logitech K120",DateCreated=DateTime.Now,Image="/client-side/images/products/6044_ban_phim_logitech_k120_0002_1.jpg",Alias="ban-phim-logitech-k120" ,Price = 150000,Status = Status.Active,OriginalPrice = 229000},
                            new Product(){Name = "Chuột Logitech M185 Wireless",DateCreated=DateTime.Now,Image="/client-side/images/6988_chu___t_logitech_m185_wireless.jpg",Alias="chuot-logitech-m185-wireless" ,Price = 249000,Status = Status.Active,OriginalPrice = 249000},
                        }},
                    new ProductCategory() { Name="Màn Hình",Alias="man-hinh", ParentId = null,Status=Status.Active,SortOrder=4,
                        Products = new List<Product>()
                        {
                            new Product(){Name = "Màn hình Asus VA24DQLB",DateCreated=DateTime.Now,Image="/client-side/images/products/54655_vg24dqlb__9_.png",Alias="man-hinh-asus-va24dqlb" ,Price = 3689000,Status = Status.Active,OriginalPrice = 42779000},
                            new Product(){Name = "Màn hình Samsung C27F390FH",DateCreated=DateTime.Now,Image="/client-side/images/products/33517_samsung_c27f390fh__4_.png",Alias="man-hinh-samsung-c27f390fh" ,Price = 4489000,Status = Status.Active,OriginalPrice = 4999000},
                            new Product(){Name = "Màn hình Acer HA220QA",DateCreated=DateTime.Now,Image="/client-side/images/products/49378__ha220q__1_.jpg",Alias="man-hinh-acer-ha220qa" ,Price = 3069000,Status = Status.Active,OriginalPrice = 3430000},
                            new Product(){Name = "Màn hình Dell E2020H",DateCreated=DateTime.Now,Image="/client-side/images/products/52974_e2020h__7_.jpg",Alias="man-hinh-dell-e2020h" ,Price = 2189000,Status = Status.Active,OriginalPrice = 2499000},
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
