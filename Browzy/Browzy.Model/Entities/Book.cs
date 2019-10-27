using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browzy.Model.Entities {
    public class Book : Product {

        public string ISBN { get; set; }
        public int Pages { get; set; }
    }
}
