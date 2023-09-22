using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitterClone.Models
{
    public class User
    {
        public int id { get; set; }
        public int username { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public object? address { get; set; }
    }
}