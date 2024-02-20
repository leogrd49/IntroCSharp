using IntroCSharp.App._3.Model;

namespace IntroCSharp.App._3
{
    internal class Program
    {
        #region Lists
        public static List<Brand> Brands = new List<Brand>();
        public static List<Beverage> Beverages = new List<Beverage>();
        #endregion

        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            AddData();

            Brand? selectedbrand = null;

            foreach(Brand brand in Brands)
                if (brand.Name == "Leffe")
                    selectedbrand = brand;
            Console.WriteLine("Liste des boissons Leffe");
            if (selectedbrand != null)
            {
                foreach(Beverage beverage in selectedbrand.Beverages)
                {
                    Console.WriteLine($" - {beverage.ToString()}");
                }
            }
                


        }

        private static void AddData()
        {
            Brand brandLeffe = new Brand() { Name = "Leffe" };
            Brand brandCoreff = new Brand() { Name = "Coreff" };
            Brand brandCola = new Brand() { Name = "CocaCola" };

            Brands.Add(brandLeffe);
            Brands.Add(brandCoreff);
            Brands.Add(brandCola);

            Beer ruby = new Beer("Ruby", 2, brandLeffe, 3.2);

            brandLeffe.Beverages.Add(ruby);

            Beer maximator = new Beer("Maximator", 2, brandLeffe, 3.2);

            brandLeffe.Beverages.Add(maximator);

            Soda sodaCoca = new Soda("Coca", 2.5, brandCola, 0.1);

            brandCola.Beverages.Add(sodaCoca);

        }

    }
}
