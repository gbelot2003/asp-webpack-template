using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class AlbumContext : ApplicationUser
    {
        public DbSet<Album> Albums { get; set; }
    }
}