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
        private int codice;
        public string nome;
        public string descrizione;
        public float prezzo;
        public float prezzoIva;

        //Costruttore
        public Product()
        {
            codice = GenerateRandomNumber();
            nome = NameMoreCode(nome, codice);
            descrizione = "**** ****";
            prezzo = GetPrice();
            prezzoIva = PriceMoreIva(prezzo);   
            
        }





        //METHODS

        //Random number generator
        private int GenerateRandomNumber()
        {
            Random rnd = new Random();

            //Console.WriteLine(rnd.Next());
            return rnd.Next(10000000, 99999999);
        }

        //Price
        private float PriceMoreIva(float prezzo)
        {
            float iva = 0.22f;
            float prezzoIva = (prezzo * iva) + prezzo; 

            return prezzoIva;
        }

        //Name
        private string NameMoreCode(string name, int code)
        {
            string codiceStringa = Convert.ToString(code);

            return codiceStringa + name;
        }




        //GET & SET


        //(Get) Product GetCode 
        public int GetCode()
        {
            return codice;
        }

        //(Get/Set) Price
        public float GetPrice()
        {
            return prezzo;
        }
        public void SetPrice(float prezzo)
        {
            this.prezzo = prezzo;
        }

        //(Get/Set) IVA Price
        public float GetIvaPrice()
        {
            return PriceMoreIva(prezzo);
        }
        //public void SetIvaPrice(float prezzoIva)
        //{
        //    this.prezzoIva = prezzoIva;
        //}

        public string GetName()
        {
            return NameMoreCode(nome, codice);
        }
        public void SetName(string name)
        {
            this.nome = name;
        }
    }
}
