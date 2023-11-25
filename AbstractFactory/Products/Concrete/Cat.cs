using AbstractFactory.Products.Abstract;


namespace AbstractFactory.Products.Concrete
{
    public class Cat: IAnimal
    {
        public string CreativeAnimal() => "Meow";
    }
}
