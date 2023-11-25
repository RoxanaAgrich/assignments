namespace builder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        public int Size { get; private set; }
        public bool perperoni { get; private set; }
        public bool Bacon { get; private set; }
        public bool Chilli { get; private set; }
        public PizzaBuilder GetSize(int size)
        {
            this.Size = size;
            return this;
        }
        public PizzaBuilder GetPerperoni(bool perperoni)
        {
            this.perperoni = perperoni;
            return this;
        }
        public PizzaBuilder GetBacon(bool bacon)
        {
            this.Bacon = bacon;
            return this;
        }
        public PizzaBuilder GetChilli(bool chilli)
        {
            this.Chilli = chilli;
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(this);
        }
    }
}