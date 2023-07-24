﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-6LLA5LIQ\\SQLEXPRESS;database=TraversalDB;integrated security=true;");
        }
        //About entityFramework adı ondan abouts diye tablo oluşturulur.
        // concreate dosyası içersindeki her şey için yap
        public DbSet<About> Abouts { get; set; }
        public DbSet<About2> Abouts2 { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Feature2> Features2 { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Newsletter>Newsletters  { get; set; }
        public DbSet<SubAbout>SubAbouts  { get; set; }
        public DbSet<Testimonial>Testimonials  { get; set; }
       public DbSet<Reservation>Reservations  { get; set; }
    
    }
}
