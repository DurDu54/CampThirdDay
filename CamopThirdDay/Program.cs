    namespace CamopThirdDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Acılkama = "Amasya elması";
            
            Product product2= new Product();
            product2.Name = "Karpuz";
            product2.Price = 25;
            product2.Acılkama = "Diyarbakır karpuzu";

            Product[] products =new Product[] {product1, product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name+" "+product.Price+" "+ product.Acılkama);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++");

            }
            Console.WriteLine("-----------------------------------------------------------+");
            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.AddCart(product1);
            sepetManager.AddCart(product2);

            sepetManager.Eklke2("Armut","Yeşil armut", 12);
            sepetManager.Eklke2("elma", "Yeşil elma", 12);
            sepetManager.Eklke2("karpuz", "Diyarbakır Karpuzu", 12);
        }
    }
}