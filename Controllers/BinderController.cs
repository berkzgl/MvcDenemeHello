using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcDenemeHello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDenemeHello.Controllers
{
    public class BinderController : Controller
    {
      public IActionResult Index()
        {
            return View();
        }
        /* [HttpPost]
         public IActionResult Index(FormCollection form)
         {
             var ograd = form["OgrenciAd"].ToString();
             var ogrsoyad = form["OgrenciSoyad"].ToString(); 
             var ogryas = form["OgrenciYas"].ToString();

             return View();
         } */
        [HttpPost]
        public IActionResult Index(IFormCollection ogr)
        {

            //var ad = form.Ad.ToString();
            //var soyad = form.Soyad.ToString();
            Ogrenci og = new Ogrenci();
            og.Ad= ogr["OgrenciAd"].ToString();
            og.Soyad = ogr["OgrenciSoyad"].ToString();
            og.Yas = int.Parse(ogr["OgrenciYas"]);
            using (var ctx=new OkulContext())
                {
                    ctx.Ogrenciler.Add(og);
                    ctx.SaveChanges();
                }
            
            return View();
        }
    }

    class OkulContext : DbContext
    {
        


        public DbSet<Ogrenci> Ogrenciler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source =.; Integrated Security = true; Initial Catalog = Ogr4db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ogrenci>().ToTable("tblOgr");

            //modelBuilder.Entity<Ogrenci>().Property(p => p.Ad).HasColumnType("varchar(30)").HasMaxLength(30).IsRequired();
            //bu tekniğe fluent Api denir kolonları özelleştirmede akıcı hızlı yazım işine denir.
        }

    }
}
