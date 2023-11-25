namespace builder
{
    public class PizzaDirector
    {
        private readonly IPizzaBuilder _pizzaBuilder;
        public PizzaDirector(IPizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        //public PizzaDirector() { }

        public Pizza GetPizzaChilli()
        {
            return _pizzaBuilder.GetSize(12).GetPerperoni(true).Build();
        }
        //public Pizza GetPizzaSalmon()
        //{

        //}
    }
}
