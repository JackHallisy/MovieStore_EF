using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieStore.DB.Models
{
    public class Movie

    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
        public virtual int YearReleased { get; set; }
        public virtual int Price { get; set; }
        public virtual int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    



    }
}