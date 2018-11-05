using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieStore.DB.Models;

namespace MovieStore.DB.Models
{
    public class MovieStoreDb : DbContext
    {
        public MovieStoreDb() : base("name=MovieStoreDb")
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        
    }
}