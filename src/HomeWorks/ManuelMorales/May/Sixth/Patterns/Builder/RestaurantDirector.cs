public class RestaurantDirector
{
    private IBuilder? _builder;

    public RestaurantDirector() { }

    public void setBuilder(IBuilder builder) => _builder = builder;

    public void BuildCremini()
    {
        _builder?.AddPepperoni().AddBacon().AddMushrooms();
    }

    public void BuildHawaiian()
    {
        _builder?.AddPineapple().AddBacon();
    }
}
