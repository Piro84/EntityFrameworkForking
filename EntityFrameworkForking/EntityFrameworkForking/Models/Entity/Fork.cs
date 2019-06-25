using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameworkForking.Models
{
    public class Fork: IEntity
    {
        public int Id { get; set; }
        public string owner { get; set; }
        public int prongs { get; set; }
    }
}