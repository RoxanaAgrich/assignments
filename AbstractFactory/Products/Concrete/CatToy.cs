using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete
{
    public class CatToy: IToy
    {
        public string CreativeToy() => " making cat's toy";
    }
}
