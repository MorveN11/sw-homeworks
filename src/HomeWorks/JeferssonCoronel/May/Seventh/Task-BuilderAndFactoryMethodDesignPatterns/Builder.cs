namespace HomeWorks.JeffersonCoronel.May.Seventh.Task-BuilderAndFactoryMethodDesignPatterns
{
    internal interface IBurgerBuilder
    {
        void SetBreadType(string breadType);
        void SetPatty(string pattyType);
        void AddCheese(bool withCheese);
        void AddVegetables(params string[] veggies);
        void AddSauce(string sauce);
        Burger GetBurger();
    }

    internal class Burger(string breadType, string pattyType, bool hasCheese, List<string> veggies, string sauce)
    {
        private string BreadType { get; } = breadType;
        private string PattyType { get; } = pattyType;
        private bool HasCheese { get; } = hasCheese;
        private List<string> Veggies { get; } = veggies;
        private string Sauce { get; } = sauce;

        public override string ToString()
        {
            string veggies = string.Join(", ", Veggies);
            return $"Bread: {BreadType}, Patty: {PattyType}, Cheese: {HasCheese}, Veggies: {veggies}, Sauce: {Sauce}";
        }
    }

    internal class BurgerBuilder : IBurgerBuilder
    {
        private string breadType;
        private string pattyType;
        private bool hasCheese;
        private List<string> veggies;
        private string sauce;

        public void SetBreadType(string breadTypeP)
        {
            breadType = breadTypeP;
        }

        public void SetPatty(string pattyTypeP)
        {
            pattyType = pattyTypeP;
        }

        public void AddCheese(bool withCheeseP)
        {
            hasCheese = withCheeseP;
        }

        public void AddVegetables(params string[] veggiesP)
        {
            this.veggies = [..veggiesP];
        }

        public void AddSauce(string sauceP)
        {
            sauce = sauceP;
        }

        public Burger GetBurger()
        {
            return new Burger(breadType, pattyType, hasCheese, veggies, sauce);
        }
    }

    internal class BurgerMaker
    {
        public void MakeClassicBurger(IBurgerBuilder builder)
        {
            builder.SetBreadType("Sesame");
            builder.SetPatty("Beef");
            builder.AddCheese(true);
            builder.AddVegetables("Lettuce", "Tomato", "Onion");
            builder.AddSauce("Mayonnaise");
        }

        public void MakeVeggieBurger(IBurgerBuilder builder)
        {
            builder.SetBreadType("Whole wheat");
            builder.SetPatty("Chickpea");
            builder.AddCheese(false);
            builder.AddVegetables("Lettuce", "Tomato", "Cucumber", "Onion");
            builder.AddSauce("Mustard");
        }
    }

    internal static class Program
    {
        static void Main(string[] args)
        {
            BurgerMaker director = new BurgerMaker();
            BurgerBuilder builder = new BurgerBuilder();
            director.MakeClassicBurger(builder);

            Burger classicBurger = builder.GetBurger();
            Console.WriteLine("- Classic Burger:");
            Console.WriteLine(classicBurger.ToString());

            director = new BurgerMaker();
            director.MakeVeggieBurger(builder);
            Burger veggieBurger = builder.GetBurger();
            Console.WriteLine("- Veggie Burger:");
            Console.WriteLine(veggieBurger.ToString());
        }
    }
}
