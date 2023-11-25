using AbstractFactory.Products.Abstract;

namespace AbstractFactory.Products.Concrete
{
    public class CatFood: IFood
    {
        public string CreativeFood() => "making cat's food";
    }
}
