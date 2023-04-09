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
        public float iva;

        //Costruttore
        public Product()
        {
            codice = GenerateRandomNumber();
            nome = GetName();
            prezzo = GetPrice();
            iva = 0.22f;   
            
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
            float prezzoIva = (prezzo * this.iva) + prezzo; 

            return prezzoIva;
        }

        //Name
        public string NameMoreCode(string name, int code)
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


        //(Get/Set) Name
        public string GetName()
        {
            return nome;
        }
        public void SetName(string nome)
        {
            this.nome = nome;
        }

    }
}
