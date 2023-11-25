using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete
{
    public class DogFood: IFood
    {
        public string CreativeFood() => "making dog's food";
    }
}
