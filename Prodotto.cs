using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int codeProduct = new Random().Next(0, 99999999);

        private string nameProduct;
        private string descriptionProduct;
        private float priceProduct;
        private int ivaProduct;

        public int CodeProduct
        {
            get
            {
                return codeProduct;
            }
        }

        public string NameProduct
        {
            get
            {
                return nameProduct;
            }
            set
            {
                nameProduct = value;
            }
        }

        public string DescriptionProduct
        {
            get
            {
                return descriptionProduct;
            }
            set
            {
                descriptionProduct = value;
            }
        }

        public float PriceProduct
        {
            get
            {
                return priceProduct;
            }
            set
            {
                priceProduct = value;
            }
        }

        public int IvaProduct
        {
            get
            {
                return ivaProduct;
            }
            set
            {
                ivaProduct = value;
            }
        }

        public float PriceWithIva()
        {
            float price = (this.PriceProduct * (100 + this.ivaProduct)) / 100;
            return (float)Math.Round(price, 2);
        }

        public string NameComplete()
        {
            return $"{this.CodeProduct}{this.NameProduct}";
        }

        public void PrintProduct()
        {
            Console.WriteLine($"Articolo: {this.NameComplete()}");
            Console.WriteLine($"Nome prodotto: {this.NameProduct}");
            Console.WriteLine($"Codice: {this.CodeProduct}");
            Console.WriteLine($"Descrizione: {this.DescriptionProduct}");
            Console.WriteLine($"IVA: {this.IvaProduct}");
            Console.WriteLine($"Prezzo senza IVA: {this.PriceProduct}");
            Console.WriteLine($"Prezzo con IVA: {this.PriceWithIva()}");
        }
    }
}