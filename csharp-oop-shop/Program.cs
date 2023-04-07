namespace csharp_oop_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();


            //Genera codice casuale da 8 cifre



            product1.codice = product1.GetCode();
            int test = product1.codice;
            Console.WriteLine(test);
        }
            

    }
}