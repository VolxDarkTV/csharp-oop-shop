using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        //Attributi
        public int codice;
        public string nome;
        public string descrizione;
        public int prezzo;
        public int prezzoIva;

        //Costruttore
        public Product()
        {
            codice = GenerateRandomNumber();
            nome = "Prodotto";
            descrizione = "Prodotto base";
        }

        public int GetCode()
        {
            return codice;
        }

        private int GenerateRandomNumber()
        {
            Random rnd = new Random();

            //Console.WriteLine(rnd.Next());
            return rnd.Next(10000000, 99999999);
        }
    }
}
