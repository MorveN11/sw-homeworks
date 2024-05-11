public class Pizza
{
    public string Type { get; set; }
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Cheese { get; set; }
    public string Toppings { get; set; }

    public override string ToString()
    {
        return $"Pizza: {Type}\n- Dough: {Dough}\n- Sauce: {Sauce}\n- Cheese: {Cheese}\n- Toppings: {Toppings}";
    }
}
