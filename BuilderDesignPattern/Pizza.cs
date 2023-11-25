namespace builder {
    public class Pizza {
        public int Size { get; private set; }
        public bool Perperoni { get; private set; }
        public bool Bacon { get; private set; }
        public bool Chilli { get; private set; }
        public Pizza (PizzaBuilder builder)
        {
            Size = builder.Size;
            this.Perperoni = builder.perperoni;
            this.Bacon = builder.Bacon;
            this.Chilli = builder.Chilli;
        }
    }
}
