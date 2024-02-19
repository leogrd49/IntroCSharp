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
            Console.WriteLine("Hello, World!");
        }

        private static void AddData()
        {
            Brand brandLeffe = new Brand() { Name = "Leffe" };
            Brand brandCoreff = new Brand() { Name = "Coreff" };

            Brands.Add(brandLeffe);
            Brands.Add(brandCoreff);
        }

    }
}
