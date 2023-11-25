namespace builder
{
    public interface IPizzaBuilder
    {
        PizzaBuilder GetSize(int size);
        PizzaBuilder GetPerperoni(bool perperoni);
        PizzaBuilder GetBacon(bool bacon);
        PizzaBuilder GetChilli(bool chilli);
        Pizza Build();
    }
}
