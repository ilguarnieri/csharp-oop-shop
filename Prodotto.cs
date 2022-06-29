using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        public int CodeProduct
        {
            get
            {
                int codeRdn = new Random().Next(0, 999999999);
                return codeRdn;
            }
        }
        public int NameProduct { get; set; }
        public int DescriptionProduct { get; set; }
        public int PriceProduct { get; set; }
        public int IvaProduct { get; set; }

    }
}
