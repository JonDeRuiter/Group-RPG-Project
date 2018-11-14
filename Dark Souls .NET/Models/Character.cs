using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dark_Souls.NET.Models
{
    public abstract class Character
    {
        protected int Id;
        protected string Name;
        protected int Hp;
        protected int Attack;
        protected int Gold;

        public int ID { get { return Id; } set { this.Id = value; } }
        public string NAME { get { return Name; } set { this.Name = value; } }
        public int HP { get { return Hp; } set { this.Hp = value; } }
        public int ATTACK { get { return Attack; } set { this.Attack = value; } }
        public int GOLD { get { return Gold; } set { this.Gold = value; } }

        //public virtual void Fight() { }
        //public virtual void Win() { }
        

    }
}