using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dark_Souls.NET.Models
{
    public class Fighter : Character
    {
        private int Lives;

        public int LIVES { get { return Lives; } set { this.Lives = value; } }
    }
    public class DbFighter : DbContext
    {
        public DbSet<Fighter> Fighters { get; set; }
    }
}