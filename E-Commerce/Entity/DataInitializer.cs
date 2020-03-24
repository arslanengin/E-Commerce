using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_Commerce.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description="Kamera Ürünleri"},
                new Category(){Name="Bilgisayar",Description="Bilgisayar Ürünleri"},
                new Category(){Name="Elektronik",Description="Elektronik Ürünleri"},
                new Category(){Name="Telefon",Description="Telefon Ürünleri"},
                new Category(){Name="Beyaz Eşya",Description="Beyaz Eşya Ürünleri"},

            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=3, IsApproved=true, IsHome=true,Image="1.jpg" },
                new Product(){Name="Canon550d",Description="Canon550d",Price=7000 ,Stock=25, CategoryId=1, IsApproved=true,Image="2.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir.",Price=3500 ,Stock=25, CategoryId=2, IsApproved=true,Image="3.jpg" },
                new Product(){Name="Samsung 558",Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Price=3500 ,Stock=25, CategoryId=4, IsApproved=true, IsHome=true,Image="4.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=2, IsApproved=false,Image="2.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Price=3500 ,Stock=25, CategoryId=3, IsApproved=true, IsHome=true,Image="3.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=1, IsApproved=true, Image="2.jpg",IsHome=true },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=1, IsApproved=true,Image="3.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Price=3500 ,Stock=25, CategoryId=2, IsApproved=true, IsHome=true,Image="4.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",Price=3500 ,Stock=25, CategoryId=4, IsApproved=true, IsHome=true,Image="1.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=2, IsApproved=true, IsHome=true,Image="2.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=4, IsApproved=true, IsHome=true,Image="3.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=2, IsApproved=true,Image="2.jpg" },
                new Product(){Name="Samsung 55KU8",Description="Samsung 55KU8",Price=3500 ,Stock=25, CategoryId=4, IsApproved=true,Image="1.jpg" },
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }

    }
}