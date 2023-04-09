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
            Console.WriteLine("Set Price: ");
            product1.SetPrice(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Prezzo: {product1.GetPrice()}$");

            //Print Iva Price
            Console.WriteLine($"Prezzo IVA: {product1.GetIvaPrice()}$");


            //Set Name
            Console.WriteLine("Set Name: ");
            product1.SetName(Console.ReadLine());

            //product1.NameMoreCode(Console.ReadLine());
            Console.WriteLine($"Nome: {product1.NameMoreCode(product1.nome, product1.GetCode())}");


            //TEST
            Console.WriteLine(product1.nome);
            Console.WriteLine(product1.prezzo);

        }


    }
}