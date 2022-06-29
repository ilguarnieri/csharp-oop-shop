using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Prodotto
    {
        private int codeProduct = new Random().Next(1, 12345678);

        public int CodeProduct {
            get { return codeProduct; }
        }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public float PriceProduct { get; set; }
        public int IvaProduct { get; set; }

        public float PriceWithIva()
        {
            float price = (this.PriceProduct * (100 + this.IvaProduct)) / 100;
            return (float)Math.Round(price, 2);
        }

        public string NameComplete()
        {
            return $"{this.CodeProduct}{this.NameProduct}";
        }

        public string getPadCode()
        {

            string strCode = this.CodeProduct.ToString();
            int zeroAdd = 8 - strCode.Length;
            string padCode = "";

            for (int i = 0; i < zeroAdd; i++)
            {
                padCode += "0";
            }

            padCode += strCode;

            return padCode;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"\nArticolo: {this.NameComplete()}");
            Console.WriteLine($"Nome prodotto: {this.NameProduct}");
            Console.WriteLine($"Codice: {this.getPadCode()}");
            Console.WriteLine($"Descrizione: {this.DescriptionProduct}");
            Console.WriteLine($"IVA: {this.IvaProduct}");
            Console.WriteLine($"Prezzo senza IVA: {this.PriceProduct}");
            Console.WriteLine($"Prezzo con IVA: {this.PriceWithIva()}");
        }
    }
}