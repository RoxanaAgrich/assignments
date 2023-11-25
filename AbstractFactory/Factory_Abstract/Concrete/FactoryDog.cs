using AbstractFactory.Factory_Abstract;
using AbstractFactory.Products.Concrete;

namespace AbstractFactory.Products.Abstract
{
    public class FactoryDog: IFactory 
    {
        public IAnimal Creative_Animal () => new Dog() ;
        public IFood GetFood() => new DogFood();
        public IToy GetToy() => new DogToy();
    }
}
