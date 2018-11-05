using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieStore.DB.Models
{
    public class Genre

    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}