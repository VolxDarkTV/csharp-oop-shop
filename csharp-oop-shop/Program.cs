namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();


            //Genera codice casuale da 8 cifre
            Console.WriteLine($"Codice: {product1.GetCode()}");

            //Print Price
            product1.SetPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Prezzo: {product1.GetPrice()}$");

            //Print Iva Price
            //product1.SetIvaPrice(3);
            Console.WriteLine($"Prezzo IVA: {product1.GetIvaPrice()}$");


            product1.SetName(Console.ReadLine());
            Console.WriteLine($"Nome: {product1.GetName()}");

        }
            

    }
}