using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete
{
    public class DogToy: IToy
    {
        public string CreativeToy() => "making dog's toy";
    }
}
