using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkForking.Models.Entity
{
    public class Student :IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string teacher { get; set; }
    }
}