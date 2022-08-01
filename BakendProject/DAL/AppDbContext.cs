using BakendProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakendProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<BasketItem> BasketItems{ get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages{ get; set; }
        public DbSet<Tag> Tag{ get; set; }
        public DbSet<TagProduct> TagProducts { get; set; }
        public DbSet<Bio> Bios{ get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ModalProduct> modalProducts{ get; set; }
        public DbSet<Blog>  Blogs{ get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<Comment> comments { get; set; }
    }

    //        protected override void OnModelCreating(ModelBuilder builder)
    //        {
    //            base.OnModelCreating(builder);
    //            builder.Entity<Slider>().HasData(
    //                    new Slider { Id = 1, ImgUrl = "h3-slider-background.jpg" },
    //                    new Slider { Id = 2, ImgUrl = "h3-slider-background-2.jpg" }

    //                                    );
    //            builder.Entity<Product>().HasData(
    //new Product { Id = 1, Name = "Product1", Price = 60, CategoryId = 1 ,BrandId=1,Desc = "Lorem ipsum"},
    //new Product { Id = 2, Name = "Product2", Price = 65,, CategoryId = 2,BrandId=2,Desc = "Lorem ipsum" },
    //new Product { Id = 3, Name = "Product3", Price = 70,  CategoryId = 3,BrandId=3 ,Desc = "Lorem ipsum"},
    //new Product { Id = 4, Name = "Product4", Price = 80,  CategoryId = 4,BrandId=4 ,Desc = "Lorem ipsum"},
    //new Product { Id = 5, Name = "Product5", Price = 90,  CategoryId = 5 ,BrandId=4,Desc = "Lorem ipsum"},
    //new Product { Id = 6, Name = "Product6", Price = 90,  CategoryId = 3 ,brandtId=4,Desc = "Lorem ipsum"}
    //          );
    //            builder.Entity<ProductImages>().HasData(
    //new ProductImages { Id = 1, ImageUrl=Category-2.jpg},
    //new ProductImages { Id = 2, ImageUrl=Category-2.jpg },
    //new ProductImages { Id = 3, ImageUrl=Category-2.jpg},
    //new ProductImages { Id = 4,ImageUrl=Category-2.jpg },
    //new ProductImages { Id = 5,ImageUrl=Category-2.jpg},
    //new ProductImages { Id = 6,ImageUrl=Category-2.jpg}
    //          );
    //            builder.Entity<Brand>().HasData(
    //new Brand { Id = 1, Name = "Barnd1",},
    //new Brand { Id = 2, Name = "Barnd2",  },
    //new Brand { Id = 3, Name = "Barnd3", },
    //new Brand { Id = 4, Name = "Barnd4",  },
    //new Brand { Id = 5, Name = "Barnd5", },
    //new Brand { Id = 6, Name = "Barnd6",}

    //               );
    //            builder.Entity<Category>().HasData(
    //new Category { Id = 1, Name = "Catogro1",  },
    //new Category { Id = 2,  Name = "Catogro1" },
    //new Category { Id = 3,  Name = "Catogro1"},
    //new Category { Id = 4,  Name = "Catogro1" },
    //new Category { Id = 5,  Name = "Catogro1 }
    //);
    //            builder.Entity<Bios>().HasData(
    //new Bios
    //{
    //    Id = 5,
    //    ImageUrl = "logo.png",
    //Phone ="050924812"
    //    LOcation="Gadabay
    //    EmailAdres=Parvin,
    //    AuthorName = "Aqil"
    //}


    //             );
    //            builder.Entity<Slider >().HasData(
    //new Slider { Id = 1, MainTitle="Aqil" ,SubTitle="Aqilxalil", Desc="orem ipsum", ImgaeUrl="slider-1.jpg  },
    //new Slider { Id = 2,  MainTitle="Aqil" ,SubTitle="Aqilxalil", Desc="orem ipsum", ImgaeUrl="slider-1.jpg  },

    //);
    //   






    //        }
    //}
}
