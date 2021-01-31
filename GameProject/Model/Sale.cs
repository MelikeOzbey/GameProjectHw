using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Model
{
    public class Sale:IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}
