namespace HomeWorks.DenisGandarillas.May.Six.Builder
{

    public class PepperoniPizza : IPizzaBuilder
    {

        Pizza pizza = new Pizza();
        public void BuildCheese()
        {
            pizza.HasCheese = true;
        }

        public void BuildTomatoSauce()
        {
            pizza.HasTomatoSauce = true;
        }

        public void BuildToppings()
        {
            pizza.HasToppings = false;
        }

        public void BuildType()
        {
            pizza.Type = "Pepperoni";
        }

        public Pizza GetPizza()
        {
            return pizza;
        }
    }

}