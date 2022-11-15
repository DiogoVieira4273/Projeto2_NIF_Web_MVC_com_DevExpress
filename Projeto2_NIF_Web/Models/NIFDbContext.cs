﻿using Microsoft.EntityFrameworkCore;

namespace Projeto2_NIF_Web.Models
{
    public class NIFDbContext : DbContext
    {
        public NIFDbContext(DbContextOptions<NIFDbContext> options) : base(options)
        {

        }
        public DbSet<NIF_Empresa> NIF_Empresa { get; set; }
    }
}