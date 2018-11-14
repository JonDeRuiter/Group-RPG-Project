using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Dark_Souls.NET.Models
{
    public class Monster : Character
    {


   
    }
    public class DbMonster : DbContext
    {
        public DbSet<Monster> Monsters { get; set; }
    }
}