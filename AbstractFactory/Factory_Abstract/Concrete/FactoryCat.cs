using AbstractFactory.Factory_Abstract;
using AbstractFactory.Products.Concrete;

namespace AbstractFactory.Products.Abstract
{
    public class FactoryCat: IFactory
    {
        public IAnimal Creative_Animal() => new Cat();
        public IFood GetFood() => new CatFood();
        public IToy GetToy() => new CatToy();
    }
}
