using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Customer
    {
        public int id { set; get; }
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public float Due { set; get; }
    }
}
